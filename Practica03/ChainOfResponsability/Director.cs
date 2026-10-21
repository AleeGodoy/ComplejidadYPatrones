using System;

namespace Practica03.ChainOfResponsibility
{
    public class Director : AprobadorDeGastos
    {
        public override void Aprobar(SolicitudDeGasto solicitud)
        {
            Console.WriteLine("Director aprobo el gasto: " + solicitud.Descripcion);
        }
    }
}