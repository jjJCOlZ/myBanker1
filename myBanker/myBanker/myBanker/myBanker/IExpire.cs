using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public interface IExpire
    {   //det er et interface da det ikke er alle kort der har en expiredate. Jeg kunne også have valgt at have det som en bool + datetime under superklassen Card. 
        DateTime ExpireDate { get; set; }
    }
}