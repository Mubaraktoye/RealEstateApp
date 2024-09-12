using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Model.ViewModel.Requests
{
    public class RentRequestViewModel
    {
        [Required]
        [StringLength(100)]
        public string Location { get; set; }
        public decimal Price { get; set; }
        [Required]
        [StringLength(100)]
        public string Type { get; set; }
        [Required]
        public int NoOfRoom { get; set; }
        [Required]
        public bool IsGated { get; set; }
        [Required]
        [StringLength(100)]
        public string Landmark { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        [StringLength(250)]
        public string Description { get; set; }
    }
}
