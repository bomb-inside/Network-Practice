using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;
using System.Threading;

namespace NetworkCheck
{
    public partial class Form1 : Form
    {
        private static Form1 staticForm;

        public Form1()
        {
            InitializeComponent();
            staticForm = this;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
