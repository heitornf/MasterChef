using MasterChef.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MasterChef.Repository
{
    public class CategoriaRepository : RepositoryBase<Categoria>
    {
        public CategoriaRepository()
        {

        }

        public DbSet<Categoria> Categorias { get; set; }

        public override Categoria Buscar(int id)
        {
            var linq = from Categoria in Categorias
                       where Categoria.CATEGORIAID == id
                       select Categoria;

            return linq.FirstOrDefault();
        }

        public override void Incluir(Categoria elemento)
        {
            Categorias.Add(elemento);
        }

        public override IEnumerable<Categoria> Listar(params int[] id)
        {
            var linq = from Categoria in Categorias
                       select Categoria;

            return new List<Categoria>(linq.ToList());

        }
    }
}