namespace Task1DB01
{
    partial class ProductCompletForm
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
            this.productCompletListBox = new System.Windows.Forms.ListBox();
            this.updateElementcomboBox = new System.Windows.Forms.ComboBox();
            this.updateElementTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productCompletListBox
            // 
            this.productCompletListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productCompletListBox.FormattingEnabled = true;
            this.productCompletListBox.Location = new System.Drawing.Point(12, 12);
            this.productCompletListBox.Name = "productCompletListBox";
            this.productCompletListBox.Size = new System.Drawing.Size(1117, 147);
            this.productCompletListBox.TabIndex = 0;
            // 
            // updateElementcomboBox
            // 
            this.updateElementcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateElementcomboBox.FormattingEnabled = true;
            this.updateElementcomboBox.Items.AddRange(new object[] {
            "ProductNumber",
            "Color ",
            "ListPrice",
            "Size",
            "ProductLine ",
            "Class",
            "Style ",
            "ProductCategory ",
            "ProductSubcategory"});
            this.updateElementcomboBox.Location = new System.Drawing.Point(12, 199);
            this.updateElementcomboBox.Name = "updateElementcomboBox";
            this.updateElementcomboBox.Size = new System.Drawing.Size(121, 21);
            this.updateElementcomboBox.TabIndex = 1;
            // 
            // updateElementTextBox
            // 
            this.updateElementTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateElementTextBox.Location = new System.Drawing.Point(187, 199);
            this.updateElementTextBox.Name = "updateElementTextBox";
            this.updateElementTextBox.Size = new System.Drawing.Size(334, 20);
            this.updateElementTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the element if you wish changed";
            // 
            // updateButt
            // 
            this.updateButt.Location = new System.Drawing.Point(527, 198);
            this.updateButt.Name = "updateButt";
            this.updateButt.Size = new System.Drawing.Size(75, 23);
            this.updateButt.TabIndex = 4;
            this.updateButt.Text = "Update";
            this.updateButt.UseVisualStyleBackColor = true;
            this.updateButt.Click += new System.EventHandler(this.updateButt_Click);
            // 
            // ProductCompletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 228);
            this.Controls.Add(this.updateButt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateElementTextBox);
            this.Controls.Add(this.updateElementcomboBox);
            this.Controls.Add(this.productCompletListBox);
            this.Name = "ProductCompletForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productCompletListBox;
        private System.Windows.Forms.ComboBox updateElementcomboBox;
        private System.Windows.Forms.TextBox updateElementTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButt;
    }
}