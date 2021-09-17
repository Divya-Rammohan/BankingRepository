using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public interface ICalculateInterest
    {
        
            int Calculate(int PrincipleAmount, int RateOfInterest, int NOOfYears);
        
    }
}
