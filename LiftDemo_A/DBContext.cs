using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorProject
{
	internal class DBContext
	{

		string connectionString = @"Server = KRITIKA; Database = ElevatorLog; Trusted_Connection = True;";

		public void InsertLogsIntoDB(DataTable dt)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					string query = @"Insert into Log (LogTime, EventDescription) values (@Time, @Log)";

					using (SqlDataAdapter adapter = new SqlDataAdapter())
					{
						adapter.InsertCommand = new SqlCommand(query, conn);
						adapter.InsertCommand.Parameters.Add("@Time", SqlDbType.DateTime, 0, "LogTime");
						adapter.InsertCommand.Parameters.Add("@Log", SqlDbType.NVarChar, 255, "EventDescription");

						conn.Open();

						adapter.Update(dt);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving logs to DB: " + ex.Message);
			}
		}

		public void loadLogsFromDB(DataTable dt, DataGridView dataGridViewLogs)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					string query = @"Select LogTime, EventDescription from Log order by LogTime desc";

					using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
					{
						dt.Rows.Clear();

						adapter.Fill(dt);

						dataGridViewLogs.Rows.Clear();

						foreach (DataRow row in dt.Rows)
						{
							string currentTime = Convert.ToDateTime(row["LogTime"]).ToString("hh:mm:ss");
							string events = row["EventDescription"].ToString();

							dataGridViewLogs.Rows.Add(currentTime, events);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading logs from DB: " + ex.Message);
			}

		}

	}
}
