using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Club.Forms
{
    public partial class Form1 : Form
    {
        private static readonly List<Producto> productos = new List<Producto>();

        // Lista en memoria para simular la base de datos
        private readonly List<Producto> listaProductos = productos;

        public Form1()
        {
            InitializeComponent();
        }


        // BOTÓN BUSCAR
        private void Button1_Click(object sender, EventArgs e)
        {
            Producto p = listaProductos.Find(x => x.Codigo == textBox1.Text);
            if (p != null)
            {
                textBox2.Text = p.Nombre;
                textBox3.Text = p.Precio.ToString();
                textBox4.Text = p.Stock.ToString();
                textBox5.Text = p.Marca;
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        // BOTÓN NUEVO
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // Código
            textBox2.Clear(); // Nombre
            textBox3.Clear(); // Precio
            textBox4.Clear(); // Stock
            textBox5.Clear(); // Marca
            textBox1.Focus();
        }

        // BOTÓN ACTUALIZAR
        private void Button3_Click(object sender, EventArgs e)
        {
            Producto p = listaProductos.Find(x => x.Codigo == textBox1.Text);
            if (p != null)
            {
                p.Nombre = textBox2.Text;
                p.Precio = decimal.Parse(textBox3.Text);
                p.Stock = int.Parse(textBox4.Text);
                p.Marca = textBox5.Text;
                MessageBox.Show("Producto actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        // BOTÓN INSERTAR
        private void Button4_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Codigo = textBox1.Text,
                Nombre = textBox2.Text,
                Precio = decimal.Parse(textBox3.Text),
                Stock = int.Parse(textBox4.Text),
                Marca = textBox5.Text
            };

            listaProductos.Add(p);
            MessageBox.Show("Producto insertado correctamente.");
            button2.PerformClick(); // limpia los campos
        }

        // BOTÓN ELIMINAR
        private void Button5_Click(object sender, EventArgs e)
        {
            Producto p = listaProductos.Find(x => x.Codigo == textBox1.Text);
            if (p != null)
            {
                listaProductos.Remove(p);
                MessageBox.Show("Producto eliminado.");
                button2.PerformClick();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        // BOTÓN SALIR
        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Clase Producto
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Marca { get; set; }
    }
}