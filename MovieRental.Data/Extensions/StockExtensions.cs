using MovieRental.Data.Repositories;
using MovieRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Data.Extensions
{
    public static class StockExtensions
    {
        public static IEnumerable<Stock> GetAvailableItems(this IEntityBaseRepository<Stock> stockRepository, int id)
        {
            return stockRepository.FindBy(s => s.MovieId == id);
        }
    }
}
