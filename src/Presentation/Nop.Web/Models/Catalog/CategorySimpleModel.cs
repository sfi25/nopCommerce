﻿using System.Collections.Generic;
using System.Linq;
using Nop.Web.Framework.Mvc;

namespace Nop.Web.Models.Catalog
{
    public class CategorySimpleModel : BaseNopEntityModel
    {
        public CategorySimpleModel()
        {
            SubCategories = new List<CategorySimpleModel>();
        }

        public string Name { get; set; }

        public string SeName { get; set; }

        public int? NumberOfProducts { get; set; }

        public bool IncludeInTopMenu { get; set; }

        public List<CategorySimpleModel> SubCategories { get; set; }

        public int SubCategoryDepth => SubCategories.Any() ? 1 + SubCategories.Max(m => m.SubCategoryDepth) : 0;
    }
}