﻿namespace ERROR_404
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
            this.CLICKbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CLICKbutton1
            // 
            this.CLICKbutton1.Location = new System.Drawing.Point(139, 100);
            this.CLICKbutton1.Name = "CLICKbutton1";
            this.CLICKbutton1.Size = new System.Drawing.Size(90, 23);
            this.CLICKbutton1.TabIndex = 0;
            this.CLICKbutton1.Text = "CLICKEAME:)";
            this.CLICKbutton1.UseVisualStyleBackColor = true;
            this.CLICKbutton1.Click += new System.EventHandler(this.CLICKbutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 228);
            this.Controls.Add(this.CLICKbutton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CLICKbutton1;
    }
}

