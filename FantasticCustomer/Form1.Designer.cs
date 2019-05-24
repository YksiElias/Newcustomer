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
            this.lisaaTiedot = new System.Windows.Forms.Button();
            this.salasanaBoxi = new System.Windows.Forms.TextBox();
            this.emailBoxi = new System.Windows.Forms.TextBox();
            this.puhelinBoxi = new System.Windows.Forms.TextBox();
            this.ptpBoxi = new System.Windows.Forms.TextBox();
            this.pnumeroBoxi = new System.Windows.Forms.TextBox();
            this.osoiteBoxi = new System.Windows.Forms.TextBox();
            this.snimiBoxi = new System.Windows.Forms.TextBox();
            this.enimiBoxi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listaNakyma = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.SalasanaBox = new System.Windows.Forms.TextBox();
            this.TunnusBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonLuo = new System.Windows.Forms.Button();
            this.buttonKirjaudu = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(9, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(263, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Syöttökenttä";
            // 
            // lisaaTiedot
            // 
            this.lisaaTiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lisaaTiedot.Location = new System.Drawing.Point(67, 270);
            this.lisaaTiedot.Margin = new System.Windows.Forms.Padding(2);
            this.lisaaTiedot.Name = "lisaaTiedot";
            this.lisaaTiedot.Size = new System.Drawing.Size(126, 26);
            this.lisaaTiedot.TabIndex = 16;
            this.lisaaTiedot.Text = "Lisää tiedot";
            this.lisaaTiedot.UseVisualStyleBackColor = true;
            this.lisaaTiedot.Click += new System.EventHandler(this.LisaaTiedot_Click);
            // 
            // salasanaBoxi
            // 
            this.salasanaBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.salasanaBoxi.Location = new System.Drawing.Point(118, 235);
            this.salasanaBoxi.Margin = new System.Windows.Forms.Padding(2);
            this.salasanaBoxi.Name = "salasanaBoxi";
            this.salasanaBoxi.Size = new System.Drawing.Size(135, 23);
            this.salasanaBoxi.TabIndex = 15;
            // 
            // emailBoxi
            // 
            this.emailBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.emailBoxi.Location = new System.Drawing.Point(118, 203);
            this.emailBoxi.Margin = new System.Windows.Forms.Padding(2);
            this.emailBoxi.Name = "emailBoxi";
            this.emailBoxi.Size = new System.Drawing.Size(135, 23);
            this.emailBoxi.TabIndex = 14;
            // 
            // puhelinBoxi
            // 
            this.puhelinBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.puhelinBoxi.Location = new System.Drawing.Point(118, 172);
            this.puhelinBoxi.Margin = new System.Windows.Forms.Padding(2);
            this.puhelinBoxi.Name = "puhelinBoxi";
            this.puhelinBoxi.Size = new System.Drawing.Size(135, 23);
            this.puhelinBoxi.TabIndex = 13;
            this.puhelinBoxi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PuhelinBoxi_KeyPress);
            // 
            // ptpBoxi
            // 
            this.ptpBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ptpBoxi.Location = new System.Drawing.Point(118, 140);
            this.ptpBoxi.Margin = new System.Windows.Forms.Padding(2);
            this.ptpBoxi.Name = "ptpBoxi";
            this.ptpBoxi.Size = new System.Drawing.Size(135, 23);
            this.ptpBoxi.TabIndex = 12;
            // 
            // pnumeroBoxi
            // 
            this.pnumeroBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pnumeroBoxi.Location = new System.Drawing.Point(118, 111);
            this.pnumeroBoxi.Margin = new System.Windows.Forms.Padding(2);
            this.pnumeroBoxi.Name = "pnumeroBoxi";
            this.pnumeroBoxi.Size = new System.Drawing.Size(135, 23);
            this.pnumeroBoxi.TabIndex = 11;
            this.pnumeroBoxi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PnumeroBoxi_KeyPress);
            // 
            // osoiteBoxi
            // 
            this.osoiteBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.osoiteBoxi.Location = new System.Drawing.Point(118, 81);
            this.osoiteBoxi.Margin = new System.Windows.Forms.Padding(2);
            this.osoiteBoxi.Name = "osoiteBoxi";
            this.osoiteBoxi.Size = new System.Drawing.Size(135, 23);
            this.osoiteBoxi.TabIndex = 10;
            // 
            // snimiBoxi
            // 
            this.snimiBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.snimiBoxi.Location = new System.Drawing.Point(118, 53);
            this.snimiBoxi.Margin = new System.Windows.Forms.Padding(2);
            this.snimiBoxi.Name = "snimiBoxi";
            this.snimiBoxi.Size = new System.Drawing.Size(135, 23);
            this.snimiBoxi.TabIndex = 9;
            // 
            // enimiBoxi
            // 
            this.enimiBoxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enimiBoxi.Location = new System.Drawing.Point(118, 25);
            this.enimiBoxi.Margin = new System.Windows.Forms.Padding(2);
            this.enimiBoxi.Name = "enimiBoxi";
            this.enimiBoxi.Size = new System.Drawing.Size(135, 23);
            this.enimiBoxi.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(12, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salasana:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(12, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sähköposti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Puhelin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Postitoimipaikka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Postinumero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lähiosoite:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sukunimi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etunimi:";
            // 
            // listaNakyma
            // 
            this.listaNakyma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listaNakyma.Location = new System.Drawing.Point(286, 62);
            this.listaNakyma.Margin = new System.Windows.Forms.Padding(2);
            this.listaNakyma.Name = "listaNakyma";
            this.listaNakyma.Size = new System.Drawing.Size(436, 299);
            this.listaNakyma.TabIndex = 1;
            this.listaNakyma.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.SalasanaBox);
            this.panel1.Controls.Add(this.TunnusBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.buttonLuo);
            this.panel1.Controls.Add(this.buttonKirjaudu);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 381);
            this.panel1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Salasana";
            // 
            // SalasanaBox
            // 
            this.SalasanaBox.Location = new System.Drawing.Point(371, 170);
            this.SalasanaBox.Name = "SalasanaBox";
            this.SalasanaBox.Size = new System.Drawing.Size(100, 20);
            this.SalasanaBox.TabIndex = 5;
            // 
            // TunnusBox
            // 
            this.TunnusBox.Location = new System.Drawing.Point(371, 141);
            this.TunnusBox.Name = "TunnusBox";
            this.TunnusBox.Size = new System.Drawing.Size(100, 20);
            this.TunnusBox.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Käyttäjätunnus";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Kirjaudu sisään";
            // 
            // buttonLuo
            // 
            this.buttonLuo.Location = new System.Drawing.Point(265, 198);
            this.buttonLuo.Name = "buttonLuo";
            this.buttonLuo.Size = new System.Drawing.Size(100, 38);
            this.buttonLuo.TabIndex = 1;
            this.buttonLuo.Text = "Luo Käyttäjätunnus";
            this.buttonLuo.UseVisualStyleBackColor = true;
            this.buttonLuo.Click += new System.EventHandler(this.buttonLuo_Click);
            // 
            // buttonKirjaudu
            // 
            this.buttonKirjaudu.Location = new System.Drawing.Point(371, 198);
            this.buttonKirjaudu.Name = "buttonKirjaudu";
            this.buttonKirjaudu.Size = new System.Drawing.Size(100, 38);
            this.buttonKirjaudu.TabIndex = 0;
            this.buttonKirjaudu.Text = "Kirjaudu";
            this.buttonKirjaudu.UseVisualStyleBackColor = true;
            this.buttonKirjaudu.Click += new System.EventHandler(this.buttonKirjaudu_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 373);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listaNakyma);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Asiakastietorekisteri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLuo;
        private System.Windows.Forms.Button buttonKirjaudu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SalasanaBox;
        private System.Windows.Forms.TextBox TunnusBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
    }
}

