﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Colegio5
{
    public partial class AgregarDocentes : Form
    {
        public AgregarDocentes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarDocente f1 = new AgregarDocente();
            f1.Show();

            
        }
    }
}
