namespace GRUPO8_VS1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.btniniciosesion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 62);
            this.panel1.TabIndex = 0;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnsalir.Location = new System.Drawing.Point(662, 7);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(56, 62);
            this.btnsalir.TabIndex = 0;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblusuario.Location = new System.Drawing.Point(79, 246);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(87, 24);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Usuario:";
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.BackColor = System.Drawing.Color.Transparent;
            this.lblcontrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontrasena.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblcontrasena.Location = new System.Drawing.Point(79, 303);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(122, 24);
            this.lblcontrasena.TabIndex = 3;
            this.lblcontrasena.Text = "Contraseña:";
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.GreenYellow;
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(86, 273);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(166, 15);
            this.txtusuario.TabIndex = 4;
            this.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.BackColor = System.Drawing.Color.GreenYellow;
            this.txtcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontrasena.Location = new System.Drawing.Point(86, 330);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(166, 15);
            this.txtcontrasena.TabIndex = 5;
            this.txtcontrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcontrasena.UseSystemPasswordChar = true;
            // 
            // btniniciosesion
            // 
            this.btniniciosesion.BackColor = System.Drawing.Color.YellowGreen;
            this.btniniciosesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciosesion.ForeColor = System.Drawing.Color.DarkGreen;
            this.btniniciosesion.Location = new System.Drawing.Point(196, 400);
            this.btniniciosesion.Name = "btniniciosesion";
            this.btniniciosesion.Size = new System.Drawing.Size(145, 51);
            this.btniniciosesion.TabIndex = 6;
            this.btniniciosesion.Text = "INGRESAR";
            this.btniniciosesion.UseVisualStyleBackColor = false;
            this.btniniciosesion.Click += new System.EventHandler(this.btniniciosesion_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(387, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "CREAR CUENTA";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btniniciosesion);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblcontrasena);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Button btniniciosesion;
        private System.Windows.Forms.Button button1;
    }
}

