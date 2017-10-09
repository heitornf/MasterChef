using MasterChef.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MasterChef.Repository
{
    public class ReceitaRepository : RepositoryBase<Receita>
    {

        public ReceitaRepository()
        {

        }

        public DbSet<Receita> Receitas { get; set; }

        public override Receita Buscar(int id)
        {
            var linq = from receita in Receitas
                       where receita.RECEITAID == id
                       select receita;

            return linq.FirstOrDefault();
        }

        public override void Incluir(Receita elemento)
        {
            Receitas.Add(elemento);            
        }

        public override IEnumerable<Receita> Listar(params int[] id)
        {
            var linq = from receita in Receitas
                       select receita;

            return new List<Receita>(linq.ToList());
                       
        }
    }
}