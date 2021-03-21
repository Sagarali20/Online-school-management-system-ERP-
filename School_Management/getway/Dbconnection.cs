using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Final_project.getway
{
	public class Dbconnection
	{
		private SqlConnection con;

		public SqlConnection GetConnection()
		{
			string s = ConfigurationManager.ConnectionStrings["sagar"].ConnectionString;

			con = new SqlConnection(s);

			if ( con.State==ConnectionState.Open )
			{
				con.Close();
				con.Open();
			}
			else
			{
				con.Open();
			}
			return con;
		}
		public void getClose()
		{
			if (con != null)
			{
				con.Close();
			}
		}
	}
}