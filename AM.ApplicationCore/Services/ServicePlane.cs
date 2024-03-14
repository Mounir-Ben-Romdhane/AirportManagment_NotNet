using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServicePlane : IServicePlane
    {
        private IGenericRepository<Plane> _genericRepository;
        private IUnitOfWork _unitOfWork;

        //GenericRepo
        //public ServicePlane(IGenericRepository<Plane> genericRepository)
        //{
        //    this._genericRepository = genericRepository;
        //}

        //IUintOfWork
        public ServicePlane(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        
    }
}
