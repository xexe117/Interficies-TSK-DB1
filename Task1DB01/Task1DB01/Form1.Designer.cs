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
            this.lenguageComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backButt = new System.Windows.Forms.Button();
            this.nextButt = new System.Windows.Forms.Button();
            this.numPgLabel = new System.Windows.Forms.Label();
            this.numFilasComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
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
            // lenguageComboBox
            // 
            this.lenguageComboBox.FormattingEnabled = true;
            this.lenguageComboBox.Items.AddRange(new object[] {
            "en",
            "fr"});
            this.lenguageComboBox.Location = new System.Drawing.Point(100, 339);
            this.lenguageComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.lenguageComboBox.Name = "lenguageComboBox";
            this.lenguageComboBox.Size = new System.Drawing.Size(70, 21);
            this.lenguageComboBox.TabIndex = 9;
            this.lenguageComboBox.Text = "en";
            this.lenguageComboBox.SelectedIndexChanged += new System.EventHandler(this.lenguageComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 339);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lenguage:";
            // 
            // backButt
            // 
            this.backButt.Location = new System.Drawing.Point(113, 361);
            this.backButt.Margin = new System.Windows.Forms.Padding(2);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(42, 21);
            this.backButt.TabIndex = 12;
            this.backButt.Text = "<";
            this.backButt.UseVisualStyleBackColor = true;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // nextButt
            // 
            this.nextButt.Location = new System.Drawing.Point(155, 361);
            this.nextButt.Margin = new System.Windows.Forms.Padding(2);
            this.nextButt.Name = "nextButt";
            this.nextButt.Size = new System.Drawing.Size(42, 21);
            this.nextButt.TabIndex = 13;
            this.nextButt.Text = ">";
            this.nextButt.UseVisualStyleBackColor = true;
            this.nextButt.Click += new System.EventHandler(this.nextButt_Click);
            // 
            // numPgLabel
            // 
            this.numPgLabel.AutoSize = true;
            this.numPgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPgLabel.Location = new System.Drawing.Point(11, 362);
            this.numPgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numPgLabel.Name = "numPgLabel";
            this.numPgLabel.Size = new System.Drawing.Size(83, 17);
            this.numPgLabel.TabIndex = 14;
            this.numPgLabel.Text = "Pag 0 of 0";
            // 
            // numFilasComboBox
            // 
            this.numFilasComboBox.FormattingEnabled = true;
            this.numFilasComboBox.Items.AddRange(new object[] {
            "10",
            "20",
            "50"});
            this.numFilasComboBox.Location = new System.Drawing.Point(100, 387);
            this.numFilasComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.numFilasComboBox.Name = "numFilasComboBox";
            this.numFilasComboBox.Size = new System.Drawing.Size(70, 21);
            this.numFilasComboBox.TabIndex = 15;
            this.numFilasComboBox.SelectedIndexChanged += new System.EventHandler(this.numFilasComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 387);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Rows:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(513, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Filter:";
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Product.ProductID",
            "Product.Size",
            "ProductCategory.Name",
            "Product.ProductSubcategoryID",
            "Product.ProductLine",
            "Product.Class",
            "Product.Style",
            "Product.ListPrice",
            "Product.Color",
            "Product.MakeFlag"});
            this.filterComboBox.Location = new System.Drawing.Point(579, 15);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(121, 21);
            this.filterComboBox.TabIndex = 18;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 441);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numFilasComboBox);
            this.Controls.Add(this.numPgLabel);
            this.Controls.Add(this.nextButt);
            this.Controls.Add(this.backButt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lenguageComboBox);
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
        private System.Windows.Forms.ComboBox lenguageComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lael5;

        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.Button nextButt;
        private System.Windows.Forms.Label numPgLabel;
        private System.Windows.Forms.ComboBox numFilasComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox filterComboBox;
    }
}

