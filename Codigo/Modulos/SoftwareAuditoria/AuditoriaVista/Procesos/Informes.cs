﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuditoriaVista.Procesos
{
    public partial class Informes : Form
    {
        public Informes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Ayudainformes
            AyudaInformes informes = new AyudaInformes();

            // Mostrar Ayudainformes utilizando Show (no bloquea informes)
            informes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Ayudainformes
            AyudaInformes informes = new AyudaInformes();

            // Mostrar Ayudainformes utilizando Show (no bloquea informes)
            informes.Show();
        }
    }
}
