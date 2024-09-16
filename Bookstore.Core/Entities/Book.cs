using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Core.Entities
{
   public record Book(int Id, string Title, string Author, decimal Price);
}
