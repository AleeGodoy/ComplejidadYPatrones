using System;

namespace Practica03.Proxy
{
    public class DocumentoReal : IDocumento
    {
        public DocumentoReal()
        {
            Console.WriteLine("Cargando documento real...");
        }

        public string Leer(string usuario)
        {
            return "Contenido del documento.";
        }
    }
}