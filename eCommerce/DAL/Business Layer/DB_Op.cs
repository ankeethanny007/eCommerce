using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Web;
using System.Configuration;

namespace DAL.Business_Layer
{
    public class DB_Op
    {
        string conName;
        SqlConnection con;
        public DB_Op()
        {
            
        }

        public void openConnection()
        {
            conName = System.Configuration.ConfigurationManager.ConnectionStrings["EBookStore"].ConnectionString;
            con = new SqlConnection(conName);
            con.Open();
        }
        public void closeConnection()
        {
            con.Close();
        }

        public bool InsertAuthor(Author a)
        {
            EBookStoreEntities e = new EBookStoreEntities();
            try
            {

                e.AddToAuthors(a);
                e.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
