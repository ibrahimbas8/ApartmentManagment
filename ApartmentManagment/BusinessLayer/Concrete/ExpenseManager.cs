using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExpenseManager : IExpenseService
    {
        IExpenseDal _expenseDal;

        public ExpenseManager(IExpenseDal expenseDal)
        {
            _expenseDal = expenseDal;
        }

        public List<Expense> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Expense t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Expense t)
        {
            throw new NotImplementedException();
        }

        public Expense TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Expense t)
        {
            throw new NotImplementedException();
        }
    }
}
