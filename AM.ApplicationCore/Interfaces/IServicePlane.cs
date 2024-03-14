using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServicePlane
    {

        void Add(Plane plane);
        public void Save();
        IList<Plane> GetAll();
    }
}
