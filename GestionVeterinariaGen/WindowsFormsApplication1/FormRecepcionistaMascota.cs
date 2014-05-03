﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using System.Collections;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormRecepcionistaMascota : Form
    {
        /** El controlador */
        private FormRecepcionistaMascotaController controller;

        /**
         * Contructor de clase de cuando lo llamamos para modificar/eliminar una mascota
         * @param session el ticket de sesion
         * @param mascota la mascota
         * @param action el tipo de accion (mod OR del)
         */
        public FormRecepcionistaMascota(FormLoginDataSessionTicket session, string mascota, char action)
        {
            Activate();
            this.Visible = true;
            InitializeComponent();
            controller = new FormRecepcionistaMascotaController(session, this);
            EnableForm(action, false);
            controller.loadData(mascota);
            
        }

        /**
         * Bloquea los componentes del formulario dependiendo de la accion
         * @param action la accion
         * @param block el tipo de bloqueo
         */
        private void EnableForm(char action, bool block)
        {
            if (action == 'M' || action == 'E')
            {
                text_cliente.Enabled = block;
                text_especie.Enabled = block;
                text_raza.Enabled = block;
                dateTime_fnac.Enabled = block;
                combo_sexo.Enabled = block;

                if (action == 'E')
                {
                    text_color.Enabled = block;
                    text_nombre.Enabled = block;
                    text_peso.Enabled = block;
                    combo_sexo.Enabled = block;
                    combo_tamanyo.Enabled = block;
                    combo_microchip.Enabled = block;
                    btn_anaydir.Enabled = block;
                    btn_buscar_cliente.Enabled = block;
                    btn_erase.Enabled = block;
                    dataGridView.Enabled = block;
                    panel_clientes_opcion.Enabled = block;
                    panel_top.Enabled = block;

                    alerta_eliminar.Visible = alerta_eliminar.Enabled = !block;
                    btn_eliminar_si.Visible = btn_eliminar_si.Enabled = !block;
                    btn_eliminar_no.Visible = btn_eliminar_no.Enabled = !block;
                    label_eliminar_box.Visible = label_eliminar_box.Enabled = !block;
                }
            }
        }

        /**
         * Pinta el panel menu superior
         */
        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.picture_clientes.BackColor = Color.White;
            this.panel_top.BackColor = Color.LightBlue;
        }


        /**
        * Cuando se slecciona la opcion start
        */
        private void picture_start_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRecepcionistaAdministradorInicio(controller.sessionData);
        }

        /**
         * Cuando se slecciona la opcion clientes
         */
        private void picture_clientes_Click(object sender, EventArgs e)
        {
            //NONE
        }

        /**
         * Cuando se slecciona la opcion consultas
         */
        private void picture_consultas_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRecepcionistaConsulta(controller.sessionData);
        }

        /**
         * Cuando se slecciona la opcion facturas
         */
        private void picture_facturas_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRecepcionistaFactura(controller.sessionData);
        }

        /**
         * Cuando se slecciona la opcion ajustes
         */
        private void picture_ajustes_Click(object sender, EventArgs e)
        {
            //Esto solo le da a un formulario
            //donde puede cambiar algunos datos personales, la constraseña la foto y desconectarse
        }

        private void panel_clientes_opcion_Paint(object sender, PaintEventArgs e)
        {
            this.picture_cliente_opcion_mascota.BackColor = Color.White;
            this.panel_clientes_opcion.BackColor = Color.LightCyan;
        }

        /**
         * Cuando se selecciona la opcion mascotas de clientes
         */
        private void picture_cliente_opcion_mascota_Click(object sender, EventArgs e)
        { }

        /** 
         * Cuando se selcciona la opcion cliente de clientes
         */
        private void picture_cliente_opcion_cliente_Click(object sender, EventArgs e)
        {
            Hide();
            new FormRecepcionistaCliente(controller.sessionData, 'A');
        }


        /**
         * Cuando se clickea en el dataGrid
         */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /**
         * Cuando se clickea el boton guardar
         */
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //GUARDA O MODIFICA EL ANIMAL
        }

        /**
         * Cuando se clickea el boton eliminar
         */
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            EnableForm('E', false);
        }

        /**
         * Cuando se clickea el boton (imagen) anaydir
         */
        private void btn_anaydir_Click(object sender, EventArgs e)
        {
            //Hide();
            //new FormRecepcionistaConsulta(session, animalActual, clienteAnimal, 'A');
        }

        /**
         * Cuando se clickea el boton buscar y apareceria en el combo_box de nombres el del animal
         */
        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            //Busca por cliente
        }

        /**
         * Borrar los campos del formulario
         */
        private void btn_erase_Click(object sender, EventArgs e)
        {
            EnableForm('E', true);
            controller.Clear();
        }

        /**
         * Cuando pulsamos el boton de no eliminar
         */
        private void btn_eliminar_no_Click(object sender, EventArgs e)
        {
            EnableForm('E', true);
        }

        /**
         * Cuando pasamos el boton de eliminar si
         */
        private void btn_eliminar_si_Click(object sender, EventArgs e)
        {
            EnableForm('E', true);
            //controller.Borrar();
        }
    }
}
