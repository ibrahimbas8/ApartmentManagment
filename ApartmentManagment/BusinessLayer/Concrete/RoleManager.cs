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
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public List<Role> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Role t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Role t)
        {
            throw new NotImplementedException();
        }

        public Role TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Role t)
        {
            throw new NotImplementedException();
        }
    }
}
