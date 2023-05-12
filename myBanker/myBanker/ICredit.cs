using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public interface ICredit
    {   //Det er et interface da det ikke er alle kort som har et creditlimit
        double CreditLimit { get; set; }
    }
}