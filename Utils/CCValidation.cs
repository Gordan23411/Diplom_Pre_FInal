using System.Text.RegularExpressions;

namespace HealthCare_Plus.Utils
{
    internal class CCValidation
    {
        //VALIDATE CREDIT NUMBER
        public static string CardNubmerValidate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "Номер кредитной карты является обязательным полем для заполнения";
            }
            if (value.Length > 16)
            {
                return "Номер кредитной карты должен состоять из 16 символов";
            }
            if (value.Length < 16)
            {
                return "Номер кредитной карты должен состоять из 16 символов";
            }
            string creditCardPattern = @"^(\d{16})$";
            Regex regex = new Regex(creditCardPattern);
            if (!regex.IsMatch(value))
            {
                return "Неверный номер кредитной карты";
            }
            return "valid";
        }

        //VALIDATE CREDIT CARD EXPIRY DATE
        public static string ExpDateValidate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "Дата истечения срока действия - обязательное поле для заполнения";
            }
            string expDatePattern = @"^(0[1-9]|1[0-2])\/?([0-9]{4}|[0-9]{2})$";
            Regex regex = new Regex(expDatePattern);
            if (!regex.IsMatch(value))
            {
                return "Недействительный срок годности";
            }
            return "valid";
        }

        //VALIDATE CREDIT CARD CVV
        public static string CVVNumberValidate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "CVV - это обязательное для заполнения поле";
            }
            if (value.Length > 3)
            {
                return "CVV должен состоять из 3 символов";
            }
            if (value.Length < 3)
            {
                return "CVV должен состоять из 3 символов";
            }
            string cvvPattern = @"^(\d{3})$";
            Regex regex = new Regex(cvvPattern);
            if (!regex.IsMatch(value))
            {
                return "Недействительный CVV";
            }
            return "valid";
        }
    }
}
