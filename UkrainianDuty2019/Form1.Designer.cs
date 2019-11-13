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
            this.in_eur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.in_uah = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CalculateUsd = new System.Windows.Forms.Button();
            this.priceProductUsd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculateCNY = new System.Windows.Forms.Button();
            this.priceProductCNY = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Recalc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter price product";
            // 
            // priceProduct
            // 
            this.priceProduct.Location = new System.Drawing.Point(36, 40);
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.Size = new System.Drawing.Size(100, 20);
            this.priceProduct.TabIndex = 1;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(36, 66);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // in_eur
            // 
            this.in_eur.Location = new System.Drawing.Point(45, 41);
            this.in_eur.Name = "in_eur";
            this.in_eur.Size = new System.Drawing.Size(100, 20);
            this.in_eur.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "EUR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "UAH";
            // 
            // in_uah
            // 
            this.in_uah.Location = new System.Drawing.Point(45, 67);
            this.in_uah.Name = "in_uah";
            this.in_uah.Size = new System.Drawing.Size(100, 20);
            this.in_uah.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Calculate);
            this.groupBox1.Controls.Add(this.priceProduct);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EUR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CalculateUsd);
            this.groupBox2.Controls.Add(this.priceProductUsd);
            this.groupBox2.Location = new System.Drawing.Point(171, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "USD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter price product";
            // 
            // CalculateUsd
            // 
            this.CalculateUsd.Location = new System.Drawing.Point(36, 66);
            this.CalculateUsd.Name = "CalculateUsd";
            this.CalculateUsd.Size = new System.Drawing.Size(75, 23);
            this.CalculateUsd.TabIndex = 2;
            this.CalculateUsd.Text = "Calculate";
            this.CalculateUsd.UseVisualStyleBackColor = true;
            this.CalculateUsd.Click += new System.EventHandler(this.CalculateUsd_Click);
            // 
            // priceProductUsd
            // 
            this.priceProductUsd.Location = new System.Drawing.Point(36, 40);
            this.priceProductUsd.Name = "priceProductUsd";
            this.priceProductUsd.Size = new System.Drawing.Size(100, 20);
            this.priceProductUsd.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.CalculateCNY);
            this.groupBox3.Controls.Add(this.priceProductCNY);
            this.groupBox3.Location = new System.Drawing.Point(12, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 130);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CNY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter price product";
            // 
            // CalculateCNY
            // 
            this.CalculateCNY.Location = new System.Drawing.Point(36, 66);
            this.CalculateCNY.Name = "CalculateCNY";
            this.CalculateCNY.Size = new System.Drawing.Size(75, 23);
            this.CalculateCNY.TabIndex = 2;
            this.CalculateCNY.Text = "Calculate";
            this.CalculateCNY.UseVisualStyleBackColor = true;
            this.CalculateCNY.Click += new System.EventHandler(this.CalculateCNY_Click);
            // 
            // priceProductCNY
            // 
            this.priceProductCNY.Location = new System.Drawing.Point(36, 40);
            this.priceProductCNY.Name = "priceProductCNY";
            this.priceProductCNY.Size = new System.Drawing.Size(100, 20);
            this.priceProductCNY.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.Recalc);
            this.groupBox4.Controls.Add(this.in_eur);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.in_uah);
            this.groupBox4.Location = new System.Drawing.Point(171, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 130);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result";
            // 
            // Recalc
            // 
            this.Recalc.Location = new System.Drawing.Point(45, 93);
            this.Recalc.Name = "Recalc";
            this.Recalc.Size = new System.Drawing.Size(75, 23);
            this.Recalc.TabIndex = 2;
            this.Recalc.Text = "Recalculate";
            this.Recalc.UseVisualStyleBackColor = true;
            this.Recalc.Click += new System.EventHandler(this.Recalc_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 289);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "App";
            this.Text = "Таможенный калькулятор для Украины 2019";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceProduct;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox in_eur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox in_uah;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalculateUsd;
        private System.Windows.Forms.TextBox priceProductUsd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalculateCNY;
        private System.Windows.Forms.TextBox priceProductCNY;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Recalc;
    }
}

