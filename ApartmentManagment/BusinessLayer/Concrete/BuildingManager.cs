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
    public class BuildingManager : IBuildingService
    {
        IBuildingDal _buildingDal;

        public BuildingManager(IBuildingDal buildingDal)
        {
            _buildingDal = buildingDal;
        }

        public List<Building> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Building t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Building t)
        {
            throw new NotImplementedException();
        }

        public Building TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Building t)
        {
            throw new NotImplementedException();
        }
    }
}
