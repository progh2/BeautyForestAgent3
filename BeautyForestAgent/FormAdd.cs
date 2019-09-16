using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautyForestAgent
{
    public partial class FormAdd : Form
    {
        public string Title
        {
            set { this.Text = value; }
        }

        public FormAdd()
        {
            InitializeComponent();
        }
    }
}
