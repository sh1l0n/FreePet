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
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class FormRecepcionistaFactura : Form
    {
        #region Variables

        /** El controlador de la pantalla */
        private FormRecepcionistaFacturaController controller;

        /** El controlador del menu superior */
        private ScreenControllerRecepcionista menu;

        /** El estado actual del form */
        public Utils.State state = Utils.State.NONE;

        /** El identificador del form */
        public string ID = "FACTURA";

        #endregion

        #region Constructor

        /**
         * Constructor de la clase
         * @param session el ticket de sesion
         */
        public FormRecepcionistaFactura(ScreenControllerRecepcionista menu)
        {
            this.menu = menu;
            InitializeComponent();
            controller = new FormRecepcionistaFacturaController(this);
        }

        /**
         * Cambia el estado del form
         * @param st el estado nuevo
         * @param cli ??
         */
        public void changeState(Utils.State st, string cli)
        {
            //AQUI COMPRUEBO EL ESTADO ACTUAL DE LA PANTALLA, PORQUE ESTE METODO SOLO SE EJECUTARA
            //CADA VEZ QUE HAGAMOS UNA ACCION REFERIDA CON AÑADIR, MODIFICAR O ELIMINAR EN LA PANTALLA
            //TANTO SI PINCHAMOS EN EL DATAGRID COMO SI NOS LA INFORMACION DE OTRA PANTALLA

            state = st;

            if (state == Utils.State.MODIFY || state == Utils.State.DESTROY)
            {
                // lo que tenga que hacer en comun para los dos casos
                //si hace algo en comun
                controller.loadData(cli);

                if (state == Utils.State.DESTROY)
                {
                    //Lo que tenga que hacer si le manda la accion eliminar
                    //mira el otro form (clientes, mascota y  consulta estan casi casi casi acabados)
                }
            }
           
        }

        #endregion

        #region I/O_Form

        public void ActivateForm()
        {
            Activate();
            this.Visible = true;
        }

        public void DesactivateForm()
        {
            this.Visible=false;
        }

        #endregion

        #region Botones

        /**
         * Cuando se pulsa el boton buscar
         */
        private void btn_buscar_Click(object sender, EventArgs e)
        {
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            controller.CargarGroupBoxCrear();
        }

        #endregion

        #region LabelClick

        private void ll_Cancelar_gpCrear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gp_CrearFactura.Visible = false;
        }

        private void ll_Cancelar_gpModificar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gp_ModificarFactura.Visible = false;
        }

        private void ll_Modificar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controller.ModificarFactura();
        }

        private void ll_Eliminar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controller.EliminarFactura();
        }

        private void ll_Crear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            controller.CrearFactura();
        }

        #endregion

        #region DataGridView

        /**
         * Pintar tamaño datagrid
         */
        private void dataGridView1_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            controller.paintDataGrid(e);
        }

        /**
        * Comprueba el contenido de la casilla pulsada
        */

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!e.RowIndex.Equals(-1))
            {
                controller.CargarGroupBoxModificar(e.RowIndex);

            }
        }

        #endregion

        #region MenuSuperior

        /**
         * Pinta el panel superior
         */
        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.picture_facturas.BackColor = Color.White;
            this.panel_top.BackColor = Color.LightBlue;
        }

        /**
         * Cuando se slecciona la opcion start
         */
        private void picture_start_Click(object sender, EventArgs e)
        {
            if (menu.LaunchStartScreen())
                DesactivateForm();
        }

        /**
         * Cuando se slecciona la opcion clientes
         */
        private void picture_clientes_Click(object sender, EventArgs e)
        {
            if (menu.LaunchClienteScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        /**
         * Cuando se slecciona la opcion consultas
         */
        private void picture_consultas_Click(object sender, EventArgs e)
        {
            if (menu.LaunchConsultaScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        /**
         * Cuando se slecciona la opcion facturas
         */
        private void picture_facturas_Click(object sender, EventArgs e)
        {
            if (menu.LaunchFacturaScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        /**
         * Cuando se slecciona la opcion ajustes
         */
        private void picture_ajustes_Click(object sender, EventArgs e)
        {
            //Esto solo le da a un formulario
            //donde puede cambiar algunos datos personales, la constraseña la foto y desconectarse
        }

        #endregion
    }
}