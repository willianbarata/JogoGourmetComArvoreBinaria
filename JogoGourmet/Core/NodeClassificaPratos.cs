using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet.Core
{
    public class NodeClassificaPratos
    {
        public string Valor;
        public NodeClassificaPratos PratoFilhoEsquerdo;
        public NodeClassificaPratos PratoFilhoDireito;

        public NodeClassificaPratos(string valor)
        {
            Valor = valor;
        }
        public bool NaoTemPratoFilho()
        {
            return PratoFilhoEsquerdo == null && PratoFilhoDireito == null;
        }
    }
}
