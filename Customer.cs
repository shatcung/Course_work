using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Customer
    {
        string FSP;
        string tele_num;
        Cargo cargo;
        public string getFSP() {return FSP; }
        public string gettele_num() { return tele_num; }
        public Cargo getcargo() { return cargo; }

        public void setFSP(string FSP) { this.FSP = FSP; }
        public void settele_num(string tele_num) { this.tele_num = tele_num; }
        public void setcargo(Cargo cargo) { this.cargo = cargo; }
    }
}
