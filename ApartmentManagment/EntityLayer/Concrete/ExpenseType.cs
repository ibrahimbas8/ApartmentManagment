using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ExpenseType
    {
        public int Id { get; set; }

        public string ExpenseTypeName { get; set; }

        public List<Expense> Expenses { get; set; }
    }
}
