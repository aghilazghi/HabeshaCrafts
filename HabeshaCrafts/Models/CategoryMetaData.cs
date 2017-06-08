﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HabeshaCrafts.Models
{

        [MetadataType(typeof(CategoryMetaData))]
        public partial class Category
        {
            
        }

        public class CategoryMetaData
        {
            [Display(Name = "Category Name")]
            public string Name { get; set; }
        }
    
}