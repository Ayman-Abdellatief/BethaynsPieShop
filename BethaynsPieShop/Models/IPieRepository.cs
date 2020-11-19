using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethaynsPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PieOfTheWeek { get; }
        Pie GetPieById (int pieId);
    }
}
