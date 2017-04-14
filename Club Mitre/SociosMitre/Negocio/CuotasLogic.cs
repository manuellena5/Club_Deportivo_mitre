using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class CuotasLogic
    {
        private CuotasData _CuotasD;

        public CuotasData CuotasD
        {
          get { return _CuotasD; }
         set { _CuotasD = value; }
        }


       
        public CuotasLogic()
        {
            CuotasD = new CuotasData();
        }

        public List<Cuotas> GetAll()
        {
            return CuotasD.GetAll();
        }

        public Cuotas GetOne(int id, int mes, int anio)
        {
            return CuotasD.GetOne(id,mes,anio);
        }

        public List<Cuotas> TraerPorSocio(int id)
        {
            return CuotasD.TraerPorSocio(id);
        }

        

        public List<Cuotas> TraerPorMes(int Mes)
        {
            return CuotasD.TraerPorMes(Mes);
        }

        public List<Cuotas> TraerPorMesParaSocio(int mes,int id)
        {
            return CuotasD.TraerPorMesParaSocio(mes,id);
        }

        public List<Cuotas> TraerPorAño(string txtBuscado)
        {
            return CuotasD.TraerPorAño(txtBuscado);
        }

        public List<Cuotas> TraerPorAñoParaSocio(string txtBuscado,int id)
        {
            return CuotasD.TraerPorAñoParaSocio(txtBuscado,id);
        }

        public List<Balance> TraerBalanceClubMutual(int anio, string tipo, string categoria)
        {
            return CuotasD.TraerBalanceClubMutual(anio,tipo,categoria);
        }

        public List<Balance> TraerBalanceClubMutualAñoActual()
        {
            return CuotasD.TraerBalanceClubMutualAñoActual();
        }


        public void Delete(Cuotas pago)
        {
            CuotasD.Save(pago);
        }
        public void Save(Cuotas pago)
        {
            CuotasD.Save(pago);
        }
        public void Update(Cuotas pago,int anioOld,int mesOld)
        {
            CuotasD.Editar(pago,anioOld,mesOld);
        }
        public void Insertar(Cuotas pago)
        {
            CuotasD.Save(pago);
        }

    }
}
