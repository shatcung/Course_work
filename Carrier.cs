using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Carrier
    {
        string company_name;
        string adress;
        string tele_num;
        string number_card;
        Auto auto;
        public string Getcompany_name() { return company_name; }
        public string Getadress() { return adress; }
        public string Gettele_num() { return tele_num; }
        public string Getnumber_card() { return number_card; }
        public Auto Getauto() { return auto; }

        public void setcompany_name(string company_name) { this.company_name = company_name; }
        public void setadress(string adress) { this.adress = adress; }
        public void settele_num(string tele_num) { this.tele_num = tele_num; }
        public void setnumber_card(string number_card) { this.number_card = number_card; }

        public void setauto(Auto auto) { this.auto = auto; }



    }
}
