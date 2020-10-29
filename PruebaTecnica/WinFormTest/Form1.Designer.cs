namespace WinFormTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnGetProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetProductos
            // 
            this.btnGetProductos.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.btnGetProductos.Location = new System.Drawing.Point(82, 33);
            this.btnGetProductos.Name = "btnGetProductos";
            this.btnGetProductos.Size = new System.Drawing.Size(75, 23);
            this.btnGetProductos.TabIndex = 0;
            this.btnGetProductos.Text = "ListaProductos";
            this.btnGetProductos.UseVisualStyleBackColor = true;
            this.btnGetProductos.Click += new System.EventHandler(this.btnGetProductos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetProductos;
    }
}

