using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAJAXMVC5.Models
{

    /// <summary>
    /// Описание модели Book
    /// </summary>
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
}