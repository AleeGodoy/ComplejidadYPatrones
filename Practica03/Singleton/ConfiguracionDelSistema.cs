using System.Collections.Generic;

namespace Practica03.Singleton
{
    public class ConfiguracionDelSistema
    {
        private static ConfiguracionDelSistema instancia;
        private Dictionary<string, string> valores;

        private ConfiguracionDelSistema()
        {
            valores = new Dictionary<string, string>();
        }

        public static ConfiguracionDelSistema ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ConfiguracionDelSistema();
            }

            return instancia;
        }

        public void EstablecerValor(string clave, string valor)
        {
            valores[clave] = valor;
        }

        public string ObtenerValor(string clave)
        {
            if (valores.ContainsKey(clave))
            {
                return valores[clave];
            }

            return null;
        }
    }
}