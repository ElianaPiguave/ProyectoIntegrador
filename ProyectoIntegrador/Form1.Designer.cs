
namespace ProyectoIntegrador
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
            this.txt_usu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.btn_mini = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mini)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // txt_usu
            // 
            this.txt_usu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(162)))));
            this.txt_usu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usu.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usu.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_usu.Location = new System.Drawing.Point(340, 124);
            this.txt_usu.Name = "txt_usu";
            this.txt_usu.Size = new System.Drawing.Size(289, 22);
            this.txt_usu.TabIndex = 1;
            this.txt_usu.Text = "Usuario";
            this.txt_usu.Enter += new System.EventHandler(this.txt_usu_Enter);
            this.txt_usu.Leave += new System.EventHandler(this.txt_usu_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // txt_contra
            // 
            this.txt_contra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(162)))));
            this.txt_contra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contra.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contra.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_contra.Location = new System.Drawing.Point(340, 180);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(289, 22);
            this.txt_contra.TabIndex = 4;
            this.txt_contra.Text = "CONTRASEÑA";
            this.txt_contra.Enter += new System.EventHandler(this.txt_contra_Enter);
            this.txt_contra.Leave += new System.EventHandler(this.txt_contra_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(415, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(693, 12);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(16, 22);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_cerrar.TabIndex = 6;
            this.btn_cerrar.TabStop = false;
            // 
            // btn_mini
            // 
            this.btn_mini.Image = ((System.Drawing.Image)(resources.GetObject("btn_mini.Image")));
            this.btn_mini.Location = new System.Drawing.Point(662, 12);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(25, 22);
            this.btn_mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_mini.TabIndex = 7;
            this.btn_mini.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(730, 330);
            this.Controls.Add(this.btn_mini);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_usu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_usu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.PictureBox btn_mini;
    }
}

