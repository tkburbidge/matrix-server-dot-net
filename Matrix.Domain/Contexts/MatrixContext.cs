using Matrix.Common;
using Matrix.Domain.Models.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Domain.Contexts
{
    public class MatrixContext : DbContext, IUnitOfWork
    {
        #region DbSets

        public DbSet<User> Users { get; set; }

        #endregion

        public MatrixContext()
            :base("DefaultConnection")
        {

        }

        public void Commit()
        {
            base.SaveChanges();
        }
    }
}
