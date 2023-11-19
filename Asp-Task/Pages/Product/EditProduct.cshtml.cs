using Asp_Task.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Asp_Task.Pages.Product
{
    public class EditProductModel : PageModel
    {
        private readonly IProductService _productService;

        public EditProductModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public Entities.Product Product { get; set; }
        public void OnGet(int productId)
        {
            var product = _productService.GetAllProductByKey().Where(s => s.Id == productId).FirstOrDefault();

            Product = product;
        }

        public IActionResult OnPost()
        {
            _productService.UpdateProduct(Product);
            return RedirectToPage("Index");
        }
    }
}
