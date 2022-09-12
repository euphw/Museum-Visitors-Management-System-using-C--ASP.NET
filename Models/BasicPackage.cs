using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Models
{
    public class BasicPackage : Visitor
    {
        public static int MaxTotalPrice { get; set; }

        public static int MaxNumOfMuseums { get; set; }

        public BasicPackage(string name)
            : base(name)
        {

        }
        public override void RegisterMuseums(List<Museum> selectedMuseums)
        {

            base.RegisterMuseums(selectedMuseums);
            if (selectedMuseums.Count > MaxNumOfMuseums)
            {
                throw new Exception(String.Format("Your selection exceeds the maximum number of Museums: {0}", Convert.ToString(MaxNumOfMuseums)));

            }
            else if (base.TotalPrice() > MaxTotalPrice)
            {
                throw new Exception(String.Format("Your selection exceeds the maximum total price: {0}", String.Format("{0:C}", MaxTotalPrice)));
            }
            else
            {
                base.RegisterMuseums(selectedMuseums);
            }

        }

        public override string ToString()
        { 
            return Id+" - "+Name+ " (Basic Package)";
        }


    }
}