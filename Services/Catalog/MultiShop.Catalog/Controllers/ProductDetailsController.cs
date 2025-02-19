using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Services.ProductDetailServices;

namespace MultiShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly IProductDetailServices _productDetailServices;
        public ProductDetailsController(IProductDetailServices categoryServices)
        {
            _productDetailServices = categoryServices;
        }
        [HttpGet]
        public async Task<IActionResult> ProductDetailList()
        {
            var values = await _productDetailServices.GetAllProductDetailAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductDetailById(string id)
        {
            var values = await _productDetailServices.GetByIdProductDetailAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductDetail(CreateProductDetailDto createProductDetailDto)
        {
            await _productDetailServices.CreateProductDetailAsync(createProductDetailDto);
            return Ok("Ürün detayı Başarıyla Eklenmiştir.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProductDetail(string id)
        {
            await _productDetailServices.DeleteProductDetailAsync(id);
            return Ok($"{id}'ye sahip ürün detayı başarıyla silinmiştir.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductDetail(UpdateProductDetailDto updateProductDetailDto)
        {
            await _productDetailServices.UpdateProductDetailAsync(updateProductDetailDto);
            return Ok($"{updateProductDetailDto.ProductDetailId}'ye sahip ürün detaylarının güncelleme işlemi tamamlandı.");
        }
    }
}
