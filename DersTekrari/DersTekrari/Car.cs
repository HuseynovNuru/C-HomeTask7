using System;
using System.Collections.Generic;
using System.Text;

namespace DersTekrari
{
    internal class Car
    {
        string model;
        string marka;
        double motor;
        int il;
        int qiymet;

        public Car(string model, string marka, double motor, int il, int qiymet)
        {
            this.model = model;
            this.marka = marka;
            this.motor = motor;
            this.il = il;
            this.qiymet = qiymet;
        }

        public string ShowInfo()
        {
            return $"Model:{model}, Marka:{marka},Motor:{motor},Il:{il},Qiymet:{qiymet}";
        }

    }


   
}
