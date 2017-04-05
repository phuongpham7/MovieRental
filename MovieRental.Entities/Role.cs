using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Entities
{
    /// <summary>
    /// MovieRental Role
    /// </summary>
    public class Role : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
