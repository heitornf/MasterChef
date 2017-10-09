using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MasterChef.Repository
{
    public abstract class RepositoryBase<T>
    {               
        public abstract void Incluir(T elemento);       
        public abstract T Buscar(int id);
        public abstract IEnumerable<T> Listar(params int[] id);
    }
}