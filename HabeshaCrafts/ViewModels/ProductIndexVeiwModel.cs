using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HabeshaCrafts.Models;

namespace HabeshaCrafts.ViewModels
{
    public class ProductIndexVeiwModel
    {
        public IQueryable<Product> Products { get; set; }
        public string Search { get; set; }
        public IEnumerable<CategoryWithCount> CategoryWithCounts { get; set; }
        public string Category { get; set; }

        public IEnumerable<SelectListItem> CategoryFilterItems
        {
            get
            {
                var allCategories = CategoryWithCounts.Select(c => new SelectListItem
                {
                    Value = c.CategoryName,
                    Text = c.CategoryNameWithCount
                });

                return allCategories;
            }
        }
    }

    public class CategoryWithCount
    {
        public int ProductCount { get; set; }
        public string CategoryName { get; set; }
        public string CategoryNameWithCount => CategoryName + "(" + ProductCount + ")";
    }
}