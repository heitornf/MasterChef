using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterChef.Entity
{
    public class Receita
    {
        public Receita()
        {

        }

        public decimal RECEITAID { get; set; }
        public string TITULO { get; set; }
        public string DESCRICAO { get; set; }
        public string INGREDIENTES { get; set; }
        public string MODODEPREPARO { get; set; }
        public string FOTO { get; set; }
        public string TAGS { get; set; }        
    }
}