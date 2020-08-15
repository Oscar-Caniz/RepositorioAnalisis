namespace menu
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
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnClien = new System.Windows.Forms.Button();
            this.btnFac = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.btnProye = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btnClien);
            this.MenuVertical.Controls.Add(this.btnFac);
            this.MenuVertical.Controls.Add(this.btnProd);
            this.MenuVertical.Controls.Add(this.btnProye);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 603);
            this.MenuVertical.TabIndex = 0;
            // 
            // btnClien
            // 
            this.btnClien.FlatAppearance.BorderSize = 0;
            this.btnClien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClien.ForeColor = System.Drawing.Color.White;
            this.btnClien.Image = ((System.Drawing.Image)(resources.GetObject("btnClien.Image")));
            this.btnClien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClien.Location = new System.Drawing.Point(3, 406);
            this.btnClien.Name = "btnClien";
            this.btnClien.Size = new System.Drawing.Size(250, 40);
            this.btnClien.TabIndex = 4;
            this.btnClien.Text = "CLIENTES";
            this.btnClien.UseVisualStyleBackColor = true;
            // 
            // btnFac
            // 
            this.btnFac.FlatAppearance.BorderSize = 0;
            this.btnFac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFac.ForeColor = System.Drawing.Color.White;
            this.btnFac.Image = ((System.Drawing.Image)(resources.GetObject("btnFac.Image")));
            this.btnFac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFac.Location = new System.Drawing.Point(0, 324);
            this.btnFac.Name = "btnFac";
            this.btnFac.Size = new System.Drawing.Size(250, 40);
            this.btnFac.TabIndex = 3;
            this.btnFac.Text = "FACTURAS";
            this.btnFac.UseVisualStyleBackColor = true;
            // 
            // btnProd
            // 
            this.btnProd.FlatAppearance.BorderSize = 0;
            this.btnProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.ForeColor = System.Drawing.Color.White;
            this.btnProd.Image = ((System.Drawing.Image)(resources.GetObject("btnProd.Image")));
            this.btnProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProd.Location = new System.Drawing.Point(-3, 234);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(250, 40);
            this.btnProd.TabIndex = 2;
            this.btnProd.Text = "PRODUCTOS";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProye
            // 
            this.btnProye.FlatAppearance.BorderSize = 0;
            this.btnProye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProye.ForeColor = System.Drawing.Color.White;
            this.btnProye.Image = ((System.Drawing.Image)(resources.GetObject("btnProye.Image")));
            this.btnProye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProye.Location = new System.Drawing.Point(0, 151);
            this.btnProye.Name = "btnProye";
            this.btnProye.Size = new System.Drawing.Size(250, 40);
            this.btnProye.TabIndex = 1;
            this.btnProye.Text = "PROYECTOS";
            this.btnProye.UseVisualStyleBackColor = true;
            this.btnProye.Click += new System.EventHandler(this.btnProye_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.btnslide);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1032, 603);
            this.panelContenedor.TabIndex = 1;
            // 
            // btnslide
            // 
            this.btnslide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnslide.Image = global::menu.Properties.Resources.menu_abierto;
            this.btnslide.Location = new System.Drawing.Point(3, 3);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(35, 35);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslide.TabIndex = 0;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 603);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuVertical.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.Button btnProye;
        private System.Windows.Forms.Button btnFac;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnClien;
    }
}

