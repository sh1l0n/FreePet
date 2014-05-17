﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestionVeterinariaGenNHibernate.CEN.GestionVeterinaria;
using GestionVeterinariaGenNHibernate.EN.GestionVeterinaria;

namespace WindowsFormsApplication1
{
    public partial class FormAdministradorEmpleado : Form
    {

        #region Variables

        /** El controlador */
        private FormAdministradorEmpleadoController controller = null;

        /** EL tipo de accion, ADD,MOD,DEL */
        public Utils.State state = Utils.State.NONE;

        /** El identificador de la clase */
        public string ID = "EMPLEADO";

        /** EL controlador del menu superior */
        public ScreenControllerAdministrador menu = null;

        #endregion

        #region Constructor

        /**
         * Constructor
         * @param session el ticket de sesion
         * @param showType el tipo de accion
         */
        public FormAdministradorEmpleado(ScreenControllerAdministrador menu) 
        {
            this.menu = menu;
            InitializeComponent();
            controller=new FormAdministradorEmpleadoController(this);
        }

        /**
         * Cambia el estado de la pantalla 
         * @param el estado de la pantalla
         * @param el cliente si es estado modificar o eliminar
         */
        public void changeState(Utils.State st, EmpleadoEN emp)
        {
           // controller.ClearForm();
            state = st;
            if (state == Utils.State.MODIFY || state == Utils.State.DESTROY)
            {
                tb_dni.Enabled = false;
                controller.loadData(emp);

                if (state == Utils.State.DESTROY) {
                    btn_eliminar_Click(new object(), new EventArgs());
                }
            }
        }

        #endregion

        #region IO

        public void ActivateForm()
        {
            Activate();
            this.Visible = true;
        }

        public void DesactivateForm()
        {
            this.Visible = false;
        }

        /**
        * Pone typ todos los elementos del formulario menos los de eliminar
        * @param typ si estan disponibles o no
        */
        private void EnableForm(Boolean typ)
        {
            tb_dni.Enabled = typ;
            tb_nombre.Enabled = typ;
            tb_apellidos.Enabled = typ;
            tb_direccion.Enabled = typ;
            tb_provincia.Enabled = typ;
            tb_localidad.Enabled = typ;
            tb_cp.Enabled = typ;
            tb_tel.Enabled = typ;

            tb_sueldo.Enabled = typ;
            tb_tipo.Enabled = typ;

            btn_buscar_dni.Enabled = typ;
            btn_erase.Enabled = typ;
            //btn_buscar.Enabled = typ;
            btn_guardar.Enabled = typ;
            btn_eliminar.Enabled = typ;
            //dataGridView.Enabled = typ;
            //panel_clientes_opcion.Enabled = typ;
            panel_top.Enabled = typ;
            //btn_anaydir.Enabled = typ;

            alerta_eliminar.Enabled = !typ;
            alerta_eliminar.Visible = !typ;
            btn_eliminar_no.Enabled = !typ;
            btn_eliminar_si.Enabled = !typ;
        }

        #endregion

        #region Botones

        /**
         * Cuando se selecciona el boton guardar
         */
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (state == Utils.State.NONE || state == Utils.State.NEW)
                state = Utils.State.NEW;
            else
                state = Utils.State.MODIFY;

            controller.ProcesarInformacion();
            EnableForm(true);
            state = Utils.State.MODIFY;
        }

        /**
         * Cuadno se pulsa el boton de cancelar eliminacion
         */
        private void btn_eliminar_no_Click(object sender, EventArgs e)
        {
            state = Utils.State.MODIFY;
            EnableForm(true);
        }

        /**
         * Cuando se pulsa el boton de proceder a eliminar
         */
        private void btn_eliminar_si_Click(object sender, EventArgs e)
        {
            state = Utils.State.DESTROY;
            EnableForm(true);
            controller.ProcesarInformacion();
            state = Utils.State.NONE;
        }


        /**
         * Cuando se pulsa el boton eliminar principal
         */
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            EnableForm(false);
        }

        /**
         * Si clickea el boton de buscar cliente por dni desde la pantalla empleado
         */
        private void btn_buscar_dni_Click(object sender, EventArgs e)
        {
            changeState(Utils.State.MODIFY, null);
        }

        /**
         * Cuando se pulsa el boton erase que es la gomita se borran todos los campos
         */
        private void btn_erase_Click(object sender, EventArgs e)
        {
            if (state == Utils.State.MODIFY)
                tb_dni.Enabled = true;

            controller.ClearForm();
            state = Utils.State.NONE;
        }


        /** 
         * Cuando se pulsa el boton modificar
         */
        /*private void bt_modificar_Click(object sender, EventArgs e) 
        {
            if (controller.modifiData()) {
                Hide();
                //new FormRecepcionistaAdministradorInicio(controller.sessionData);
            }
        }*/

        /**
         * Cuando se pulsa la foto
         */
        private void pictureBox1_Click(object sender, EventArgs e) {
            controller.clickInPhoto();
        }

        /**
         * Cuando escribimos el dni
         */
        private void tb_dni_TextChanged(object sender, EventArgs e) {
            controller.showData();
        }

        private void picture_desconectar_admin_Click(object sender, EventArgs e)
        {
            menu.Disconnect();
        }

        #endregion

        #region MenuSuperior

        /**
         * Pinta panel superior menu
         */
        private void panel_top_Paint(object sender, PaintEventArgs e)
        {
            this.picture_empleado.BackColor = Color.White;
            this.panel_top.BackColor = Color.LightBlue;
        }

        /**
         * Cuando se slecciona la opcion start
         */
        private void picture_start_Click(object sender, EventArgs e)
        {
            if (menu.LaunchStartScreen())
                DesactivateForm();

            //Hide();
            //new FormRecepcionistaAdministradorInicio(controller.sessionData);
        }

        /**
         * Cuando se slecciona la opcion clientes
         */
        private void picture_empleados_Click(object sender, EventArgs e)
        {
            if (menu.LaunchEmpleadoScreen(Utils.State.NONE, null))
                DesactivateForm();
        }


        /**
         * Cuando se slecciona la opcion facturas
         */
        private void picture_tratamientos_Click(object sender, EventArgs e)
        {
            if (menu.LaunchTratamientoScreen(Utils.State.NONE, null))
                DesactivateForm();
        }

        /**
         * Cuando se slecciona la opcion ajustes
         */
        private void picture_desconectar_Click(object sender, EventArgs e)
        {

            menu.sessionData.Disconnect();
        }

        #endregion
    }
}