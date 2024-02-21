using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.UnitOfWork;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace DesignPattern.BusinessLayer.Concrete
{
    public class ProcessManager : IProcessService
    {
        private readonly IProcessDal _processDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public ProcessManager(IProcessDal processDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _processDal = processDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public void TDelete(Process t)
        {
            throw new NotImplementedException();
        }

        public Process TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Process> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Process t)
        {
            throw new NotImplementedException();
        }

        public void tMultiUpdate(List<Process> t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Process t)
        {
            throw new NotImplementedException();
        }
    }
}
