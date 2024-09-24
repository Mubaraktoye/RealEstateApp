using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Model.ViewModel.Requests
{
	public class LogQueryRequestModel
	{
		public DateTime? Date { get; set; }
		public bool IsContacted { get; set; }
	}
}
