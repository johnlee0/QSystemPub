using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qystem.Models
{
    public class Calculator
    {
        public int GetAvg(int sumScore,int sumSubject)
        {
            return sumScore / sumSubject;
        }
    }
}