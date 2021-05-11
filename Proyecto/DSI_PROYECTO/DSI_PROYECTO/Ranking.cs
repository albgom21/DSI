using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI_PROYECTO
{
    public class Ranking

    { 
        public int Id { get; set; }
        public int Nivel { get; set; }
        public string Nombre { get; set; }
        public string Rango { get; set; }
        public string Imagen1 { get; set; }
        public string Imagen2 { get; set; }

        public Ranking() { }
    }
    public class ModelRanking
    {
        public static List<Ranking> rankings = new List<Ranking>()
        {
            new Ranking()
            {
                Id = 0,
                Nivel = 20,
                Nombre = "Jugador 0",
                Rango = "Plata III",
            },
            new Ranking()
            {
                Id = 1,
                Nivel = 25,
                Nombre = "Jugador 1",
                Rango = "Plata IV",
            },
            new Ranking()
            {
                Id = 2,
                Nivel = 15,
                Nombre = "Jugador 2",
                Rango = "Bronce III",
            },
            new Ranking()
            {
                Id = 3,
                Nivel = 35,
                Nombre = "Jugador 3",
                Rango = "Plata III",
            },
            new Ranking()
            {
                Id = 4,
                Nivel = 53,
                Nombre = "Jugador 4",
                Rango = "Oro III",
            },
            new Ranking()
            {
                Id = 5,
                Nivel = 23,
                Nombre = "Jugador 5",
                Rango = "Plata I",
            },
            new Ranking()
            {
                Id = 6,
                Nivel = 76,
                Nombre = "Jugador 6",
                Rango = "Bronce IV",
            },
            new Ranking()
            {
                Id = 7,
                Nivel = 65,
                Nombre = "Jugador 7",
                Rango = "Oro I",
            },
            new Ranking()
            {
                Id = 8,
                Nivel = 48,
                Nombre = "Jugador 8",
                Rango = "Platino I",
            }
        };

        public static IList<Ranking> getAllRankings(){
            return rankings;
        }
        public static Ranking getRankingById(int id){
            return rankings[id];
        }
    }
}
