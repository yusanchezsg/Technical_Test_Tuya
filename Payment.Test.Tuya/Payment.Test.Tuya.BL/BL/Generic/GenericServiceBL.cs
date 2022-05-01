using Payment.Test.Tuya.BL.Interfaces;
using Payment.Test.Tuya.DAL.Interfaces;
using System.Collections.Generic;

namespace Payment.Test.Tuya.BL.Generic
{
    public class GenericServiceBL<Model> : IGenericServiceBL<Model> where Model : class
    {
        private readonly IUnitOfWork<Model> _unitOfWork;

        protected GenericServiceBL(IUnitOfWork<Model> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Model Create(Model entity)
        {
            _unitOfWork.Save();
            return entity;
        }

        public Model Get(int Id)
        {
            return _unitOfWork.GenericRepositoryDAL.Get(Id);
        }

        public List<Model> Get()
        {
            return _unitOfWork.GenericRepositoryDAL.Get();
        }

        public void Remove(Model entity)
        {
            _unitOfWork.GenericRepositoryDAL.Remove(entity);
        }

        public void Update(Model entity)
        {
            _unitOfWork.GenericRepositoryDAL.Update(entity);
            _unitOfWork.Save();
        }
    }
}
