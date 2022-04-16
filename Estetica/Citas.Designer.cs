
namespace Estetica
{
    partial class Citas
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
            this.Salir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ingresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Num_tel = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Hora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TipoTrabajo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Modificar_Cita = new System.Windows.Forms.Button();
            this.Eliminar_Cita = new System.Windows.Forms.Button();
            this.ID_Buscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OpModificiar = new System.Windows.Forms.RadioButton();
            this.OpEliminarC = new System.Windows.Forms.RadioButton();
            this.rB_ingresar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Salir.Location = new System.Drawing.Point(26, 533);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(137, 46);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Regresar";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(420, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(931, 531);
            this.dataGridView1.TabIndex = 4;
            // 
            // Ingresar
            // 
            this.Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ingresar.Location = new System.Drawing.Point(26, 476);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(182, 51);
            this.Ingresar.TabIndex = 5;
            this.Ingresar.Text = "Ingresar cita";
            this.Ingresar.UseVisualStyleBackColor = false;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(21, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(21, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(21, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hora";
            // 
            // Num_tel
            // 
            this.Num_tel.Enabled = false;
            this.Num_tel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.Num_tel.Location = new System.Drawing.Point(26, 200);
            this.Num_tel.Name = "Num_tel";
            this.Num_tel.ShortcutsEnabled = false;
            this.Num_tel.Size = new System.Drawing.Size(213, 27);
            this.Num_tel.TabIndex = 13;
            this.Num_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Nom
            // 
            this.Nom.Enabled = false;
            this.Nom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.Nom.Location = new System.Drawing.Point(26, 258);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(329, 27);
            this.Nom.TabIndex = 14;
            this.Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Hora
            // 
            this.Hora.Enabled = false;
            this.Hora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.Hora.Location = new System.Drawing.Point(26, 432);
            this.Hora.MaxLength = 5;
            this.Hora.Name = "Hora";
            this.Hora.ShortcutsEnabled = false;
            this.Hora.Size = new System.Drawing.Size(82, 27);
            this.Hora.TabIndex = 16;
            this.Hora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(21, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Numero de telefono";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 312);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(329, 27);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // TipoTrabajo
            // 
            this.TipoTrabajo.Enabled = false;
            this.TipoTrabajo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.TipoTrabajo.Location = new System.Drawing.Point(26, 374);
            this.TipoTrabajo.Name = "TipoTrabajo";
            this.TipoTrabajo.ShortcutsEnabled = false;
            this.TipoTrabajo.Size = new System.Drawing.Size(278, 27);
            this.TipoTrabajo.TabIndex = 15;
            this.TipoTrabajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(21, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tipo de Trabajo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estetica.Properties.Resources.logo_vanity1_5;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Modificar_Cita
            // 
            this.Modificar_Cita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Modificar_Cita.Enabled = false;
            this.Modificar_Cita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modificar_Cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar_Cita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Modificar_Cita.Location = new System.Drawing.Point(232, 473);
            this.Modificar_Cita.Name = "Modificar_Cita";
            this.Modificar_Cita.Size = new System.Drawing.Size(182, 51);
            this.Modificar_Cita.TabIndex = 20;
            this.Modificar_Cita.Text = "Modificar";
            this.Modificar_Cita.UseVisualStyleBackColor = false;
            this.Modificar_Cita.Click += new System.EventHandler(this.Modificar_Cita_Click);
            // 
            // Eliminar_Cita
            // 
            this.Eliminar_Cita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Eliminar_Cita.Enabled = false;
            this.Eliminar_Cita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar_Cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_Cita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Eliminar_Cita.Location = new System.Drawing.Point(232, 528);
            this.Eliminar_Cita.Name = "Eliminar_Cita";
            this.Eliminar_Cita.Size = new System.Drawing.Size(182, 51);
            this.Eliminar_Cita.TabIndex = 21;
            this.Eliminar_Cita.Text = "Eliminar cita";
            this.Eliminar_Cita.UseVisualStyleBackColor = false;
            this.Eliminar_Cita.Click += new System.EventHandler(this.Eliminar_Cita_Click);
            // 
            // ID_Buscar
            // 
            this.ID_Buscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.ID_Buscar.Location = new System.Drawing.Point(282, 200);
            this.ID_Buscar.Name = "ID_Buscar";
            this.ID_Buscar.Size = new System.Drawing.Size(121, 27);
            this.ID_Buscar.TabIndex = 22;
            this.ID_Buscar.Visible = false;
            this.ID_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(277, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "ID de la cita";
            this.label6.Visible = false;
            // 
            // OpModificiar
            // 
            this.OpModificiar.AutoSize = true;
            this.OpModificiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.OpModificiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OpModificiar.Location = new System.Drawing.Point(245, 407);
            this.OpModificiar.Name = "OpModificiar";
            this.OpModificiar.Size = new System.Drawing.Size(121, 29);
            this.OpModificiar.TabIndex = 24;
            this.OpModificiar.TabStop = true;
            this.OpModificiar.Text = "Modficiar";
            this.OpModificiar.UseVisualStyleBackColor = true;
            this.OpModificiar.CheckedChanged += new System.EventHandler(this.OpModificiar_CheckedChanged);
            // 
            // OpEliminarC
            // 
            this.OpEliminarC.AutoSize = true;
            this.OpEliminarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.OpEliminarC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.OpEliminarC.Location = new System.Drawing.Point(245, 438);
            this.OpEliminarC.Name = "OpEliminarC";
            this.OpEliminarC.Size = new System.Drawing.Size(155, 29);
            this.OpEliminarC.TabIndex = 25;
            this.OpEliminarC.TabStop = true;
            this.OpEliminarC.Text = "Eliminar Cita";
            this.OpEliminarC.UseVisualStyleBackColor = true;
            this.OpEliminarC.CheckedChanged += new System.EventHandler(this.OpEliminarC_CheckedChanged);
            // 
            // rB_ingresar
            // 
            this.rB_ingresar.AutoSize = true;
            this.rB_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rB_ingresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rB_ingresar.Location = new System.Drawing.Point(127, 430);
            this.rB_ingresar.Name = "rB_ingresar";
            this.rB_ingresar.Size = new System.Drawing.Size(112, 29);
            this.rB_ingresar.TabIndex = 26;
            this.rB_ingresar.TabStop = true;
            this.rB_ingresar.Text = "Ingresar";
            this.rB_ingresar.UseVisualStyleBackColor = true;
            this.rB_ingresar.CheckedChanged += new System.EventHandler(this.rB_ingresar_CheckedChanged);
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1372, 589);
            this.Controls.Add(this.rB_ingresar);
            this.Controls.Add(this.OpEliminarC);
            this.Controls.Add(this.OpModificiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ID_Buscar);
            this.Controls.Add(this.Eliminar_Cita);
            this.Controls.Add(this.Modificar_Cita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.TipoTrabajo);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Num_tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Num_tel;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Hora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TipoTrabajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Modificar_Cita;
        private System.Windows.Forms.Button Eliminar_Cita;
        private System.Windows.Forms.TextBox ID_Buscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton OpModificiar;
        private System.Windows.Forms.RadioButton OpEliminarC;
        private System.Windows.Forms.RadioButton rB_ingresar;
    }
}