using BussinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Model.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace N_Katmanlı_Mimari.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public ViewResult Index()
        {
            return View();
        }


        public ViewResult GetAll()
        {
            var result = productService.GetAll();
            return View(result);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            productService.Add(product);
            return RedirectToAction("GetAll");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var product = productService.GetById(id); // ID'ye göre ürünü alın
            if (product != null)
            {
                productService.Delete(product);
                return Ok(); // Başarılı silme için HTTP 200 döndür
            }
            return NotFound(); // Ürün bulunamazsa HTTP 404 döndür
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = productService.GetById(id); // ID'ye göre ürünü al
            if (product == null)
            {
                return NotFound(); // Ürün bulunamazsa HTTP 404 döndür
            }

            // Modeli `Edit` tipine dönüştürün
            var editModel = new LoginModel
            {
                CategoryId = product.CategoryId,
                ProductId = product.ProductId,   // ProductId burada set ediliyor ve formda hidden olarak gönderilecek.
                ProductName = product.ProductName,
                UnitsInStock = product.UnitsInStock,
                UnitPrice = product.UnitPrice
            };

            return View(editModel); // Ürün bilgilerini view'a gönder
        }

        [HttpPost]
        public IActionResult Edit(LoginModel edit)
        {
            if (ModelState.IsValid)
            {
                var state = productService.GetById(edit.ProductId);

                if (state == null)
                {
                    return NotFound(); // Ürün bulunamazsa 404 döndür
                }

                // Ürün bilgilerini güncelle
                state.CategoryId = edit.CategoryId;
                state.ProductName = edit.ProductName;
                state.UnitPrice = edit.UnitPrice;
                state.UnitsInStock = edit.UnitsInStock;

                // Veritabanına güncellenmiş ürünü kaydet
                productService.Update(state);

                return RedirectToAction("GetAll"); // "GetAll" action'ına yönlendir
            }

            // Eğer model doğrulaması geçerli değilse, aynı view'ı tekrar göster
            return View(edit);
        }



    }
}