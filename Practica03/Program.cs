using System;
using Practica03.Adapter;
using Practica03.Proxy;
using Practica03.Command;
using Practica03.Composite;
using Practica03.TemplateMethod;
using Practica03.ChainOfResponsibility;
using Practica03.Singleton;

namespace Practica03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProbarAdapter();
            ProbarProxy();
            ProbarCommand();
            ProbarComposite();
            ProbarTemplateMethod();
            ProbarChainOfResponsibility();
            ProbarSingleton();

     
        }

        static void ProbarAdapter()
        {
            Console.WriteLine("PATRON ADAPTER");
            Console.WriteLine();

            ReproductorMp3 reproductorMp3 = new ReproductorMp3();

            ReproductorAvanzadoExterno reproductorExterno =
                new ReproductorAvanzadoExterno();

            AdaptadorReproductorAvanzado adaptador =
                new AdaptadorReproductorAvanzado(reproductorExterno);

            ReproducirArchivo(reproductorMp3, "cancion.mp3");
            ReproducirArchivo(adaptador, "video.avi");
            ReproducirArchivo(adaptador, "pelicula.mp4");

            Console.WriteLine();
        }

        static void ReproducirArchivo(
            IReproductor reproductor, string archivo)
        {
            reproductor.Reproducir(archivo);
        }

        static void ProbarProxy()
        {
            Console.WriteLine("PATRON PROXY");
            Console.WriteLine();

            IDocumento documento = new DocumentoProxy();

            Console.WriteLine(documento.Leer("invitado"));
            Console.WriteLine(documento.Leer("admin"));
            Console.WriteLine(documento.Leer("admin"));

            Console.WriteLine();
        }

        static void ProbarCommand()
        {
            Console.WriteLine("PATRON COMMAND");
            Console.WriteLine();

            Luz luz = new Luz();
            ControlRemoto control = new ControlRemoto();

            IComando encender = new ComandoEncenderLuz(luz);
            IComando apagar = new ComandoApagarLuz(luz);

            control.Ejecutar(encender);
            control.Ejecutar(apagar);
            control.DeshacerUltimo();
            control.Ejecutar(encender);
            control.DeshacerUltimo();

            Console.WriteLine();
        }

        static void ProbarComposite()
        {
            Console.WriteLine("PATRON COMPOSITE");
            Console.WriteLine();

            Carpeta carpetaPrincipal = new Carpeta("Carpeta principal");
            Carpeta documentos = new Carpeta("Documentos");

            Archivo archivo1 = new Archivo("archivo1.txt", 100);
            Archivo archivo2 = new Archivo("archivo2.txt", 200);
            Archivo archivo3 = new Archivo("archivo3.txt", 300);

            documentos.Agregar(archivo1);
            documentos.Agregar(archivo2);

            carpetaPrincipal.Agregar(documentos);
            carpetaPrincipal.Agregar(archivo3);

            carpetaPrincipal.Mostrar(0);

            Console.WriteLine(
                "Tamaño total: " +
                carpetaPrincipal.ObtenerTamano() + " bytes");

            Console.WriteLine();
        }

        static void ProbarTemplateMethod()
        {
            Console.WriteLine("PATRON TEMPLATE METHOD");
            Console.WriteLine();

            PreparadorDeBebida cafe = new PreparadorDeCafe();
            PreparadorDeBebida te = new PreparadorDeTe();

            Console.WriteLine("Preparando café:");
            cafe.PrepararBebida();

            Console.WriteLine();

            Console.WriteLine("Preparando té:");
            te.PrepararBebida();

            Console.WriteLine();
        }

        static void ProbarChainOfResponsibility()
        {
            Console.WriteLine("PATRON CHAIN OF RESPONSIBILITY");
            Console.WriteLine();

            Supervisor supervisor = new Supervisor();
            Gerente gerente = new Gerente();
            Director director = new Director();

            supervisor.EstablecerSucesor(gerente);
            gerente.EstablecerSucesor(director);

            SolicitudDeGasto gasto1 =
                new SolicitudDeGasto(800, "Compra de materiales");

            SolicitudDeGasto gasto2 =
                new SolicitudDeGasto(3000, "Compra de equipos");

            SolicitudDeGasto gasto3 =
                new SolicitudDeGasto(7000, "Renovacion de instalaciones");

            supervisor.Aprobar(gasto1);
            supervisor.Aprobar(gasto2);
            supervisor.Aprobar(gasto3);

            Console.WriteLine();

            Supervisor supervisorSinSucesor = new Supervisor();

            SolicitudDeGasto gasto4 =
                new SolicitudDeGasto(2000, "Compra sin responsable");

            supervisorSinSucesor.Aprobar(gasto4);

            Console.WriteLine();
        }

        static void ProbarSingleton()
        {
            Console.WriteLine("PATRON SINGLETON");
            Console.WriteLine();

            ConfiguracionDelSistema configuracion1 =
                ConfiguracionDelSistema.ObtenerInstancia();

            ConfiguracionDelSistema configuracion2 =
                ConfiguracionDelSistema.ObtenerInstancia();

            configuracion1.EstablecerValor("Idioma", "Español");

            Console.WriteLine(
                "Valor desde configuracion1: " +
                configuracion1.ObtenerValor("Idioma"));

            Console.WriteLine(
                "Valor desde configuracion2: " +
                configuracion2.ObtenerValor("Idioma"));

            Console.WriteLine(
                "¿Es la misma instancia? " +
                (configuracion1 == configuracion2));

            Console.WriteLine();
        }
    }
}