﻿using SistemasVentas.BSS;
using SistemasVentas.Modelos;
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

namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteInsertarVista : Form
    {
        public ClienteInsertarVista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente p = new Cliente();
            p.IdPersona= Convert.ToInt32(textBox1.Text);
            p.TipoCliente= textBox2.Text;
            p.CodigoClie = textBox3.Text;
            bss.InsertarClienteBss(p);
            MessageBox.Show("Se guardó correctamente a Cliente");
        }
    }
}
