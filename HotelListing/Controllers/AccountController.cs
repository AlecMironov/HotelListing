using AutoMapper;
using HotelListing.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotelListing.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<ApiUser> _userManager;
		private readonly SignInManager<ApiUser> _signInManager;
		private readonly ILogger<CountryController> _logger;
		private readonly IMapper _mapper;

		public AccountController(UserManager<ApiUser> userManager, SignInManager<ApiUser> signInManager, ILogger<CountryController> logger, IMapper mapper)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_logger = logger;
			_mapper = mapper;
		}

		//[HttpPost]
		//public async Task<IActionResult> Register([FromBody] UserDTO userDTO)
		//{
		//	_logger.LogInformation($"Registration Attempt for {userDTO.Email}");
		//	if (!ModelState.IsValid)
		//	{
		//		return BadRequest(ModelState);
		//	}

		//	try
		//	{
		//		var user = _mapper.Map<ApiUser>(userDTO);
		//		var result = await _userManager.CreateAsync(user);

		//		if (!result.Succeeded)
		//		{
		//			return BadRequest($"User Registration Attempt Failed");
		//		}
		//	}

		//	catch (System.Exception ex)
		//	{
		//		_logger.LogError(ex, $"Something Went Wrong in the {nameof(Register)}");
		//		return Problem($"Something Went Wrong in the {nameof(Register)}", statusCode: 500);
		//	}
		//}
	}
}
