using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación_Windows_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.BackColor = Color.Red;
            }
            else
            {
                textBox1.BackColor = System.Drawing.SystemColors.Control;
            }

            if (textBox2.Text == "")
            {
                textBox2.BackColor = Color.Red;
            }
            else
            {
                textBox2.BackColor = System.Drawing.SystemColors.Control;
            }

            if (textBox3.Text == "")
            {
                textBox3.BackColor = Color.Red;
            }
            else
            {
                textBox3.BackColor = System.Drawing.SystemColors.Control;
            }

            if (textBox4.Text == "")
            {
                textBox4.BackColor = Color.Red;
            }
            else
            {
                textBox4.BackColor = System.Drawing.SystemColors.Control;
            }

            bool verificador;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Por favor complete los campos en Rojo");
                verificador = false;
            }
            else
            {
                verificador = true;
            }

            if (verificador == true)
            {
                string apellidoNombre = "Apellido y Nombre: "+ textBox1.Text + ", " + textBox2.Text;
                string edad = "Edad: " + textBox3.Text;
                string direccion = "Dirección: " + textBox4.Text;
                //string resultado = "Apellido y Nombre: " + textBox1.Text + ", " + textBox2.Text + "\nEdad: " + textBox3.Text + "\nDirección: " + textBox4.Text;
                listResultado.Items.Add(apellidoNombre);
                listResultado.Items.Add(edad);
                listResultado.Items.Add(direccion);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
