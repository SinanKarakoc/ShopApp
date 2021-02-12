using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shoppapp.webui.Data;
using shoppapp.webui.Models;

namespace shoppapp.webui.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(){    
            if(RouteData.Values["action"].ToString()=="ProductList") 
                ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);
        }
    }
}