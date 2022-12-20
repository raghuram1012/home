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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects; Initial Catalog=project; Integrated Security=True");
            SqlParameter sp1 = new SqlParameter();
            sp1.ParameterName = "@q1";
            sp1.SqlDbType = SqlDbType.VarChar;
            sp1.Size = 60;
            sp1.Direction = ParameterDirection.Input;
            sp1.Value = TextBox1.Text;

            SqlParameter sp2 = new SqlParameter();
            sp2.ParameterName = "@q2";
            sp2.SqlDbType = SqlDbType.VarChar;
            sp2.Size = 60;
            sp2.Direction = ParameterDirection.Input;
            sp2.Value = TextBox2.Text;

            SqlParameter sp3 = new SqlParameter();
            sp3.ParameterName = "@q3";
            sp3.SqlDbType = SqlDbType.VarChar;
            sp3.Size = 60;
            sp3.Direction = ParameterDirection.Input;
            sp3.Value = TextBox3.Text;

            SqlParameter sp4 = new SqlParameter();
            sp4.ParameterName = "@q4";
            sp4.SqlDbType = SqlDbType.VarChar;
            sp4.Size = 60;
            sp4.Direction = ParameterDirection.Input;
            sp4.Value = TextBox4.Text;

            SqlParameter sp5 = new SqlParameter();
            sp5.ParameterName = "@q5";
            sp5.SqlDbType = SqlDbType.VarChar;
            sp5.Size = 60;
            sp5.Direction = ParameterDirection.Input;
            sp5.Value = TextBox5.Text;

            SqlCommand cmd = new SqlCommand("insert into quizans1  values (@q1,@q2,@q3,@q4,@q5)", con);
            con.Open();
            cmd.Parameters.Add(sp1);
            cmd.Parameters.Add(sp2);
            cmd.Parameters.Add(sp3);
            cmd.Parameters.Add(sp4);
            cmd.Parameters.Add(sp5);
            int res = cmd.ExecuteNonQuery();
            if(res > 0)
            {
                Response.Write("yes");
            }
        }
    }
}