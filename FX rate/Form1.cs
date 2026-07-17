using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FX_rate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CurrencyExchangeBottom_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> exchangeRates = new Dictionary<string, double>()
            {
                {"新台幣 TWD", 1 },
                {"美元 USD", 32.32 },
                {"人民幣 CNY", 4.794 },
                {"港幣 HKD", 4.145 },
                {"日圓 JPY", 0.201}
            };

            double inputAmount = Convert.ToDouble(InputCurrency.Text);
            double twd = inputAmount * exchangeRates[FromCurrency.Text];
            OutputCurrency.Text = (twd / exchangeRates[ToCurrency.Text]).ToString("F2");

        }

        private void InputCurrency_MouseDown(object sender, MouseEventArgs e)
        {
            InputCurrency.Clear();
        }

        private void OutputCurrency_MouseDown(object sender, MouseEventArgs e)
        {
            OutputCurrency.Clear();
        }

    }
}
