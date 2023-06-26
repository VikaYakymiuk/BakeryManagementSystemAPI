using BakeryManagementSystemBLL.Contracts;
using BakeryManagementSystemBLL.DTOs.RequestDTOs.CustomersDTOs;
using BakeryManagementSystemBLL.DTOs.ResponseDTOs.CustomersDTOs;
using Microsoft.AspNetCore.Mvc;

namespace BakeryManagementSystemAPI.Controllers
{
    [ApiController]
    [Route("api/Customers")]
    public class CustomerController : Controller
    {
        private readonly ICustomersService _customersService;

        public CustomerController(ICustomersService customersService)
        {
            _customersService = customersService;
        }

        [HttpGet("Return-Customers-Async")]
        public async Task<ActionResult<IEnumerable<GetCustomersDTO>>> ReturnCustomersDTOAsync()
        {
            try
            {
                var result = await _customersService.ReturnEntitiesAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("Return-Customers-By-Id-Async")]
        public async Task<ActionResult<GetCustomersDTO>> ReturnCustomersDTOByIdAsync(Guid Id)
        {
            try
            {
                var result = await _customersService.ReturnEntityByIdAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("Add-Customer-to-Table-Async")]
        public async Task<ActionResult<GetCustomersDTO>> InsertCustomerDTOAsync(InsertCustomersDTO insertCustomersDTO)
        {
            try
            {
                var result = await _customersService.InsertCustomerAsync(insertCustomersDTO);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("Update-Customer-By-Id-Async")]
        public async Task<ActionResult<GetCustomersDTO>> UpdateCustomersByIdAsync(UpdateCustomersDTO updateCustomersDTO, [FromForm] Guid Id)
        {
            try
            {
                var result = await _customersService.UpdateCustomerById(updateCustomersDTO, Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("Delete-Customer-By-Id-Async")]
        public async Task<ActionResult<IEnumerable<GetCustomersDTO>>> DeleteCustomersByIdAsync([FromForm] Guid Id)
        {
            try
            {
                var result = await _customersService.DeleteCustomerByIdAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
