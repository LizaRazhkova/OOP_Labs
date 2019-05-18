using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAST9.Repository
{
    class UsersLogRepos : BaseRepos<USERS_LOG>
    {
        public MyBase _UsersLogContext { get; set; }
        public List<USERS_LOG> ListOfLog { get; set; }
        public UsersLogRepos(MyBase context)
        {
            _UsersLogContext = context;
        }

        public USERS_LOG Save(USERS_LOG userLog)
        {

            _UsersLogContext.USERS_LOG.Add(userLog);
            _UsersLogContext.SaveChanges();
            return userLog;
        }
    }
}
