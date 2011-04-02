using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eCommerceWeb.Business_Layer;

namespace eCommerceWeb.admin
{
    public partial class GetAuthors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DB_Op op = new DB_Op();
            
            int count = 1;
            int d = 0;
            int page = 1;
            if (Request.QueryString["p"] != null)
                page = Convert.ToInt32(Request.QueryString["p"]);
            bool delete = false;
            
            

            if (Request.QueryString["m"] != null && Request.QueryString["id"]!=null)
            {
                if (Request.QueryString["m"] == "delete")
                    delete = true;
            }

            if(delete)
            Delete();

            List<eCommerceWeb.Author> authors = op.GetAuthors();
            foreach (eCommerceWeb.Author a in authors)
            {
                if (count > ((page - 1) * 10) && count < page * 10)
                {
                    Literal1.Text += "First Name :" + a.AuthorFirstName + "<br>";
                    Literal1.Text += "Last Name :" + a.AuthorLastName + "<br>";
                    
                    Literal1.Text += (string.Format("   <a style= ' margin-left:200px; text-decoration:none;' href='EditAuthors.aspx?id={0}'>Edit<a/>", a.AuthorID));
                    Literal1.Text += (string.Format("   <a  onclick='halim()' 'text-decoration:none;' href='GetAuthors.aspx?m={0}&&id={1}' >&nbsp;Delete<a/><br>", "delete", a.AuthorID));
                    Literal1.Text += "--------------------------------------------<br>";
                    d++;
                }
                count++;
            }

            if (page == 1)
            {
                Literal1.Text += (string.Format("<a style= ' margin-left:240px; text-decoration:none;' href='GetAuthors.aspx?p={0}'>&nbsp;{0}<a/>", page));
                goto Halim;
            }
            if (page != 1)
                Literal1.Text += (string.Format("<a style= 'margin-left:240px; text-decoration:none;' href='GetAuthors.aspx?p={0}'>&nbsp;{0}<a/>", page - 1));
            Literal1.Text += (string.Format("<a style= ' text-decoration:none;' href='GetAuthors.aspx?p={0}'>&nbsp;{0}<a/>", page));
            Halim:
            if ((d == 9))
            {
                Literal1.Text += (string.Format("<a  style= ' text-decoration:none;' href='GetAuthors.aspx?p={0}'>&nbsp;{0}<a/>", page + 1));
            }
        }

        private void Delete()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);

            DB_Op op = new DB_Op();

            if (op.DeleteAuthor(id))
                Response.Write("Başarıyla Silindi");
            else
                Response.Write("Silinemedi");
        }

        
    }
}