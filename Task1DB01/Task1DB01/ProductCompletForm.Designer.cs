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
            this.SuspendLayout();
            // 
            // productCompletListBox
            // 
            this.productCompletListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productCompletListBox.FormattingEnabled = true;
            this.productCompletListBox.Location = new System.Drawing.Point(12, 73);
            this.productCompletListBox.Name = "productCompletListBox";
            this.productCompletListBox.Size = new System.Drawing.Size(776, 173);
            this.productCompletListBox.TabIndex = 0;
            // 
            // ProductCompletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productCompletListBox);
            this.Name = "ProductCompletForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox productCompletListBox;
    }
}