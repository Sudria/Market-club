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
    public partial class RegistroProductos : Form
    {
        private static readonly List<Producto> productos = new List<Producto>();

        // Lista en memoria para simular la base de datos
        private readonly List<Producto> listaProductos = productos;

        public RegistroProductos()
        {
            InitializeComponent();
        }


        // BOTÓN BUSCAR
        private void Button1_Click(object sender, EventArgs e)
        {
            Producto p = listaProductos.Find(x => x.Nombre == textBox2.Text);
            if (p != null)
            {
                textBox2.Text = p.Nombre;
                textBox3.Text = p.Precio.ToString();
                textBox4.Text = p.Stock.ToString();
                textBox5.Text = p.StockMinimo;
                textBox1.Text = p.CategoriaID;
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        // BOTÓN NUEVO
        private void Button2_Click(object sender, EventArgs e)
        {
            
            textBox2.Clear(); // Nombre
            textBox3.Clear(); // Precio
            textBox4.Clear(); // Stock
            textBox5.Clear(); // Stock Minimo
            textBox2.Clear(); //CategoriaID
            textBox1.Focus();

        }

        // BOTÓN ACTUALIZAR
        private void Button3_Click(object sender, EventArgs e)
        {
            Producto p = listaProductos.Find(x => x.Nombre == textBox2.Text);
            if (p != null)
            {
                p.Nombre = textBox2.Text;
                p.Precio = decimal.Parse(textBox3.Text);
                p.Stock = int.Parse(textBox4.Text);
                p.StockMinimo  = int.Parse(textBox5.Text);
                p.CategoriaID = int.Parse(textBox1.Text);

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
                
                Nombre = textBox2.Text,
                Precio = decimal.Parse(textBox3.Text),
                Stock = int.Parse(textBox4.Text),
                StockMinimo = int.Parse(textBox5.Text);
                CategoriaID = int.Parse(textBox1.Text);
            };

            listaProductos.Add(p);
            MessageBox.Show("Producto insertado correctamente.");
            button2.PerformClick(); // limpia los campos
        }

        // BOTÓN ELIMINAR
        private void Button5_Click(object sender, EventArgs e)
        {
            Producto p = listaProductos.Find(x => x.Nombre == textBox2.Text);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

    // Clase Producto
    public class Producto
    {
       
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        
        public string StockMinimo { get; internal set; }
        public string CategoriaID { get; internal set; }

        public static implicit operator Producto(Producto v)
        {
            throw new NotImplementedException();
        }
    }
}