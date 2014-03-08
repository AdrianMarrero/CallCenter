using System.Collections.Generic;
using System.Data.Entity;

namespace CallCenter.Models
{
    public class AveriaDatabaseInitializer : DropCreateDatabaseIfModelChanges<AveriaContext>
    {


    protected override void Seed(AveriaContext context)
    {
      GetCategoria().ForEach(c => context.Categorias.Add(c));
      GetAverias().ForEach(p => context.Averias.Add(p));
    }

    private static List<Categoria> GetCategoria()
    {
      var categorias = new List<Categoria> {
                new Categoria
                {
                    CategoriaID = 1,
                    CategoriaNombre = "Software"
                },
                new Categoria
                {
                    CategoriaID = 2,
                    CategoriaNombre = "Hardware"
                },

            };

      return categorias;
    }

    private static List<Averia> GetAverias()
    {
        var averias = new List<Averia> {
                new Averia
                {
                    AveriaID = 1,
                    AveriaNombre = "Actualización",
                    Descripcion = "Si está ejecutando una versión sin parche de Windows, versión obsoleta de Firefox o la versión vulnerable de Java , su equipo está en riesgo.", 
                    ImagePath="software.jpg",
                    UnitPrecio = 22.50,
                    CategoriaID = 1
               },
                new Averia 
                {
                    AveriaID = 2,
                    AveriaNombre = "Antivirus",
                    Descripcion = "Su equipo debe de disponer de un antivirus actualizado con el que proteger el equipo de ataques malintencionados", 
                    ImagePath="antivirus.jpg",
                    UnitPrecio = 35,
                    CategoriaID = 1
               },
                new Averia
                {
                    AveriaID = 3,
                    AveriaNombre = "Drivers",
                    Descripcion = "Para que su equipo funcione correctamente debe disponer de los driver adecuados a sus componentes. Cada fabricante se los suministrará", 
                    ImagePath="software.jpg",
                    UnitPrecio = 15,
                    CategoriaID = 1
                },
                new Averia
                {
                    AveriaID = 4,
                    AveriaNombre = "Anti-Malware",
                    Descripcion = "Debemos protegernos ante los ataques que podamos sufrir en nuestra navegación web", 
                    ImagePath="malware.jpg",
                    UnitPrecio = 10,
                    CategoriaID = 1
                },
                new Averia
                {
                    AveriaID = 5,
                    AveriaNombre = "Software original",
                    Descripcion = "Utilizar siempre software original. Aquí sólo confiamos en programas debidamente registrados", 
                    ImagePath="software.jpg",
                    UnitPrecio = 50,
                    CategoriaID = 1
                },
                new Averia
                {
                    AveriaID = 6,
                    AveriaNombre = "Tarjeta Gráfica",
                    Descripcion = "No visualización corracta de la imagen. Imagénes pixeladas", 
                    ImagePath="hardware.png",
                    UnitPrecio = 40,
                    CategoriaID = 2
                },
                new Averia
                {
                    AveriaID = 7,
                    AveriaNombre = "Sonido",
                    Descripcion = "Sonido inadecuado o inexistente cuando ejecuta algun archivo, posible fallo de la tarjeta de sonido", 
                    ImagePath="hardware.png",
                    UnitPrecio = 35,
                    CategoriaID = 2
                },
                new Averia
                {
                    AveriaID = 8,
                    AveriaNombre = "Fuente de Alimentación",
                    Descripcion = "El equipo no responde cuando tratamos de arrancarlo, no le llega la corriente eléctrica.", 
                    ImagePath="fuente.jpg",
                    UnitPrecio = 18,
                    CategoriaID = 2
                },
                new Averia
                {
                    AveriaID = 9,
                    AveriaNombre = "Monitor",
                    Descripcion = "Dispones de excelentes monitores con gran resolución", 
                    ImagePath="monitor.jpg",
                    UnitPrecio = 75,
                    CategoriaID = 2
                },
                new Averia
                {
                    AveriaID = 10,
                    AveriaNombre = "Disco Duro",
                    Descripcion = "Falta de espacio en el disco duro debido al que el mismo puede estas lleno o averiado", 
                    ImagePath="discoduro.jpg",
                    UnitPrecio = 36,
                    CategoriaID = 2
                },
                new Averia
                {
                    AveriaID = 11,
                    AveriaNombre = "Memoria RAM",
                    Descripcion = "Actualice sus equipo añadiendole nuevos módules de memoria RAM", 
                    ImagePath="ram.jpg",
                    UnitPrecio = 22.50,
                    CategoriaID = 2
                },
                new Averia
                {
                    AveriaID = 12,
                    AveriaNombre = "Ventilador",
                    Descripcion = "Máxima refrigeración con nuestros nuevos ventiladores turbo-bost", 
                    ImagePath="ventilador.jpg",
                    UnitPrecio = 13,
                    CategoriaID = 2
                },
                new Averia
                {
                    AveriaID = 13,
                    AveriaNombre = "Teclado",
                    Descripcion = "Teclado no responde o se queda bloqueado", 
                    ImagePath="teclado.jpg",
                    UnitPrecio = 12,
                    CategoriaID = 2
                },
                new Averia
                {
                    AveriaID = 14,
                    AveriaNombre = "Ratón",
                    Descripcion = "Se desplaza lentamente y sus botones no responden como deseariamos", 
                    ImagePath="raton.jpg",
                    UnitPrecio = 18,
                    CategoriaID = 2
                }

            };

        return averias;
    }
    }
}