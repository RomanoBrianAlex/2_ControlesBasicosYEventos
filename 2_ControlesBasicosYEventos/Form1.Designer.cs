namespace _2_ControlesBasicosYEventos
{
    partial class FrInicio
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
            this.BtnMensaje = new System.Windows.Forms.Button();
            this.LbNombre = new System.Windows.Forms.Label();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.TxtbNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnMensaje
            // 
            this.BtnMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.BtnMensaje.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnMensaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnMensaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMensaje.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnMensaje.Location = new System.Drawing.Point(131, 146);
            this.BtnMensaje.Name = "BtnMensaje";
            this.BtnMensaje.Size = new System.Drawing.Size(101, 37);
            this.BtnMensaje.TabIndex = 0;
            this.BtnMensaje.Text = "Mensaje";
            this.BtnMensaje.UseVisualStyleBackColor = false;
            this.BtnMensaje.Click += new System.EventHandler(this.BtnMensaje_Click);
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LbNombre.Location = new System.Drawing.Point(47, 47);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(78, 23);
            this.LbNombre.TabIndex = 1;
            this.LbNombre.Text = "Nombre";
            // 
            // btnSaludar
            // 
            this.btnSaludar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btnSaludar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaludar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaludar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSaludar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaludar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaludar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaludar.Location = new System.Drawing.Point(238, 146);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(101, 37);
            this.btnSaludar.TabIndex = 2;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = false;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // TxtbNombre
            // 
            this.TxtbNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbNombre.Location = new System.Drawing.Point(51, 73);
            this.TxtbNombre.Name = "TxtbNombre";
            this.TxtbNombre.Size = new System.Drawing.Size(288, 32);
            this.TxtbNombre.TabIndex = 3;
            // 
            // FrInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(401, 244);
            this.Controls.Add(this.TxtbNombre);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.BtnMensaje);
            this.Name = "FrInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrInicio_FormClosing);
            this.Load += new System.EventHandler(this.FrInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMensaje;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.TextBox TxtbNombre;
    }
}

