﻿using EFLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public DateTime Year { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public List<Category> Categories { get; set; }
    }
}
