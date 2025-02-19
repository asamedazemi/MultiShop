using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.ProductImageDtos;
using MultiShop.Catalog.Services.ProductImageServices;

namespace MultiShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly IProductImageServices _pServices;
        public ProductImagesController(IProductImageServices pServices)
        {
            _pServices = pServices;
        }
        [HttpGet]
        public async Task<IActionResult> ProductImageList()
        {
            var values = await _pServices.GetAllProductImageAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductImageById(string id)
        {
            var values = await _pServices.GetByIdProductImageAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductImage(CreateProductImageDto createProductImageDto)
        {
            await _pServices.CreateProductImageAsync(createProductImageDto);
            return Ok("Ürün resmi Başarıyla Eklenmiştir.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProductImage(string id)
        {
            await _pServices.DeleteProductImageAsync(id);
            return Ok($"{id}'ye sahip ürün resmi başarıyla silinmiştir.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductImage(UpdateProductImageDto updateProductImageDto)
        {
            await _pServices.UpdateProductImageAsync(updateProductImageDto);
            return Ok($"{updateProductImageDto.ProductImageId}'ye sahip ürün resminin güncelleme işlemi tamamlandı.");
        }
    }
}
