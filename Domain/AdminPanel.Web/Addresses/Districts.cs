using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.AdminPanel.Web.Addresses
{
    public class Districts
    {
        public int Id { get; set; }
        public int GovernorateId { get; set; }
        public string Name { get; set; }
        public Governorates Governorates { get; set; }
    }
}
