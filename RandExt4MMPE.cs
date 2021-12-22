using System;

namespace RandExt4MMPE
{
    public static class RandExt4MMPE
    {
        public static double ExponentialDistributionFunction(this Random r, double lambda)
        {
            return -(1 / lambda) * Math.Log(r.NextDouble());
        }
        public static double NormalDistributionFunction(this Random r, double sigma, double m)
        {
            return (sigma * Math.Cos(2 * Math.PI * r.NextDouble())
            * Math.Sqrt(-2 * Math.Log(r.NextDouble()))) + m;
        }
    }
}
