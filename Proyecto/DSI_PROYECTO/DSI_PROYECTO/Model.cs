using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PROYECTO
{
    public class Cartas
    {
        public int cantidad { get; set; }
        public string Nombre { get; set; }

        public Cartas() { }
    }

    public class Cartas_Grid
    {
        public string Name { get; set; }
        public string Imagen { get; set; }
        public char Tipo { get; set; }

        public Cartas_Grid() { }
    }
    public class Mazos_Grid
    {
        public string Name { get; set; }
        public string Imagen { get; set; }
        public IList<Cartas> Cartas { get; set; } = new List<Cartas>();

        public Mazos_Grid() { }
    }
    public class Model
    {
        public static int dinero_ = 125;

        public static List<bool> cartasCompradas = new List<bool>() { false, false, false, false };

        public static List<Cartas> cartas_ = new List<Cartas>()
        {
            // new Cartas()
            // {
            //     cantidad = 1,
            //     Nombre = "Carta_1",                
            // },
            // new Cartas()
            // {
            //     cantidad = 1,
            //     Nombre = "Carta_2",                
            // },
            // new Cartas()
            // {
            //     cantidad = 2,
            //     Nombre = "Carta_3",

            // },
            // new Cartas()
            // {
            //     cantidad = 3,
            //     Nombre = "Carta_4",

            // },
            // new Cartas()
            // {
            //     cantidad = 1,
            //     Nombre = "Carta_5",

            // },
            // new Cartas()
            // {
            //     cantidad = 1,
            //     Nombre = "Carta_6",

            // },
            // new Cartas()
            // {
            //     cantidad = 2,
            //     Nombre = "Carta_7",

            //},
            // new Cartas()
            // {
            //     cantidad = 3,
            //     Nombre = "Carta_8",

            // },
            // new Cartas()
            // {
            //     cantidad = 1,
            //     Nombre = "Carta_9",

            // },
            // new Cartas()
            // {
            //     cantidad = 2,
            //     Nombre = "Carta_10",               
            // },
            // new Cartas()
            // {
            //     cantidad = 1,
            //     Nombre = "Carta_11",               
            // },
            // new Cartas()
            // {
            //     cantidad = 1,
            //     Nombre = "Carta_12",              
            // },
            // new Cartas()
            // {
            //     cantidad = 2,
            //     Nombre = "Carta_13",                
            // }
        };

        public static List<Cartas_Grid> cartas_grid_ = new List<Cartas_Grid>()
        {
            new Cartas_Grid()
            {
                Name = "ESQUELETO",
                Imagen = "Assets\\carta2.png",
                Tipo = 's'
            },

            new Cartas_Grid()
            {
                Name = "ZAP",
                Imagen = "Assets\\carta1.png",
                Tipo = 'h'
            },

            new Cartas_Grid()
            {
                Name = "TANQUE",
                Imagen = "Assets\\carta3.png",
                Tipo = 'c'
            },

            new Cartas_Grid()
            {
                Name = "DUENDE",
                Imagen = "Assets\\carta2.png",
                Tipo = 's'
            },

            new Cartas_Grid()
            {
                Name = "FLECHAS",
                Imagen = "Assets\\carta1.png",
                Tipo = 'h'
            },

            new Cartas_Grid()
            {
                Name = "ESBIRRO",
                Imagen = "Assets\\carta3.png",
                Tipo = 'c'
            },

            new Cartas_Grid()
            {
                Name = "BOMBER",
                Imagen = "Assets\\carta2.png",
                Tipo = 's'
            },

            new Cartas_Grid()
            {
                Name = "TERREMOTO",
                Imagen = "Assets\\carta1.png",
                Tipo = 'h'
            },

            new Cartas_Grid()
            {
                Name = "CABALLERO",
                Imagen = "Assets\\carta3.png",
                Tipo = 'c'
            },

            new Cartas_Grid()
            {
                Name = "GÓLEM",
                Imagen = "Assets\\carta2.png",
                Tipo = 's'
            },

            new Cartas_Grid()
            {
                Name = "FUEGO",
                Imagen = "Assets\\carta1.png",
                Tipo = 'h'
            },

            new Cartas_Grid()
            {
                Name = "ARIETE",
                Imagen = "Assets\\carta3.png",
                Tipo = 'c'
            },

            new Cartas_Grid()
            {
                Name = "COHETE",
                Imagen = "Assets\\carta2.png",
                Tipo = 's'
            },

            new Cartas_Grid()
            {
                Name = "HIELO",
                Imagen = "Assets\\carta1.png",
                Tipo = 'h'
            },

            new Cartas_Grid()
            {
                Name = "DRAGÓN",
                Imagen = "Assets\\carta3.png",
                Tipo = 'c'
            },

            new Cartas_Grid()
            {
                Name = "ARQUERA",
                Imagen = "Assets\\carta2.png",
                Tipo = 's'
            },

            new Cartas_Grid()
            {
                Name = "FURIA",
                Imagen = "Assets\\carta1.png",
                Tipo = 'h'
            },

            new Cartas_Grid()
            {
                Name = "CAZADOR",
                Imagen = "Assets\\carta3.png",
                Tipo = 'c'
            },

            new Cartas_Grid()
            {
                Name = "BRUJA",
                Imagen = "Assets\\carta2.png",
                Tipo = 's'
            },

            new Cartas_Grid()
            {
                Name = "VENENO",
                Imagen = "Assets\\carta1.png",
                Tipo = 'h'
            },

            new Cartas_Grid()
            {
                Name = "MAGO",
                Imagen = "Assets\\carta3.png",
                Tipo = 'c'
            }
        };

        public static List<Mazos_Grid> mazos_grid_ = new List<Mazos_Grid>()
        {
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo1.png",
                Cartas = createCartas()
            },

            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo1.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo1.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo1.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo1.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo1.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo2.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo2.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo2.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo2.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo2.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo2.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo2.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo3.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo3.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo3.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo3.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo3.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png",
                Cartas = createCartas()
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png",
                Cartas = createCartas()
            },

        };

        public static List<Cartas> createCartas()
        {
            List<Cartas> a = new List<Cartas>();

            var rnd = new Random();
            int anterior = -1;
            int cart;
            for (int i = 1; i <= 2; i++)
            {
                do
                {
                    cart = rnd.Next(0, cartas_grid_.Count());
                } while (cart == anterior && cartas_grid_[cart].Tipo != 'c');

                int cant = rnd.Next(0, 3);

                Cartas carta = new Cartas();

                carta.Nombre = cartas_grid_[cart].Name;
                carta.cantidad = i + cant;
                a.Add(carta);

                anterior = cart;
            }

            return a;
        }

        public static int getDinero()
        {
            return dinero_;
        }

        public static void setDinero(int dinero)
        {
            dinero_ = dinero;
        }

        public static IList<bool> GetCartasCompradas()
        {
            return cartasCompradas;
        }

        public static IList<Cartas> GetAllCartas()
        {
            return cartas_;
        }

        public static IList<Cartas_Grid> GetAllCartas_Grid()
        {
            return cartas_grid_;
        }

        public static IList<Mazos_Grid> GetAllMazos_Grid()
        {
            return mazos_grid_;
        }
    }
}
