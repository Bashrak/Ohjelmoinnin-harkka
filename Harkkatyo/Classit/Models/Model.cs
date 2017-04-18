﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classit.Models {
	class WorkDayItem {
		public int EmployeeId { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
	}
	class Employee {
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public int Passwd { get; set; }
		public bool IsAdministrator { get; set; }
	}
	class HourMultipliers {
		public int MultiplierID { get; set; }
		public string Name { get; set; }
		private float multiplier;

		public float Multiplier
		{
			get { return multiplier; }
			set {
				multiplier = value;
				if (multiplier < 1) {
					multiplier = 1;
				}
			}
		}

	}
}