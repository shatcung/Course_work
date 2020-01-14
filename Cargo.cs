using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Cargo
    {
        string cargo_Name;
        float cargo_Weight;
        string cargo_Prop;
        public string getcargo_Name() { return cargo_Name; }
        public double getcargo_Weight() { return cargo_Weight; }
        public string getcargo_Prop() { return cargo_Prop; }

        public void setcargo_Name(string cargo_Name) { this.cargo_Name = cargo_Name; }
        public void setcargo_Weight(float cargo_Weight) { this.cargo_Weight = cargo_Weight; }
        public void setcargo_Prop(string cargo_Prop) { this.cargo_Prop = cargo_Prop; }

    }
}
