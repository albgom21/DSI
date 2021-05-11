using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PROYECTO
{
    public class Amigo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }

        public Amigo() { }
    }

    public class ModelA
    {
        public static List<Amigo> amigos = new List<Amigo>()
        {
            new Amigo()
            {
                Id = 0,
                Nombre = "Amigo 0",
                Imagen = "Assets\\online.png",
            },new Amigo()
            {
                Id = 1,
                Nombre = "Amigo 1",
                Imagen = "Assets\\online.png",
            },new Amigo()
            {
                Id = 2,
                Nombre = "Amigo 2",
                Imagen = "Assets\\online.png",
            },new Amigo()
            {
                Id = 3,
                Nombre = "Amigo 3",
                Imagen = "Assets\\online.png",
            },new Amigo()
            {
                Id = 4,
                Nombre = "Amigo 4",
                Imagen = "Assets\\online.png",
            },new Amigo()
            {
                Id = 5,
                Nombre = "Amigo 5",
                Imagen = "Assets\\online.png",
            },new Amigo()
            {
                Id = 6,
                Nombre = "Amigo 6",
                Imagen = "Assets\\online.png",
            },
            new Amigo()
            {
                Id = 7,
                Nombre = "Amigo 7",
                Imagen = "Assets\\online.png",
            },
            new Amigo()
            {
                Id = 8,
                Nombre = "Amigo 8",
                Imagen = "Assets\\offline.png",
            },
            new Amigo()
            {
                Id = 9,
                Nombre = "Amigo 9",
                Imagen = "Assets\\offline.png",
            },
            new Amigo()
            {
                Id = 10,
                Nombre = "Amigo 10",
                Imagen = "Assets\\offline.png",
            },
            new Amigo()
            {
                Id = 11,
                Nombre = "Amigo 11",
                Imagen = "Assets\\offline.png",
            },
            new Amigo()
            {
                Id = 12,
                Nombre = "Amigo 12",
                Imagen = "Assets\\offline.png",
            },
            new Amigo()
            {
                Id = 13,
                Nombre = "Amigo 13",
                Imagen = "Assets\\offline.png",
            },

        };

        public static IList<Amigo> getAllAmigos()
        {
            return amigos;
        }

        public static Amigo getAmigoById(int id)
        {
            return amigos[id];
        }
    }
}
