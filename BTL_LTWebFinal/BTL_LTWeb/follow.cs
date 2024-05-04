using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_LTWeb
{
    public class follow : Video
    {
        public int quantity { get; set; }
        public follow(string id, string name, string images, int quantity)
        {
            this.Id = id;
            this.Name = name;
            this.images = images;
            this.quantity = quantity;
        }
    }
}