using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Task3.Ship;

namespace Task3
{
    class Plane : Vehicle
    {
        public int hight;
        private int passengers;

        public int Hight {
            get { return hight; }
            set { hight = value; }
        }
        public int Passengers
        {
            get { return passengers; }
            set { passengers = value; }
        }
        public Plane(int x, int y, uint price, uint speed, uint year)
            : base(x, y, price, speed, year)
        {

        }
        public Plane(uint price, uint speed, uint year)
            : base(price, speed, year)
        {

        }
    }
    class Car : Vehicle 
    {
        public Car(int x, int y, uint price, uint speed, uint year)
                : base(x, y, price, speed, year)
        {

        }
        public Car(uint price, uint speed, uint year)
            : base(price, speed, year)
        {

        }
    }
    class Ship : Vehicle
    {
        int passengers;
        string port;
        public int Passengers
        {
            get { return passengers; }
            set { passengers = value; }
        }
        public string Port
        {
            get { return port; }
            set { port = value; }
        }

        public Ship(int x, int y, uint price, uint speed, uint year)
            : base(x, y, price, speed, year)
        {

        }
        public Ship(uint price, uint speed, uint year)
            : base(price, speed, year)
        {

        }
    }

    internal class Vehicle
    {
        readonly int x, y;
        readonly uint price;
        readonly uint speed;
        readonly uint year;

        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public uint Price
        {
            get { return price; }
        }
        public uint Speed
        {
            get { return speed; }
        }
        public uint Year
        {
            get { return year; }
        }

        public Vehicle(int x, int y, uint price, uint speed, uint year)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        public Vehicle(uint price, uint speed, uint year)
            : this(0, 0, price, speed, year)
        {
        }
    }

}
