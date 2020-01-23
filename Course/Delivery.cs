using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Delivery
    {
        DateTime sending_date;
        string adress_from;
        string adress_to;
        DateTime arrival_date;
        Carrier carrier;
        Customer customer;
        double rasst;
        double cost;
     
       
        public double GetRasstoanie() {return rasst;}
        public Carrier GetCarrier() { return carrier; }
        public Customer GetCustomer() { return customer; }

        public void setsending_date(DateTime sending_date) { this.sending_date = sending_date; }
        public void setadress_from(string adress_from) { this.adress_from = adress_from; }
        public void setadress_to(string adress_to) { this.adress_to = adress_to; }
        public void setarrival_date(DateTime arrival_date) { this.arrival_date = arrival_date; }
        public void setcarrier(Carrier carrier) { this.carrier = carrier; }
        public void setcustomer(Customer customer) { this.customer = customer; }
        public void setRasstoanie(double rasst){this.rasst = rasst;}
        public void setCost(double cost) { this.cost = cost; }

     


        public double Cost_deliv() { return Math.Round((customer.getcargo().getcargo_Weight() / rasst),3); }

        public void Print()
        {
            Console.WriteLine("Дата отправки:");
            Console.WriteLine("" + sending_date);

            Console.WriteLine("Адрес отправки(откуда):");
            Console.WriteLine("" + adress_from);

            Console.WriteLine("Адрес отправки(куда):");
            Console.WriteLine("" + adress_to);

            Console.WriteLine("Дата доставки:");
            Console.WriteLine("" + arrival_date);

            Console.WriteLine("Название компании Доставщика:");
            Console.WriteLine("" + carrier.Getcompany_name());

            Console.WriteLine("Адрес Доставщика:");
            Console.WriteLine("" + carrier.Getadress());

            Console.WriteLine("Телефонный номер Доставщика:");
            Console.WriteLine("" + carrier.Gettele_num());

            Console.WriteLine("Реквизиты Доставщика:");
            Console.WriteLine("" + carrier.Getnumber_card());

            Console.WriteLine("Автомобиль Доставщика-марка:");
            Console.WriteLine("" + carrier.Getauto().getauto_mark());

            Console.WriteLine("Автомобиль Доставщика-модель:");
            Console.WriteLine("" + carrier.Getauto().getauto_model());

            Console.WriteLine("Автомобиль Доставщика-ГОС номер:");
            Console.WriteLine("" + carrier.Getauto().getauto_Num());

            Console.WriteLine("Ф.И.О. заказчика:");
            Console.WriteLine("" + customer.getFSP());

            Console.WriteLine("Телефонный номер заказчика:");
            Console.WriteLine("" + customer.gettele_num());

            Console.WriteLine("Наименование груза:");
            Console.WriteLine("" + customer.getcargo().getcargo_Name());

            Console.WriteLine("Вес груза(кг.):");
            Console.WriteLine("" + customer.getcargo().getcargo_Weight());

            Console.WriteLine("Свойства груза:");
            Console.WriteLine("" + customer.getcargo().getcargo_Prop());

            Console.WriteLine("Расстояние грузоперевозки(км.):");
            Console.WriteLine("" + rasst);

            Console.WriteLine("Конечная стоимость исходя из веса груза на километр(т.руб.):");
            Console.WriteLine("" + cost);
        }

        public void PrintFile(StreamWriter file)
        {   
            file.WriteLine("Дата отправки:");
            file.WriteLine("" + sending_date);

            file.WriteLine("Адрес отправки(откуда):");
            file.WriteLine("" + adress_from);

            file.WriteLine("Адрес отправки(куда):");
            file.WriteLine("" + adress_to);

            file.WriteLine("Дата доставки:");
            file.WriteLine("" + arrival_date);

            file.WriteLine("Название компании Доставщика:");
            file.WriteLine("" + carrier.Getcompany_name());

            file.WriteLine("Адрес Доставщика:");
            file.WriteLine("" + carrier.Getadress());

            file.WriteLine("Телефонный номер Доставщика:");
            file.WriteLine("" + carrier.Gettele_num());

            file.WriteLine("Реквизиты Доставщика:");
            file.WriteLine("" + carrier.Getnumber_card());

            file.WriteLine("Автомобиль Доставщика-марка:");
            file.WriteLine("" + carrier.Getauto().getauto_mark());

            file.WriteLine("Автомобиль Доставщика-модель:");
            file.WriteLine("" + carrier.Getauto().getauto_model());

            file.WriteLine("Автомобиль Доставщика-ГОС номер:");
            file.WriteLine("" + carrier.Getauto().getauto_Num());

            file.WriteLine("Ф.И.О. заказчика:");
            file.WriteLine("" + customer.getFSP());

            file.WriteLine("Телефонный номер заказчика:");
            file.WriteLine("" + customer.gettele_num());

            file.WriteLine("Наименование груза:");
            file.WriteLine("" + customer.getcargo().getcargo_Name());

            file.WriteLine("Вес груза(кг.):");
            file.WriteLine("" + customer.getcargo().getcargo_Weight());

            file.WriteLine("Свойства груза:");
            file.WriteLine("" + customer.getcargo().getcargo_Prop());

            file.WriteLine("Расстояние грузоперевозки(км.):");
            file.WriteLine("" + rasst);

            file.WriteLine("Конечная стоимость исходя из веса груза на километр(т.руб.):");
            file.WriteLine("" + cost);
        }
    }
}
