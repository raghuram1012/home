using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace home
{
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlParameter sp1 = new SqlParameter();
            sp1.ParameterName = "@id";
            sp1.SqlDbType = SqlDbType.VarChar;
            sp1.Size = 60;
            sp1.Direction = ParameterDirection.Input;
            sp1.Value = TextBox1.Text;

            String pass;
            String email;
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects; Initial Catalog=project; Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select password from admin where id=@id", con);
            con.Open();
            cmd.Parameters.Add(sp1);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                email = sdr["email"] + "";
                pass = sdr["password"] + "";
                if (TextBox2.Text == (email)&&(TextBox3.Text == (email)))
                {
                    Response.Write("login success");
                    Response.Redirect("result.aspx");
                }
                else
                {
                    Response.Write("passward or email is mismatch");
                }
            }
            sdr.Close();
            con.Close();
        }
    }
}