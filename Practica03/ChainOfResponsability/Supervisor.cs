using System;

namespace Practica03.ChainOfResponsibility
{
    public class Supervisor : AprobadorDeGastos
    {
        public override void Aprobar(SolicitudDeGasto solicitud)
        {
            if (solicitud.Monto <= 1000)
            {
                Console.WriteLine("Supervisor aprobo el gasto: " + solicitud.Descripcion);
            }
            else
            {
                Delegar(solicitud);
            }
        }
    }
}