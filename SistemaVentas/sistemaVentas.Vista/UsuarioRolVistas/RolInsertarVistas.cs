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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sistemaVentas.Vista.RolVistas
{
    public partial class RolInsertarVistas : Form
    {
        public RolInsertarVistas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        RolBss bss = new RolBss();
        private void button1_Click(object sender, EventArgs e)
        {
          
            
                Rol r = new Rol();
                r.Nombre = textBox1.Text;
                bss.InsertarRolBss(r);
                MessageBox.Show("Se guardo correctamente");
            
        }
    }
}
