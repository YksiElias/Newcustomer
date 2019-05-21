using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticCustomer
{
    class Asiakas
    {
        // Muuttujat
        private string etunimi;
        private string sukunimi;
        private string lahiosoite;
        private string postinumero;
        private string postitoimipaikka;
        private string puhelin;
        private string sahkoposti;
        private string salasana;

        public Asiakas() // Oletuskonstruktori
        {
            etunimi = "";
            sukunimi = "";
            lahiosoite = "";
            postinumero = "";
            postitoimipaikka = "";
            puhelin = "";
            sahkoposti = "";
            salasana = "";
        }
        // Ylikuormitettu konstruktori
        public Asiakas (string en, string sn, string lo, string pn, string pt, string pu, string em, string sa)
        {
            etunimi = en;
            sukunimi = sn;
            lahiosoite = lo;
            postinumero = pn;
            postitoimipaikka = pt;
            puhelin = pu;
            sahkoposti = em;
            salasana = sa;
        }
        //Tästä alkaa metodit, jotka ovat vain setterit ja getterit
        public string Etunimi { get => etunimi; set => etunimi = value; }
        public string Sukunimi { get => sukunimi; set => sukunimi = value; }
        public string Lahiosoite { get => lahiosoite; set => lahiosoite = value; }
        public string Postinumero { get => postinumero; set => postinumero = value; }
        public string Postitoimipaikka { get => postitoimipaikka; set => postitoimipaikka = value; }
        public string Puhelin { get => puhelin; set => puhelin = value; }
        public string Sahkoposti { get => sahkoposti; set => sahkoposti = value; }
        public string Salasana { get => salasana; set => salasana = value; }

    }
}
