using System;

namespace Practica03.ChainOfResponsibility
{
    public class Gerente : AprobadorDeGastos
    {
        public override void Aprobar(SolicitudDeGasto solicitud)
        {
            if (solicitud.Monto <= 5000)
            {
                Console.WriteLine( "Gerente aprobo el gasto: " + solicitud.Descripcion);
            }
            else
            {
                Delegar(solicitud);
            }
        }
    }
}