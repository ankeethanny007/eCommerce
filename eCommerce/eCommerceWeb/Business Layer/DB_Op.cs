using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace eCommerceWeb.Business_Layer
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
            conName = System.Configuration.ConfigurationManager.ConnectionStrings["EBookStoreEntities"].ConnectionString;
            con = new SqlConnection("data source=mssql01.turhost.com;Initial Catalog=wnc_eBookStore;User Id=eBook;Password=banaMiBilader;");
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

        public List<Author> GetAuthors()
        {
            EBookStoreEntities e = new EBookStoreEntities();

            List<Author> authors = e.Authors.ToList<Author>();

            return authors;
        }

        public bool DeleteAuthor(int id)
        {
            openConnection();

            SqlCommand com = new SqlCommand("Delete_Author", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@AuthorID", id);

            try
            {
                com.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                closeConnection();
            }
         
        }
    }
}