using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Models
{
    public class Visitor
    {

        public string Id { get; }
        public string Name { get; }
        public List<Museum> RegisteredMuseums { get; }

        protected Visitor(string name)
        {
            Name = name;
            
            Random generator = new Random();
            string id = generator.Next(0, 9999).ToString("D4");
            Id = id;
            RegisteredMuseums = new List<Museum>();
            
        }
        public virtual void RegisterMuseums(List<Museum> selectedMuseums)
        {
            RegisteredMuseums.Clear();
            foreach (Museum museum in selectedMuseums)
            {
                RegisteredMuseums.Add(museum);
            }

        }

        //public int totalHours { get; set; }
        public int TotalPrice() 
        {
            int totalPrice = 0;
            foreach (Museum museum in RegisteredMuseums)
            {

                totalPrice += Convert.ToInt32(museum.Price);
            }
            return totalPrice;
        }
    }
}