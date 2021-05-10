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
            
        public Cartas_Grid() { }
    }
    public class Mazos_Grid
    {
        public string Name { get; set; }
        public string Imagen { get; set; }

        public Mazos_Grid() { }
    }
    public class Model
    {
        public static List<Cartas> cartas_ = new List<Cartas>()
        {
            new Cartas()
            {
                cantidad = 1,
                Nombre = "Carta_1",                
            },
            new Cartas()
            {
                cantidad = 1,
                Nombre = "Carta_2",                
            },
            new Cartas()
            {
                cantidad = 2,
                Nombre = "Carta_3",
               
            },
            new Cartas()
            {
                cantidad = 3,
                Nombre = "Carta_4",
               
            },
            new Cartas()
            {
                cantidad = 1,
                Nombre = "Carta_5",
                
            },
            new Cartas()
            {
                cantidad = 1,
                Nombre = "Carta_6",
               
            },
            new Cartas()
            {
                cantidad = 2,
                Nombre = "Carta_7",
               
           },
            new Cartas()
            {
                cantidad = 3,
                Nombre = "Carta_8",
               
            },
            new Cartas()
            {
                cantidad = 1,
                Nombre = "Carta_9",
                
            },
            new Cartas()
            {
                cantidad = 2,
                Nombre = "Carta_10",               
            },
            new Cartas()
            {
                cantidad = 1,
                Nombre = "Carta_11",               
            },
            new Cartas()
            {
                cantidad = 1,
                Nombre = "Carta_12",              
            },
            new Cartas()
            {
                cantidad = 2,
                Nombre = "Carta_13",                
            }
        };

        public static List<Cartas_Grid> cartas_grid_ = new List<Cartas_Grid>()
        {
            new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta1.png"
            },

            new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta2.png"
            },

            new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta3.png"
            },
             new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta1.png"
            },

            new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta2.png"
            },

            new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta3.png"
            },
             new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta1.png"
            },

            new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta2.png"
            },

            new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta3.png"
            },
             new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta1.png"
            },

            new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta2.png"
            },

            new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta3.png"
            },
             new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta1.png"
            },

            new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta2.png"
            },

            new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta3.png"
            },
             new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta1.png"
            },

            new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta2.png"
            },

            new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta3.png"
            },
             new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta1.png"
            },

            new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta2.png"
            },

            new Cartas_Grid()
            {
                Name = "NOMBRE_CARTA",
                Imagen = "Assets\\carta3.png"
            },
        };

        public static List<Mazos_Grid> mazos_grid_ = new List<Mazos_Grid>()
        {
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo1.png"
            }, 

            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo1.png"
            }, 
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo1.png"
            }, 
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo1.png"
            }, 
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo1.png"
            }, 
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo1.png"
            },  
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo2.png"
            }, 
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo2.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo2.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo2.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo2.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo2.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo2.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo3.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo3.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo3.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo3.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo3.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png"
            },
            new Mazos_Grid()
            {
                Name = "NOMBRE_MAZO",
                Imagen = "Assets\\mazo4.png"
            },
        
        };
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
