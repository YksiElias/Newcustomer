using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FantasticCustomer
{

    class Yhteys
    {
        private MySqlConnection connection;
        private string server;
        private string port;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public Yhteys()
        {
            Initialize();
        }
        //Iniatialize values
        private void Initialize()
        {
            server = "146.0.40.202";
            port = "2211";
            database = "mastercode";
            uid = "mastercode";
            password = "superskill";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + uid + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        //Open connection to database
        private bool OpenConnection()
        {
            //check if connection is alredy open
            if (connection.State == System.Data.ConnectionState.Open)
                return true;

            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's responce based
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect the server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Invalid connection");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password.");
                        break;
                }
                return false;
            }
        }

        //Close connection to database
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                  MessageBox.Show(ex.Message);
            }
            return false;
        }
    
        //Insert statement
        public void Insert()
        {
            try
            {
                string Query = "insert into mastercode(Etunimi,Sukunimi,Lahiosoite,Postinumero,Postitoimipaikka,Puhelinnumero,Sahkopostiosoite,Salasana) values('" + this.enimiBoxi.Text + "','"
                    + this.snimiBoxi.Text + "','" + this.osoiteBoxi.Text + "','" + this.pnumeroBoxi.Text + "','" + this.ptpBoxi.Text + "','" + this.puhelinBoxi.Text + "','" + this.emailBoxi.Text + "','" + this.salasanaBoxi.Text + "');";

                MySqlCommand MyCommand2 = new MySqlCommand(Query);

                MySqlDataReader MyReader2;

                connection.Open();

                MyReader2 = MyCommand2.Executereader();

                MessageBox.Show("Tiedot tallennettu");

                while (MyReader2.Read())
                {

                }
                connection.Close();
            }
            catch (Exeption ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Update statement
        public void Update()
        {

        }

        //Delete statement
        public void Delete()
        {

        }

        //Select statement
    }
}