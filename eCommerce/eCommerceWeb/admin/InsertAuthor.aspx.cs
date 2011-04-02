using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eCommerceWeb;
using eCommerceWeb.Business_Layer;



namespace eCommerceWeb.admin
{
    public partial class InsertAuthor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Literal1.Text = "";
        }

        protected void ButtonAdd_Click(object sender, ImageClickEventArgs e)
        {
            Literal1.Text = "";
            eCommerceWeb.Author a = new eCommerceWeb.Author();
            DB_Op op = new DB_Op();

            a.AuthorFirstName = TextBox1.Text;
            a.AuthorLastName = TextBox2.Text;
            if (op.InsertAuthor(a))
                Literal1.Text = "Başarıyla Veritabanına eklendi";
            else
                Literal1.Text = "What the fuck is wrong with you";

            
        }

    }
}