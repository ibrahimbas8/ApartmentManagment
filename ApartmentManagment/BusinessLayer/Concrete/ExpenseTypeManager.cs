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
    public class ExpenseTypeManager : IExpenseTypeService
    {
        IExpenseTypeDal _expenseTypeDal;

        public ExpenseTypeManager(IExpenseTypeDal expenseTypeDal)
        {
            _expenseTypeDal = expenseTypeDal;
        }

        public List<ExpenseType> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(ExpenseType t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ExpenseType t)
        {
            throw new NotImplementedException();
        }

        public ExpenseType TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ExpenseType t)
        {
            throw new NotImplementedException();
        }
    }
}
