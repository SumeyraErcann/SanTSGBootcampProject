using System.Collections.Generic;

namespace BootcampProje.Web.Models.Request.HotelProduct
{
    public class PriceSearchRequestt
    {
        
        public class RoomCriterion
        {
            public int adult { get; set; }
        }

        public class Root
        {
            public bool checkAllotment { get; set; }
            public bool checkStopSale { get; set; }
            public bool getOnlyDiscountedPrice { get; set; }
            public bool getOnlyBestOffers { get; set; }
            public int productType { get; set; }
            public List<string> Products { get; set; }
            public List<RoomCriterion> roomCriteria { get; set; }
            public string nationality { get; set; }
            public string checkIn { get; set; }
            public int night { get; set; }
            public string currency { get; set; }
            public string culture { get; set; }
        }


    }

}
