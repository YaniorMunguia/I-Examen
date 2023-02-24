namespace YaniorMunguia
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Image = global::YaniorMunguia.Properties.Resources.images__5_;
            this.bt1.Location = new System.Drawing.Point(101, 15);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(88, 36);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "Interes";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Image = ((System.Drawing.Image)(resources.GetObject("bt2.Image")));
            this.bt2.Location = new System.Drawing.Point(101, 57);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(88, 41);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "Descuento";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("PMingLiU-ExtB", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Image = ((System.Drawing.Image)(resources.GetObject("bt3.Image")));
            this.bt3.Location = new System.Drawing.Point(82, 104);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(124, 40);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "Numeros del 1-100";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(242, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YaniorMunguia.Properties.Resources.images__5_;
            this.ClientSize = new System.Drawing.Size(301, 156);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button button1;
    }
}

