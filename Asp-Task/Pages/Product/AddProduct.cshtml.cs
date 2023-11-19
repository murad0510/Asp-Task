using Asp_Task.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Asp_Task.Pages.Product
{
    public class AddProductModel : PageModel
    {
        private readonly IProductService _productService;

        public AddProductModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public Entities.Product Product { get; set; }
        public void OnGet()
        {
            Product = new Entities.Product();
        }

        public IActionResult OnPost()
        {
            _productService.AddProduct(Product);

            return RedirectToPage("Index");
        }
    }
}
