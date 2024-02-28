using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BrandsController : ControllerBase
	{
		private readonly IBrandService _brandService;

		public BrandsController(IBrandService brandService)
		{
			_brandService = brandService;
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			var response = _brandService.TGetAll();

			return Ok(response);
		}

		[HttpPost]
		public IActionResult Add(CreateBrandRequest createBrandRequest)
		{
			CreatedBrandResponse createdBrandResponse = _brandService.TAdd(createBrandRequest);

			return Ok(createdBrandResponse);	// 200
		}

	}
}
