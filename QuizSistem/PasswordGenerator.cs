using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSistem
{
    public class PasswordGenerator
    {
        public static string GeneratePassword()
        {
            int minLength = 8;
            int maxLength = 12;

            string aviableChars = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM0123456789";

            StringBuilder pass = new StringBuilder();
            Random rand = new Random();

            int passwordLength = rand.Next(minLength, maxLength + 1);

            while (passwordLength-- > 0)
            {
                pass.Append(aviableChars[rand.Next(aviableChars.Length)]);
            }

            return pass.ToString();
        }
    }
}
