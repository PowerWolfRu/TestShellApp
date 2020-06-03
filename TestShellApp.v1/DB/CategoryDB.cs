using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    public class CategoryDB
    {
        List<Category> categories = new List<Category>();
        int AutoIncrement = 1;

        public List<Category> allCategories { get => categories; }

        DataContractJsonSerializer json =
            new DataContractJsonSerializer(typeof(List<Category>));

        public static CategoryDB instance;

        public static CategoryDB GetInstance()
        {
            if (instance == null)
                instance = new CategoryDB();
            return instance;
        }
        public void SaveCategories()
        {
            using (FileStream fs = new FileStream("category.json", FileMode.Create, FileAccess.Write))
            {
                fs.Write(BitConverter.GetBytes(AutoIncrement), 0, 4);
                json.WriteObject(fs, categories);
            }
        }

        public CategoryDB()
        {
            if (!File.Exists("category.json"))
                return;
            using (FileStream fs = new FileStream("category.json", FileMode.Open, FileAccess.Read))
            {
                byte[] temp = new byte[4];
                fs.Read(temp, 0, 4);
                AutoIncrement = BitConverter.ToInt32(temp, 0);
                categories = (List<Category>)json.ReadObject(fs);
            }
        }

        public Category GetCategoryByID(int id) => categories[id];

        public List<Category> GetCategories()
        {
            return categories.Select(s => s)?.ToList();
        }

        public Category AddCategory()
        {
            var cat = new Category { ID = AutoIncrement++ };
            categories.Add(cat);
            return cat;
        }

        public void RemoveCategory(Category category)
        {
            categories.Remove(category);
        }
    }
}
