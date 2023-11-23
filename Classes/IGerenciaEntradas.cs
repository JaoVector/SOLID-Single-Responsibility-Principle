using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP.Classes
{
    public interface IGerenciaEntradas<T>
    {
        void Adiciona(T entry);
        void Exclui(int index);
        List<T> Lista();
    }
}