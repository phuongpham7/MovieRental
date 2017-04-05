using MovieRental.Data.Repositories;
using MovieRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Data.Extensions
{
    public static class UserExtensions
    {
        public static User GetSingleByUsername(this IEntityBaseRepository<User> userRepository, string username)
        {
            return userRepository.GetAll().FirstOrDefault(x => x.Username == username);
        }

        public static bool UserExists(this IEntityBaseRepository<Customer> customerRepository, string email, string identityCard)
        {
            return customerRepository.GetAll().Any(c => c.Email == email && c.IdentityCard == identityCard);
        }

        public static string GetCustomerFullName(this IEntityBaseRepository<Customer> customerRepository, int customerId)
        {
            Customer cust = customerRepository.GetSingle(customerId);
            return cust.FirstName + cust.LastName;
        }
    }
}
