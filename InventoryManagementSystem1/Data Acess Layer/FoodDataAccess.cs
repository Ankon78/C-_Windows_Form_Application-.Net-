using ChefsFoodManagement.Entities;
using InventoryManagementSystem1.Data_Acess_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefsFoodManagement.Data_Access_Layer
{
    class FoodDataAccess:DataAccess
    {
        public List<Food> GetFoods()
        {
            string sql = "SELECT * FROM FoodList";
            SqlDataReader reader = this.GetData(sql);
            List<Food> foods = new List<Food>();
            while(reader.Read())
            {
                Food food = new Food();
                food.FoodId = (int)reader["FoodId"];
                food.FoodName = reader["FoodName"].ToString();
                food.FoodCategory = reader["FoodCategory"].ToString();
                food.MfgDate = reader["MfgDate"].ToString();
                food.ExpDate = reader["ExpDate"].ToString();
                food.Quantity = (int)reader["Quantity"];
                food.PerUnitPrice = (int)reader["PerUnitPrice"];
                food.Ingredients = reader["Ingredients"].ToString();
                foods.Add(food);
            }
            return foods;
        }

        public List<Food> GetFoodById(int foodId)
        {
            string sql = "SELECT * FROM FoodList Foods WHERE FoodId = " + foodId;
            SqlDataReader reader = this.GetData(sql);
            List<Food> food1 = new List<Food>();
            while (reader.Read())
            {
                Food food = new Food();
                food.FoodId = (int)reader["FoodId"];
                food.FoodName = reader["FoodName"].ToString();
                food.FoodCategory = reader["FoodCategory"].ToString();
                food.MfgDate = reader["MfgDate"].ToString();
                food.ExpDate = reader["ExpDate"].ToString();
                food.Quantity = (int)reader["Quantity"];
                food.PerUnitPrice = (int)reader["PerUnitPrice"];
                food.Ingredients = reader["Ingredients"].ToString();
                food1.Add(food);
            }
            return food1;
        }


        public bool CreateFood(string foodName,string foodCategory,string mfgDate,string expDate,int quantity,int perUnitPrice,string ingredients)
        {
            string sql = "INSERT INTO FoodList(FoodName,FoodCategory,MfgDate,ExpDate,Quantity,PerUnitPrice,Ingredients) VALUES('" + foodName+"','"+foodCategory+"','"+mfgDate+"','"+expDate+"',"+quantity+","+perUnitPrice+",'"+ingredients+"')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateFood(int foodId, string foodName, string foodCategory, string mfgDate, string expDate, int quantity, int perUnitPrice, string ingredients)
        {
            string sql = "UPDATE FoodList SET FoodName='" + foodName+"',FoodCategory='"+foodCategory+"',MfgDate='"+mfgDate+"',ExpDate='"+expDate+"',Quantity="+quantity+",PerUnitPrice="+perUnitPrice+",Ingredients='"+ingredients+"' WHERE FoodId="+foodId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool DeleteFood(int foodId)
        {
            string sql = "DELETE FROM FoodList WHERE FoodId=" + foodId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public List<Food> GetFoodListByNames(string str)
        {
            string sql = "SELECT * FROM FoodList  WHERE FoodName LIKE '" + str + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Food> foods = new List<Food>();
            while (reader.Read())
            {
                Food food = new Food();
                food.FoodId = (int)reader["FoodId"];
                food.FoodName = reader["FoodName"].ToString();
                food.FoodCategory = reader["FoodCategory"].ToString();
                food.MfgDate = reader["MfgDate"].ToString();
                food.ExpDate = reader["ExpDate"].ToString();
                food.Quantity = (int)reader["Quantity"];
                food.PerUnitPrice = (int)reader["PerUnitPrice"];
                food.Ingredients = reader["Ingredients"].ToString();
                foods.Add(food);
            }
            return foods;
        }
    }
}
