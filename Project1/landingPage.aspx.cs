using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Project1
{
    public partial class landingPage : System.Web.UI.Page
    {
        private SQLDataHandler dh;
        protected void Page_Load(object sender, EventArgs e)
        {
            dh = new SQLDataHandler();
            if (!IsPostBack)
            {
               dh.executeSql("Update Student set sname = Fred where sid no = '17'");
            }
           SqlDataReader dr = dh.getDataReader("Select * from Student");
            while (dr.Read())
            {
               //DropDownList1.Items.Add((String)dr["sname"]);
            }//while
            dr.Close();
           // lblCount.Text = "" + (Int32)dh.getScalar("Select Count(*) from Student");


            DataTable dt = dh.getDataTable("Select * from Student");
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            dh.executeSql("Update Student set sname = Fred where sid no = '17'");
            DataTable dt = dh.getDataTable("Select * from Student");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Response.Redirect(Request.Url.AbsoluteUri);

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String sidno = (String)GridView1.DataKeys[e.RowIndex].Value;
            //dh.executeSql("Delete from Student where sidno = ' " + sidno + "'");
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String sidno = (String)GridView1.DataKeys[e.RowIndex].Value;
            int index = GridView1.EditIndex;
            GridViewRow row = GridView1.Rows[index];
            TextBox t1 = (TextBox)row.Cells[0].Controls[0];
            TextBox t2 = (TextBox)row.Cells[1].Controls[0];
            TextBox t3 = (TextBox)row.Cells[2].Controls[0];
           // dh.executeSql("Update Student set sidno = '" + t1.Text + "', sname = '" + t2.Text + "', majorcode = '" + t3.Text + "' where sidno = '" + sidno + "'");
            GridView1.EditIndex = -1;
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}