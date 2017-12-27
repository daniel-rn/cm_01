using System;

namespace CORUJAMANAGER.ENTIDADESDENEGOCIO
{
    public class Endereco : ObjetoComId,IEndereco
    {
        public int Numero { get; set; }
        public int Quadra { get; set; }
        public int Lote { get; set; }
        public IEstado Estado { get; set; }
        public ICidade Cidade { get; set; }

        public Endereco(string nome,int numero, int quadra, int lote, IEstado estado, ICidade cidade)
        {
            Nome = nome;
            Numero = numero;
            Quadra = quadra;
            Lote = lote;
            Estado = estado ?? throw new ArgumentNullException(nameof(estado));
            Cidade = cidade ?? throw new ArgumentNullException(nameof(cidade));
        }

        public override string ToString()
        {
            return $"Rua: {Nome} Quadra: {Quadra} lote: {Lote}";
        }
    }
}
