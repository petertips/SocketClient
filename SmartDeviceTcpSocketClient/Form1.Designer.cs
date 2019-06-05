namespace SmartDeviceTcpSocketClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtBoxMensaje = new System.Windows.Forms.TextBox();
            this.listBoxRespuesta = new System.Windows.Forms.ListBox();
            this.lblConStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(34, 13);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(72, 20);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(131, 13);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(84, 20);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(143, 84);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(72, 20);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(155, 236);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 20);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.Location = new System.Drawing.Point(6, 60);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(100, 20);
            this.lblTexto.Text = "Entrar Texto";
            // 
            // txtBoxMensaje
            // 
            this.txtBoxMensaje.Location = new System.Drawing.Point(6, 83);
            this.txtBoxMensaje.Name = "txtBoxMensaje";
            this.txtBoxMensaje.Size = new System.Drawing.Size(131, 21);
            this.txtBoxMensaje.TabIndex = 5;
            // 
            // listBoxRespuesta
            // 
            this.listBoxRespuesta.Location = new System.Drawing.Point(6, 120);
            this.listBoxRespuesta.Name = "listBoxRespuesta";
            this.listBoxRespuesta.Size = new System.Drawing.Size(221, 100);
            this.listBoxRespuesta.TabIndex = 6;
            // 
            // lblConStatus
            // 
            this.lblConStatus.Location = new System.Drawing.Point(6, 236);
            this.lblConStatus.Name = "lblConStatus";
            this.lblConStatus.Size = new System.Drawing.Size(131, 67);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lblConStatus);
            this.Controls.Add(this.listBoxRespuesta);
            this.Controls.Add(this.txtBoxMensaje);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtBoxMensaje;
        private System.Windows.Forms.ListBox listBoxRespuesta;
        private System.Windows.Forms.Label lblConStatus;
    }
}

