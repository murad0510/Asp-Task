using Asp_Task.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Asp_Task.Pages.Product
{
    public class DeleteProductModel : PageModel
    {
        private readonly IProductService _productService;

        public DeleteProductModel(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult OnGet(int productId)
        {
            var product = _productService.GetAllProductByKey().Where(c => c.Id == productId).FirstOrDefault();

            //_productService.DeleteProduct(product);

            _productService.DeleteProduct(product);

            return RedirectToPage("Index");
        }
    }
}
