using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Model.Data;

public class BaseEntity
{
	public Guid Id { get; set; }
	public DateTime CreatedDate { get; set; }
	public DateTime? ModifiedDate { get; set; }
	public Guid CreatedById { get; set; }
	public virtual User CreatedBy { get; set; } //
	public Guid? ModifiedById { get; set; }
	public virtual User? ModifiedBy { get; set; }
}
