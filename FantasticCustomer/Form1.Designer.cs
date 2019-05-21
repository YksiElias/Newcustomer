namespace FantasticCustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.enimiBoxi = new System.Windows.Forms.TextBox();
            this.snimiBoxi = new System.Windows.Forms.TextBox();
            this.osoiteBoxi = new System.Windows.Forms.TextBox();
            this.pnumeroBoxi = new System.Windows.Forms.TextBox();
            this.ptpBoxi = new System.Windows.Forms.TextBox();
            this.puhelinBoxi = new System.Windows.Forms.TextBox();
            this.emailBoxi = new System.Windows.Forms.TextBox();
            this.salasanaBoxi = new System.Windows.Forms.TextBox();
            this.lisaaTiedot = new System.Windows.Forms.Button();
            this.listaNakyma = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lisaaTiedot);
            this.groupBox1.Controls.Add(this.salasanaBoxi);
            this.groupBox1.Controls.Add(this.emailBoxi);
            this.groupBox1.Controls.Add(this.puhelinBoxi);
            this.groupBox1.Controls.Add(this.ptpBoxi);
            this.groupBox1.Controls.Add(this.pnumeroBoxi);
            this.groupBox1.Controls.Add(this.osoiteBoxi);
            this.groupBox1.Controls.Add(this.snimiBoxi);
            this.groupBox1.Controls.Add(this.enimiBoxi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Syöttökenttä";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etunimi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sukunimi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(18, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lähiosoite:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(18, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Postinumero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(18, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Postitoimipaikka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(18, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Puhelin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(18, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sähköposti:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(18, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salasana:";
            // 
            // enimiBoxi
            // 
            this.enimiBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enimiBoxi.Location = new System.Drawing.Point(177, 39);
            this.enimiBoxi.Name = "enimiBoxi";
            this.enimiBoxi.Size = new System.Drawing.Size(201, 30);
            this.enimiBoxi.TabIndex = 8;
            // 
            // snimiBoxi
            // 
            this.snimiBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.snimiBoxi.Location = new System.Drawing.Point(177, 82);
            this.snimiBoxi.Name = "snimiBoxi";
            this.snimiBoxi.Size = new System.Drawing.Size(201, 30);
            this.snimiBoxi.TabIndex = 9;
            // 
            // osoiteBoxi
            // 
            this.osoiteBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.osoiteBoxi.Location = new System.Drawing.Point(177, 125);
            this.osoiteBoxi.Name = "osoiteBoxi";
            this.osoiteBoxi.Size = new System.Drawing.Size(201, 30);
            this.osoiteBoxi.TabIndex = 10;
            // 
            // pnumeroBoxi
            // 
            this.pnumeroBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pnumeroBoxi.Location = new System.Drawing.Point(177, 171);
            this.pnumeroBoxi.Name = "pnumeroBoxi";
            this.pnumeroBoxi.Size = new System.Drawing.Size(201, 30);
            this.pnumeroBoxi.TabIndex = 11;
            this.pnumeroBoxi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PnumeroBoxi_KeyPress);
            // 
            // ptpBoxi
            // 
            this.ptpBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ptpBoxi.Location = new System.Drawing.Point(177, 215);
            this.ptpBoxi.Name = "ptpBoxi";
            this.ptpBoxi.Size = new System.Drawing.Size(201, 30);
            this.ptpBoxi.TabIndex = 12;
            // 
            // puhelinBoxi
            // 
            this.puhelinBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.puhelinBoxi.Location = new System.Drawing.Point(177, 264);
            this.puhelinBoxi.Name = "puhelinBoxi";
            this.puhelinBoxi.Size = new System.Drawing.Size(201, 30);
            this.puhelinBoxi.TabIndex = 13;
            this.puhelinBoxi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PuhelinBoxi_KeyPress);
            // 
            // emailBoxi
            // 
            this.emailBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.emailBoxi.Location = new System.Drawing.Point(177, 313);
            this.emailBoxi.Name = "emailBoxi";
            this.emailBoxi.Size = new System.Drawing.Size(201, 30);
            this.emailBoxi.TabIndex = 14;
            // 
            // salasanaBoxi
            // 
            this.salasanaBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.salasanaBoxi.Location = new System.Drawing.Point(177, 362);
            this.salasanaBoxi.Name = "salasanaBoxi";
            this.salasanaBoxi.Size = new System.Drawing.Size(201, 30);
            this.salasanaBoxi.TabIndex = 15;
            // 
            // lisaaTiedot
            // 
            this.lisaaTiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lisaaTiedot.Location = new System.Drawing.Point(101, 416);
            this.lisaaTiedot.Name = "lisaaTiedot";
            this.lisaaTiedot.Size = new System.Drawing.Size(189, 40);
            this.lisaaTiedot.TabIndex = 16;
            this.lisaaTiedot.Text = "Lisää tiedot";
            this.lisaaTiedot.UseVisualStyleBackColor = true;
            this.lisaaTiedot.Click += new System.EventHandler(this.LisaaTiedot_Click);
            // 
            // listaNakyma
            // 
            this.listaNakyma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listaNakyma.Location = new System.Drawing.Point(429, 29);
            this.listaNakyma.Name = "listaNakyma";
            this.listaNakyma.Size = new System.Drawing.Size(652, 458);
            this.listaNakyma.TabIndex = 1;
            this.listaNakyma.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 500);
            this.Controls.Add(this.listaNakyma);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Asiakastietorekisteri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button lisaaTiedot;
        private System.Windows.Forms.TextBox salasanaBoxi;
        private System.Windows.Forms.TextBox emailBoxi;
        private System.Windows.Forms.TextBox puhelinBoxi;
        private System.Windows.Forms.TextBox ptpBoxi;
        private System.Windows.Forms.TextBox pnumeroBoxi;
        private System.Windows.Forms.TextBox osoiteBoxi;
        private System.Windows.Forms.TextBox snimiBoxi;
        private System.Windows.Forms.TextBox enimiBoxi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listaNakyma;
    }
}

