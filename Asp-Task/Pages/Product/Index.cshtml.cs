using Asp_Task.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Asp_Task.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public List<Entities.Product> Products { get; set; }
        public void OnGet(string info = "")
        {
            Products = _productService.GetAllProductByKey();
        }

        public string Info { get; set; }

        public IActionResult ProductDelete(Entities.Product product)
        {
            _productService.DeleteProduct(product);

            return RedirectToPage("Index");
        }
    }
}
