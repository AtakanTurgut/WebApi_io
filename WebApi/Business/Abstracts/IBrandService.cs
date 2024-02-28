using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
	public interface IBrandService
	{
		Brand TAdd(Brand brand);
		List<Brand> TGetAll();
	}
	// responses and requests
}
