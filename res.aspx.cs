using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace home
{
    public partial class res : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           Response.Write( Request.QueryString["count"]);

            Label1.Text= Request.QueryString["name"];
            SqlParameter sp2 = new SqlParameter();
            sp2.ParameterName = "@name";
            sp2.SqlDbType = SqlDbType.VarChar;
            sp2.Size = 20;
            sp2.Direction = ParameterDirection.Input;
            sp2.Value = Label1.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects; Initial Catalog=project; Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from quiz where name=@name", con);
            con.Open();
            cmd.Parameters.Add(sp2);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
            

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
           
            Label2.Text = "Correct Answers";
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Projects; Initial Catalog=project; Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from quizans1 ", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            sd.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}