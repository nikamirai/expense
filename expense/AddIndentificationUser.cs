using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace expense
{
    internal class AddIndentificationUser
    {
        public string AddUserInSystem(string login, string password)
        {
            byte[] passwordInByte = Encoding.ASCII.GetBytes(password);
            byte[] hash = new MD5CryptoServiceProvider().ComputeHash(passwordInByte);
            string passwordEnd = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
            try
            {
                UserSystem userSystem = new UserSystem { LoginUser = login, PasswordUser = passwordEnd };
                _ = ExpenseEntities.GetContext().UserSystem.Add(userSystem);
                _ = ExpenseEntities.GetContext().SaveChanges();
                return "success";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        public string AvtorizationInSystem(string login, string password)
        {
            byte[] passwordInByte = Encoding.ASCII.GetBytes(password);
            byte[] hash = new MD5CryptoServiceProvider().ComputeHash(passwordInByte);
            string passwordEnd = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
            var user = ExpenseEntities.GetContext().UserSystem.
                Where(r => r.LoginUser == login && r.PasswordUser == passwordEnd).FirstOrDefault();
            try
            {
                if(user != null) //пользователь есть
                {
                    return "success";

                }else //пользователь не найден
                {
                    return "Неправильный логин или пароль";
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
    }
}
