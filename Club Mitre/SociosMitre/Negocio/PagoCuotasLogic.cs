using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class PagoCuotasLogic
    {
        private PagoCuotasData _PagosD;

        public PagoCuotasData PagosD
        {
          get { return _PagosD; }
         set { _PagosD = value; }
        }


       
        public PagoCuotasLogic()
        {
            PagosD = new PagoCuotasData();
        }

        public List<PagoCuotas> GetAll()
        {
            return PagosD.GetAll();
        }

        public List<PagoCuotas> TraerControl()
        {
            return PagosD.TraerControl();
        }

        public List<PagoCuotas> TraerPorMes(string txtBuscado)
        {
            return PagosD.TraerPorMes(txtBuscado);
        }


        public void Delete(PagoCuotas pago)
        {
            PagosD.Save(pago);
        }
        public void Save(PagoCuotas pago)
        {
            PagosD.Save(pago);
        }
        public void Update(PagoCuotas pago)
        {
            PagosD.Save(pago);
        }
        public void Insertar(PagoCuotas pago)
        {
            PagosD.Save(pago);
        }

    }
}
