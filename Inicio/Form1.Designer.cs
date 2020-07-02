namespace Inicio
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            this.lstProgramas = new System.Windows.Forms.ListBox();
            this.tiInicio = new System.Windows.Forms.Timer(this.components);
            this.cdmAgregar = new System.Windows.Forms.Button();
            this.cdmBorrar = new System.Windows.Forms.Button();
            this.cdmCancelar = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.ofdRutas = new System.Windows.Forms.OpenFileDialog();
            this.cdmReanudar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProgramas
            // 
            this.lstProgramas.AccessibleName = "lstprogramas";
            this.lstProgramas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProgramas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProgramas.FormattingEnabled = true;
            this.lstProgramas.Location = new System.Drawing.Point(12, 12);
            this.lstProgramas.Name = "lstProgramas";
            this.lstProgramas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstProgramas.Size = new System.Drawing.Size(504, 221);
            this.lstProgramas.TabIndex = 0;
            this.lstProgramas.SelectedIndexChanged += new System.EventHandler(this.lstProgramas_SelectedIndexChanged);
            // 
            // tiInicio
            // 
            this.tiInicio.Enabled = true;
            this.tiInicio.Interval = 1000;
            this.tiInicio.Tick += new System.EventHandler(this.tiInicio_Tick);
            // 
            // cdmAgregar
            // 
            this.cdmAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cdmAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cdmAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cdmAgregar.Location = new System.Drawing.Point(198, 245);
            this.cdmAgregar.Name = "cdmAgregar";
            this.cdmAgregar.Size = new System.Drawing.Size(75, 23);
            this.cdmAgregar.TabIndex = 1;
            this.cdmAgregar.Text = "&Agregar";
            this.cdmAgregar.UseVisualStyleBackColor = true;
            this.cdmAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cdmBorrar
            // 
            this.cdmBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cdmBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cdmBorrar.Location = new System.Drawing.Point(279, 245);
            this.cdmBorrar.Name = "cdmBorrar";
            this.cdmBorrar.Size = new System.Drawing.Size(75, 23);
            this.cdmBorrar.TabIndex = 2;
            this.cdmBorrar.Text = "&Borrar";
            this.cdmBorrar.UseVisualStyleBackColor = true;
            this.cdmBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // cdmCancelar
            // 
            this.cdmCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cdmCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cdmCancelar.Location = new System.Drawing.Point(441, 245);
            this.cdmCancelar.Name = "cdmCancelar";
            this.cdmCancelar.Size = new System.Drawing.Size(75, 23);
            this.cdmCancelar.TabIndex = 3;
            this.cdmCancelar.Text = "&Cancelar";
            this.cdmCancelar.UseVisualStyleBackColor = true;
            this.cdmCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblContador
            // 
            this.lblContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblContador.Location = new System.Drawing.Point(8, 240);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(29, 21);
            this.lblContador.TabIndex = 5;
            this.lblContador.Text = "5";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ofdRutas
            // 
            this.ofdRutas.Multiselect = true;
            this.ofdRutas.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // cdmReanudar
            // 
            this.cdmReanudar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cdmReanudar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cdmReanudar.Location = new System.Drawing.Point(360, 245);
            this.cdmReanudar.Name = "cdmReanudar";
            this.cdmReanudar.Size = new System.Drawing.Size(75, 23);
            this.cdmReanudar.TabIndex = 6;
            this.cdmReanudar.Text = "&Reanudar";
            this.cdmReanudar.UseVisualStyleBackColor = true;
            this.cdmReanudar.Click += new System.EventHandler(this.cdmReanudar_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 280);
            this.Controls.Add(this.cdmReanudar);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.cdmCancelar);
            this.Controls.Add(this.cdmBorrar);
            this.Controls.Add(this.cdmAgregar);
            this.Controls.Add(this.lstProgramas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProgramas;
        private System.Windows.Forms.Timer tiInicio;
        private System.Windows.Forms.Button cdmAgregar;
        private System.Windows.Forms.Button cdmBorrar;
        private System.Windows.Forms.Button cdmCancelar;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.OpenFileDialog ofdRutas;
        private System.Windows.Forms.Button cdmReanudar;
    }
}

