using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoXAML
{
    public class Logro
    {
        public int Id { get; set; }
        public int Recompensa { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Imagen { get; set; }

        public string Coin { get; set; }
        public Logro() { }
    }
    public class Model
    {
        public static List<Logro> logros = new List<Logro>()
        {
            new Logro()
            {
                Id = 0,
                Recompensa = 50,
                Nombre = "Logro 0",
                Descripcion = "Descripción Logro 0",
                Imagen = "Assets\\star.png",
    },
            new Logro()
            {
                Id = 1,
                Recompensa = 25,
                Nombre = "Logro 1",
                Descripcion = "Descripción Logro 1",
                Imagen = "Assets\\star.png",
            },
            new Logro()
            {
                Id = 2,
                Recompensa = 10,
                Nombre = "Logro 2",
                Descripcion = "Descripción Logro 2",
                Imagen = "Assets\\star.png",
            },
            new Logro()
            {
                Id = 3,
                Recompensa = 50,
                Nombre = "Logro 3",
                Descripcion = "Descripción Logro 3",
                Imagen = "Assets\\star.png",
            },
            new Logro()
            {
                Id = 4,
                Recompensa = 75,
                Nombre = "Logro 4",
                Descripcion = "Descripción Logro 4",
                Imagen = "Assets\\star.png",
            },
            new Logro()
            {
                Id = 5,
                Recompensa = 25,
                Nombre = "Logro 5",
                Descripcion = "Descripción Logro 5",
                Imagen = "Assets\\star.png",
            },
            new Logro()
            {
                Id = 6,
                Recompensa = 15,
                Nombre = "Logro 6",
                Descripcion = "Descripción Logro 6",
                Imagen = "Assets\\star.png",
            },
            new Logro()
            {
                Id = 7,
                Recompensa = 10,
                Nombre = "Logro 7",
                Descripcion = "Descripción Logro 7",
                Imagen = "Assets\\star.png",
            },
            new Logro()
            {
                Id = 8,
                Recompensa = 100,
                Nombre = "Logro 8",
                Descripcion = "Descripción Logro 8",
                Imagen = "Assets\\lock.png",
            },
            new Logro()
            {
                Id = 9,
                Recompensa = 150,
                Nombre = "Logro 0",
                Descripcion = "Descripción Logro 9",
                Imagen = "Assets\\lock.png",
            },
        };

        public static IList<Logro> getAllLogros()
        {
            return logros;
        }

        public static Logro getLogroById(int id)
        {
            return logros[id];
        }
    }
}
