using BakeryManagementSystemBLL.Contracts;
using BakeryManagementSystemBLL.DTOs.ResponseDTOs.CustomersDTOs;
using BakeryManagementSystemBLL.DTOs.ResponseDTOs.DistributorsDTOs;
using BakeryManagementSystemBLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace BakeryManagementSystemAPI.Controllers
{
    [ApiController]
    [Route("api/Distributors")]
    public class DistributorsController : Controller
    {
        private readonly IDistriburorsService _distriburorsService;

        public DistributorsController(IDistriburorsService distriburorsService)
        {
            _distriburorsService = distriburorsService;
        }

        [HttpGet("Return-Distributors-Async")]
        public async Task<ActionResult<IEnumerable<GetDistributorsDTO>>> ReturnDistributorsDTOAsync()
        {
            try
            {
                var distributors = await _distriburorsService.ReturnDistributorsAsync();
                return Ok(distributors);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong... {ex.Message}");
            }
        }

        [HttpGet("Return-Distributors-Countris-Title-Async")]
        public async Task<ActionResult<IEnumerable<GetDistributorsDTO>>> ReturnDistributorsDTOByCountrisTitleAsync(string title)
        {
            try
            {
                var distributors = await _distriburorsService.ReturnsDistributorsByCoutrisTitle(title);
                return Ok(distributors);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong... {ex.Message}");
            }
        }
    }
}
