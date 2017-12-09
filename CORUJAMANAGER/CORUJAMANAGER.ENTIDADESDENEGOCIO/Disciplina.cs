namespace CORUJAMANAGER.ENTIDADESDENEGOCIO
{
    public class Disciplina : ObjetoComId
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
