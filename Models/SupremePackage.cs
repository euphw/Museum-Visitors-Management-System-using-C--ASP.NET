
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Models
{
    public class SupremePackage : Visitor
    {
        public static int MaxNumOfMuseums { get; set; }

        public SupremePackage(string name)
            : base(name)
        {

        }

        public override void RegisterMuseums(List<Museum> selectedMuseums)
        {

            base.RegisterMuseums(selectedMuseums);

            if (selectedMuseums.Count > MaxNumOfMuseums)
            {
                throw new Exception(String.Format("Your selection exceeds the maximum number of museums: {0}", Convert.ToString(MaxNumOfMuseums)));

            }
            else
            {
                base.RegisterMuseums(selectedMuseums);
            }

        }

        public override string ToString()
        {
            return base.Id + " - " + base.Name + " (Supreme Package)";
        }


    }
}