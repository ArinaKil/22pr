using Microsoft.AspNetCore.Mvc;
using Shop_Kilunina.Data.Interfaces;
using Shop_Kilunina.Data.Models;
using Shop_Kilunina.Data.ViewModell;
using System.Linq;

namespace Shop_Kilunina.Controllers
{
    public class ItemsController : Controller
    {
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment;

        private IItems IAllItems;
        private ICategorys IAllCategorys;
        VMItems VMItems = new VMItems();

        public ItemsController(IItems IAllItems, ICategorys IAllCategorys, Microsoft.AspNetCore.Hosting.IHostingEnvironment environment)
        {
            this.IAllItems = IAllItems;
            this.IAllCategorys = IAllCategorys;
            this.hostingEnvironment = environment;
        }

        public ViewResult List(int id = 0)
        {
            ViewBag.Title = "Страница с предметами";
            VMItems.Items = IAllItems.AllItems;
            VMItems.Categories = IAllCategorys.AllCategorys;
            VMItems.SelectCategory = id;
            return View(VMItems);
        }

        [HttpGet]
        public ViewResult Add()
        {
            IEnumerable<Categories> Categorys = IAllCategorys.AllCategorys;
            return View(Categorys);
        }

        [HttpPost]
        public RedirectResult Add(string name, string description, IFormFile files, float price, int idCategory)
        {
            if (files != null)
            {
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "img");
                var filePath = Path.Combine(uploads, files.FileName);
                files.CopyTo(new FileStream(filePath, FileMode.Create));
            }
            Items newItems = new Items();
            newItems.Name = name;
            newItems.Description = description;
            newItems.Img = files.FileName;
            newItems.Price = Convert.ToInt32(price);
            newItems.Category = new Categories() { Id = idCategory };
            int id = IAllItems.Add(newItems);
            return Redirect("/Items/Update?id=" + id);
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            VMUpdate VMUpdate = new VMUpdate();
            VMUpdate.Item = IAllItems.AllItems.Where(x => x.Id == id).First();
            VMUpdate.Categories = IAllCategorys.AllCategorys;
            return View(VMUpdate);
        }

        [HttpPost]
        public RedirectResult Update(int id, string name, string description, IFormFile files, float price, int idCategory)
        {
            Items updItem = IAllItems.AllItems.Where(x => x.Id == id).First();
            updItem.Name = name;
            updItem.Description = description;
            updItem.Price = Convert.ToInt32(price);
            updItem.Category = new Categories() { Id = idCategory };
            if (files != null)
            {
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "img");
                var filePath = Path.Combine(uploads, files.FileName);
                files.CopyTo(new FileStream(filePath, FileMode.Create));
                updItem.Img = files.FileName;
            }
            IAllItems.Update(updItem);
            return Redirect("/Items/List");
        }

        public RedirectResult Delete(int id)
        {
            IAllItems.Delete(id);
            return Redirect("/Items/List");
        }

        public ActionResult Basket(int idItem = -1)
        {
            if (idItem != -1)
            {
                Startup.BasketItem.Add(new ItemsBasket(1, IAllItems.AllItems.Where(x => x.Id == idItem).First()));
            }
            return Json(Startup.BasketItem);
        }

        public ActionResult BasketCount(int idItem = -1, int count = 0)
        {
            if (idItem != -1)
            {
                if (count == 0)
                {
                    Startup.BasketItem.RemoveAll(x => x.Id == idItem);
                }
                else
                {
                    Startup.BasketItem.Where(x => x.Id == idItem).First().Count = count;
                }
            }
            return Json(Startup.BasketItem);
        }
    }
}
