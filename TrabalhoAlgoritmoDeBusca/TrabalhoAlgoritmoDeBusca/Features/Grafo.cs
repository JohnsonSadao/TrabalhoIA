using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAlgoritmoDeBusca.Features
{
//    public class Grafo
//    {
//        public List<Vertice> cidades { get; set; }

//        public Grafo()
//        {
//            Albania = new Vertice
//            {
//                Nome = "Albania",
//                Capital = "Tirana",
//                Neighbors =
//            {
//                Grecia,
//                MonteNegro,
//                RMacedonia
//            }
//            };
//            Alemanha = new Vertice
//            {
//                Nome = "Alemanha",
//                Capital = "Berlim",
//                Neighbors =
//            {
//                Austria,
//                Belgica,
//                Dinamarca,
//                Franca,
//                Luxemburgo,
//                Holanda,
//                Polonia,
//                RTcheca,
//                Suica
//            }
//            };
//            Andorra = new Vertice
//            {
//                Nome = "Andorra",
//                Capital = "Andorra la Vella",
//                Neighbors =
//            {
//                Espanha,
//                Franca
//            }
//            };
//            Austria = new Vertice
//            {
//                Nome = "Áustria",
//                Capital = "Viena",
//                Neighbors =
//            {
//                Alemanha,
//                Eslovaquia,
//                Eslovenia,
//                Hungria,
//                Italia,
//                Liechtenstein,
//                RTcheca,
//                Suica
//            }
//            };
//            Bielorrussia = new Vertice
//            {
//                Nome = "Bielorrússia",
//                Capital = "Misnk",
//                Neighbors =
//            {
//                Letonia,
//                Lituania,
//                Polonia,
//                Russia,
//                Ucrania
//            }
//            };
//            Belgica = new Vertice
//            {
//                Nome = "Bélgica",
//                Capital = "Bruxelas",
//                Neighbors =
//            {
//                Alemanha,
//                Franca,
//                Luxemburgo,
//                Holanda
//            }
//            };
//            Bosnia = new Vertice
//            {
//                Nome = "Bósnia-Herzegovina",
//                Capital = "Saravejo",
//                Neighbors =
//            {
//                Croacia,
//                MonteNegro,
//                Servia
//            }
//            };
//            Bulgaria = new Vertice
//            {
//                Nome = "Bulgária",
//                Capital = "Sófia",
//                Neighbors =
//            {
//                Grecia,
//                RMacedonia,
//                Romenia,
//                Servia,
//                Turquia
//            }
//            };
//            RTcheca = new Vertice
//            {
//                Nome = "República Tcheca",
//                Capital = "Praga",
//                Neighbors =
//            {
//                    Alemanha,
//                    Austria,
//                    Eslovaquia,
//                    Polonia
//            }
//            };
//            Chipre = new Vertice
//            {
//                Nome = "Chipre",
//                Capital = "Nicósia",
//                Neighbors =
//            {

//            }
//            };
//            Croacia = new Vertice
//            {
//                Nome = "Croácia",
//                Capital = "Zagreb",
//                Neighbors =
//            {
//                Bosnia,
//                Eslovenia,
//                Hungria,
//                Servia
//            }
//            };
//            Dinamarca = new Vertice
//            {
//                Nome = "Dinamarca",
//                Capital = "Copenhagem",
//                Neighbors =
//            {
//                Alemanha,
//                Suecia
//            }
//            };
//            Eslovaquia = new Vertice
//            {
//                Nome = "Eslováquia",
//                Capital = "Bratislava",
//                Neighbors =
//            {
//                Austria,
//                Hungria,
//                Polonia,
//                RTcheca,
//                Ucrania
//            }
//            };
//            Eslovenia = new Vertice
//            {
//                Nome = "Eslovênia",
//                Capital = "Liubliana",
//                Neighbors =
//            {
//                Austria,
//                Croacia,
//                Hungria,
//                Italia
//            }
//            };
//            Espanha = new Vertice
//            {
//                Nome = "Espanha",
//                Capital = "Madrid",
//                Neighbors =
//            {
//                Andorra,
//                Franca,
//                Portugal
//            }
//            };
//            Estonia = new Vertice
//            {
//                Nome = "Estônia",
//                Capital = "Tallin",
//                Neighbors =
//            {
//                Letonia,
//                Russia
//            }
//            };
//            Finlandia = new Vertice
//            {
//                Nome = "Finlândia",
//                Capital = "Helsinque",
//                Neighbors =
//            {
//                Noruega,
//                Russia
//            }
//            };
//            Franca = new Vertice
//            {
//                Nome = "França",
//                Capital = "Paris",
//                Neighbors =
//            {
//                Alemanha,
//                Andorra,
//                Espanha,
//                Italia,
//                Luxemburgo,
//                Monaco,
//                ReinoUnido,
//                Suica
//            }
//            };
//            Grecia = new Vertice
//            {
//                Nome = "Grécia",
//                Capital = "Atenas",
//                Neighbors =
//            {
//                Albania,
//                Bulgaria,
//                RMacedonia,
//                Turquia
//            }
//            };
//            Hungria = new Vertice
//            {
//                Nome = "Hungria",
//                Capital = "Budapeste",
//                Neighbors =
//            {
//                Austria,
//                Croacia,
//                Eslovaquia,
//                Eslovenia,
//                Romenia,
//                Servia,
//                Ucrania
//            }
//            };
//            Irlanda = new Vertice
//            {
//                Nome = "Irlanda",
//                Capital = "Dublin",
//                Neighbors =
//            {

//            }
//            };
//            Islandia = new Vertice
//            {
//                Nome = "Islândia",
//                Capital = "Reiquiavique",
//                Neighbors =
//            {

//            }
//            };
//            Italia = new Vertice
//            {
//                Nome = "Itália",
//                Capital = "Roma",
//                Neighbors =
//            {
//                Austria,
//                Eslovenia,
//                SanMarino,
//                Suica
//            }
//            };
//            Letonia = new Vertice
//            {
//                Nome = "Letônia",
//                Capital = "Riga",
//                Neighbors =
//            {
//                Bielorrussia,
//                Estonia,
//                Lituania,
//                Russia
//            }
//            };
//            Liechtenstein = new Vertice
//            {
//                Nome = "Liechtenstein",
//                Capital = "Vaduz",
//                Neighbors =
//            {
//                Austria,
//                Suica
//            }
//            };
//            Lituania = new Vertice
//            {
//                Nome = "Lituânia",
//                Capital = "Vilnius",
//                Neighbors =
//            {
//                Bielorrussia,
//                Letonia,
//                Polonia,
//                Russia
//            }
//            };
//            Luxemburgo = new Vertice
//            {
//                Nome = "Luxemburgo",
//                Capital = "Luxemburgo",
//                Neighbors =
//            {
//                Alemanha,
//                Belgica,
//                Franca
//            }
//            };
//            RMacedonia = new Vertice
//            {
//                Nome = "República da Macedônia",
//                Capital = "Skopje",
//                Neighbors =
//            {
//                Albania,
//                Bulgaria,
//                Grecia,
//                Servia
//            }
//            };
//            Malta = new Vertice
//            {
//                Nome = "Malta",
//                Capital = "Valetta",
//                Neighbors =
//            {

//            }
//            };
//            Moldavia = new Vertice
//            {
//                Nome = "Moldavia",
//                Capital = "Chisinau",
//                Neighbors =
//            {
//                Romenia,
//                Ucrania
//            }
//            };
//            Monaco = new Vertice
//            {
//                Nome = "Mônaco",
//                Capital = "Monaco-ville",
//                Neighbors =
//            {
//                Franca
//            }
//            };
//            MonteNegro = new Vertice
//            {
//                Nome = "MonteNegro",
//                Capital = "Podgorica",
//                Neighbors =
//            {
//                Albania,
//                Bosnia,
//                Servia
//            }
//            };
//            Noruega = new Vertice
//            {
//                Nome = "Noruega",
//                Capital = "Oslo",
//                Neighbors =
//            {
//                Finlandia,
//                Russia,
//                Suecia
//            }
//            };
//            Holanda = new Vertice
//            {
//                Nome = "Países Baixos (Holanda)",
//                Capital = "Amsterdã",
//                Neighbors =
//            {
//                Alemanha,
//                Belgica
//            }
//            };
//            Polonia = new Vertice
//            {
//                Nome = "Polônia",
//                Capital = "Varsóvia",
//                Neighbors =
//            {
//                Alemanha,
//                Bielorrussia,
//                Eslovaquia,
//                Lituania,
//                RTcheca,
//                Ucrania
//            }
//            };
//            Portugal = new Vertice
//            {
//                Nome = "Portugal",
//                Capital = "Lisboa",
//                Neighbors =
//            {
//                Espanha
//            }
//            };
//            ReinoUnido = new Vertice
//            {
//                Nome = "Reino Unido",
//                Capital = "Londres",
//                Neighbors =
//            {
//                Franca
//            }
//            };
//            Romenia = new Vertice
//            {
//                Nome = "Romênia",
//                Capital = "Bucareste",
//                Neighbors =
//            {
//                Bulgaria,
//                Hungria,
//                Moldavia,
//                Servia,
//                Ucrania
//            }
//            };
//            Russia = new Vertice
//            {
//                Nome = "Rússia",
//                Capital = "Moscou",
//                Neighbors =
//            {
//                Bielorrussia,
//                Estonia,
//                Finlandia,
//                Letonia,
//                Lituania,
//                Noruega,
//                Ucrania
//            }
//            };
//            Turquia = new Vertice
//            {
//                Nome = "Turquia",
//                Capital = "Ancara",
//                Neighbors =
//            {
//                Bulgaria,
//                Grecia
//            }
//            };
//            SanMarino = new Vertice
//            {
//                Nome = "San Marino",
//                Capital = "San Marino",
//                Neighbors =
//            {
//                Italia
//            }
//            };
//            Servia = new Vertice
//            {
//                Nome = "Sérvia",
//                Capital = "Belgrado",
//                Neighbors =
//            {
//                Bosnia,
//                Bulgaria,
//                Croacia,
//                Hungria,
//                MonteNegro,
//                RMacedonia,
//                Romenia
//            }
//            };
//            Suecia = new Vertice
//            {
//                Nome = "Suécia",
//                Capital = "Estocolmo",
//                Neighbors =
//            {
//                Dinamarca,
//                Finlandia,
//                Noruega
//            }
//            };
//            Suica = new Vertice
//            {
//                Nome = "Suíça",
//                Capital = "Berna",
//                Neighbors =
//            {
//                Alemanha,
//                Austria,
//                Franca,
//                Italia,
//                Liechtenstein
//            }
//            };
//            Ucrania = new Vertice
//            {
//                Nome = "Ucrânia",
//                Capital = "Kiev",
//                Neighbors =
//            {
//                Bielorrussia,
//                Eslovaquia,
//                Hungria,
//                Moldavia,
//                Polonia,
//                Romenia,
//                Russia
//            }
//            };

//            cidades = new List<Vertice> {        Albania,
//               Alemanha,
//               Andorra,
//               Austria,
//               Belgica,
//               Bielorrussia,
//               Bosnia,
//               Bulgaria,
//               Chipre,
//               Croacia,
//               Dinamarca,
//               Eslovaquia,
//               Eslovenia,
//               Espanha,
//               Estonia,
//               Finlandia,
//               Franca,
//               Grecia,
//               Hungria,
//               Irlanda,
//               Islandia,
//               Italia,
//               Letonia,
//               Liechtenstein,
//               Lituania,
//               Luxemburgo,
//               RMacedonia,
//               Malta,
//               Moldavia,
//               Monaco,
//               MonteNegro,
//               Noruega,
//               Holanda,
//               Polonia,
//               Portugal,
//               ReinoUnido,
//               Romenia,
//               Russia,
//               Turquia,
//               SanMarino,
//               Servia,
//               Suecia,
//               Suica,
//               Ucrania};
//        }

//        public static Vertice Albania { get; set; }

//        public static Vertice Alemanha { get; set; }

//        public static Vertice Andorra { get; set; }

//        public static Vertice Austria { get; set; }

//        public static Vertice Bielorrussia { get; set; }

//        public static Vertice Belgica { get; set; }

//        public static Vertice Bosnia { get; set; }

//        public static Vertice Bulgaria { get; set; }

//        public static Vertice RTcheca { get; set; }

//        public static Vertice Chipre { get; set; }

//        public static Vertice Croacia { get; set; }

//        public static Vertice Dinamarca { get; set; }

//        public static Vertice Eslovaquia { get; set; }

//        public static Vertice Eslovenia { get; set; }

//        public static Vertice Espanha { get; set; }

//        public static Vertice Estonia { get; set; }

//        public static Vertice Finlandia { get; set; }

//        public static Vertice Franca { get; set; }

//        public static Vertice Grecia { get; set; }

//        public static Vertice Hungria { get; set; }

//        public static Vertice Irlanda { get; set; }

//        public static Vertice Islandia { get; set; }

//        public static Vertice Italia { get; set; }

//        public static Vertice Letonia { get; set; }

//        public static Vertice Liechtenstein { get; set; }

//        public static Vertice Lituania { get; set; }

//        public static Vertice Luxemburgo { get; set; }

//        public static Vertice RMacedonia { get; set; }

//        public static Vertice Malta { get; set; }

//        public static Vertice Moldavia { get; set; }

//        public static Vertice Monaco { get; set; }

//        public static Vertice MonteNegro { get; set; }

//        public static Vertice Noruega { get; set; }

//        public static Vertice Holanda { get; set; }

//        public static Vertice Polonia { get; set; }

//        public static Vertice Portugal { get; set; }

//        public static Vertice ReinoUnido { get; set; }

//        public static Vertice Romenia { get; set; }

//        public static Vertice Russia { get; set; }

//        public static Vertice Turquia { get; set; }

//        public static Vertice SanMarino { get; set; }

//        public static Vertice Servia { get; set; }

//        public static Vertice Suecia { get; set; }

//        public static Vertice Suica { get; set; }

//        public static Vertice Ucrania { get; set; }


//    }
}
