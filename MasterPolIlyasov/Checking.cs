using MasterPolIlyasov;
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public static class PartnerValidator
{
    public static string ValidatePartnerData(string partnerName, int partnerIndex, string partnerRegion, string partnerCity, string partnerStreet, string partnerHouse, string partnerINN, string directorSurname, string directorFirstname, string directorPatronymic, string partnerPhone, string partnerEmail, double? partnerRating)
    {
        StringBuilder error = new StringBuilder();

        if (string.IsNullOrWhiteSpace(partnerName))
            error.Append("Укажите название партнера!");

        if (partnerIndex.ToString().Length != 6)
            error.Append("Длина индекса адреса компании должна быть равна 6 символам!");

        if (string.IsNullOrWhiteSpace(partnerRegion))
            error.Append("Укажите регион!");

        if (string.IsNullOrWhiteSpace(partnerCity))
            error.Append("Укажите город!");

        if (string.IsNullOrWhiteSpace(partnerStreet))
            error.Append("Укажите улицу!");

        if (string.IsNullOrWhiteSpace(partnerHouse))
            error.Append("Укажите дом!");

        if (string.IsNullOrWhiteSpace(partnerINN) || partnerINN.Length != 10 || !partnerINN.All(char.IsDigit))
            error.Append("ИНН компании должен быть длиной 10 символов и состоять из цифр!");

        if (string.IsNullOrWhiteSpace(directorSurname))
            error.Append("Укажите фамилию директора!");

        if (string.IsNullOrWhiteSpace(directorFirstname))
            error.Append("Укажите имя директора!");

        if (string.IsNullOrWhiteSpace(directorPatronymic))
            error.Append("Укажите отчество директора!");

        if (string.IsNullOrWhiteSpace(partnerPhone) || partnerPhone.Length != 11 || !partnerPhone.StartsWith("8") || !partnerPhone.All(char.IsDigit))
            error.Append("Номер телефона должен начинаться с 8 и быть длиной 11 символов!");

        if (string.IsNullOrWhiteSpace(partnerEmail) || !Regex.IsMatch(partnerEmail, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9]+$"))
            error.Append("Некорректный email!");

        if (partnerRating == null || partnerRating < 0)
            error.Append("Неверный рейтинг партнера!");

        if (error.Length != 0)
            return error.ToString();

        return "Успех";
    }

    public static StringBuilder ValidatePartnerData(Partner partner)
    {
        throw new NotImplementedException();
    }
}
