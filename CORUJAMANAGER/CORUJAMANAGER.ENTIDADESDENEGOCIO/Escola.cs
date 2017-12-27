using System;
using System.Collections.Generic;
using System.Text;

namespace CORUJAMANAGER.ENTIDADESDENEGOCIO
{
    public class Escola : ObjetoComId
    {
        public IEndereco Endereco{ get; set; }
    }
}
