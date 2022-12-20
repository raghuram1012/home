using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace home
{
    public partial class quiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects; Initial Catalog=project; Integrated Security=True");
            String name = Request.QueryString["name"];

            int count;
            
            SqlParameter sp1 = new SqlParameter();
            sp1.ParameterName = "@q1";
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

            

            SqlCommand cmd = new SqlCommand("update quiz set q1 = @q1 where name=@name", con);
            con.Open();
            cmd.Parameters.Add(sp1);
            cmd.Parameters.Add(sp2);
            int res=   cmd.ExecuteNonQuery();
            if (res > 0)
            {
                Response.Redirect("page2.aspx?name="+name);
                if (RadioButtonList1.SelectedItem.Text.Equals("Framework"))
                {
                    count =1;
                   
                }
                else
                {
                    count = 0;
                }
                Response.Redirect("?count=" + count);
            }
            con.Close();
            
            
        }
    }
}