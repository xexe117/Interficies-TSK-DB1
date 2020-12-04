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
            this.aviabelCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 4;
            // 
            // enterProduct
            // 
            this.enterProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterProduct.Location = new System.Drawing.Point(155, 12);
            this.enterProduct.Margin = new System.Windows.Forms.Padding(2);
            this.enterProduct.Name = "enterProduct";
            this.enterProduct.Size = new System.Drawing.Size(173, 23);
            this.enterProduct.TabIndex = 3;
            this.enterProduct.TextChanged += new System.EventHandler(this.enterProduct_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Serch product/model";
            // 
            // aviabelCheckBox
            // 
            this.aviabelCheckBox.AutoSize = true;
            this.aviabelCheckBox.Location = new System.Drawing.Point(476, 17);
            this.aviabelCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.aviabelCheckBox.Name = "aviabelCheckBox";
            this.aviabelCheckBox.Size = new System.Drawing.Size(15, 14);
            this.aviabelCheckBox.TabIndex = 6;
            this.aviabelCheckBox.UseVisualStyleBackColor = true;
            this.aviabelCheckBox.CheckedChanged += new System.EventHandler(this.aviabelCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Just show aviabel:";
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Items.AddRange(new object[] {
            ""});
            this.listBoxProducts.Location = new System.Drawing.Point(9, 60);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(1086, 277);
            this.listBoxProducts.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aviabelCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enterProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxProducts);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.CheckBox aviabelCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxProducts;
    }
}

