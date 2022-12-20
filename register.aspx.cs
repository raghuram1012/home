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
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text.Equals(TextBox5.Text)){
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects; Initial Catalog=project; Integrated Security=True");

                SqlParameter sp1 = new SqlParameter();
                sp1.ParameterName = "@name";
                sp1.SqlDbType = SqlDbType.VarChar;
                sp1.Size = 20;
                sp1.Direction = ParameterDirection.Input;
                sp1.Value = TextBox1.Text;

                SqlParameter sp2 = new SqlParameter();
                sp2.ParameterName = "@email";
                sp2.SqlDbType = SqlDbType.VarChar;
                sp2.Size = 20;
                sp2.Direction = ParameterDirection.Input;
                sp2.Value = TextBox2.Text;

                SqlParameter sp3 = new SqlParameter();
                sp3.ParameterName = "@mob";
                sp3.SqlDbType = SqlDbType.VarChar;
                sp3.Size = 20;
                sp3.Direction = ParameterDirection.Input;
                sp3.Value = TextBox3.Text;

                SqlParameter sp4 = new SqlParameter();
                sp4.ParameterName = "@pass";
                sp4.SqlDbType = SqlDbType.VarChar;
                sp4.Size = 20;
                sp4.Direction = ParameterDirection.Input;
                sp4.Value = TextBox4.Text;
                SqlCommand cmd = new SqlCommand("insert into users values(@name,@email,@mob,@pass)", con);
                con.Open();
                cmd.Parameters.Add(sp1);
                cmd.Parameters.Add(sp2);
                cmd.Parameters.Add(sp3);
                cmd.Parameters.Add(sp4);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Response.Write("register successfully");
                }
                else
                {
                    Response.Write("register notsuccessfully");
                }
                con.Close();
            }
            else
            {
                Response.Write("password not match");
            }
        }
    }
}