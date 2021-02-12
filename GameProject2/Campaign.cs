using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public int Discount { get; set; } //indirim % olarak
        public string Description { get; set; }
    }
}
