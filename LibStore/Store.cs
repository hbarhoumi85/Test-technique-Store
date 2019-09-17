using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace LibStore
{
    class Store:IStore
    {
        public List<Category> Category { get; set; }
        public List<Catalog> Catalog { get; set; }

        public void Import(string catalogAsJson)
        {
            var result = JsonConvert.DeserializeObject<Store>(catalogAsJson);
            this.Category = result.Category;
            this.Catalog = result.Catalog;
        }

        public int Quantity(string name)
        {
            var query = from ctg in Catalog
                        where ctg.Name.Equals(name)
                        select ctg.Quantity;
            return query.FirstOrDefault();
        }

        public string GetCategoryByBookName(string name)
        {
            var query = from ctg in Catalog
                        where ctg.Name.Equals(name)
                        select ctg.Category;
            return query.FirstOrDefault();
        }

        public double Buy(params string[] booksByNames)
        {
            Dictionary<string, string> booksByCategory = new Dictionary<string, string>();

            foreach (var name in booksByNames)
            {
                string categoryName = GetCategoryByBookName(name);
                if (!booksByCategory.ContainsKey(categoryName))
                {
                    booksByCategory[categoryName] = name;
                }
            }
            throw new NotImplementedException();
        }
    }
}
