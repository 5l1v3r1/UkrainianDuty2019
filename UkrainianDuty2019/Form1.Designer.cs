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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.CalculateShipment = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ship_uah_label = new System.Windows.Forms.Label();
            this.ship_usd = new System.Windows.Forms.TextBox();
            this.ship_usd_label = new System.Windows.Forms.Label();
            this.ship_uah = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ship_air = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ship_uah_air = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter price product";
            // 
            // priceProduct
            // 
            this.priceProduct.Location = new System.Drawing.Point(17, 40);
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.Size = new System.Drawing.Size(100, 20);
            this.priceProduct.TabIndex = 1;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(17, 66);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // in_eur
            // 
            this.in_eur.Location = new System.Drawing.Point(45, 38);
            this.in_eur.Name = "in_eur";
            this.in_eur.Size = new System.Drawing.Size(100, 20);
            this.in_eur.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "EUR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "UAH";
            // 
            // in_uah
            // 
            this.in_uah.Location = new System.Drawing.Point(45, 64);
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
            this.groupBox2.Location = new System.Drawing.Point(171, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "USD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter price product";
            // 
            // CalculateUsd
            // 
            this.CalculateUsd.Location = new System.Drawing.Point(12, 66);
            this.CalculateUsd.Name = "CalculateUsd";
            this.CalculateUsd.Size = new System.Drawing.Size(75, 23);
            this.CalculateUsd.TabIndex = 2;
            this.CalculateUsd.Text = "Calculate";
            this.CalculateUsd.UseVisualStyleBackColor = true;
            this.CalculateUsd.Click += new System.EventHandler(this.CalculateUsd_Click);
            // 
            // priceProductUsd
            // 
            this.priceProductUsd.Location = new System.Drawing.Point(12, 40);
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
            this.label5.Location = new System.Drawing.Point(14, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enter price product";
            // 
            // CalculateCNY
            // 
            this.CalculateCNY.Location = new System.Drawing.Point(17, 83);
            this.CalculateCNY.Name = "CalculateCNY";
            this.CalculateCNY.Size = new System.Drawing.Size(75, 23);
            this.CalculateCNY.TabIndex = 2;
            this.CalculateCNY.Text = "Calculate";
            this.CalculateCNY.UseVisualStyleBackColor = true;
            this.CalculateCNY.Click += new System.EventHandler(this.CalculateCNY_Click);
            // 
            // priceProductCNY
            // 
            this.priceProductCNY.Location = new System.Drawing.Point(17, 57);
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
            this.Recalc.Location = new System.Drawing.Point(45, 90);
            this.Recalc.Name = "Recalc";
            this.Recalc.Size = new System.Drawing.Size(75, 23);
            this.Recalc.TabIndex = 2;
            this.Recalc.Text = "Recalculate";
            this.Recalc.UseVisualStyleBackColor = true;
            this.Recalc.Click += new System.EventHandler(this.Recalc_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.weight);
            this.groupBox5.Controls.Add(this.CalculateShipment);
            this.groupBox5.Location = new System.Drawing.Point(346, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(184, 130);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Meest China Calculator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Weight, kg";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(12, 40);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 20);
            this.weight.TabIndex = 1;
            // 
            // CalculateShipment
            // 
            this.CalculateShipment.Location = new System.Drawing.Point(12, 66);
            this.CalculateShipment.Name = "CalculateShipment";
            this.CalculateShipment.Size = new System.Drawing.Size(75, 23);
            this.CalculateShipment.TabIndex = 2;
            this.CalculateShipment.Text = "Calculate";
            this.CalculateShipment.UseVisualStyleBackColor = true;
            this.CalculateShipment.Click += new System.EventHandler(this.CalculateShipment_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(346, 151);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(184, 218);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Shipment";
            // 
            // ship_uah_label
            // 
            this.ship_uah_label.AutoSize = true;
            this.ship_uah_label.Location = new System.Drawing.Point(6, 54);
            this.ship_uah_label.Name = "ship_uah_label";
            this.ship_uah_label.Size = new System.Drawing.Size(30, 13);
            this.ship_uah_label.TabIndex = 0;
            this.ship_uah_label.Text = "UAH";
            // 
            // ship_usd
            // 
            this.ship_usd.Location = new System.Drawing.Point(42, 25);
            this.ship_usd.Name = "ship_usd";
            this.ship_usd.Size = new System.Drawing.Size(100, 20);
            this.ship_usd.TabIndex = 3;
            // 
            // ship_usd_label
            // 
            this.ship_usd_label.AutoSize = true;
            this.ship_usd_label.Location = new System.Drawing.Point(6, 28);
            this.ship_usd_label.Name = "ship_usd_label";
            this.ship_usd_label.Size = new System.Drawing.Size(30, 13);
            this.ship_usd_label.TabIndex = 0;
            this.ship_usd_label.Text = "USD";
            // 
            // ship_uah
            // 
            this.ship_uah.Location = new System.Drawing.Point(42, 51);
            this.ship_uah.Name = "ship_uah";
            this.ship_uah.Size = new System.Drawing.Size(100, 20);
            this.ship_uah.TabIndex = 3;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ship_usd_label);
            this.groupBox7.Controls.Add(this.ship_uah);
            this.groupBox7.Controls.Add(this.ship_uah_label);
            this.groupBox7.Controls.Add(this.ship_usd);
            this.groupBox7.Location = new System.Drawing.Point(12, 24);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(159, 89);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Train";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.ship_uah_air);
            this.groupBox8.Controls.Add(this.ship_air);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Location = new System.Drawing.Point(12, 119);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(159, 89);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Air";
            // 
            // ship_air
            // 
            this.ship_air.Location = new System.Drawing.Point(42, 24);
            this.ship_air.Name = "ship_air";
            this.ship_air.Size = new System.Drawing.Size(100, 20);
            this.ship_air.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "UAH";
            // 
            // ship_uah_air
            // 
            this.ship_uah_air.Location = new System.Drawing.Point(42, 50);
            this.ship_uah_air.Name = "ship_uah_air";
            this.ship_uah_air.Size = new System.Drawing.Size(100, 20);
            this.ship_uah_air.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "USD";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Location = new System.Drawing.Point(12, 288);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(328, 81);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "10% Пошлина";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "20% НДС";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(156, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "3% Alipay";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "2% Торговый эквайринг";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 374);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Button CalculateShipment;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label ship_uah_label;
        private System.Windows.Forms.TextBox ship_usd;
        private System.Windows.Forms.Label ship_usd_label;
        private System.Windows.Forms.TextBox ship_uah;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ship_uah_air;
        private System.Windows.Forms.TextBox ship_air;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

