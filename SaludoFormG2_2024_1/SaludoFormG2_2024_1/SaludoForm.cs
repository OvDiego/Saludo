﻿using System;
using System.Windows.Forms;

namespace SaludoFormG2_2024_1
{
    internal partial class SaludoForm
    {
        public SaludoForm()
        {
            InitializeComponent();
        }

        internal void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtbNombre.Text;
            MessageBox.Show("Hola" + nombre);
        }
    }
}
