namespace Practica03.ChainOfResponsibility
{
    public class SolicitudDeGasto
    {
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }

        public SolicitudDeGasto(decimal monto, string descripcion)
        {
            Monto = monto;
            Descripcion = descripcion;
        }
    }
}