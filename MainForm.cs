using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserHTML
{
    public partial class MainForm : Form
    {
        private KinopoiskSearcher ks;

        public MainForm()
        {
            InitializeComponent();
            ks = new KinopoiskSearcher();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (ks.DownloadHTML(NameTextBox.Text))
                MessageBox.Show("Download complete");
        }
    }
}
