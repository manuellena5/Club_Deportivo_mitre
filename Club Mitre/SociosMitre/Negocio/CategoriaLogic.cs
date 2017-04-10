using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class CategoriaLogic
    {
        private CategoriaData _CatD;

        public CategoriaData CatD
        {
            get { return _CatD; }
            set { _CatD = value; }
        }

        public CategoriaLogic()
        {
            CatD = new CategoriaData();
        }

        public List<Categoria> GetAll()
        {
            return CatD.GetAll();
        }

        public Categoria GetOne(int id)
        {
            return CatD.GetOne(id);
        }

        public List<string> TraerCategorias()
        {
            return CatD.TraerCategorias();

        }

        public int TraerIdCategoria(string nombre_cat)
        {
            return CatD.TraerIdCategoria(nombre_cat);
        }


        public void Delete(Categoria cat)
        {
            CatD.Save(cat);
        }
        public void Save(Categoria cat)
        {
            CatD.Save(cat);
        }
        public void Update(Categoria cat)
        {
            CatD.Save(cat);
        }
        public void Insertar(Categoria cat)
        {
            CatD.Save(cat);
        }

    }
}
