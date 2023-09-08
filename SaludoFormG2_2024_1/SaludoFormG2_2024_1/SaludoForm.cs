using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace SaludoFormG2_2024_1
{
    internal partial class SaludoForm
    {
        int contador = 0;
        public SaludoForm()
        
            
      
        {
            InitializeComponent();
        }
        
        internal void btnAceptar_Click(object sender, EventArgs e)
        {
            contador ++;
            lbNombre.Text= String.Format("Ingresa tu nombre {0}", contador);
            string nombre = txtbNombre.Text;
            MessageBox.Show("Hola " + nombre );
        }

    }
}
