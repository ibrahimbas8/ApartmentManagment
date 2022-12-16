using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Flat
    {
        public int Id { get; set; }
        public byte FlatNumber { get; set; }
        public bool IsEmpty { get; set; }
        public string TypeOfFlat { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public int BuildingId { get; set; }
        public Building Building { get; set; }

        public List<Expense> Expenses { get; set; }
    }
}
