﻿namespace WindowsFormsApplication1
{
    partial class FormVeterinarioInicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.log_date = new System.Windows.Forms.Label();
            this.log_type = new System.Windows.Forms.Label();
            this.log_id = new System.Windows.Forms.Label();
            this.log_name = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.label_fecha_consulta = new System.Windows.Forms.Label();
            this.dataGrid_consultas = new System.Windows.Forms.DataGridView();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.picture_desconectar_veterinario = new System.Windows.Forms.PictureBox();
            this.picture_consulta_veterinario = new System.Windows.Forms.PictureBox();
            this.picture_inicio_veterinario = new System.Windows.Forms.PictureBox();
            this.log_photo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_consultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_desconectar_veterinario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consulta_veterinario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_inicio_veterinario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // log_date
            // 
            this.log_date.AutoSize = true;
            this.log_date.BackColor = System.Drawing.Color.Transparent;
            this.log_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_date.Location = new System.Drawing.Point(108, 154);
            this.log_date.Name = "log_date";
            this.log_date.Size = new System.Drawing.Size(51, 20);
            this.log_date.TabIndex = 46;
            this.log_date.Text = "label4";
            // 
            // log_type
            // 
            this.log_type.AutoSize = true;
            this.log_type.BackColor = System.Drawing.Color.Transparent;
            this.log_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_type.Location = new System.Drawing.Point(108, 122);
            this.log_type.Name = "log_type";
            this.log_type.Size = new System.Drawing.Size(51, 20);
            this.log_type.TabIndex = 45;
            this.log_type.Text = "label3";
            // 
            // log_id
            // 
            this.log_id.AutoSize = true;
            this.log_id.BackColor = System.Drawing.Color.Transparent;
            this.log_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_id.Location = new System.Drawing.Point(108, 89);
            this.log_id.Name = "log_id";
            this.log_id.Size = new System.Drawing.Size(51, 20);
            this.log_id.TabIndex = 44;
            this.log_id.Text = "label2";
            // 
            // log_name
            // 
            this.log_name.AutoSize = true;
            this.log_name.BackColor = System.Drawing.Color.Transparent;
            this.log_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_name.Location = new System.Drawing.Point(108, 54);
            this.log_name.Name = "log_name";
            this.log_name.Size = new System.Drawing.Size(51, 20);
            this.log_name.TabIndex = 43;
            this.log_name.Text = "label1";
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.Color.Gainsboro;
            this.Calendar.Location = new System.Drawing.Point(312, 54);
            this.Calendar.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.Calendar.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 47;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // label_fecha_consulta
            // 
            this.label_fecha_consulta.AutoSize = true;
            this.label_fecha_consulta.BackColor = System.Drawing.Color.Transparent;
            this.label_fecha_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha_consulta.Location = new System.Drawing.Point(12, 189);
            this.label_fecha_consulta.Name = "label_fecha_consulta";
            this.label_fecha_consulta.Size = new System.Drawing.Size(51, 20);
            this.label_fecha_consulta.TabIndex = 48;
            this.label_fecha_consulta.Text = "label5";
            // 
            // dataGrid_consultas
            // 
            this.dataGrid_consultas.AllowUserToAddRows = false;
            this.dataGrid_consultas.AllowUserToDeleteRows = false;
            this.dataGrid_consultas.AllowUserToResizeRows = false;
            this.dataGrid_consultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_consultas.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_consultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora,
            this.Raza,
            this.Especie,
            this.Motivo,
            this.Lugar,
            this.Ver});
            this.dataGrid_consultas.GridColor = System.Drawing.SystemColors.Control;
            this.dataGrid_consultas.Location = new System.Drawing.Point(12, 230);
            this.dataGrid_consultas.Name = "dataGrid_consultas";
            this.dataGrid_consultas.ReadOnly = true;
            this.dataGrid_consultas.RowHeadersVisible = false;
            this.dataGrid_consultas.Size = new System.Drawing.Size(658, 240);
            this.dataGrid_consultas.TabIndex = 49;
            this.dataGrid_consultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_consultas_CellContentClick);
            this.dataGrid_consultas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.CellPainting_veterinario);
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Raza
            // 
            this.Raza.HeaderText = "Raza";
            this.Raza.Name = "Raza";
            this.Raza.ReadOnly = true;
            // 
            // Especie
            // 
            this.Especie.HeaderText = "Especie";
            this.Especie.Name = "Especie";
            this.Especie.ReadOnly = true;
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            // 
            // Lugar
            // 
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.Name = "Lugar";
            this.Lugar.ReadOnly = true;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // picture_desconectar_veterinario
            // 
            this.picture_desconectar_veterinario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
//            this.picture_desconectar_veterinario.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.desconectar;
            this.picture_desconectar_veterinario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_desconectar_veterinario.Location = new System.Drawing.Point(506, 0);
            this.picture_desconectar_veterinario.Name = "picture_desconectar_veterinario";
            this.picture_desconectar_veterinario.Size = new System.Drawing.Size(165, 34);
            this.picture_desconectar_veterinario.TabIndex = 52;
            this.picture_desconectar_veterinario.TabStop = false;
            this.picture_desconectar_veterinario.Click += new System.EventHandler(this.picture_ajustes_veterinario_Click);
            // 
            // picture_consulta_veterinario
            // 
//            this.picture_consulta_veterinario.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.consulta;
            this.picture_consulta_veterinario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_consulta_veterinario.Location = new System.Drawing.Point(257, 0);
            this.picture_consulta_veterinario.Name = "picture_consulta_veterinario";
            this.picture_consulta_veterinario.Size = new System.Drawing.Size(165, 34);
            this.picture_consulta_veterinario.TabIndex = 51;
            this.picture_consulta_veterinario.TabStop = false;
            this.picture_consulta_veterinario.Click += new System.EventHandler(this.picture_consulta_veterinario_Click);
            // 
            // picture_inicio_veterinario
            // 
//            this.picture_inicio_veterinario.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.home;
            this.picture_inicio_veterinario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picture_inicio_veterinario.Location = new System.Drawing.Point(9, 0);
            this.picture_inicio_veterinario.Name = "picture_inicio_veterinario";
            this.picture_inicio_veterinario.Size = new System.Drawing.Size(165, 34);
            this.picture_inicio_veterinario.TabIndex = 50;
            this.picture_inicio_veterinario.TabStop = false;
            this.picture_inicio_veterinario.Click += new System.EventHandler(this.picture_inicio_veterinario_Click);
            // 
            // log_photo
            // 
            this.log_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log_photo.Image = global::WindowsFormsApplication1.Properties.Resources.sinFoto;
            this.log_photo.Location = new System.Drawing.Point(12, 54);
            this.log_photo.Name = "log_photo";
            this.log_photo.Size = new System.Drawing.Size(90, 120);
            this.log_photo.TabIndex = 42;
            this.log_photo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.picture_inicio_veterinario);
            this.panel1.Controls.Add(this.picture_consulta_veterinario);
            this.panel1.Controls.Add(this.picture_desconectar_veterinario);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 34);
            this.panel1.TabIndex = 56;
            // 
            // FormVeterinarioInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
//            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.FONDO_VETERINARIA_blanco_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(682, 476);
            this.Controls.Add(this.dataGrid_consultas);
            this.Controls.Add(this.label_fecha_consulta);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.log_date);
            this.Controls.Add(this.log_type);
            this.Controls.Add(this.log_id);
            this.Controls.Add(this.log_name);
            this.Controls.Add(this.log_photo);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormVeterinarioInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStartVeterinario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_consultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_desconectar_veterinario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_consulta_veterinario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_inicio_veterinario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.log_photo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label log_date;
        public System.Windows.Forms.Label log_type;
        public System.Windows.Forms.Label log_id;
        public System.Windows.Forms.Label log_name;
        public System.Windows.Forms.PictureBox log_photo;
        public System.Windows.Forms.MonthCalendar Calendar;
        public System.Windows.Forms.Label label_fecha_consulta;
        public System.Windows.Forms.DataGridView dataGrid_consultas;
        private System.Windows.Forms.PictureBox picture_inicio_veterinario;
        private System.Windows.Forms.PictureBox picture_consulta_veterinario;
        private System.Windows.Forms.PictureBox picture_desconectar_veterinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.Panel panel1;
    }
}