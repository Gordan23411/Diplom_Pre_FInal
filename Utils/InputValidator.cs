using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HealthCare_Plus.Utils
{
    internal class InputValidator
    {
        //VARIABLES
        private string value;
        private string label;

        public InputValidator(string value, string label)
        {
            this.value = value;
            this.label = label;
        }

        // VALIDATE ALL TEXT INPUTS
        public static string TextValidate(string value, string label)
        {
            if (string.IsNullOrEmpty(value))
            {
                return label + " это обязательное для заполнения поле";
            }
            if (value.Length < 2)
            {
                return label + " должно быть не менее 2 символов ";
            }
            return "valid";
        }

        // VALIDATE EMAIL INPUTS
        public static string EmailValidate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "Поле электронной почты является обязательным для заполнения";
            }
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);
            if (!regex.IsMatch(value))
            {
                return "Неверный адрес электронной почты";
            }
            return "valid";
        }

        // VALIDATE PASSWORD INPUTS
        public static string PasswordValidate(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "Пароль - это поле, обязательное для заполнения";
            }
            if (value.Length < 8)
            {
                return "Пароль должен содержать не менее 8 символов";
            }
            return "valid";
        }

        // VALIDATE PHONE INPUTS
        public static string PhoneValidation(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "Номер телефона является обязательным полем для заполнения";
            }
            if (value.Length > 10)
            {
                return "Номер телефона должен состоять из 10 символов";
            }
            if (value.Length < 10)
            {
                return "Номер телефона должен состоять из 10 символов";
            }
            string phonePattern = @"^(\d{10})$";
            Regex regex = new Regex(phonePattern);
            if (!regex.IsMatch(value))
            {
                return "Неверный номер телефона";
            }
            return "valid";
        }

        // VALIDATE DATE INPUTS
        public static string DateValidate(DateTime value, string label, string timeLine)
        {
            if (value == null)
            {
                return label + " это обязательное для заполнения поле";
            }
            if (timeLine == "future")
            {
                if (value < DateTime.Now)
                {
                    return label + " должно быть, дата в будующем";
                }
            }
            else
            {
                if (value > DateTime.Now)
                {
                    return label + " должно быть, это прошлая дата";
                }
            }
            return "valid";
        }

        //VALIDATE SELECTIONS
        public static string SelectionValidate(string value, string label, bool validateZero = false)
        {
            if (string.IsNullOrEmpty(value))
            {
                return label + " это обязательное для заполнения поле";
            }

            //VALIDATE INVALID NUMBER
            bool isValidNumber = int.TryParse(value, out int result);
            if (isValidNumber)
            {
                if (result < 0)
                {
                    return label + " недопустимый выбор";
                }
            }

            if (validateZero)
            {
                if (value == "0")
                {
                    return label + " это обязательное для заполнения поле";
                }
            }

            return "valid";
        }

        // VALIDATE NUMBERS
        public static string NumberValidate(string value, string label)
        {
            if (string.IsNullOrEmpty(value))
            {
                return label + " это обязательное для заполнения поле";
            }

            bool isValidNumber = int.TryParse(value, out int result);
            if (isValidNumber)
            {
                if (result < 0)
                {
                    return label + " неверный номер";
                }
            }

            string numberPattern = @"^(\d+)$";
            Regex regex = new Regex(numberPattern);
            if (!regex.IsMatch(value))
            {
                return label + " должны быть цифры";
            }
            return "valid";
        }
    }
}
