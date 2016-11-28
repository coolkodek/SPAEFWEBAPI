using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataModel.GenericRepository;

namespace BusinessEntities
{
    class CustomerServices
    {
        private readonly UnitOfWork _unitOfWork;
       
        public CustomerServices()
        {
            _unitOfWork = new UnitOfWork();
        }
    }
}
