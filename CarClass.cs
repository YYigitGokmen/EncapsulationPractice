using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPractice
{
    internal class CarClass
    {
        //Araba sınıfının özellikleri -> Marka, Model, Renk, Kapı Sayısı
        private string? _brand;
        private string? _model;
        private string? _color;
        private int _numberOfCarDoors;

        public string? Brand
        { get { return _brand; } set { _brand = value; } }
        public string? Model
        { get { return _model; } set { _model = value; } }
        public string? Color
        { get { return _color; } set { _color = value; } }

        //Özelliklerimizden (Property) Kapı sayısı için kapsülleme işlemi yapmak istiyoruz.
        public int NumberOfCarDoors
        {
            get { return _numberOfCarDoors; }

            set
            {
                if (value == 2 || value == 4)
                {
                    _numberOfCarDoors = value;
                }
                else
                {
                    Console.WriteLine("YANLIŞ KAPI SAYISI GİRDİNİZ!");
                    _numberOfCarDoors--;

                }

            }

        }
        public CarClass(string brand, string model, string color, int door)
        {
            Brand = brand;
            Model = model;
            Color = color;
            NumberOfCarDoors = door;

        }


        public void DisplayCar()
        {
            Console.WriteLine($"{_brand} marka aracınız, {_numberOfCarDoors} Kapı sayısıyla üretilmiştir");

        }


    }


}

