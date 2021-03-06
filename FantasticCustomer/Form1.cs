﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FantasticCustomer
{
    public partial class Form1 : Form
    {
        Asiakas[] uusiAsiakas;
        Yhteys[] uusiYhteys;
        private bool i;
       

        public Form1()
        {
            InitializeComponent();

            listaNakyma.View = View.Details;
            listaNakyma.FullRowSelect = true;

            listaNakyma.Columns.Add("Etunimi", 100);
            listaNakyma.Columns.Add("Sukunimi", 100);
            listaNakyma.Columns.Add("Lähiosoite", 100);
            listaNakyma.Columns.Add("Postinumero", 100);
            listaNakyma.Columns.Add("Postitoimipaikka", 100);
            listaNakyma.Columns.Add("Puhelin", 100);
            listaNakyma.Columns.Add("Sähköposti", 100);
            listaNakyma.Columns.Add("Salasana", 100);
        }

        public void lisaa(string en, string sn, string Lahiosoite, string Postinumero, string Postitoimipaikka, string Puhelin, string Sahkoposti, string Salasana)
        {

            string[] row = { en, sn, Lahiosoite, Postinumero, Postitoimipaikka, Puhelin, Sahkoposti, Salasana };
            {
                ListViewItem item = new ListViewItem(row);
                item.SubItems.Add(en);
                item.SubItems.Add(sn);
                item.SubItems.Add(Lahiosoite);
                item.SubItems.Add(Postinumero);
                item.SubItems.Add(Postitoimipaikka);
                item.SubItems.Add(Puhelin);
                item.SubItems.Add(Sahkoposti);
                item.SubItems.Add(Salasana);

                listaNakyma.Items.Add(item);

                this.Controls.Add(listaNakyma);
            }
        }

        public void TyhjennaKentat()
        {
            enimiBoxi.Clear();
            snimiBoxi.Clear();
            osoiteBoxi.Clear();
            pnumeroBoxi.Clear();
            ptpBoxi.Clear();
            puhelinBoxi.Clear();
            emailBoxi.Clear();
            salasanaBoxi.Clear();
        }

        private void LisaaTiedot_Click(object sender, EventArgs e)
        {
            TextBox[] boxit = new TextBox[8] { enimiBoxi, snimiBoxi, osoiteBoxi, pnumeroBoxi, ptpBoxi, puhelinBoxi, emailBoxi, salasanaBoxi };

            if (enimiBoxi.Text.Length < 2)
            {
                MessageBox.Show("Etunimi on liian lyhyt");
                enimiBoxi.Focus();
            }
            else if (snimiBoxi.Text.Length < 2)
            {
                MessageBox.Show("Sukunimi on liian lyhyt");
                snimiBoxi.Focus();
            }
            else if (osoiteBoxi.Text.Length < 2)
            {
                MessageBox.Show("Lähiosoite on liian lyhyt");
                osoiteBoxi.Focus();
            }
            else if (pnumeroBoxi.Text.Length < 5)
            {
                MessageBox.Show("Postinumero on liian lyhyt");
                pnumeroBoxi.Focus();
            }
            else if (ptpBoxi.Text.Length < 2)
            {
                MessageBox.Show("Postitoimipaikka on liian lyhyt");
                ptpBoxi.Focus();
            }
            else if (puhelinBoxi.Text.Length < 6)
            {
                MessageBox.Show("Puhelinnumero on liian lyhyt");
                puhelinBoxi.Focus();
            }
            else if (emailBoxi.Text.Length < 7)
            {
                MessageBox.Show("Sähköpostiosoite on liian lyhyt");
                emailBoxi.Focus();
            }
            else if (emailBoxi.Text.IndexOf("@", 0) < 0)
            {
                MessageBox.Show("Sähköpostiosoite on puutteellinen");
                emailBoxi.Focus();
            }
            else if (emailBoxi.Text.IndexOf(".", 0) < 0)
            {
                MessageBox.Show("Sähköpostiosoite on puutteellinen");
                emailBoxi.Focus();
            }
            else if (salasanaBoxi.Text.Length < 8)
            {
                MessageBox.Show("Salasana on liian lyhyt");
                salasanaBoxi.Focus();
            }
            else if (true)
            {
            uusiAsiakas = new Asiakas[]
            {
                new Asiakas(enimiBoxi.Text, snimiBoxi.Text, osoiteBoxi.Text, pnumeroBoxi.Text, ptpBoxi.Text, puhelinBoxi.Text, emailBoxi.Text, salasanaBoxi.Text)
            };
            lisaa(enimiBoxi.Text, snimiBoxi.Text, osoiteBoxi.Text, pnumeroBoxi.Text, ptpBoxi.Text, puhelinBoxi.Text, emailBoxi.Text, salasanaBoxi.Text);
            TyhjennaKentat();
                if (i == true)
                {
                    TunnusBox.Clear();
                    SalasanaBox.Clear();
                    panel1.Visible = true;
                    label12.Text = "";
                    TunnusBox.Focus();
                }

            }
            try
            {
                // This is connection string i have assigned the database file address path
                string MyConnection2 = "server=146.0.40.202; port=3306; database=mastercode; username=mastercode; password=superskill";
             
                // This is MySqlConnection here to created the object and pass connection string
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //try
                //{
                //    MyConn2.Open();
                //}
                //catch
                //{
                //    MessageBox.Show("Yhteyttä ei voitu muodostaa");
                //}
                // This is insert query in which taking input from user through windows forms
                string Query = "insert into asiakas(etunimi,sukunimi,lahiosoite,postinumero,postitoimipaikka,puhelin,email,salasana) values('" + this.enimiBoxi.Text + "','"
                    + this.snimiBoxi.Text + "','" + this.osoiteBoxi.Text + "','" + this.pnumeroBoxi.Text + "','" + this.ptpBoxi.Text + "','" + this.puhelinBoxi.Text + "','" + this.emailBoxi.Text + "','" + this.salasanaBoxi.Text + "');";

                // This is command class which will handle the query and connection object
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader(); // Here our query will be executed and data saved into the database

                MessageBox.Show("Tiedot tallennettu");

                while (MyReader2.Read())
                {

                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        

        private void PnumeroBoxi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PuhelinBoxi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            // Sallii - ja + merkit puhelinnumerossa 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }

        private void buttonKirjaudu_Click(object sender, EventArgs e)
        {
            if (TunnusBox.Text.Length < 7)
            {
                MessageBox.Show("Sähköpostiosoite on liian lyhyt");
                TunnusBox.Focus();
            }
            else if (TunnusBox.Text.IndexOf("@", 0) < 0)
            {
                MessageBox.Show("Sähköpostiosoite on puutteellinen");
                TunnusBox.Focus();
            }
            else if (TunnusBox.Text.IndexOf(".", 0) < 0)
            {
                MessageBox.Show("Sähköpostiosoite on puutteellinen");
                TunnusBox.Focus();
            }
            else if (true)
            {
                panel1.Visible = false;
                label12.Text = "Kirjautuneena: " + TunnusBox.Text;
                i = false;
            }
        }

        private void buttonLuo_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label12.Text = "Luo käyttäjätunnus";
            i = true;
        }
    }

    internal class Yhteys
    {
    }
}
