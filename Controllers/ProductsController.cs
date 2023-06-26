using BakeryManagementSystemBLL.Contracts;
using BakeryManagementSystemBLL.DTOs.ResponseDTOs.ProductsDTOs;
using BakeryManagementSystemBLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace BakeryManagementSystemAPI.Controllers
{
    [ApiController]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet("Return-Products-Async")]
        public async Task<ActionResult<IEnumerable<GetProductsDTO>>> ReturnProductsDTOAsync()
        {
            try
            {
                var products = await _productsService.ReturnProductsAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong... {ex.Message}");
            }
        }
    }
}
