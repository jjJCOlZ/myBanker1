using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public interface IDayDrawLimit
    {
        //Det er et interface da det kun er et af kortet (pt) som har et dagligt hævelimit. Men det skal være muligt for andre kort også at have et dagligt hævelimit.
        double DailyWithdrawalLimit { get; }
    }
}