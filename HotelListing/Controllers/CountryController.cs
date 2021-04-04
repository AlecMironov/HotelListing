using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HotelListing.IRepository;
using HotelListing.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotelListing.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CountryController : ControllerBase
	{
		private readonly ILogger<CountryController> _logger;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public CountryController(ILogger<CountryController> logger, IUnitOfWork unitOfWork, IMapper mapper)
		{
			_logger = logger;
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetCountries()
		{
			try
			{
				var countries = await _unitOfWork.Countries.GetAll(includes: new List<string> { "Hotels" });
				var result = _mapper.Map<IList<CountryDTO>>(countries);

				return Ok(result);
			}
			catch (System.Exception ex)
			{
				_logger.LogError(ex, $"Something went wrong in the {nameof(GetCountries)}");
				return StatusCode(500, "Internal Server Error. Please Try Again Later.");
			}
		}

		[HttpGet("{id:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> GetCountry(int id)
		{
			try
			{
				var country = await _unitOfWork.Countries.Get(q => q.Id == id, new List<string> { "Hotels" });
				var result = _mapper.Map<CountryDTO>(country);

				return Ok(result);
			}
			catch (System.Exception ex)
			{
				_logger.LogError(ex, $"Something went wrong in the {nameof(GetCountry)}");
				return StatusCode(500, "Internal Server Error. Please Try Again Later.");
			}
		}
	}
}
