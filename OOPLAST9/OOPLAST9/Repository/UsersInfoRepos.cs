using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAST9.Repository
{
    class UsersInfoRepos : BaseRepos<USERS_INFO>
    {
        public MyBase _UsersInfoContext { get; set; }
        public List<USERS_INFO> ListOfInfo  { get; set; }
        public UsersInfoRepos(MyBase context)
        {
            _UsersInfoContext = context;
        }
        public USERS_INFO Save(USERS_INFO userInfo)
        {
            _UsersInfoContext.USERS_INFO.Add(userInfo);
            _UsersInfoContext.SaveChanges();
            return userInfo;
        }
    }
}
