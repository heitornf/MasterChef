using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterChef.Entity
{
    public class Categoria
    {
        public Categoria()
        {

        }

        public decimal CATEGORIAID { get; set; }
        public string TITULO { get; set; }
        public string DESCRICAO { get; set; }
    }
}