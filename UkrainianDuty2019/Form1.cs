using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkrainianDuty2019
{
    public partial class App : Form
    {
        int priceProduct_;
        int fullPrice_;
        public App()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            priceProduct_ = Int32.Parse(priceProduct.Text);
            // 20% НДС
            // 10% Пошлина
            if (priceProduct_ >= 100)
            {
                fullPrice_ = ((priceProduct_ / 100) * 10) + ((priceProduct_ / 100) * 20) + priceProduct_;
            } else
            {
                fullPrice_ = priceProduct_;
            }

            fullPrice.Text = fullPrice_.ToString();
        }
    }
}
