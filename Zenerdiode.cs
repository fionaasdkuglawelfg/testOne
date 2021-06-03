using System;
using System.Collections.Generic;
using System.Text;

namespace ZenerdiodeAufgabe
{
    class Zenerdiode
    {
        //Variablen
        private double voltageUz;
        private double powerPztot;
        private double currentIztot;
        private double currentIzmin;
        private double currentIzmax;
        private double currentIz;
        private double noname;


        //Konstruktor
        public Zenerdiode(double spannungUz, double leistungPztot)
        {
            voltageUz = spannungUz;
            powerPztot = leistungPztot;
            currentIztot = (spannungUz / leistungPztot);
            currentIzmax = (0.9 * currentIztot);
            currentIzmin = (0.1 * currentIztot);
            currentIz = (0.5 * currentIztot);
        }
        public void setCurrent (double StromIz)
        {
            //gitHub
        }
        public double getVoltageUz()
        {

        }
        public double getPowerPz()
        {

        }
        public double getCurrentIztot()
        {

        }
        public double getCurrentIzmin()
        {

        }
        public double getCurrentIzmax()
        {

        }
        public bool testWorkingArea()
        {

        }
    }
}
