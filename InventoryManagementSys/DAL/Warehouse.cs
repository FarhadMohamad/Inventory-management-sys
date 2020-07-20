using System;
using System.Collections.Generic;

namespace InventoryManagementSys.DAL
{
    public partial class Warehouse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int? Cvr { get; set; }
        public int? PhoneNumber { get; set; }
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public int? PostCode { get; set; }
        public string City { get; set; }

        public virtual AspNetUsers IdNavigation { get; set; }
    }
}
