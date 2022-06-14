using System.Collections.Generic;

namespace BootcampProje.Web.Models.Request.HotelProduct
{
    public class PriceSearchRequest
    {
        
        public class ArrivalLocation
        {
            public string id { get; set; }
            public int type { get; set; }
        }

        public class RoomCriterion
        {
            public int adult { get; set; }
            public List<int> childAges { get; set; }
        }

        public class Root
        {
            public bool checkAllotment { get; set; }
            public bool checkStopSale { get; set; }
            public bool getOnlyDiscountedPrice { get; set; }
            public bool getOnlyBestOffers { get; set; }
            public int productType { get; set; }
            public List<ArrivalLocation> arrivalLocations { get; set; }
            public List<RoomCriterion> roomCriteria { get; set; }
            public string nationality { get; set; }
            public string checkIn { get; set; }
            public int night { get; set; }
            public string currency { get; set; }
            public string culture { get; set; }
        }


    }
}
