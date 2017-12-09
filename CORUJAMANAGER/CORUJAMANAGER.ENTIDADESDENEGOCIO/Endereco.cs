using System;
using System.Collections.Generic;
using System.Text;

namespace CORUJAMANAGER.ENTIDADESDENEGOCIO
{
    public class Endereco : ObjetoComId
    {
        public int Numero { get; set; }
        public int Quadra { get; set; }
        public int Lote { get; set; }
        public IEstado Estado { get; set; }
        public ICidade Cidade { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
