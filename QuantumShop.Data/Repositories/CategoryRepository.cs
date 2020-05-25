using QuantumShop.Data.Data;
using QuantumShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumShop.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository 
    {
        private ApplicationDbContext _con;

        public CategoryRepository(ApplicationDbContext con)
        {
            _con = con;
        }

        public Category GetCategory(int Id)
        {
            return _con.Categories.Find(Id);
        }

        public Category AddCategory(Category cat)
        {
            _con.Categories.Add(cat);
            _con.SaveChanges();
            return cat;
        }

        public Category ClearCategory(Category cat)
        {
            _con.Categories.Remove(cat);
            _con.SaveChanges();
            return cat;

        }
    }
}
