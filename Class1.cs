using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    class Computer
{
    public string Brand;
    public string Model;
    public string Processor;
    public int RAM; 
    public int Storage; 
    public double Price; 
    public bool HasDedicatedGPU;
    public bool HasTouchscreen;

    public double GetPricePerGB()
    {
        return Price / (RAM + Storage);
    }
}
}