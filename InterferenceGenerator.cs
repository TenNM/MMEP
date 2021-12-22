using System;
using System.Collections.Generic;
using RandExt4MMPE;

namespace InterferenceGeneratorNamespace
{
    class InterferenceGenerator
    {
        List<double> _values;
        internal List<double> Values
        {
            get { return _values; }
        }
        double _generated_M = 0;
        double _generated_D = 0;
        internal double CalcM(List<double> list)
        {
            if (list.Count <= 0) throw new Exception("Empty list");
            double M = 0;
            foreach (double d in list) M += d;
            M /= list.Count;
            return M;
        }
        internal double CalcD(List<double> list)
        {
            if (list.Count <= 0) throw new Exception("Empty list");
            double M = CalcM(list);
            double D = 0;
            for (int i = 0; i < list.Count; ++i) D += Math.Pow(M - list[i], 2);
            D /= list.Count;
            return Math.Sqrt(D);
        }
        internal void ChetoNeYasnoe2(List<double> coeffs, double M, int pointsCount)
        {
            Random r = new Random();
            List<double> q = new List<double>(pointsCount + (int)Math.Ceiling(M) + coeffs.Count);

            for (int i = 0; i < q.Capacity; ++i) q.Add(r.NormalDistributionFunction(1, 0));
            _values = new List<double>(pointsCount);

            for (int i = 0; i < _values.Capacity; ++i)
            {
                _values.Add(M);
                for (int j = 0; j < coeffs.Count; ++j)
                {
                    _values[i] += coeffs[j] * q[i + j];
                    //_values[i]++;
                    //coefficients[j]++;
                    //q[i + j]++;
                }
            }
            _generated_M = CalcM(_values);
            _generated_D = CalcD(_values);
        }
        internal void TestIt()
        {
            Console.WriteLine("generated M = {0}\ngenerated D = {1}", _generated_M, _generated_D);

            List<double> odd = new List<double>();
            List<double> even = new List<double>();

            for (int i = 0; i < _values.Count; ++i)
            {
                if (1 == (i & 1)) odd.Add(_values[i]);
                else even.Add(_values[i]);
            }

            double[] arrM = {
                CalcM(odd),
                CalcM(even),
            };

            double[] arrD = {
                Math.Pow( CalcD(odd), 2 ),
                Math.Pow( CalcD(even), 2 ),
            };

            //-----------------------------------------------------

            double D = (  (odd.Count - 1) * arrD[0] + (even.Count - 1) * arrD[1]  )
                / (_values.Count - 2);

            double tBp = Math.Sqrt(
                (  Math.Pow(arrM[0] - arrM[1], 2) * odd.Count * even.Count  ) /
                (D * _values.Count)
            );

            Console.WriteLine("criterion of Student = " + tBp);

            //--------------------------------------------------

            double fBBa = 0;
            if (arrD[0] >= arrD[1]) fBBa = arrD[0] / arrD[1];
            else fBBa = arrD[1] / arrD[0];

            Console.WriteLine("criterion of Fisher = " + fBBa + "\n");

        }//test

    }//c
}
