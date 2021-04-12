using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab4A
{
    public partial class MainPage : ContentPage 
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private String morcein = "";
        private String word = "";
        

        private void AddADot(object sender, EventArgs e)
        {
            morcein += ".";
            dot.Text = morcein;
        }

        private void addDassh(object sender, EventArgs e)
        {
            morcein += "-";
            dot.Text = morcein;
        }

        private void Space(object sender, EventArgs e)
        {
            word +=  Morse.MorseCoder(morcein);
            Output.Text = word;
            morcein = "";
            dot.Text = morcein;
        }
    }
}