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
    public class FlatManager : IFlatService
    {
        IFlatDal _flatDal;

        public FlatManager(IFlatDal flatDal)
        {
            _flatDal = flatDal;
        }

        public List<Flat> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Flat t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Flat t)
        {
            throw new NotImplementedException();
        }

        public Flat TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Flat t)
        {
            throw new NotImplementedException();
        }
    }
}
