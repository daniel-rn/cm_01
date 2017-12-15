namespace CORUJAMANAGER.ENTIDADESDENEGOCIO
{
    public class Aluno : ObjetoComId
    {
        public string DataNascimento { get; set; }

        public string SenhaDeAcesso { get; set; }
        
        public override bool Equals(object obj)
        {
            return Nome.Equals(obj);
        }

        public override string ToString()
        {
            return Nome;
        }

        public override int GetHashCode() => Id;
    }
}
