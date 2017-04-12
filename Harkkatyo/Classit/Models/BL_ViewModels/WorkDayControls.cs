using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classit.Models;
using MySql.Data.MySqlClient;

namespace Classit.Models.BL_ViewModels {
	class WorkDayControls {
		public ObservableCollection<WorkDayItem> WorkDayItems { get; set; }
		public void LoadFromMysql()
		{
			try {
				ObservableCollection<WorkDayItem> workdayitems = new ObservableCollection<WorkDayItem>();
				string connStr = ""; // TODO fill this!!!
				string sql = "SELECT EmployeeID, WorkStartTime, WorkEndTime FROM WorkDays";
				using (MySqlConnection conn = new MySqlConnection(connStr)) {
					conn.Open();
					using (MySqlCommand cmd = new MySqlCommand(sql, conn))
					using (MySqlDataReader reader = cmd.ExecuteReader()) {
						while (reader.Read()) {
							WorkDayItem s = new WorkDayItem();
							s.EmployeeId = reader.GetInt32(0);
							s.StartTime = reader.GetDateTime(1);
							s.EndTime = reader.GetDateTime(2);
							workdayitems.Add(s);
						}
						WorkDayItems = workdayitems;
					}
				}
			}
			catch {
				throw;
			}
		}
	}
}
