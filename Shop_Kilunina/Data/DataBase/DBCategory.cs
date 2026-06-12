using MySql.Data.MySqlClient;
using Shop_Kilunina.Data.Common;
using Shop_Kilunina.Data.Interfaces;
using Shop_Kilunina.Data.Models;
using System.Collections.Generic;

namespace Shop_Kilunina.Data.DataBase
{
    public class DBCategory : ICategorys
    {
        public IEnumerable<Categories> AllCategorys
        {
            get
            {
                List<Categories> categorys = new List<Categories>();
                MySqlConnection MySqlConnection = Connection.MySqlOpen();
                MySqlDataReader CategoriesData = Connection.MySqlQuery("SELECT * FROM Shop.Categorys ORDER BY `Name`;", MySqlConnection);
                while (CategoriesData.Read())
                {
                    categorys.Add(new Categories()
                    {
                        Id = CategoriesData.IsDBNull(0) ? -1 : CategoriesData.GetInt32(0),
                        Name = CategoriesData.IsDBNull(1) ? null : CategoriesData.GetString(1),
                        Description = CategoriesData.IsDBNull(2) ? null : CategoriesData.GetString(2)
                    });
                }
                return categorys;
            }
        }
    }
}
