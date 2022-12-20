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
    public partial class page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string count = Request.QueryString["count"];

            Response.Write(count);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string count = Request.QueryString["count"];

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects; Initial Catalog=project; Integrated Security=True");
            String name = Request.QueryString["name"];
            SqlParameter sp1 = new SqlParameter();
            sp1.ParameterName = "@q3";
            sp1.SqlDbType = SqlDbType.VarChar;
            sp1.Size = 60;
            sp1.Direction = ParameterDirection.Input;
            sp1.Value = RadioButtonList1.SelectedItem.ToString();

            SqlParameter sp2 = new SqlParameter();
            sp2.ParameterName = "@name";
            sp2.SqlDbType = SqlDbType.VarChar;
            sp2.Size = 60;
            sp2.Direction = ParameterDirection.Input;
            sp2.Value = name;
            if (RadioButtonList1.SelectedItem.Text.Equals("Character"))

            {
                count = "3";

            }
            SqlCommand cmd = new SqlCommand("update quiz set q3 = @q3 where name=@name", con);
            con.Open();
            cmd.Parameters.Add(sp1);
            cmd.Parameters.Add(sp2);
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                Response.Redirect("page4.aspx?name=" + name);
                Response.Redirect("?count=" + count);
            }
            con.Close();
        }
    }
}