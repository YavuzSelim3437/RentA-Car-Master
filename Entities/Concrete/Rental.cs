using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public int RentId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }

        public DateTime  RentDate { get; set; }

        public DateTime ReturnDate  { get; set; }
    }
}
