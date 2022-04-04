using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistration2;

namespace InventoryManagementSystem1.Data_Acess_Layer
{
    class UserDataAccess:DataAccess
    {
        public bool UserRegister(User user)
        {
            string sql = "INSERT INTO Users(Name,Username,Password,Email,DateOfBirth,Gender,BloodGroup)VALUES('" + user.Name + "','" + user.Username + "','" + user.Password + "','" + user.Email + "','" + user.DateOfBirth + "','" + user.Gender + "','" + user.BloodGroup + "' ) ";

            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            else
                return false;
        }
        public bool ValidateLogin(string username,string password)
        {
            string sql = "SELECT * FROM Users WHERE Username='"+username+"'AND Password='"+password+"'";

            SqlDataReader reader = this.GetData(sql);

            if (reader.HasRows)
            {
                return true;
            }
            else
                return false;
        }
    }
}
