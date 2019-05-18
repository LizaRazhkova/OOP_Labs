using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAST9.Repository
{
    interface BaseRepos <T> where T:class
    {
        T Save(T obj);
    }
}
