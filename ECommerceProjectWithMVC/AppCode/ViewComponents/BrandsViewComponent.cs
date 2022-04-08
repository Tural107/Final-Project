using ECommerceProjectWithMVC.Models.DataContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC.AppCode.ViewComponents
{
    public class BrandsViewComponent:ViewComponent
    {
        readonly ShopDbContext db;
        public BrandsViewComponent(ShopDbContext db)
        {
            this.db = db;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {


            var result = await db.Brands
                .Where(b => b.DeletedTime == null)
                .ToListAsync();



            return View(result);
        }
    }
}
