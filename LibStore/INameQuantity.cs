using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibStore
{
    public interface INameQuantity
    {
        string Name { get; }
        int Quantity { get; }
    }
    public class NameQuantity: INameQuantity
    {
        string Name { get; set; }
        int Quantity { get; set; }
        string INameQuantity.Name
        {
            get
            {
                return Name;
            }
        }

        int INameQuantity.Quantity
        {
            get
            {
                return Quantity;
            }
        }
    }
}
