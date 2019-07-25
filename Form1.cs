using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser.Navigate("https://www.google.com/finance/converter");//This Part of code is wrong.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("https://www.google.com/finance/converter");
        }
    }
}
