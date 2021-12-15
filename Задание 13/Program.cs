using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building firstBuilding = new Building("Чистопольская 20", 20, 12, 5);
            firstBuilding.Print();
            Console.WriteLine();
            MultiBuilding secondBuilding = new MultiBuilding("Чистопольская 25", 30, 18, 15, 4);
            secondBuilding.MPrint();
            Console.ReadKey();
        }
    }
    public class Building
    {
        protected string address;
        protected int length;
        protected int width;
        protected int height;
        public string Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }
        public int Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                }
            }
            get
            {
                return length;
            }
        }
        public int Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                }
            }
            get
            {
                return width;
            }
        }
        public int Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                }
            }
            get
            {
                return height;
            }
        }
        public Building(string address, int length, int width, int height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine("Адрес здания: \t{0};\nДлина здания: \t{1} м;\nШирина здания: \t{2} м;\nВысота здания: \t{3} м.", Address, Length, Width, Height);
        }


    }
    class MultiBuilding : Building
    {
        protected int numberFloor;
        public int NumberFloor
        {
            set
            {
                if (value > 0)
                {
                    numberFloor = value;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                }
            }
            get
            {
                return numberFloor;
            }
        }
        public MultiBuilding(string address, int length, int width, int height, int numberFloor)
            : base (address, length, width, height)
            {
            NumberFloor = numberFloor;
            }
        public void MPrint()
        { 
            base.Print();
            Console.WriteLine("Количество этажей в здании: \t{0} м.", numberFloor);
        }
    }
}
