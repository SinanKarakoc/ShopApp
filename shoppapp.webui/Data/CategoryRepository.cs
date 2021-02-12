using System.Collections.Generic;
using System.Linq;
using shoppapp.webui.Models;

namespace shoppapp.webui.Data
{
    public class CategoryRepository
    {
        private static List<CategoryEntity> _categoryList = null;

        static CategoryRepository(){
            //constructor
            _categoryList= new List<CategoryEntity>{
                new CategoryEntity{CategoryId=1,Name="Laptop",Description="Laptop Kataloğu"},
                new CategoryEntity{CategoryId=2,Name="Tablet",Description="Tablet Kataloğu"},
                new CategoryEntity{CategoryId=3,Name="Telefon",Description="Telefon Kataloğu"}
            };
        }

        public static List<CategoryEntity> Categories{
            get{
                return _categoryList;
            }
        }
        public static void AddCategory(CategoryEntity category){
            _categoryList.Add(category);
        }
        public static CategoryEntity GetCategoryById(int id){
            return _categoryList.FirstOrDefault(c => c.CategoryId == id);
        }
    }
}