using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Helper
/// </summary>
namespace Final_Project.Models
{
    public class Helper
    {
        public static List<Museum> GetAvailableMuseums()
        {
            List<Museum> museums = new List<Museum>();

            Museum museum = new Museum("01", "Bank of Canada Museum");
            museum.Price = 7.2;
            museums.Add(museum);

            museum = new Museum("02", "Canadian Museum of History");
            museum.Price = 15.3;
            museums.Add(museum);

            museum = new Museum("03", "Canada Science and Technology Museum");
            museum.Price = 8.7;
            museums.Add(museum);

            museum = new Museum("04", "Canadian War Museum");
            museum.Price = 11.2;
            museums.Add(museum);

            museum = new Museum("05", "Canadian Museum of Nature");
            museum.Price = 9.8;
            museums.Add(museum);

            museum = new Museum("06", "National Gallery of Canada");
            museum.Price = 14.7;
            museums.Add(museum);

            return museums;
        }


        public static Museum GetMuseumByCode(string code)
        {
            foreach (Museum m in GetAvailableMuseums())
            {
                if (m.Code == code)
                {
                    return m;
                }
            }
            return null;
        }
    }
}