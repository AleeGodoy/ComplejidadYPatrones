namespace Practica03.Proxy
{
    public class DocumentoProxy : IDocumento
    {
        private DocumentoReal documentoReal;

        public string Leer(string usuario)
        {
            if (usuario != "admin")
            {
                return "Acceso denegado.";
            }

            if (documentoReal == null)
            {
                documentoReal = new DocumentoReal();
            }

            return documentoReal.Leer(usuario);
        }
    }
}