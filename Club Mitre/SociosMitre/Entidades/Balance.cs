using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Balance: BusinessEntities
    {

        #region VARIABLES

        private int _NroMes;
        private string _Mes;
        private double _ImporteClub;
        private double _ImporteMutual;
        private double _TotalSuma;
        private double _TotalTotal;




        #endregion



        #region PROPIEDADES

        public double TotalTotal
        {
            get { return _TotalTotal; }
            set { _TotalTotal = value; }
        }

        public double TotalSuma
        {
            get { return _TotalSuma; }
            set { _TotalSuma = value; }
        }

        public double ImporteMutual
        {
            get { return _ImporteMutual; }
            set { _ImporteMutual = value; }
        }

        public double ImporteClub
        {
            get { return _ImporteClub; }
            set { _ImporteClub = value; }
        }

        public string Mes
        {
            get { return _Mes; }
            set { _Mes = value; }
        }
        public int NroMes
        {
            get { return _NroMes; }
            set { _NroMes = value; }
        }

        #endregion

        #region CONSTRUCTOR

        public Balance ()
        {

        }

        public Balance(int nromes,string mes,double importeclub,double importemutual,double TotalSuma,double totaltotal)
        {
            this.NroMes = nromes;
            this.Mes = mes;
            this.ImporteClub = importeclub;
            this.ImporteMutual = importemutual;
            this.TotalSuma = TotalSuma;
            this.TotalTotal = totaltotal;


        }

        #endregion


    }
}
