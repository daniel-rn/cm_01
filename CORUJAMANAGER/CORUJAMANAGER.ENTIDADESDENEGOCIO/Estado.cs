﻿namespace CORUJAMANAGER.ENTIDADESDENEGOCIO
{
    public class Estado : ObjetoComId, IEstado
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
            return Nome;
        }
    }
}
