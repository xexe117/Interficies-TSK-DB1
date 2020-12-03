namespace Task1DB01
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
            this.label1 = new System.Windows.Forms.Label();
            this.enterProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aviabel = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tablas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            // 
            // enterProduct
            // 
            this.enterProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterProduct.Location = new System.Drawing.Point(207, 15);
            this.enterProduct.Name = "enterProduct";
            this.enterProduct.Size = new System.Drawing.Size(229, 27);
            this.enterProduct.TabIndex = 3;
            this.enterProduct.TextChanged += new System.EventHandler(this.enterProduct_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Serch product/model";
            // 
            // aviabel
            // 
            this.aviabel.AutoSize = true;
            this.aviabel.Location = new System.Drawing.Point(635, 21);
            this.aviabel.Name = "aviabel";
            this.aviabel.Size = new System.Drawing.Size(18, 17);
            this.aviabel.TabIndex = 6;
            this.aviabel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Just show aviabel:";
            // 
            // tablas
            // 
            this.tablas.FormattingEnabled = true;
            this.tablas.ItemHeight = 16;
            this.tablas.Items.AddRange(new object[] {
            ""});
            this.tablas.Location = new System.Drawing.Point(12, 74);
            this.tablas.Name = "tablas";
            this.tablas.Size = new System.Drawing.Size(638, 228);
            this.tablas.TabIndex = 0;
            this.tablas.SelectedIndexChanged += new System.EventHandler(this.tablas_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aviabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enterProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox aviabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox tablas;
    }
}

