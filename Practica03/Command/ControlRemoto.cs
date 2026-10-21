namespace Practica03.Command
{
    public class ControlRemoto
    {
        private IComando ultimoComando;

        public void Ejecutar(IComando comando)
        {
            comando.Ejecutar();
            ultimoComando = comando;
        }

        public void DeshacerUltimo()
        {
            if (ultimoComando != null)
            {
                ultimoComando.Deshacer();
                ultimoComando = null;
            }
        }
    }
}