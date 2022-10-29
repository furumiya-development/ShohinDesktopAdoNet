using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShohinDesktopAdoNet.Models.DomainObjects
{
    public abstract class Entity<T>
    {
        public abstract bool Equals(T other);

        protected void IsNull(object? value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "nullです。");
            }
        }
    }
}