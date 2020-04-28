using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagment.BO.Interface
{
    interface IBaseCrud<T>
    {
        //add ose insert qe kthen bool, int, void, T

        int Add(T model);
        int Modify(T model);
        int Remove(int id);
        int Remove(T model);
        T Get(int id);
        T Get(T model);
        List<T> GetAll();
    }
}
