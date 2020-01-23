using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.AdminPanel.Web.Addresses
{
    public class Governorates
    {
        public Governorates()
        {
            Districts = new HashSet<Districts>();
        }
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public Countries Countries { get; set; }
        public ICollection<Districts> Districts { get; set; }
    }
}
