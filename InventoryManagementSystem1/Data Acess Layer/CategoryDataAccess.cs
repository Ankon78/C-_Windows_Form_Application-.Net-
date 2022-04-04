using InventoryManagementSystem1.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem1.Data_Acess_Layer
{
    class CategoryDataAccess:DataAccess
    {
        public List<Category>GetCategories()
        {
            string sql = "SELECT * FROM Categories";
            SqlDataReader reader = this.GetData(sql);
            List<Category> categories = new List<Category>();
            while(reader.Read())
            {
                Category category = new Category();
                category.CategoryId = (int)reader["CategoryId"];
                category.CategoryName = reader["CategoryName"].ToString();
                categories.Add(category);
            }
            return categories;
        }

        public Category GetCategoryById(int CategoryId)
        {
            string sql = "SELECT * FROM Categories WHERE CategoryId="+CategoryId;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                 Category category = new Category();
                category.CategoryId = (int)reader["CategoryId"];
                category.CategoryName = reader["CategoryName"].ToString();
                return category;
            }
            else
                return null;
        }

        public bool CreateCategory(string categoryName)
        {
            string sql="INSERT INTO Categories(CategoryName) VALUES('"+categoryName + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool UpdateCategory(int categoryId,string categoryName)
        {
            string sql = "UPDATE Categories SET CategoryName='" + categoryName + "'WHERE CategoryId=" + categoryId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool DeleteCategory(int categoryId)
        {
            string sql = "DELETE FROM Categories WHERE CategoryId="+categoryId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            else
                return false;
        }

        public List<string> GetCategoryNames()
        {
            string sql = "SELECT CategoryName FROM Categories";
            SqlDataReader reader = this.GetData(sql);
            List<string> categories = new List<string>();
            while (reader.Read())
            {
               
                categories.Add(reader["CategoryName"].ToString());
            }
            return categories;
        }

        public Category GetCategoryByName(string categoryName)
        {
            string sql = "SELECT * FROM Categories WHERE CategoryName='"+categoryName+"'" ;
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Category category = new Category();
                category.CategoryId = (int)reader["CategoryId"];
                category.CategoryName = reader["CategoryName"].ToString();
                return category;
            }
            else
                return null;
        }


    }
}
