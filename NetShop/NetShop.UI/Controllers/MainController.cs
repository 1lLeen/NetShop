using Microsoft.AspNetCore.Mvc;
using NetShop.Application.Servicese.Interfaces;

namespace NetShop.UI.Controllers
{
    public class MainController : Controller
    {
        protected readonly IProductService productService;
        protected readonly ICategoryService categoryService;
        private ILogger logger;
        public MainController(IProductService productService, ICategoryService categoryService, ILogger logger)
        {
            this.productService = productService;
            this.categoryService = categoryService;
            this.logger = logger;
        }
        public ActionResult Index()
        {
            return View(productService.GetAll());
        }

    }
}
