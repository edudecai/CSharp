namespace TutorialCSharp
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
            this.CMD_Mostrar = new System.Windows.Forms.Button();
            this.TEX_Numero1 = new System.Windows.Forms.TextBox();
            this.TEX_Numero2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CMD_Mostrar
            // 
            this.CMD_Mostrar.Location = new System.Drawing.Point(165, 116);
            this.CMD_Mostrar.Name = "CMD_Mostrar";
            this.CMD_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.CMD_Mostrar.TabIndex = 0;
            this.CMD_Mostrar.Text = "Mostrar";
            this.CMD_Mostrar.UseVisualStyleBackColor = true;
            this.CMD_Mostrar.Click += new System.EventHandler(this.CMD_Mostrar_Click);
            // 
            // TEX_Numero1
            // 
            this.TEX_Numero1.Location = new System.Drawing.Point(165, 42);
            this.TEX_Numero1.Name = "TEX_Numero1";
            this.TEX_Numero1.Size = new System.Drawing.Size(100, 20);
            this.TEX_Numero1.TabIndex = 1;
            // 
            // TEX_Numero2
            // 
            this.TEX_Numero2.Location = new System.Drawing.Point(165, 80);
            this.TEX_Numero2.Name = "TEX_Numero2";
            this.TEX_Numero2.Size = new System.Drawing.Size(100, 20);
            this.TEX_Numero2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese primer número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese segundo número:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 313);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TEX_Numero2);
            this.Controls.Add(this.TEX_Numero1);
            this.Controls.Add(this.CMD_Mostrar);
            this.Name = "Form1";
            this.Text = "Tutorial CSharp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CMD_Mostrar;
        private System.Windows.Forms.TextBox TEX_Numero1;
        private System.Windows.Forms.TextBox TEX_Numero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

