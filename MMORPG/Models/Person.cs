using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person
    {
        int id;

        private List<string> items = new List<string>();
        private int[] specification = new int[6];
        private string[] personInf = new string[5];

        public List<string> Items 
        { 
            get
            {
                return items;
            }
        }

        public int[] Specification
        {
            get
            {
                return specification;
            }
        }

        public string[] PersonInf
        {
            get
            {
                return personInf;
            }
        }

        public Person(int idPerson)
        {
            id = idPerson;
        }

        public void UpdateDataPerson()
        {
            using (SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["CourseWork"].ConnectionString))
            {
                SqlCommand com = new SqlCommand("SELECT P_Nickname, P_SDVIFL, P_Level, C_Name, R_Name " +
                    "FROM Person INNER JOIN Class ON P_Class = Class.ID INNER JOIN Race ON C_Race = Race.ID " +
                    "WHERE Person.ID = @ID");
                com.Parameters.AddWithValue("@ID", id);
                com.Connection = sql;

                sql.Open();

                using (var rdr = com.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            personInf[i] = rdr[i].ToString();
                        }
                    }
                }
                com.CommandText = "SELECT I_Name FROM Items INNER JOIN Person_Items ON ID_Item = Items.ID" +
                    " INNER JOIN Person ON ID_Person = Person.ID " +
                    "Where Person.ID = @ID";
                using (var rdr = com.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        items.Add(rdr[0].ToString());
                    }
                }
                for (int i = 0; i < specification.Length; i++)
                {
                    int value = int.Parse(personInf[1][i * 2].ToString() + personInf[1][i * 2 + 1].ToString());
                    specification[i] = value;
                }
            }
        }
    }
}
