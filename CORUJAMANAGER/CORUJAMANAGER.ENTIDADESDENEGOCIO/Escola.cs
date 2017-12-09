using System;
using System.Collections.Generic;
using System.Text;

namespace CORUJAMANAGER.ENTIDADESDENEGOCIO
{
    public class Escola : ObjetoComId
    {
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
