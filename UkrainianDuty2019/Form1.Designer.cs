namespace UkrainianDuty2019
{
    partial class App
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
            this.priceProduct = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.fullPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter price product";
            // 
            // priceProduct
            // 
            this.priceProduct.Location = new System.Drawing.Point(155, 85);
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.Size = new System.Drawing.Size(100, 20);
            this.priceProduct.TabIndex = 1;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(155, 111);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // fullPrice
            // 
            this.fullPrice.Location = new System.Drawing.Point(155, 178);
            this.fullPrice.Name = "fullPrice";
            this.fullPrice.Size = new System.Drawing.Size(100, 20);
            this.fullPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full price";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 285);
            this.Controls.Add(this.fullPrice);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.priceProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "App";
            this.Text = "Как же теперь не любить Украину?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceProduct;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox fullPrice;
        private System.Windows.Forms.Label label2;
    }
}

