using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Final_project.getway;

namespace Final_project
{
	public partial class admin_card : System.Web.UI.Page
	{
		Dbconnection cn = new Dbconnection();
		protected void Page_Load(object sender, EventArgs e)
		{

		}



		protected void Save_Access_Click(object sender, EventArgs e)
		{
			insert_update();
			TextBox1.Text = "";
			TextBox2.Text = "";
			TextBox3.Text = "";
			CheckBox2.Checked = false;

		}
		protected void Update_Click(object sender, EventArgs e)
		{
			if(CheckBox2.Checked==false)
			{
				string q = "UPDATE user_derive set status = 'deactive' WHERE user_name = '"+TextBox3.Text+"' ";
				SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
				cmd.ExecuteNonQuery();
			}
			else
			{
				string q = "UPDATE user_derive set status = 'active' WHERE user_name = '" + TextBox3.Text + "' ";
				SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
				cmd.ExecuteNonQuery();

			}
			insert_update();
			int i = 0;
			Update.Enabled = false;
			cancle.Enabled = false;
			CheckBox2.Checked = false;
			Save_Access.Enabled = true;
			TextBox1.Text = "";
			TextBox2.Text = "";
			TextBox3.Text = "";

		}


		protected void Search_Click(object sender, EventArgs e)
		{
			fun1();
			Update.Enabled = true;
			cancle.Enabled = true;
			Save_Access.Enabled = false;
			string ck;
			string q2 = "select *from user_derive where user_name='" + TextBox3.Text + "'";
			SqlCommand cmd2 = new SqlCommand(q2, cn.GetConnection());
			SqlDataReader reader1 = cmd2.ExecuteReader();
			if(reader1.Read())
			{
				ck = reader1["status"].ToString();
				TextBox1.Text = reader1["userid"].ToString();
				TextBox2.Text = reader1["utype"].ToString();
				TextBox1.ReadOnly = true;
				if(ck=="active")
				{
					CheckBox2.Checked = true;
				}
			}
			else
			{
				CheckBox2.Checked = false;
			}
			string pck,ack;
			string q = "select *from user_access_derive where user_name='"+TextBox3.Text+"'";
			SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				pck = reader["pageid"].ToString();
				ack = reader["action"].ToString();
				foreach (ListItem li in accesslist.Items)
				{
					if (pck == li.Value)
					{

						li.Selected = true;
					}
				}
				if(pck=="1")
				{
					foreach(ListItem li in classlist.Items)
					{
						if(ack==li.Value)
						{
							li.Selected = true;
						}
					}
				}
				if (pck == "2")
				{
					foreach (ListItem li in subjectlist.Items)
					{
						if (ack == li.Value)
						{
							li.Selected = true;
						}
					}
				}
                if (pck == "3")
                {
                    foreach (ListItem li in Stdaddmissionlist.Items)
                    {
                        if (ack == li.Value)
                        {
                            li.Selected = true;
                        }
                    }
                }
                if (pck == "4")
                {
                    foreach (ListItem li in std_resultlist.Items)
                    {
                        if (ack == li.Value)
                        {
                            li.Selected = true;
                        }
                    }
                }
                if (pck == "6")
                {
                    foreach (ListItem li in specialmarklist.Items)
                    {
                        if (ack == li.Value)
                        {
                            li.Selected = true;
                        }
                    }
                }
                if (pck == "8")
                {
                    foreach (ListItem li in paymentList.Items)
                    {
                        if (ack == li.Value)
                        {
                            li.Selected = true;
                        }
                    }
                }
                if (pck == "10")
                {
                    foreach (ListItem li in userdetailsLiast.Items)
                    {
                        if (ack == li.Value)
                        {
                            li.Selected = true;
                        }
                    }
                }
                if (pck == "11")
                {
                    foreach (ListItem li in createuserlist.Items)
                    {
                        if (ack == li.Value)
                        {
                            li.Selected = true;
                        }
                    }
                }

            }
			cn.getClose();
		}

		protected void cancle_Click(object sender, EventArgs e)
		{
			fun1();
			Save_Access.Enabled = true;
			Update.Enabled = false;
			cancle.Enabled = false;
			TextBox2.Text = "";
			TextBox3.Text = "";
			TextBox1.Text = "";
			CheckBox2.Checked = false;

		}


		private void insert_update()
		{

			string q = "delete from user_access_derive where user_name='" + TextBox3.Text + "'";
			SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
			cmd.ExecuteNonQuery();
			cn.getClose();
			foreach (ListItem li in accesslist.Items)
			{
				string ck;
				if (li.Selected)
				{
					ck = li.Value.ToString();
                    fun(ck, "0");

					if (ck == "1")
					{
						foreach (ListItem cl in classlist.Items)
						{
							string ivalue;
							if (cl.Selected)
							{
								ivalue = cl.Value.ToString();
								fun(ck, ivalue);
							}
                            

						}

					}

					if (ck == "2")
					{
						foreach (ListItem cl in subjectlist.Items)
						{
							string ivalue;
							if (cl.Selected)
							{
								ivalue = cl.Value.ToString();
								fun(ck, ivalue);
							}

						}

					}

                    if (ck == "3")
                    {
                        foreach (ListItem cl in Stdaddmissionlist.Items)
                        {
                            string ivalue;
                            if (cl.Selected)
                            {
                                ivalue = cl.Value.ToString();
                                fun(ck, ivalue);
                            }

                        }

                    }

                    if (ck == "4")
                    {
                        foreach (ListItem cl in std_resultlist.Items)
                        {
                            string ivalue;
                            if (cl.Selected)
                            {
                                ivalue = cl.Value.ToString();
                                fun(ck, ivalue);
                            }

                        }

                    }
                    if (ck == "6")
                    {
                        foreach (ListItem cl in specialmarklist.Items)
                        {
                            string ivalue;
                            if (cl.Selected)
                            {
                                ivalue = cl.Value.ToString();
                                fun(ck, ivalue);
                            }

                        }

                    }
                    if (ck == "8")
                    {
                        foreach (ListItem cl in paymentList.Items)
                        {
                            string ivalue;
                            if (cl.Selected)
                            {
                                ivalue = cl.Value.ToString();
                                fun(ck, ivalue);
                            }

                        }

                    }
                    if (ck == "5")
                    {
                        fun("5", "0");
                        //promosition
                    }
                    if (ck == "7")
                    {
                        fun("7", "0");
                        //attendence
                    }
                    if (ck == "9")
                    {
                        fun("9", "0");
                        //account History
                    }
                    if (ck == "10")
                        {
                            foreach (ListItem cl in userdetailsLiast.Items)
                            {
                                string ivalue;
                                if (cl.Selected)
                                {
                                    ivalue = cl.Value.ToString();
                                    fun(ck, ivalue);
                                }

                            }

                    }
                        if (ck == "11")
                        {
                            foreach (ListItem cl in createuserlist.Items)
                            {
                                string ivalue;
                                if (cl.Selected)
                                {
                                    ivalue = cl.Value.ToString();
                                    fun(ck, ivalue);
                                }

                            }

                        }
                    if (ck == "12")
                    {
                        fun("12", "0");
                        //changepassword
                    }
                    if (ck == "13")
                    {
                        fun("13", "0");
                        //user permission
                    }

                }
			}
			fun1();

		}
		private void fun(string fid, string facs)
		{
			string q = "insert into user_access_derive values('" + fid + "','" + facs + "','" + TextBox3.Text + "')";
			SqlCommand cmd = new SqlCommand(q, cn.GetConnection());
			cmd.ExecuteNonQuery();
			cn.getClose();
		}
		private void fun1()
		{
			foreach (ListItem ls in accesslist.Items)
			{
				ls.Selected = false;

			}
			foreach (ListItem ls in classlist.Items)
			{
				ls.Selected = false;

			}
			foreach (ListItem ls in subjectlist.Items)
			{
				ls.Selected = false;

			}
            foreach (ListItem ls in Stdaddmissionlist.Items)
            {
                ls.Selected = false;

            }
            foreach (ListItem ls in specialmarklist.Items)
            {
                ls.Selected = false;

            }
            foreach (ListItem ls in paymentList.Items)
            {
                ls.Selected = false;

            }
            foreach (ListItem ls in userdetailsLiast.Items)
            {
                ls.Selected = false;

            }
            foreach (ListItem ls in createuserlist.Items)
            {
                ls.Selected = false;

            }
            foreach (ListItem ls in std_resultlist.Items)
            {
                ls.Selected = false;

            }




        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Session.Remove("user_name");
            Response.Redirect("~/login.aspx");
        }
    }
}