﻿namespace WindowsFormsApplication1
{
    partial class FormConsultaRecepcionista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datetime_fin = new System.Windows.Forms.DateTimePicker();
            this.datetime_init = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar_Fecha = new System.Windows.Forms.Button();
            this.label_error_fecha = new System.Windows.Forms.Label();
            this.box_controller = new System.Windows.Forms.GroupBox();
            this.linklabel_eliminar = new System.Windows.Forms.LinkLabel();
            this.box_error_cliente = new System.Windows.Forms.Label();
            this.box_text_lugar = new System.Windows.Forms.TextBox();
            this.box_combo_veterinario = new System.Windows.Forms.ComboBox();
            this.box_combo_mascotas = new System.Windows.Forms.ComboBox();
            this.box_text_cliente = new System.Windows.Forms.TextBox();
            this.box_text_motivo = new System.Windows.Forms.TextBox();
            this.box_label_save = new System.Windows.Forms.LinkLabel();
            this.box_label_lugar = new System.Windows.Forms.Label();
            this.box_label_veterinario = new System.Windows.Forms.Label();
            this.box_label_mascota = new System.Windows.Forms.Label();
            this.box_label_cliente = new System.Windows.Forms.Label();
            this.box_label_motivo = new System.Windows.Forms.Label();
            this.box_label_hora = new System.Windows.Forms.Label();
            this.box_label_fecha = new System.Windows.Forms.Label();
            this.box_combo_hora = new System.Windows.Forms.ComboBox();
            this.box_text_fecha = new System.Windows.Forms.TextBox();
            this.box_controller_cancel = new System.Windows.Forms.LinkLabel();
            this.image_add = new System.Windows.Forms.PictureBox();
            this.image_del = new System.Windows.Forms.PictureBox();
            this.image_mod = new System.Windows.Forms.PictureBox();
            this.treeViewConsultas = new System.Windows.Forms.TreeView();
            this.alerta_eliminar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminar_no = new System.Windows.Forms.Button();
            this.btn_eliminar_si = new System.Windows.Forms.Button();
            this.log_photo = new System.Windows.Forms.PictureBox();
            this.log_date = new System.Windows.Forms.Label();
            this.log_type = new System.Windows.Forms.Label();
            this.log_id = new System.Windows.Forms.Label();
            this.log_name = new System.Windows.Forms.Label();
            this.box_controller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_del)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_mod)).BeginInit();
            this.alerta_eliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // datetime_fin
            // 
            this.datetime_fin.Location = new System.Drawing.Point(12, 209);
            this.datetime_fin.Name = "datetime_fin";
            this.datetime_fin.Size = new System.Drawing.Size(273, 20);
            this.datetime_fin.TabIndex = 10;
            // 
            // datetime_init
            // 
            this.datetime_init.Location = new System.Drawing.Point(12, 183);
            this.datetime_init.Name = "datetime_init";
            this.datetime_init.Size = new System.Drawing.Size(273, 20);
            this.datetime_init.TabIndex = 11;
            // 
            // btnBuscar_Fecha
            // 
            this.btnBuscar_Fecha.Location = new System.Drawing.Point(291, 206);
            this.btnBuscar_Fecha.Name = "btnBuscar_Fecha";
            this.btnBuscar_Fecha.Size = new System.Drawing.Size(79, 23);
            this.btnBuscar_Fecha.TabIndex = 12;
            this.btnBuscar_Fecha.Text = "Buscar";
            this.btnBuscar_Fecha.UseVisualStyleBackColor = true;
            this.btnBuscar_Fecha.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label_error_fecha
            // 
            this.label_error_fecha.AutoSize = true;
            this.label_error_fecha.ForeColor = System.Drawing.Color.Red;
            this.label_error_fecha.Location = new System.Drawing.Point(408, 204);
            this.label_error_fecha.Name = "label_error_fecha";
            this.label_error_fecha.Size = new System.Drawing.Size(146, 13);
            this.label_error_fecha.TabIndex = 15;
            this.label_error_fecha.Text = "*ERROR: Fechas incorrectas";
            this.label_error_fecha.Visible = false;
            // 
            // box_controller
            // 
            this.box_controller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.box_controller.Controls.Add(this.linklabel_eliminar);
            this.box_controller.Controls.Add(this.box_error_cliente);
            this.box_controller.Controls.Add(this.box_text_lugar);
            this.box_controller.Controls.Add(this.box_combo_veterinario);
            this.box_controller.Controls.Add(this.box_combo_mascotas);
            this.box_controller.Controls.Add(this.box_text_cliente);
            this.box_controller.Controls.Add(this.box_text_motivo);
            this.box_controller.Controls.Add(this.box_label_save);
            this.box_controller.Controls.Add(this.box_label_lugar);
            this.box_controller.Controls.Add(this.box_label_veterinario);
            this.box_controller.Controls.Add(this.box_label_mascota);
            this.box_controller.Controls.Add(this.box_label_cliente);
            this.box_controller.Controls.Add(this.box_label_motivo);
            this.box_controller.Controls.Add(this.box_label_hora);
            this.box_controller.Controls.Add(this.box_label_fecha);
            this.box_controller.Controls.Add(this.box_combo_hora);
            this.box_controller.Controls.Add(this.box_text_fecha);
            this.box_controller.Controls.Add(this.box_controller_cancel);
            this.box_controller.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_controller.Location = new System.Drawing.Point(376, 206);
            this.box_controller.Name = "box_controller";
            this.box_controller.Size = new System.Drawing.Size(271, 254);
            this.box_controller.TabIndex = 20;
            this.box_controller.TabStop = false;
            this.box_controller.Text = "Controller";
            this.box_controller.Visible = false;
            // 
            // linklabel_eliminar
            // 
            this.linklabel_eliminar.AutoSize = true;
            this.linklabel_eliminar.Location = new System.Drawing.Point(185, 227);
            this.linklabel_eliminar.Name = "linklabel_eliminar";
            this.linklabel_eliminar.Size = new System.Drawing.Size(43, 13);
            this.linklabel_eliminar.TabIndex = 17;
            this.linklabel_eliminar.TabStop = true;
            this.linklabel_eliminar.Text = "Eliminar";
            this.linklabel_eliminar.Visible = false;
            this.linklabel_eliminar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_eliminar_LinkClicked);
            // 
            // box_error_cliente
            // 
            this.box_error_cliente.AutoSize = true;
            this.box_error_cliente.ForeColor = System.Drawing.Color.Red;
            this.box_error_cliente.Location = new System.Drawing.Point(46, 123);
            this.box_error_cliente.Name = "box_error_cliente";
            this.box_error_cliente.Size = new System.Drawing.Size(104, 13);
            this.box_error_cliente.TabIndex = 16;
            this.box_error_cliente.Text = "*ERROR: Incorrecto";
            this.box_error_cliente.Visible = false;
            // 
            // box_text_lugar
            // 
            this.box_text_lugar.Location = new System.Drawing.Point(159, 193);
            this.box_text_lugar.Name = "box_text_lugar";
            this.box_text_lugar.Size = new System.Drawing.Size(99, 20);
            this.box_text_lugar.TabIndex = 15;
            // 
            // box_combo_veterinario
            // 
            this.box_combo_veterinario.FormattingEnabled = true;
            this.box_combo_veterinario.Location = new System.Drawing.Point(6, 192);
            this.box_combo_veterinario.Name = "box_combo_veterinario";
            this.box_combo_veterinario.Size = new System.Drawing.Size(140, 21);
            this.box_combo_veterinario.TabIndex = 14;
            // 
            // box_combo_mascotas
            // 
            this.box_combo_mascotas.FormattingEnabled = true;
            this.box_combo_mascotas.Location = new System.Drawing.Point(159, 139);
            this.box_combo_mascotas.Name = "box_combo_mascotas";
            this.box_combo_mascotas.Size = new System.Drawing.Size(99, 21);
            this.box_combo_mascotas.TabIndex = 13;
            // 
            // box_text_cliente
            // 
            this.box_text_cliente.Location = new System.Drawing.Point(6, 139);
            this.box_text_cliente.Name = "box_text_cliente";
            this.box_text_cliente.Size = new System.Drawing.Size(140, 20);
            this.box_text_cliente.TabIndex = 12;
            this.box_text_cliente.TextChanged += new System.EventHandler(this.box_text_cliente_TextChanged);
            // 
            // box_text_motivo
            // 
            this.box_text_motivo.Location = new System.Drawing.Point(9, 89);
            this.box_text_motivo.Name = "box_text_motivo";
            this.box_text_motivo.Size = new System.Drawing.Size(249, 20);
            this.box_text_motivo.TabIndex = 11;
            // 
            // box_label_save
            // 
            this.box_label_save.AutoSize = true;
            this.box_label_save.Location = new System.Drawing.Point(185, 227);
            this.box_label_save.Name = "box_label_save";
            this.box_label_save.Size = new System.Drawing.Size(45, 13);
            this.box_label_save.TabIndex = 10;
            this.box_label_save.TabStop = true;
            this.box_label_save.Text = "Guardar";
            this.box_label_save.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.box_label_save_LinkClicked);
            // 
            // box_label_lugar
            // 
            this.box_label_lugar.AutoSize = true;
            this.box_label_lugar.Location = new System.Drawing.Point(161, 177);
            this.box_label_lugar.Name = "box_label_lugar";
            this.box_label_lugar.Size = new System.Drawing.Size(37, 13);
            this.box_label_lugar.TabIndex = 9;
            this.box_label_lugar.Text = "Lugar:";
            // 
            // box_label_veterinario
            // 
            this.box_label_veterinario.AutoSize = true;
            this.box_label_veterinario.Location = new System.Drawing.Point(3, 176);
            this.box_label_veterinario.Name = "box_label_veterinario";
            this.box_label_veterinario.Size = new System.Drawing.Size(60, 13);
            this.box_label_veterinario.TabIndex = 8;
            this.box_label_veterinario.Text = "Veterinario:";
            // 
            // box_label_mascota
            // 
            this.box_label_mascota.AutoSize = true;
            this.box_label_mascota.Location = new System.Drawing.Point(156, 123);
            this.box_label_mascota.Name = "box_label_mascota";
            this.box_label_mascota.Size = new System.Drawing.Size(51, 13);
            this.box_label_mascota.TabIndex = 7;
            this.box_label_mascota.Text = "Mascota:";
            // 
            // box_label_cliente
            // 
            this.box_label_cliente.AutoSize = true;
            this.box_label_cliente.Location = new System.Drawing.Point(6, 123);
            this.box_label_cliente.Name = "box_label_cliente";
            this.box_label_cliente.Size = new System.Drawing.Size(42, 13);
            this.box_label_cliente.TabIndex = 6;
            this.box_label_cliente.Text = "Cliente:";
            // 
            // box_label_motivo
            // 
            this.box_label_motivo.AutoSize = true;
            this.box_label_motivo.Location = new System.Drawing.Point(6, 72);
            this.box_label_motivo.Name = "box_label_motivo";
            this.box_label_motivo.Size = new System.Drawing.Size(42, 13);
            this.box_label_motivo.TabIndex = 5;
            this.box_label_motivo.Text = "Motivo:";
            // 
            // box_label_hora
            // 
            this.box_label_hora.AutoSize = true;
            this.box_label_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_label_hora.Location = new System.Drawing.Point(165, 23);
            this.box_label_hora.Name = "box_label_hora";
            this.box_label_hora.Size = new System.Drawing.Size(33, 13);
            this.box_label_hora.TabIndex = 4;
            this.box_label_hora.Text = "Hora:";
            // 
            // box_label_fecha
            // 
            this.box_label_fecha.AutoSize = true;
            this.box_label_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_label_fecha.Location = new System.Drawing.Point(8, 23);
            this.box_label_fecha.Name = "box_label_fecha";
            this.box_label_fecha.Size = new System.Drawing.Size(40, 13);
            this.box_label_fecha.TabIndex = 3;
            this.box_label_fecha.Text = "Fecha:";
            // 
            // box_combo_hora
            // 
            this.box_combo_hora.FormattingEnabled = true;
            this.box_combo_hora.Location = new System.Drawing.Point(168, 39);
            this.box_combo_hora.Name = "box_combo_hora";
            this.box_combo_hora.Size = new System.Drawing.Size(75, 21);
            this.box_combo_hora.TabIndex = 2;
            this.box_combo_hora.SelectedIndexChanged += new System.EventHandler(this.box_combo_hora_SelectedIndexChanged);
            // 
            // box_text_fecha
            // 
            this.box_text_fecha.Location = new System.Drawing.Point(9, 39);
            this.box_text_fecha.Name = "box_text_fecha";
            this.box_text_fecha.Size = new System.Drawing.Size(144, 20);
            this.box_text_fecha.TabIndex = 1;
            // 
            // box_controller_cancel
            // 
            this.box_controller_cancel.AutoSize = true;
            this.box_controller_cancel.Location = new System.Drawing.Point(37, 227);
            this.box_controller_cancel.Name = "box_controller_cancel";
            this.box_controller_cancel.Size = new System.Drawing.Size(49, 13);
            this.box_controller_cancel.TabIndex = 0;
            this.box_controller_cancel.TabStop = true;
            this.box_controller_cancel.Text = "Cancelar";
            this.box_controller_cancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.box_controller_cancel_LinkClicked);
            // 
            // image_add
            // 
            this.image_add.BackColor = System.Drawing.Color.White;
            this.image_add.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.add;
            this.image_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.image_add.Location = new System.Drawing.Point(609, 219);
            this.image_add.Name = "image_add";
            this.image_add.Size = new System.Drawing.Size(16, 16);
            this.image_add.TabIndex = 22;
            this.image_add.TabStop = false;
            this.image_add.Click += new System.EventHandler(this.image_add_Click);
            // 
            // image_del
            // 
            this.image_del.BackColor = System.Drawing.Color.White;
            this.image_del.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.delete;
            this.image_del.Location = new System.Drawing.Point(653, 219);
            this.image_del.Name = "image_del";
            this.image_del.Size = new System.Drawing.Size(16, 16);
            this.image_del.TabIndex = 23;
            this.image_del.TabStop = false;
            this.image_del.Click += new System.EventHandler(this.image_del_Click);
            // 
            // image_mod
            // 
            this.image_mod.BackColor = System.Drawing.Color.White;
            this.image_mod.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.mod;
            this.image_mod.Location = new System.Drawing.Point(631, 219);
            this.image_mod.Name = "image_mod";
            this.image_mod.Size = new System.Drawing.Size(16, 16);
            this.image_mod.TabIndex = 24;
            this.image_mod.TabStop = false;
            this.image_mod.Click += new System.EventHandler(this.image_mod_Click);
            // 
            // treeViewConsultas
            // 
            this.treeViewConsultas.Location = new System.Drawing.Point(12, 241);
            this.treeViewConsultas.Name = "treeViewConsultas";
            this.treeViewConsultas.Size = new System.Drawing.Size(657, 228);
            this.treeViewConsultas.TabIndex = 9;
            this.treeViewConsultas.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewConsultas_AfterSelect);
            // 
            // alerta_eliminar
            // 
            this.alerta_eliminar.Controls.Add(this.label1);
            this.alerta_eliminar.Controls.Add(this.btn_eliminar_no);
            this.alerta_eliminar.Controls.Add(this.btn_eliminar_si);
            this.alerta_eliminar.Location = new System.Drawing.Point(170, 298);
            this.alerta_eliminar.Name = "alerta_eliminar";
            this.alerta_eliminar.Size = new System.Drawing.Size(200, 67);
            this.alerta_eliminar.TabIndex = 26;
            this.alerta_eliminar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Eliminar Consulta?";
            // 
            // btn_eliminar_no
            // 
            this.btn_eliminar_no.Location = new System.Drawing.Point(104, 35);
            this.btn_eliminar_no.Name = "btn_eliminar_no";
            this.btn_eliminar_no.Size = new System.Drawing.Size(41, 23);
            this.btn_eliminar_no.TabIndex = 1;
            this.btn_eliminar_no.Text = "No";
            this.btn_eliminar_no.UseVisualStyleBackColor = true;
            this.btn_eliminar_no.Click += new System.EventHandler(this.btn_eliminar_no_Click);
            // 
            // btn_eliminar_si
            // 
            this.btn_eliminar_si.Location = new System.Drawing.Point(151, 35);
            this.btn_eliminar_si.Name = "btn_eliminar_si";
            this.btn_eliminar_si.Size = new System.Drawing.Size(38, 23);
            this.btn_eliminar_si.TabIndex = 0;
            this.btn_eliminar_si.Text = "Si";
            this.btn_eliminar_si.UseVisualStyleBackColor = true;
            this.btn_eliminar_si.Click += new System.EventHandler(this.btn_eliminar_si_Click);
            // 
            // log_photo
            // 
            this.log_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.log_photo.ErrorImage = null;
            this.log_photo.Image = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.log_photo.InitialImage = null;
            this.log_photo.Location = new System.Drawing.Point(12, 37);
            this.log_photo.Name = "log_photo";
            this.log_photo.Size = new System.Drawing.Size(90, 120);
            this.log_photo.TabIndex = 58;
            this.log_photo.TabStop = false;
            // 
            // log_date
            // 
            this.log_date.AutoSize = true;
            this.log_date.BackColor = System.Drawing.Color.Transparent;
            this.log_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_date.Location = new System.Drawing.Point(108, 137);
            this.log_date.Name = "log_date";
            this.log_date.Size = new System.Drawing.Size(49, 20);
            this.log_date.TabIndex = 57;
            this.log_date.Text = "fecha";
            // 
            // log_type
            // 
            this.log_type.AutoSize = true;
            this.log_type.BackColor = System.Drawing.Color.Transparent;
            this.log_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_type.Location = new System.Drawing.Point(108, 105);
            this.log_type.Name = "log_type";
            this.log_type.Size = new System.Drawing.Size(35, 20);
            this.log_type.TabIndex = 56;
            this.log_type.Text = "tipo";
            // 
            // log_id
            // 
            this.log_id.AutoSize = true;
            this.log_id.BackColor = System.Drawing.Color.Transparent;
            this.log_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_id.Location = new System.Drawing.Point(108, 72);
            this.log_id.Name = "log_id";
            this.log_id.Size = new System.Drawing.Size(55, 20);
            this.log_id.TabIndex = 55;
            this.log_id.Text = "sesion";
            // 
            // log_name
            // 
            this.log_name.AutoSize = true;
            this.log_name.BackColor = System.Drawing.Color.Transparent;
            this.log_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_name.Location = new System.Drawing.Point(108, 37);
            this.log_name.Name = "log_name";
            this.log_name.Size = new System.Drawing.Size(63, 20);
            this.log_name.TabIndex = 54;
            this.log_name.Text = "nombre";
            // 
            // FormConsultaRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fondo_nuevo;
            this.ClientSize = new System.Drawing.Size(682, 483);
            this.Controls.Add(this.log_photo);
            this.Controls.Add(this.log_date);
            this.Controls.Add(this.log_type);
            this.Controls.Add(this.log_id);
            this.Controls.Add(this.log_name);
            this.Controls.Add(this.alerta_eliminar);
            this.Controls.Add(this.image_mod);
            this.Controls.Add(this.image_del);
            this.Controls.Add(this.image_add);
            this.Controls.Add(this.box_controller);
            this.Controls.Add(this.label_error_fecha);
            this.Controls.Add(this.btnBuscar_Fecha);
            this.Controls.Add(this.datetime_init);
            this.Controls.Add(this.datetime_fin);
            this.Controls.Add(this.treeViewConsultas);
            this.Name = "FormConsultaRecepcionista";
            this.Text = "FormAddConsulta";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.box_controller.ResumeLayout(false);
            this.box_controller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_del)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_mod)).EndInit();
            this.alerta_eliminar.ResumeLayout(false);
            this.alerta_eliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker datetime_fin;
        public System.Windows.Forms.DateTimePicker datetime_init;
        public System.Windows.Forms.Button btnBuscar_Fecha;
        public System.Windows.Forms.Label label_error_fecha;
        public System.Windows.Forms.GroupBox box_controller;
        public System.Windows.Forms.LinkLabel box_controller_cancel;
        public System.Windows.Forms.TextBox box_text_fecha;
        public System.Windows.Forms.Label box_label_hora;
        public System.Windows.Forms.Label box_label_fecha;
        public System.Windows.Forms.ComboBox box_combo_hora;
        public System.Windows.Forms.Label box_label_lugar;
        public System.Windows.Forms.Label box_label_veterinario;
        public System.Windows.Forms.Label box_label_mascota;
        public System.Windows.Forms.Label box_label_cliente;
        public System.Windows.Forms.Label box_label_motivo;
        public System.Windows.Forms.LinkLabel box_label_save;
        public System.Windows.Forms.TextBox box_text_lugar;
        public System.Windows.Forms.ComboBox box_combo_veterinario;
        public System.Windows.Forms.ComboBox box_combo_mascotas;
        public System.Windows.Forms.TextBox box_text_cliente;
        public System.Windows.Forms.TextBox box_text_motivo;
        public System.Windows.Forms.Label box_error_cliente;
        public System.Windows.Forms.PictureBox image_add;
        public System.Windows.Forms.PictureBox image_del;
        public System.Windows.Forms.PictureBox image_mod;
        public System.Windows.Forms.TreeView treeViewConsultas;
        public System.Windows.Forms.Panel alerta_eliminar;
        public System.Windows.Forms.Button btn_eliminar_no;
        public System.Windows.Forms.Button btn_eliminar_si;
        public System.Windows.Forms.LinkLabel linklabel_eliminar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox log_photo;
        public System.Windows.Forms.Label log_date;
        public System.Windows.Forms.Label log_type;
        public System.Windows.Forms.Label log_id;
        public System.Windows.Forms.Label log_name;
    }
}