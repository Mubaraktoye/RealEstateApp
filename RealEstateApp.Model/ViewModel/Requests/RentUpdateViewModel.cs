using RealEstateApp.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Model.ViewModel.Requests
{
	public class RentUpdateViewModel
	{
		public Guid Id { get; set; }
		public string Location { get; set; }
		public decimal Price { get; set; }
		public string Type { get; set; }
		public int NoOfRoom { get; set; }
		public bool IsGated { get; set; }
		public string Landmark { get; set; }
		public string Status { get; set; }//
		public string Description { get; set; }
	}

	public class RentApprovalViewModel
	{
		public Guid Id { get; set; }
		public ApprovalType ApprovalType { get; set; }
	}
}
