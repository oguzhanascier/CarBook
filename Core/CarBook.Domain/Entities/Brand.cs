using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Brand
    {
        public int BrandId { get;}
        public string BrandName { get;}
        public List<Car> Cars { get;}

    }
}
