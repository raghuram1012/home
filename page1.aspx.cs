using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace home
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "login success  start taking quiz";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects; Initial Catalog=project; Integrated Security=True");
            

            SqlParameter sp1 = new SqlParameter();
            sp1.ParameterName = "@name";
            sp1.SqlDbType = SqlDbType.VarChar;
            sp1.Size = 20;
            sp1.Direction = ParameterDirection.Input;
            sp1.Value = TextBox1.Text;

            SqlCommand cmd = new SqlCommand("insert  into quiz (name) values (@name)", con);
            con.Open();
            cmd.Parameters.Add(sp1);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                Response.Redirect("quiz.aspx?name="+TextBox1.Text);
            }
            con.Close();
            
        }
    }
}