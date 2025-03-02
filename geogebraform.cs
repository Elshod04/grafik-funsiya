using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elshod_kurs_ishi
{
    public partial class geogebraform : Form
    {
        public geogebraform()
        {
            InitializeComponent();
            webView21.Source = new Uri("https://www.geogebra.org/graphing?embed&app=graphing&toolbar=false&algebra=false&menubar=false&showResetIcon=false");
        }

        private void geogebraform_Load(object sender, EventArgs e)
        {
            webView21.CoreWebView2InitializationCompleted += (s, ev) =>
            {
                // Example: Set a GeoGebra command when WebView2 is initialized
                webView21.CoreWebView2.ExecuteScriptAsync("ggbApplet.setValue('x', 5)");
            };
            webView21.Source = new Uri("https://www.geogebra.org/graphing?embed&&app=graphing&&toolbar=0&&algebra=0&&menubar=0&&showResetIcon=false");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox'dan ifodani oling
            

            // WebView2 bilan appletga JavaScript buyruq yuboring
            

            string formula = textBoxformula.Text;

            // Agar TextBox bo'sh bo'lmasa
            if (!string.IsNullOrWhiteSpace(formula))
            {
                // ListBox ga formulani qo'shish
                listBoxformula.Items.Add(formula);
                webView21.CoreWebView2InitializationCompleted += (s, ev) =>
                {
                    // GeoGebra'da ifodani bajarish
                    webView21.CoreWebView2.ExecuteScriptAsync($"ggbApplet.evalCommand('{formula}')");
                };

                
                // GeoGebra appletida formulani bajarish
                if (webView21.CoreWebView2 != null)
                {
                    webView21.CoreWebView2.ExecuteScriptAsync($"ggbApplet.evalCommand('{formula}')");
                }

                // TextBox ni tozalash
                textBoxformula.Clear();
            }
        }

        private void listBoxformula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxformula.SelectedItem != null)
            {
                string selectedFormula = listBoxformula.SelectedItem.ToString();

                // GeoGebra appletida formulani bajarish
                if (webView21.CoreWebView2 != null)
                {
                    webView21.CoreWebView2.ExecuteScriptAsync("ggbApplet.reset()");

                    // Yangi formulani bajarish
                    webView21.CoreWebView2.ExecuteScriptAsync($"ggbApplet.evalCommand('{selectedFormula}')");
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.ExecuteScriptAsync("ggbApplet.reset()");

                listBoxformula.Items.Clear();                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
