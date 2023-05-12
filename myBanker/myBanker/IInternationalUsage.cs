using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public interface IInternationalUsage
    {
        //Jeg kunne også have valgt at sætte det som en bool under Card superklassen. 
        bool IsInternationalUsageEnabled { get; set; }
    }
}
