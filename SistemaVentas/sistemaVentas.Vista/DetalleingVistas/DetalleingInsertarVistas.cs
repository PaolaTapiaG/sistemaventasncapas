using sistemaVentas.BSS;
using sistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVentas.Vista.DetalleingVistas
{
    public partial class DetalleingInsertarVistas : Form
    {
        public DetalleingInsertarVistas()
        {
            InitializeComponent();
        }
        DetalleingBss bss = new DetalleingBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Detalleing p = new Detalleing();
            p.IdIngreso = Convert.ToInt32(textBox1.Text);
            p.IdProducto = Convert.ToInt32(textBox2.Text);
            p.FechaVenc = dateTimePicker1.Value;
            p.Cantidad = Convert.ToInt32(textBox4.Text);
            p.PrecioCosto = Convert.ToDecimal(textBox5.Text);
            p.PrecioVenta = Convert.ToDecimal(textBox6.Text);
            p.Subtotal = Convert.ToDecimal(textBox7.Text);
            bss.InsertarDetalleingBss(p);
            MessageBox.Show("Se guardó correctamente a Detalle Ing");
        }
    }
}
