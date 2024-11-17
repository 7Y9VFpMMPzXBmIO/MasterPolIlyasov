using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MasterPolIlyasov
{
    /// <summary>
    /// Логика взаимодействия для AddPartnerPage.xaml
    /// </summary>
    public partial class AddPartnerPage : Page
    {
        private Partner currentPartner = new Partner();

        public bool check = false;

        public Partner DataContext { get; set; }

        public AddPartnerPage(Partner SelectedPartner)
        {
            InitializeComponent();
            var PartnersTypes = IlyasovmasterpolEntities.GetContext().Partner_type.Select(p => p.Type_name).ToList();

            foreach (var PartnerType in PartnersTypes)
            {
                PartnerTypeComboBox.Items.Add(PartnerType);
            }

            if (SelectedPartner != null)
            {
                check = true;
                currentPartner = SelectedPartner;
                PartnerTypeComboBox.SelectedIndex = currentPartner.Partner_Type - 1;
            }
            else
            {
                currentPartner.Partner_Rating = 0;
                PartnerTypeComboBox.SelectedIndex = 0;
            }

            DataContext = currentPartner;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_Name))
                errors.AppendLine("Укажите название партнера");
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_Index.ToString()))
                errors.AppendLine("Укажите индекс");
            else
            {
                if (currentPartner.Partner_Index.ToString().Length != 6)
                    errors.AppendLine("Длина индекса адреса компании должна быть равна 6 символам!");
            }
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_Region))
                errors.AppendLine("Укажите регион");
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_City))
                errors.AppendLine("Укажите город");
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_Street))
                errors.AppendLine("Укажите улицу");
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_House))
                errors.AppendLine("Укажите дом");
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_INN))
                errors.AppendLine("Укажите ИНН");
            else
            {
                if (currentPartner.Partner_INN.ToString().Length != 10 ||
         !currentPartner.Partner_INN.ToString().All(char.IsDigit))
                    errors.AppendLine("Длина ИНН компании должна быть равна 10 символам и содержать только цифры!");
            }
            if (string.IsNullOrWhiteSpace(currentPartner.Director_Surname))
                errors.AppendLine("Укажите фамилию директора");
            if (string.IsNullOrWhiteSpace(currentPartner.Director_Firstname))
                errors.AppendLine("Укажите имя директора");
            if (string.IsNullOrWhiteSpace(currentPartner.Director_Patronymic))
                errors.AppendLine("Укажите отчество директора");
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_Phone))
            {
                errors.AppendLine("Укажите номер телефона!");
            }
            else
            {
                // Проверяем, что номер телефона состоит из 11 символов и начинается с '8'
                if (currentPartner.Partner_Phone.Length != 11 ||
                    !currentPartner.Partner_Phone.StartsWith("8") ||
                    !currentPartner.Partner_Phone.All(char.IsDigit))
                {
                    errors.AppendLine("Номер телефона должен начинаться с цифры 8 и состоять из 11 цифр!");
                }
            }
            if (string.IsNullOrWhiteSpace(currentPartner.Partner_Email))
                errors.AppendLine("Укажите Email");
            else
            {
                string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9]+$";
                if (!Regex.IsMatch(currentPartner.Partner_Email, emailPattern))
                    errors.AppendLine("Не корректный Email!");
            }
            if (currentPartner.Partner_Rating == null || currentPartner.Partner_Rating < 0)
                errors.AppendLine("Неверный рейтинг партнера");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            currentPartner.Partner_Type = PartnerTypeComboBox.SelectedIndex + 1;

            var allPartner = IlyasovmasterpolEntities.GetContext().Partner.ToList();
            allPartner = allPartner.Where(p => p.Partner_Name == currentPartner.Partner_Name).ToList();
            if (allPartner.Count == 0 || check == true)
            {
                if (currentPartner.ID_Partner == 0)
                {
                    IlyasovmasterpolEntities.GetContext().Partner.Add(currentPartner);
                }

                try
                {
                    IlyasovmasterpolEntities.GetContext().SaveChanges();
                    Manager.MainFrame.Navigate(new PartnerPage());
                    MessageBox.Show("Информация сохранена");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
                MessageBox.Show("Такой партнер уже сущесвтует!");
        }

        public void SaveBtn_Click(object value1, object value2)
        {
            throw new NotImplementedException();
        }

        public class PartnerValidation
        {
            public int ValidatePartnerData(Partner currentPartner)
            {
                StringBuilder errors = new StringBuilder();

                if (string.IsNullOrWhiteSpace(currentPartner.Partner_Name))
                    errors.AppendLine("Укажите название партнера");

                if (string.IsNullOrWhiteSpace(currentPartner.Partner_Index.ToString()))
                    errors.AppendLine("Укажите индекс");
                else
                {
                    if (currentPartner.Partner_Index.ToString().Length != 6)
                        errors.AppendLine("Длина индекса адреса компании должна быть равна 6 символам!");
                }

                if (string.IsNullOrWhiteSpace(currentPartner.Partner_Region))
                    errors.AppendLine("Укажите регион");

                if (string.IsNullOrWhiteSpace(currentPartner.Partner_City))
                    errors.AppendLine("Укажите город");

                if (string.IsNullOrWhiteSpace(currentPartner.Partner_Street))
                    errors.AppendLine("Укажите улицу");

                if (string.IsNullOrWhiteSpace(currentPartner.Partner_House))
                    errors.AppendLine("Укажите дом");

                if (string.IsNullOrWhiteSpace(currentPartner.Partner_INN))
                    errors.AppendLine("Укажите ИНН");
                else
                {
                    if (currentPartner.Partner_INN.ToString().Length != 10 ||
                        !currentPartner.Partner_INN.ToString().All(char.IsDigit))
                        errors.AppendLine("Длина ИНН компании должна быть равна 10 символам и содержать только цифры!");
                }

                if (string.IsNullOrWhiteSpace(currentPartner.Director_Surname))
                    errors.AppendLine("Укажите фамилию директора");

                if (string.IsNullOrWhiteSpace(currentPartner.Director_Firstname))
                    errors.AppendLine("Укажите имя директора");

                if (string.IsNullOrWhiteSpace(currentPartner.Director_Patronymic))
                    errors.AppendLine("Укажите отчество директора");

                if (string.IsNullOrWhiteSpace(currentPartner.Partner_Phone))
                {
                    errors.AppendLine("Укажите номер телефона!");
                }
                else
                {
                    // Проверяем, что номер телефона состоит из 11 символов и начинается с '8'
                    if (currentPartner.Partner_Phone.Length != 11 ||
                        !currentPartner.Partner_Phone.StartsWith("8") ||
                        !currentPartner.Partner_Phone.All(char.IsDigit))
                    {
                        errors.AppendLine("Номер телефона должен начинаться с цифры 8 и состоять из 11 цифр!");
                    }
                }

                if (string.IsNullOrWhiteSpace(currentPartner.Partner_Email))
                    errors.AppendLine("Укажите Email");
                else
                {
                    string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9]+$";
                    if (!Regex.IsMatch(currentPartner.Partner_Email, emailPattern))
                        errors.AppendLine("Не корректный Email!");
                }

                if (currentPartner.Partner_Rating == null || currentPartner.Partner_Rating < 0)
                    errors.AppendLine("Неверный рейтинг партнера");

                // Возвращаем длину строки ошибок
                return errors.Length;
            }
        }



    }

}

