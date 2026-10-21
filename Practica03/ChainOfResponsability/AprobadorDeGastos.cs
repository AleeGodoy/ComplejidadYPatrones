using System;

namespace Practica03.ChainOfResponsibility
{
    public abstract class AprobadorDeGastos
    {
        protected AprobadorDeGastos sucesor;

        public void EstablecerSucesor(AprobadorDeGastos sucesor)
        {
            this.sucesor = sucesor;
        }

        public abstract void Aprobar(SolicitudDeGasto solicitud);

        protected void Delegar(SolicitudDeGasto solicitud)
        {
            if (sucesor != null)
            {
                sucesor.Aprobar(solicitud);
            }
            else
            {
                Console.WriteLine(
                    "Nadie puede aprobar el gasto: " +
                    solicitud.Descripcion +
                    " ($" + solicitud.Monto + ").");
            }
        }
    }
}