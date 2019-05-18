using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAST9.Repository
{
    class UnitOfWork : IDisposable
    {
        private MyBase db = new MyBase();
        private UsersInfoRepos _usersInfoRepos;
        private UsersLogRepos _usersLogRepos;
        public UsersInfoRepos _UsersInfoUnits
        {
            get
            {
                if (_usersInfoRepos == null)
                    _usersInfoRepos = new UsersInfoRepos(db);
                return _usersInfoRepos;
            }
        }
        public UsersLogRepos _UsersLogUnits
        {
            get
            {
                if (_usersLogRepos == null)
                    _usersLogRepos = new UsersLogRepos(db);
                return _usersLogRepos;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                db.Dispose();
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
