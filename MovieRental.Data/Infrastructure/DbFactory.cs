using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        MovieRentalContext dbContext;

        public MovieRentalContext Init()
        {
            return dbContext ?? (dbContext = new MovieRentalContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
