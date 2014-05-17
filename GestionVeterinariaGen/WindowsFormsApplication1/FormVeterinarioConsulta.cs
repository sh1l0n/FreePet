﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormVeterinarioConsulta : Form
    {

        public string ID = "CONSULTA";
        public ScreenControllerVeterinario menu;

        private MascotaEN mascota;

        private FormVeterinarioConsultaController controller;

        public FormVeterinarioConsulta(ScreenControllerVeterinario menu)
        {
            this.menu = menu;
            InitializeComponent();
            controller = new FormVeterinarioConsultaController(this);
        }


        #region IO

        /** Activa el formulario */
        public void ActivateForm()
        {
            Activate();
            this.Visible = true;
        }

        /** Desactiva el formulario */
        public void DesactivateForm()
        {
            this.Visible = false;
        }
        #endregion

        public void changeState(MascotaEN mascota)
        {
            controller.loadData(mascota);
        }


        private void FormConsultaVeterinario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'formAdministradorTratamientoDataSet.Tratamiento' Puede moverla o quitarla según sea necesario.
            this.tratamientoTableAdapter.Fill(this.formAdministradorTratamientoDataSet.Tratamiento);

        }

        private void label_tratamientos_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void picture_inicio_veterinario_Click_1(object sender, EventArgs e)
        {
            if (menu.LaunchStartScreenVeterinario())
                DesactivateForm();
        }

        private void picture_consulta_veterinario_Click_1(object sender, EventArgs e)
        {
            if (menu.LaunchConsultaScreenVeterinario(mascota))
                DesactivateForm();
        }

        private void picture_desconectar_veterinario_Click_1(object sender, EventArgs e)
        {
            //Solucion Provisional
            menu.sessionData.Disconnect();
            this.Hide();
        }

        private void button_realizar_Click(object sender, EventArgs e)
        {

        }

        private void listBox_addTratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_ConsultaPet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_tratamientos.Visible = false;
        }

        private void textBox_tam_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            panel_tratamientos.Visible = true;
            //DataGridViewRow fila = dataGrid_consultas.Rows[e.RowIndex];
            //String s = Convert.ToString(fila.Cells["Nombre"].Value);
            listBox_addTratamiento.Items.Add(dataGridView_ConsultaPet.Rows.ToString());
        }

        private void button_cerrartrat_Click(object sender, EventArgs e)
        {
            panel_tratamientos.Visible = false;
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            listBox_addTratamiento.Items.Remove(listBox_addTratamiento.SelectedItem);
        }
    }
}