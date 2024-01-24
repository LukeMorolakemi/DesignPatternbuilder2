using DesignPattern2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern2.Implementation
{
    public class Bottle : IPackage
    {
        public string Pack()
        {
            return "Bottle";
        }
    }
}
