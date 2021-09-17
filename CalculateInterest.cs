using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class CalculateInterest : ICalculateInterest
    {
        public int Calculate(int PrincipleAmount, int RateOfInterest, int NOOfYears)
        {
            int SI = (PrincipleAmount * RateOfInterest * NOOfYears) / 100;
            return SI;
        }
    }
}
