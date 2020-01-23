using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.AdminPanel.Web.Addresses
{
    public class Countries
    {
        public Countries()
        {
            Governorates = new HashSet<Governorates>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Governorates> Governorates { get; set; }
    }
}
