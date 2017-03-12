using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            int amount = 0;
            int.TryParse(txtbx_amount.Text, out amount);
            if (amount <= 0)
                return;

            var arr = AnsiX9_17.generate(amount);

            var bin_seq = "";
            foreach (var num in arr)
            {
                string bin = Convert.ToString((long)num, 2);
                while (bin.Length != 64)
                    bin = string.Concat("0", bin);
                bin_seq += bin + "\n";
            }
            txtbx_bin.Text = bin_seq;

            var test1 = new Tests(arr);

            bool freq_bool = false, eq_bool = false, dev_bool = false;
            double freq_double = 0, eq_double = 0;
            double[] dev_double = new double[18];

            test1.freq(ref freq_bool, ref freq_double);
            lbl_test_freq.Text = freq_bool.ToString() + " " + freq_double.ToString();

            test1.eq_seq(ref eq_bool, ref eq_double);
            lbl_test_seq.Text = eq_bool.ToString() + " " + eq_double.ToString();

            test1.deviation(ref dev_bool, ref dev_double);
            lbl_test_deviat.Text = dev_bool.ToString();
        }
    }
}
