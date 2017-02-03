using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Domain.Extensions
{
    public static class DbContextExtensions
    {
        public static bool IsAttached<T>(this DbContext context, ref T entity) where T : class
        {
            var objectContext = ((IObjectContextAdapter)context).ObjectContext;

            ObjectStateEntry entry;
            // Check to see if the entity is attached
            if (objectContext.ObjectStateManager.TryGetObjectStateEntry(entity, out entry))
            {
                // Cast the attached entity to the correct type
                entity = (T)entry.Entity;
                return true;
            }

            return false;
        }
    }
}
