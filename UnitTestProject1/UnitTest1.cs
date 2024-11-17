using MasterPolIlyasov;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static MasterPolIlyasov.AddPartnerPage;

namespace YourNamespace.Tests
{
    [TestClass]
    public class PartnerValidationTests
    {
        private PartnerValidation _partnerValidation;

        [TestInitialize]
        public void Setup()
        {
            _partnerValidation = new PartnerValidation();
        }


        [TestMethod]
        public void Check1_PartnerName_True()
        {
            Partner partner = new Partner
            {
                Partner_Name = "",  // Пустое название
                Partner_Index = "123456",
                Partner_Region = "Регион",
                Partner_City = "Город",
                Partner_Street = "Улица",
                Partner_House = "12",
                Partner_INN = "1234567890",
                Director_Surname = "Иванов",
                Director_Firstname = "Иван",
                Director_Patronymic = "Иванович",
                Partner_Phone = "81234567890",
                Partner_Email = "example@example.com",
                
            };

            int result = _partnerValidation.ValidatePartnerData(partner);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Check2_PartnerIndex_True()
        {
            Partner partner = new Partner
            {
                Partner_Name = "Партнер",
                Partner_Index = "12345",  // Некорректная длина индекса
                Partner_Region = "Регион",
                Partner_City = "Город",
                Partner_Street = "Улица",
                Partner_House = "12",
                Partner_INN = "1234567890",
                Director_Surname = "Иванов",
                Director_Firstname = "Иван",
                Director_Patronymic = "Иванович",
                Partner_Phone = "81234567890",
                Partner_Email = "example@example.com",
                
            };

            int result = _partnerValidation.ValidatePartnerData(partner);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Check3_PartnerRegion_True()
        {
            Partner partner = new Partner
            {
                Partner_Name = "Партнер",
                Partner_Index = "123456",
                Partner_Region = "",  // Пустой регион
                Partner_City = "Город",
                Partner_Street = "Улица",
                Partner_House = "12",
                Partner_INN = "1234567890",
                Director_Surname = "Иванов",
                Director_Firstname = "Иван",
                Director_Patronymic = "Иванович",
                Partner_Phone = "81234567890",
                Partner_Email = "example@example.com",
                
            };

            int result = _partnerValidation.ValidatePartnerData(partner);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Check4_PartnerCity_True()
        {
            Partner partner = new Partner
            {
                Partner_Name = "Партнер",
                Partner_Index = "123456",
                Partner_Region = "Регион",
                Partner_City = "",  // Пустой город
                Partner_Street = "Улица",
                Partner_House = "12",
                Partner_INN = "1234567890",
                Director_Surname = "Иванов",
                Director_Firstname = "Иван",
                Director_Patronymic = "Иванович",
                Partner_Phone = "81234567890",
                Partner_Email = "example@example.com",
                
            };

            int result = _partnerValidation.ValidatePartnerData(partner);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Check5_PartnerStreet_True()
        {
            Partner partner = new Partner
            {
                Partner_Name = "Партнер",
                Partner_Index = "123456",
                Partner_Region = "Регион",
                Partner_City = "Город",
                Partner_Street = "",  // Пустая улица
                Partner_House = "12",
                Partner_INN = "1234567890",
                Director_Surname = "Иванов",
                Director_Firstname = "Иван",
                Director_Patronymic = "Иванович",
                Partner_Phone = "81234567890",
                Partner_Email = "example@example.com",
                
            };

            int result = _partnerValidation.ValidatePartnerData(partner);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Check6_PartnerHouse_True()
        {
            Partner partner = new Partner
            {
                Partner_Name = "Партнер",
                Partner_Index = "123456",
                Partner_Region = "Регион",
                Partner_City = "Город",
                Partner_Street = "Улица",
                Partner_House = "",  // Пустой дом
                Partner_INN = "1234567890",
                Director_Surname = "Иванов",
                Director_Firstname = "Иван",
                Director_Patronymic = "Иванович",
                Partner_Phone = "81234567890",
                Partner_Email = "example@example.com",
                
            };

            int result = _partnerValidation.ValidatePartnerData(partner);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Check7_PartnerINN_True()
        {
            Partner partner = new Partner
            {
                Partner_Name = "Партнер",
                Partner_Index = "123456",
                Partner_Region = "Регион",
                Partner_City = "Город",
                Partner_Street = "Улица",
                Partner_House = "12",
                Partner_INN = "",  // Пустой ИНН
                Director_Surname = "Иванов",
                Director_Firstname = "Иван",
                Director_Patronymic = "Иванович",
                Partner_Phone = "81234567890",
                Partner_Email = "example@example.com",
                
            };

            int result = _partnerValidation.ValidatePartnerData(partner);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Check8_PartnerINN_True()
        {
            Partner partner = new Partner
            {
                Partner_Name = "Партнер",
                Partner_Index = "123456",
                Partner_Region = "Регион",
                Partner_City = "Город",
                Partner_Street = "Улица",
                Partner_House = "12",
                Partner_INN = "12345",  // Некорректный ИНН
                Director_Surname = "Иванов",
                Director_Firstname = "Иван",
                Director_Patronymic = "Иванович",
                Partner_Phone = "81234567890",
                Partner_Email = "example@example.com",
                
            };

            int result = _partnerValidation.ValidatePartnerData(partner);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Check9_DirectorSurname_True()
        {
            Partner partner = new Partner
            {
                Partner_Name = "Партнер",
                Partner_Index = "123456",
                Partner_Region = "Регион",
                Partner_City = "Город",
                Partner_Street = "Улица",
                Partner_House = "12",
                Partner_INN = "1234567890",
                Director_Surname = "",  // Пустая фамилия директора
                Director_Firstname = "Иван",
                Director_Patronymic = "Иванович",
                Partner_Phone = "81234567890",
                Partner_Email = "example@example.com",
                
            };

            int result = _partnerValidation.ValidatePartnerData(partner);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Check10_DirectorFirstname_True()
        {
            Partner partner = new Partner
            {
                Partner_Name = "Партнер",
                Partner_Index = "123456",
                Partner_Region = "Регион",
                Partner_City = "Город",
                Partner_Street = "Улица",
                Partner_House = "12",
                Partner_INN = "1234567890",
                Director_Surname = "Иванов",
                Director_Firstname = "",  // Пустое имя директора
                Director_Patronymic = "Иванович",
                Partner_Phone = "81234567890",
                Partner_Email = "example@example.com",
                
            };

            int result = _partnerValidation.ValidatePartnerData(partner);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Check11_DirectorPatronymic_True()
        {
            Partner partner = new Partner
            {
                Partner_Name = "Партнер",
                Partner_Index = "123456",
                Partner_Region = "Регион",
                Partner_City = "Город",
                Partner_Street = "Улица",
                Partner_House = "12",
                Partner_INN = "1234567890",
                Director_Surname = "Иванов",
                Director_Firstname = "Иван",
                Director_Patronymic = "",  // Пустое отчество директора
                Partner_Phone = "81234567890",
                Partner_Email = "example@example.com",
                
            };

            int result = _partnerValidation.ValidatePartnerData(partner);

            Assert.IsTrue(result > 0);
        }
        [TestMethod]
        public void Check12_PartnerPhone_True()
        {
            Partner partner = new Partner
            {
                Partner_Name = "Партнер",
                Partner_Index = "123456",
                Partner_Region = "Регион",
                Partner_City = "Город",
                Partner_Street = "Улица",
                Partner_House = "12",
                Partner_INN = "1234567890",
                Director_Surname = "Иванов",
                Director_Firstname = "Иван",
                Director_Patronymic = "Иванович",
                Partner_Phone = "",  // Пустой телефон
                Partner_Email = "example@example.com",
                
            };

            int result = _partnerValidation.ValidatePartnerData(partner);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Check13_PartnerPhone_True()
        {
            Partner partner = new Partner
            {
                Partner_Name = "Партнер",
                Partner_Index = "123456",
                Partner_Region = "Регион",
                Partner_City = "Город",
                Partner_Street = "Улица",
                Partner_House = "12",
                Partner_INN = "1234567890",
                Director_Surname = "Иванов",
                Director_Firstname = "Иван",
                Director_Patronymic = "Иванович",
                Partner_Phone = "1234567890",  // Некорректный телефон
                Partner_Email = "example@example.com",
                
            };

            int result = _partnerValidation.ValidatePartnerData(partner);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Check14_PartnerEmail_True()
        {
            Partner partner = new Partner
            {
                Partner_Name = "Партнер",
                Partner_Index = "123456",
                Partner_Region = "Регион",
                Partner_City = "Город",
                Partner_Street = "Улица",
                Partner_House = "12",
                Partner_INN = "1234567890",
                Director_Surname = "Иванов",
                Director_Firstname = "Иван",
                Director_Patronymic = "Иванович",
                Partner_Phone = "81234567890",
                Partner_Email = "",  // Пустой Email
                
            };

            int result = _partnerValidation.ValidatePartnerData(partner);

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Check15_PartnerEmail_True()
        {
            Partner partner = new Partner
            {
                Partner_Name = "Партнер",
                Partner_Index = "123456",
                Partner_Region = "Регион",
                Partner_City = "Город",
                Partner_Street = "Улица",
                Partner_House = "12",
                Partner_INN = "1234567890",
                Director_Surname = "Иванов",
                Director_Firstname = "Иван",
                Director_Patronymic = "Иванович",
                Partner_Phone = "81234567890",
                Partner_Email = "invalid-email",  // Некорректный email
                
            };

            int result = _partnerValidation.ValidatePartnerData(partner);

            Assert.IsTrue(result > 0);
        }

    }
}

