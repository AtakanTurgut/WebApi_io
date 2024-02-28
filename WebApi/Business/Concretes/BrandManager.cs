using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
	public class BrandManager : IBrandService
	{
		private readonly IBrandDal _brandDal;

		public BrandManager(IBrandDal brandDal)
		{
			_brandDal = brandDal;
		}

		public CreatedBrandResponse TAdd(CreateBrandRequest createBrandRequest)
		{
			// mapping
			Brand brand = new Brand();
			brand.Name = createBrandRequest.Name;
			brand.CreatedDate = DateTime.Now;

			_brandDal.Add(brand);

			// mapping
			CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
			createdBrandResponse.Name = brand.Name;
			createdBrandResponse.Id = 1;
			createdBrandResponse.CreatedDate = brand.CreatedDate;

			return createdBrandResponse;
		}

		public List<GetAllBrandResponse> TGetAll()
		{
			List<Brand> brands = _brandDal.GetAll();
			List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();

			foreach (var brand in brands)
			{
				GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
				getAllBrandResponse.Id = brand.Id;
				getAllBrandResponse.Name = brand.Name;
				getAllBrandResponse.CreatedDate = brand.CreatedDate;

				getAllBrandResponses.Add(getAllBrandResponse);
			}

			return getAllBrandResponses;
		}

	}
}
