
namespace Estetica
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Salir = new System.Windows.Forms.Button();
            this.Citas = new System.Windows.Forms.Button();
            this.Trabajos = new System.Windows.Forms.Button();
            this.Conexion = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Inicio_de_sesion = new System.Windows.Forms.Button();
            this.Bitacora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Salir.FlatAppearance.BorderSize = 2;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Salir.Location = new System.Drawing.Point(12, 451);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(137, 46);
            this.Salir.TabIndex = 0;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Citas
            // 
            this.Citas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Citas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Citas.FlatAppearance.BorderSize = 2;
            this.Citas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Citas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Citas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Citas.Location = new System.Drawing.Point(419, 428);
            this.Citas.Name = "Citas";
            this.Citas.Size = new System.Drawing.Size(137, 46);
            this.Citas.TabIndex = 1;
            this.Citas.Text = "Citas";
            this.Citas.UseVisualStyleBackColor = false;
            this.Citas.Click += new System.EventHandler(this.Citas_Click);
            // 
            // Trabajos
            // 
            this.Trabajos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Trabajos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Trabajos.FlatAppearance.BorderSize = 2;
            this.Trabajos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trabajos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trabajos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Trabajos.Location = new System.Drawing.Point(562, 428);
            this.Trabajos.Name = "Trabajos";
            this.Trabajos.Size = new System.Drawing.Size(137, 46);
            this.Trabajos.TabIndex = 2;
            this.Trabajos.Text = "Trabajos";
            this.Trabajos.UseVisualStyleBackColor = false;
            this.Trabajos.Click += new System.EventHandler(this.Ventas_Click);
            // 
            // Conexion
            // 
            this.Conexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Conexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Conexion.FlatAppearance.BorderSize = 2;
            this.Conexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Conexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Conexion.Location = new System.Drawing.Point(705, 428);
            this.Conexion.Name = "Conexion";
            this.Conexion.Size = new System.Drawing.Size(268, 46);
            this.Conexion.TabIndex = 3;
            this.Conexion.Text = "Verificar conexión";
            this.Conexion.UseVisualStyleBackColor = false;
            this.Conexion.Click += new System.EventHandler(this.Conexion_Click);
            // 
            // Usuario
            // 
            this.Usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(621, 68);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(145, 27);
            this.Usuario.TabIndex = 4;
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            // 
            // Contraseña
            // 
            this.Contraseña.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.Contraseña.Location = new System.Drawing.Point(621, 172);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(145, 27);
            this.Contraseña.TabIndex = 5;
            this.Contraseña.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(617, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(617, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // Inicio_de_sesion
            // 
            this.Inicio_de_sesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Inicio_de_sesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Inicio_de_sesion.FlatAppearance.BorderSize = 2;
            this.Inicio_de_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inicio_de_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicio_de_sesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Inicio_de_sesion.Location = new System.Drawing.Point(624, 227);
            this.Inicio_de_sesion.Name = "Inicio_de_sesion";
            this.Inicio_de_sesion.Size = new System.Drawing.Size(209, 43);
            this.Inicio_de_sesion.TabIndex = 8;
            this.Inicio_de_sesion.Text = "Iniciar sesión";
            this.Inicio_de_sesion.UseVisualStyleBackColor = false;
            this.Inicio_de_sesion.Click += new System.EventHandler(this.Inicio_de_sesion_Click);
            // 
            // Bitacora
            // 
            this.Bitacora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bitacora.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Bitacora.FlatAppearance.BorderSize = 2;
            this.Bitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bitacora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Bitacora.Location = new System.Drawing.Point(276, 428);
            this.Bitacora.Name = "Bitacora";
            this.Bitacora.Size = new System.Drawing.Size(137, 46);
            this.Bitacora.TabIndex = 9;
            this.Bitacora.Text = "Bitacora";
            this.Bitacora.UseVisualStyleBackColor = false;
            this.Bitacora.Visible = false;
            this.Bitacora.Click += new System.EventHandler(this.Bitacora_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(101)))));
            this.BackgroundImage = global::Estetica.Properties.Resources.logo_vanity1_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.Salir;
            this.ClientSize = new System.Drawing.Size(985, 509);
            this.Controls.Add(this.Bitacora);
            this.Controls.Add(this.Inicio_de_sesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Conexion);
            this.Controls.Add(this.Trabajos);
            this.Controls.Add(this.Citas);
            this.Controls.Add(this.Salir);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Citas;
        private System.Windows.Forms.Button Trabajos;
        private System.Windows.Forms.Button Conexion;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Inicio_de_sesion;
        private System.Windows.Forms.Button Bitacora;
    }
}

