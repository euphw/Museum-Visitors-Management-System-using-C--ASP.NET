using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Models
{
    public class Museum
    {
        public string Code { get; }
        public string Title { get; }
        public double Price { get; set; }

        public Museum(string code, string title)
        {
            Code = code;
            Title = title;
        }
    }
}