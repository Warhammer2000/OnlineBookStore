using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Core.Entities
{
    public record Customer(int Id, string Name, string Email);
}
