using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToysAuction.Models;
using System.Data.SqlClient;

namespace ToysAuction.DataAccess
{
    public class Repository : IRepository
    {
        private System.Configuration.ConnectionStringSettings connectionString;

        public Repository()
        {
            System.Configuration.Configuration rootWebConfig =
                System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/MyWebSiteRoot");

            if (rootWebConfig.ConnectionStrings.ConnectionStrings.Count > 0)
            {
                connectionString =
                    rootWebConfig.ConnectionStrings.ConnectionStrings["AuzreDb"];
            }
        }

        public List<Toy> GetToys()
        {
            List<Toy> result = new List<Toy>();
            using (SqlConnection conn = new SqlConnection())
            {
                SqlCommand command = new SqlCommand("select t.Name, t.NumberLegs, c.ColorName as Color, t.OwnerID from Toys as t inner join Colors as c on t.ColorID = c.ColorID");
                conn.ConnectionString = this.connectionString.ConnectionString;
                command.Connection = conn; 
                
                conn.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Toy() {
                        Name = reader["Name"].ToString(),
                        NumberLegs = (int)reader["NumberLegs"],
                        Color = reader["Color"].ToString(), 
                        Owner = reader["OwnerId"].ToString()
                    }); 
                }
            }

            return result;
        }

        public Toy CreateToy(Toy toy)
        {

            using (SqlConnection conn = new SqlConnection())
            {
                var query = string.Format("insert into toys ( Name, NumberLegs, ColorId, OwnerID ) values('{0}', '{1}','{2}','{3}')",
                toy.Name, toy.NumberLegs, toy.ColorId, toy.OwnerId);

                SqlCommand command = new SqlCommand(query);
                conn.ConnectionString = this.connectionString.ConnectionString;
                command.Connection = conn;

                conn.Open();

                command.ExecuteNonQuery();

                return toy;
            }

        }
    }
}