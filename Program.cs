using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamWriter file = new StreamWriter(File.Create("Result.txt"));
            DateTime sending_date;
            DateTime arrival_date;
            string auto_mark;
            string auto_model;
            string auto_Num;

            string company_name;
            string adress;
            string number_card;
            string tele_numс;

            string cargo_Name;
            float cargo_Weight;
            string cargo_Prop;

            string FSP;
            string tele_num;

            string adress_from;
            string adress_to;

            double rasst;

            while (true)
            {
                Console.WriteLine("Меню");
                Console.WriteLine("1-Ввод из файла");
                Console.WriteLine("2-Ввод из консоли");
                int M = int.Parse(Console.ReadLine());
                switch (M)
                {
                    case 1:
                        int i = 0;
                        Delivery[] delivery = new Delivery[30];
                        Carrier[] carrier = new Carrier[30];
                        Auto[] autos = new Auto[30];
                        Customer[] customer = new Customer[30];
                        Cargo[] cargos = new Cargo[30];


                        StreamReader sr = File.OpenText("Delivery.txt");
                        while (true)
                        {
                            string str = sr.ReadLine();
                            if (str == null)
                                break;
                            string[] elements = str.Split(';');

                            autos[i] = new Auto();
                            autos[i].setauto_mark(elements[8]);
                            autos[i].setauto_model(elements[9]);
                            autos[i].setauto_Num(elements[10]);

                            carrier[i] = new Carrier();
                            carrier[i].setcompany_name(elements[4]);
                            carrier[i].setadress(elements[5]);
                            carrier[i].settele_num(elements[6]);
                            carrier[i].setnumber_card(elements[7]);
                            carrier[i].setauto(autos[i]);

                            cargos[i] = new Cargo();
                            cargos[i].setcargo_Name(elements[11]);
                            cargos[i].setcargo_Weight(int.Parse(elements[12]));
                            cargos[i].setcargo_Prop(elements[13]);

                            customer[i] = new Customer();
                            customer[i].setFSP(elements[14]);
                            customer[i].settele_num(elements[15]);
                            customer[i].setcargo(cargos[i]);

                            delivery[i] = new Delivery();
                            delivery[i].setsending_date(DateTime.Parse(elements[0]));
                            delivery[i].setadress_from(elements[1]);
                            delivery[i].setadress_to(elements[2]);
                            delivery[i].setarrival_date(DateTime.Parse(elements[3]));
                            delivery[i].setcarrier(carrier[i]);
                            delivery[i].setcustomer(customer[i]);
                            delivery[i].setRasstoanie(float.Parse(elements[16]));
                            delivery[i].setCost(delivery[i].Cost_deliv());


                            i++;
                        }
                        sr.Close();
                        i = 0;
                        while (true)
                        {
                            if (delivery[i] == null) break;
                            Console.WriteLine("Грузоперевозка[" + (i + 1) + "]");
                            file.WriteLine("Грузоперевозка[" + (i + 1) + "]");
                            delivery[i].Print();
                            delivery[i].PrintFile(file);
                            i++;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите количество грузоперевозок");
                        int n = (int.Parse(Console.ReadLine()));
                        Delivery[] deliveryc = new Delivery[n];
                        Carrier[] carrierc = new Carrier[n];
                        Auto[] autosc = new Auto[n];
                        Customer[] customerc = new Customer[n];
                        Cargo[] cargosc = new Cargo[n];


                        for (i = 0; i < n; i++)
                        {
                            Console.WriteLine("Введите дату отправки груза");
                            sending_date = (DateTime.Parse(Console.ReadLine()));
                            Console.WriteLine($"Дата отправки : {sending_date}");

                            Console.WriteLine("Введите дату доставки груза");
                            arrival_date = (DateTime.Parse(Console.ReadLine()));
                            Console.WriteLine($"Дата доставки : {arrival_date}");

                            autosc[i] = new Auto();
                            //Авто
                            Console.WriteLine("Введите автомобиль,доставляющий груз");
                            Console.WriteLine("Марка автомобиля");
                            auto_mark = ((Console.ReadLine()));
                            Console.WriteLine("Модель автомобиля");
                            auto_model = ((Console.ReadLine()));
                            Console.WriteLine("Гос. регистрационный номер автомобиля");
                            auto_Num = ((Console.ReadLine()));


                            autosc[i].setauto_mark(auto_mark);
                            autosc[i].setauto_model(auto_model);
                            autosc[i].setauto_Num(auto_Num);

                            carrierc[i] = new Carrier();
                            //Отправитель
                            Console.WriteLine("Введите наименование Доставщика");
                            company_name = ((Console.ReadLine()));
                            Console.WriteLine("Введите адрес Доставщика");
                            adress = ((Console.ReadLine()));
                            Console.WriteLine("Введите телефонный номер Доставщика");
                            tele_numс = ((Console.ReadLine()));
                            tele_numс = tele_numс.Substring(tele_numс.IndexOf(':') + 2);
                            int count = 0;
                            foreach (char c in tele_numс)
                            {
                                if (!char.IsDigit(c))
                                {
                                    Console.WriteLine("Некорректно номер телефона.");
                                    Console.WriteLine("Введите заново телефонный номер Доставщика");
                                    tele_numс = ((Console.ReadLine()));
                                }
                                count++;
                            }
                            if (count != 11)
                            {
                                Console.WriteLine("Некорректно номер телефона.");
                                Console.WriteLine("Введите заново телефонный номер Доставщика");
                                tele_numс = ((Console.ReadLine()));
                            }
                            Console.WriteLine("Введите реквизиты Доставщика");
                            number_card = ((Console.ReadLine()));

                            carrierc[i].setcompany_name(company_name);
                            carrierc[i].setadress(adress);
                            carrierc[i].settele_num(tele_numс);
                            carrierc[i].setnumber_card(number_card);
                            Console.WriteLine("Авто Доставщика");
                            carrierc[i].setauto(autosc[i]);//

                            cargosc[i] = new Cargo();
                            //Груз
                            Console.WriteLine("Введите наименование груза");
                            cargo_Name = ((Console.ReadLine()));

                            Console.WriteLine("Введите вес груза");

                            cargo_Weight = (float.Parse(Console.ReadLine()));

                            if (cargo_Weight < 0)
                            {
                                Console.WriteLine("Введено неверное значение");
                                cargo_Weight = (float.Parse(Console.ReadLine()));
                            }
                            Console.WriteLine("Введите характеристики груза");
                            cargo_Prop = ((Console.ReadLine()));


                            cargosc[i].setcargo_Name(cargo_Name);
                            cargosc[i].setcargo_Weight(cargo_Weight);
                            cargosc[i].setcargo_Prop(cargo_Prop);


                            customerc[i] = new Customer();
                            //Заказчик
                            Console.WriteLine("Введите наименование Заказчика");
                            FSP = ((Console.ReadLine()));
                            Console.WriteLine("Введите телефонный номер Заказчика");
                            tele_num = ((Console.ReadLine()));
                            tele_num = tele_num.Substring(tele_num.IndexOf(':') + 2);
                           
                            foreach (char c in tele_num)
                            {
                                if (!char.IsDigit(c))
                                {
                                    Console.WriteLine("Некорректно номер телефона.");
                                    Console.WriteLine("Введите заново телефонный номер Заказчика");
                                    tele_num = ((Console.ReadLine()));
                                }
                                count++;
                            }
                            if (count != 11)
                            {
                                Console.WriteLine("Некорректно номер телефона.");
                                Console.WriteLine("Введите заново телефонный номер Заказчика");
                                tele_num = ((Console.ReadLine()));
                            }
                                customerc[i].setFSP(FSP);

                                customerc[i].settele_num(tele_num);
                                customerc[i].setcargo(cargosc[i]);//



                                deliveryc[i] = new Delivery();
                                Console.WriteLine("Введите адрес,откуда произойдет отправка");
                                adress_from = ((Console.ReadLine()));
                                Console.WriteLine("Введите адрес,куда произойдет доставка");
                                adress_to = ((Console.ReadLine()));
                                Console.WriteLine("Введите расстояние,на которое нужно перевезти груз");
                                rasst = (double.Parse(Console.ReadLine()));
                                if (rasst < 0)
                                {
                                    Console.WriteLine("Введено неверное значение");
                                    rasst = (double.Parse(Console.ReadLine()));
                                }


                                deliveryc[i].setsending_date(sending_date);
                                //
                                deliveryc[i].setarrival_date(arrival_date);

                                deliveryc[i].setcarrier(carrierc[i]);//

                                deliveryc[i].setcustomer(customerc[i]);//

                                deliveryc[i].setadress_from(adress_from);
                                deliveryc[i].setadress_to(adress_to);
                                deliveryc[i].setRasstoanie(rasst);
                                deliveryc[i].setCost(deliveryc[i].Cost_deliv());


                            }

                            for (int a = 0; a < n; a++)
                            {
                                Console.WriteLine("Грузоперевозка[" + (a + 1) + "]");
                                file.WriteLine("Грузоперевозка[" + (a + 1) + "]");
                                deliveryc[a].Print();
                                deliveryc[a].PrintFile(file);
                            }
                            break;
                        }
                        file.Close();
                        Console.ReadKey();
                }

            }
        }
    }

