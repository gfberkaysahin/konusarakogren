using AutoMapper;
using EntityLayer.Services;
using KonusarakOgrenUILayer.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KonusarakOgrenUILayer.Controllers;

[Authorize(Roles = "sysadmin")]
public class SysAdminController: Controller
{
    private readonly ILogger<SysAdminController> _logger;
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;
    private readonly IBrandService _brandService;
    private readonly IMapper _mapper;

    public SysAdminController(ILogger<SysAdminController> logger, IProductService productService, ICategoryService categoryService, IBrandService brandService, IMapper mapper)
    {
        _logger = logger;
        _productService = productService;
        _categoryService = categoryService;
        _brandService = brandService;
        _mapper = mapper;
    }

    public IActionResult Index()
    {
        return View();
    }
    
    public async Task<IActionResult> ProductList()
    {
        List<ProductListDTO> productList = new List<ProductListDTO>();
        var products = await _productService.GetAllProducts();
        foreach (var item in products)
        {
            var category = await _categoryService.GetCategoryById(item.CategoryId);
            var brand = await _brandService.GetBrandById(item.BrandId);
            var productListItem =new  ProductListDTO()
            {
                ID = item.Id,
                Description = item.Description,
                Color = item.Color,
                Size = item.Size,
                BrandName = brand.Name,
                CategoryName = category.Name,
                CreatedDate = item.CreatedDate,
                DiscountPercante = item.DiscountPercante,
                Name = item.Name,
                Price = item.Price
            };
            productList.Add(productListItem);
        }
        return View(productList);
    }
}