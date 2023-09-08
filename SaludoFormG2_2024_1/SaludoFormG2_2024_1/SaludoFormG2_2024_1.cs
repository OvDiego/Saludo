using System;
using System.Windows.Forms;
using System.Drawing;

namespace SaludoFormG2_2024_1
{
    internal partial class SaludoForm : Form
    {
        private Label lbNombre;
        private TextBox txtbNombre;
        private Button btnAceptar;
        private Button btnLimpiar;



        public void InitializeComponent()
        {
            // Redimensionando y configurando la ventana
            this.Size = new Size(600, 400);
            this.Text = "Form Saludo";

            //Label: Ingresa tu nombre
            lbNombre = new Label(); //Instanciamos objeto
            lbNombre.Text = "Ingresa tu nombre";
            lbNombre.Location = new Point(200, 100);

            //textbox
            txtbNombre = new TextBox();
            txtbNombre.Size = new Size(500, 100);
            txtbNombre.Location = new Point(300, 200);

            //botonAcpt
            btnAceptar = new Button();
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.Location = new Point(100, 100);
            btnAceptar.Click += new EventHandler(btnAceptar_Click);
            //botonLimpiar
            btnLimpiar = new Button();
            btnLimpiar.Text = "ACEPTAR";
            btnLimpiar.Location = new Point(400, 400);




            this.Controls.Add(lbNombre);//Agregamos a la ventana
            this.Controls.Add(txtbNombre);
            this.Controls.Add(btnAceptar);
            this.Controls.Add(btnLimpiar);
        }
    }
}