﻿namespace WindowsFormsApplication1
{
    partial class FormAddEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEmpleado));
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_dni = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_apellidos = new System.Windows.Forms.TextBox();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.tb_localidad = new System.Windows.Forms.TextBox();
            this.tb_provincia = new System.Windows.Forms.TextBox();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_confPass = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_sueldo = new System.Windows.Forms.TextBox();
            this.err_dni = new System.Windows.Forms.Label();
            this.err_nom = new System.Windows.Forms.Label();
            this.err_id = new System.Windows.Forms.Label();
            this.err_apellidos = new System.Windows.Forms.Label();
            this.err_pas = new System.Windows.Forms.Label();
            this.err_direccion = new System.Windows.Forms.Label();
            this.err_sueldo = new System.Windows.Forms.Label();
            this.err_tel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.err_add = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 651);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 101);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tb_dni
            // 
            this.tb_dni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_dni.Location = new System.Drawing.Point(231, 137);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.Size = new System.Drawing.Size(163, 20);
            this.tb_dni.TabIndex = 5;
            this.tb_dni.TextChanged += new System.EventHandler(this.tb_dni_TextChanged);
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(231, 176);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(163, 20);
            this.tb_nombre.TabIndex = 6;
            // 
            // tb_apellidos
            // 
            this.tb_apellidos.Location = new System.Drawing.Point(147, 266);
            this.tb_apellidos.Name = "tb_apellidos";
            this.tb_apellidos.Size = new System.Drawing.Size(247, 20);
            this.tb_apellidos.TabIndex = 7;
            // 
            // tb_direccion
            // 
            this.tb_direccion.Location = new System.Drawing.Point(147, 394);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(247, 20);
            this.tb_direccion.TabIndex = 8;
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(231, 485);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(163, 20);
            this.tb_tel.TabIndex = 9;
            // 
            // tb_localidad
            // 
            this.tb_localidad.Location = new System.Drawing.Point(231, 531);
            this.tb_localidad.Name = "tb_localidad";
            this.tb_localidad.Size = new System.Drawing.Size(163, 20);
            this.tb_localidad.TabIndex = 10;
            // 
            // tb_provincia
            // 
            this.tb_provincia.Location = new System.Drawing.Point(231, 560);
            this.tb_provincia.Name = "tb_provincia";
            this.tb_provincia.Size = new System.Drawing.Size(163, 20);
            this.tb_provincia.TabIndex = 11;
            this.tb_provincia.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // tb_cp
            // 
            this.tb_cp.Location = new System.Drawing.Point(231, 590);
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.Size = new System.Drawing.Size(163, 20);
            this.tb_cp.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(42, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Apellidos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(42, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Teléfono:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Localidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(42, 564);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Provincia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(42, 594);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "CP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(42, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Repita Password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(42, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Password:";
            // 
            // tb_confPass
            // 
            this.tb_confPass.Location = new System.Drawing.Point(231, 345);
            this.tb_confPass.Name = "tb_confPass";
            this.tb_confPass.Size = new System.Drawing.Size(163, 20);
            this.tb_confPass.TabIndex = 22;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(231, 314);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(163, 20);
            this.tb_pass.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(42, 597);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 25;
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(66, 651);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_aceptar.TabIndex = 27;
            this.bt_aceptar.Text = "ACEPTAR";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Id Empleado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(231, 218);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(163, 20);
            this.tb_id.TabIndex = 28;
            this.tb_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(42, 446);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Sueldo:";
            // 
            // tb_sueldo
            // 
            this.tb_sueldo.Location = new System.Drawing.Point(231, 442);
            this.tb_sueldo.Name = "tb_sueldo";
            this.tb_sueldo.Size = new System.Drawing.Size(163, 20);
            this.tb_sueldo.TabIndex = 31;
            this.tb_sueldo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // err_dni
            // 
            this.err_dni.AutoSize = true;
            this.err_dni.ForeColor = System.Drawing.Color.Red;
            this.err_dni.Location = new System.Drawing.Point(239, 160);
            this.err_dni.Name = "err_dni";
            this.err_dni.Size = new System.Drawing.Size(97, 13);
            this.err_dni.TabIndex = 34;
            this.err_dni.Text = "* Datos incorrectos";
            this.err_dni.Visible = false;
            // 
            // err_nom
            // 
            this.err_nom.AutoSize = true;
            this.err_nom.ForeColor = System.Drawing.Color.Red;
            this.err_nom.Location = new System.Drawing.Point(239, 199);
            this.err_nom.Name = "err_nom";
            this.err_nom.Size = new System.Drawing.Size(97, 13);
            this.err_nom.TabIndex = 40;
            this.err_nom.Text = "* Datos incorrectos";
            this.err_nom.Visible = false;
            // 
            // err_id
            // 
            this.err_id.AutoSize = true;
            this.err_id.ForeColor = System.Drawing.Color.Red;
            this.err_id.Location = new System.Drawing.Point(239, 241);
            this.err_id.Name = "err_id";
            this.err_id.Size = new System.Drawing.Size(97, 13);
            this.err_id.TabIndex = 41;
            this.err_id.Text = "* Datos incorrectos";
            this.err_id.Visible = false;
            // 
            // err_apellidos
            // 
            this.err_apellidos.AutoSize = true;
            this.err_apellidos.ForeColor = System.Drawing.Color.Red;
            this.err_apellidos.Location = new System.Drawing.Point(239, 289);
            this.err_apellidos.Name = "err_apellidos";
            this.err_apellidos.Size = new System.Drawing.Size(97, 13);
            this.err_apellidos.TabIndex = 42;
            this.err_apellidos.Text = "* Datos incorrectos";
            this.err_apellidos.Visible = false;
            // 
            // err_pas
            // 
            this.err_pas.AutoSize = true;
            this.err_pas.ForeColor = System.Drawing.Color.Red;
            this.err_pas.Location = new System.Drawing.Point(239, 368);
            this.err_pas.Name = "err_pas";
            this.err_pas.Size = new System.Drawing.Size(97, 13);
            this.err_pas.TabIndex = 43;
            this.err_pas.Text = "* Datos incorrectos";
            this.err_pas.Visible = false;
            // 
            // err_direccion
            // 
            this.err_direccion.AutoSize = true;
            this.err_direccion.ForeColor = System.Drawing.Color.Red;
            this.err_direccion.Location = new System.Drawing.Point(239, 417);
            this.err_direccion.Name = "err_direccion";
            this.err_direccion.Size = new System.Drawing.Size(97, 13);
            this.err_direccion.TabIndex = 44;
            this.err_direccion.Text = "* Datos incorrectos";
            this.err_direccion.Visible = false;
            // 
            // err_sueldo
            // 
            this.err_sueldo.AutoSize = true;
            this.err_sueldo.ForeColor = System.Drawing.Color.Red;
            this.err_sueldo.Location = new System.Drawing.Point(239, 465);
            this.err_sueldo.Name = "err_sueldo";
            this.err_sueldo.Size = new System.Drawing.Size(97, 13);
            this.err_sueldo.TabIndex = 45;
            this.err_sueldo.Text = "* Datos incorrectos";
            this.err_sueldo.Visible = false;
            // 
            // err_tel
            // 
            this.err_tel.AutoSize = true;
            this.err_tel.ForeColor = System.Drawing.Color.Red;
            this.err_tel.Location = new System.Drawing.Point(239, 508);
            this.err_tel.Name = "err_tel";
            this.err_tel.Size = new System.Drawing.Size(97, 13);
            this.err_tel.TabIndex = 46;
            this.err_tel.Text = "* Datos incorrectos";
            this.err_tel.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(144, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(236, 16);
            this.label14.TabIndex = 47;
            this.label14.Text = "Nuevo Empleado: Recepcionista";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // err_add
            // 
            this.err_add.AutoSize = true;
            this.err_add.BackColor = System.Drawing.Color.Transparent;
            this.err_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.err_add.ForeColor = System.Drawing.Color.Red;
            this.err_add.Location = new System.Drawing.Point(41, 632);
            this.err_add.Name = "err_add";
            this.err_add.Size = new System.Drawing.Size(218, 16);
            this.err_add.TabIndex = 48;
            this.err_add.Text = "*Error al Añadir Recepcionista";
            this.err_add.Visible = false;
            // 
            // FormAddEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(438, 702);
            this.ControlBox = false;
            this.Controls.Add(this.err_add);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.err_tel);
            this.Controls.Add(this.err_sueldo);
            this.Controls.Add(this.err_direccion);
            this.Controls.Add(this.err_pas);
            this.Controls.Add(this.err_apellidos);
            this.Controls.Add(this.err_id);
            this.Controls.Add(this.err_nom);
            this.Controls.Add(this.err_dni);
            this.Controls.Add(this.tb_sueldo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_confPass);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cp);
            this.Controls.Add(this.tb_provincia);
            this.Controls.Add(this.tb_localidad);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_direccion);
            this.Controls.Add(this.tb_apellidos);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_dni);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEmpleado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormAddEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_dni;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_apellidos;
        private System.Windows.Forms.TextBox tb_direccion;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_localidad;
        private System.Windows.Forms.TextBox tb_provincia;
        private System.Windows.Forms.TextBox tb_cp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_confPass;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_sueldo;
        private System.Windows.Forms.Label err_dni;
        private System.Windows.Forms.Label err_nom;
        private System.Windows.Forms.Label err_id;
        private System.Windows.Forms.Label err_apellidos;
        private System.Windows.Forms.Label err_pas;
        private System.Windows.Forms.Label err_direccion;
        private System.Windows.Forms.Label err_sueldo;
        private System.Windows.Forms.Label err_tel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label err_add;
    }
}