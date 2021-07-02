﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class specialCar
    {
        private string make;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private Engine engine;

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        private double fuelQuantity;

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public specialCar(string make, string model, int year, Engine engine, double fuelQuantity) 
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Engine = engine;
            this.FuelQuantity = fuelQuantity;
        }
    }
}
