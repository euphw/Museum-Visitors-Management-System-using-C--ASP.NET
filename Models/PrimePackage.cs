using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Models
{
    public class PrimePackage : Visitor
    {
        public static int MaxNumOfMuseums { get; set; }

        public PrimePackage(string name)
            : base(name)
        {

        }

        public override void RegisterMuseums(List<Museum> selectedMuseums)
        {
            base.RegisterMuseums(selectedMuseums);
            if (selectedMuseums.Count > MaxNumOfMuseums)
            {
                throw new Exception(String.Format("Your selection exceeds the maximum number of muesums: {0}", Convert.ToString(MaxNumOfMuseums)));
            }
            else
            {
                base.RegisterMuseums(selectedMuseums);
            }
        }
        public override string ToString()
        {
            return Id + " - " + Name + " (Prime Package)";
        }


    }
}