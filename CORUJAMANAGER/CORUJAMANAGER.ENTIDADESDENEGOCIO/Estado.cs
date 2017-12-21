namespace CORUJAMANAGER.ENTIDADESDENEGOCIO
{
    public class Estado : ObjetoComId, IEstado
    {
        public override string ToString()
        {
            return Nome;
        }
    }
}
