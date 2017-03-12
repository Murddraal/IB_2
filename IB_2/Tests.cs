using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB_2
{
    class Tests
    {
        private double crit_val = 1.82138636;
        private string bin_seq = "";
        private UInt32 N = 0;

        public Tests(List<ulong> arr)
        {
            foreach (var num in arr)
            {
                string bin = Convert.ToString((long)num, 2);
                while (bin.Length != 64)
                    bin = string.Concat("0", bin);
                bin_seq += bin;
            }
            N = (uint)bin_seq.Length;
        }

        public void freq(ref bool res_b, ref double res_d)
        {
            List<int> X = new List<int>();
            for (int i = 0; i < N; ++i)
            {
                var xi = 2 * (bin_seq[i] - '0') - 1;
                X.Add(xi);
            }

            int summ = 0;
            foreach (var x in X)
                summ += x;

            var S = Math.Abs(summ) / Math.Sqrt(N);

            res_b = S <= crit_val;
            res_d = S;
            
        }

        public void eq_seq(ref bool res_b, ref double res_d)
        {
            double pi = 0;
            foreach (var i in bin_seq)
                pi += i - '0';
            pi /= N;

            int V = 1;
            for (int i = 0; i < N - 1; ++i)
            {
                var r = bin_seq[i] == bin_seq[i + 1] ? 0 : 1;
                V += r;
            }

            var S = Math.Abs(V - 2 * N * pi * (1 - pi)) / (2 * Math.Sqrt(2 * N) * pi * (1 - pi));

            res_b = S <= crit_val;
            res_d = S;
            
        }

        public void deviation(ref bool res_b, ref double[] res_d)
        {
            var X = new List<int>();

            var S = new List<int>();
            S.Add(0);
            var k = 2;

            for (int i = 0; i < N; ++i)
            {
                var xi = 2 * (bin_seq[i] - '0') - 1;
                X.Add(xi);
                S.Add(xi + S[i]);
                if (S[i + 1] == 0)
                    ++k;
            }
            S.Add(0);

            var L = k - 1;

            int[] J = new int[18];
            for (int i = -9, j = 0; i < 10; ++i, ++j)
                J[j] = i != 0 ? i : ++i;

            int[] J_count = new int[18];

            for (int i = 0; i < 18; ++i)
            {
                for (int j = 0; j < S.Count; ++j)
                    if (S[j] == J[i])
                        ++J_count[i];
            }

            double[] Y = new double[18];
            for (int i = 0; i < 18; ++i)
            {
                res_d[i] = Y[i] = Math.Abs(J_count[i] - L) / (Math.Sqrt(2 * L * (4 * Math.Abs(J[i]) - 2)));
            }

            bool result = true;
            foreach(var y in Y)
            {
                if (y > crit_val)
                    result = false;
            }

            res_b = result;
        }
    }
}
