using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoAlgoritmoDeBusca;
using TrabalhoAlgoritmoDeBusca.Features;
using TrabalhoAlgoritmoDeBusca.Infra;

namespace TelaPrincipal
{
    public partial class Form1 : Form
    {
        public Buscas buscas;
        //cidades
        #region
        public static Vertice Albania
        {
            get
            {
                return new Vertice
                {
                    Nome = "Albania",
                    Capital = "Tirana",
                    Neighbors =
            {
                Grecia,
                MonteNegro,
                RMacedonia
            }
                };
            }
        }

        public static Vertice Alemanha
        {
            get
            {
                return new Vertice
                {
                    Nome = "Alemanha",
                    Capital = "Berlim",
                    Neighbors =
            {
                Austria,
                Belgica,
                Dinamarca,
                Franca,
                Luxemburgo,
                Holanda,
                Polonia,
                RTcheca,
                Suica
            }
                };
            }
        }

        public static Vertice Andorra
        {
            get
            {
                return new Vertice
                {
                    Nome = "Andorra",
                    Capital = "Andorra la Vella",
                    Neighbors =
            {
                Espanha,
                Franca
            }
                };
            }
        }

        public static Vertice Austria
        {
            get
            {
                return new Vertice
                {
                    Nome = "Áustria",
                    Capital = "Viena",
                    Neighbors =
            {
                Alemanha,
                Eslovaquia,
                Eslovenia,
                Hungria,
                Italia,
                Liechtenstein,
                RTcheca,
                Suica
            }
                };
            }
        }

        public static Vertice Bielorrussia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Bielorrússia",
                    Capital = "Misnk",
                    Neighbors =
            {
                Letonia,
                Lituania,
                Polonia,
                Russia,
                Ucrania
            }
                };
            }
        }

        public static Vertice Belgica
        {
            get
            {
                return new Vertice
                {
                    Nome = "Bélgica",
                    Capital = "Bruxelas",
                    Neighbors =
            {
                Alemanha,
                Franca,
                Luxemburgo,
                Holanda
            }
                };
            }
        }

        public static Vertice Bosnia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Bósnia-Herzegovina",
                    Capital = "Saravejo",
                    Neighbors =
            {
                Croacia,
                MonteNegro,
                Servia
            }
                };
            }
        }

        public static Vertice Bulgaria
        {
            get
            {
                return new Vertice
                {
                    Nome = "Bulgária",
                    Capital = "Sófia",
                    Neighbors =
            {
                Grecia,
                RMacedonia,
                Romenia,
                Servia,
                Turquia
            }
                };
            }
        }

        public static Vertice RTcheca
        {
            get
            {
                return new Vertice
                {
                    Nome = "República Tcheca",
                    Capital = "Praga",
                    Neighbors =
            {
                    Alemanha,
                    Austria,
                    Eslovaquia,
                    Polonia
            }
                };
            }
        }

        public static Vertice Chipre
        {
            get
            {
                return new Vertice
                {
                    Nome = "Chipre",
                    Capital = "Nicósia",
                    Neighbors =
            {

            }
                };
            }
        }

        public static Vertice Croacia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Croácia",
                    Capital = "Zagreb",
                    Neighbors =
            {
                Bosnia,
                Eslovenia,
                Hungria,
                Servia
            }
                };
            }
        }

        public static Vertice Dinamarca
        {
            get
            {
                return new Vertice
                {
                    Nome = "Dinamarca",
                    Capital = "Copenhagem",
                    Neighbors =
            {
                Alemanha,
                Suecia
            }
                };
            }
        }

        public static Vertice Eslovaquia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Eslováquia",
                    Capital = "Bratislava",
                    Neighbors =
            {
                Austria,
                Hungria,
                Polonia,
                RTcheca,
                Ucrania
            }
                };
            }
        }

        public static Vertice Eslovenia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Eslovênia",
                    Capital = "Liubliana",
                    Neighbors =
            {
                Austria,
                Croacia,
                Hungria,
                Italia
            }
                };
            }
        }

        public static Vertice Espanha
        {
            get
            {
                return new Vertice
                {
                    Nome = "Espanha",
                    Capital = "Madrid",
                    Neighbors =
            {
                //Andorra,
                Franca,
                Portugal
            }
                };
            }
        }

        public static Vertice Estonia;

        public static Vertice Finlandia;

        public static Vertice Franca
        {
            get
            {
                return new Vertice
                {
                    Nome = "França",
                    Capital = "Paris",
                    Neighbors =
            {
                //Alemanha,
                //Andorra,
                Espanha,
                //Italia,
                //Luxemburgo,
                //Monaco,
                //ReinoUnido,
                //Suica
            }
                };
            }
        }

        public static Vertice Grecia;

        public static Vertice Hungria;

        public static Vertice Irlanda;

        public static Vertice Islandia;

        public static Vertice Italia;

        public static Vertice Letonia;

        public static Vertice Liechtenstein;

        public static Vertice Lituania;

        public static Vertice Luxemburgo;

        public static Vertice RMacedonia;

        public static Vertice Malta;

        public static Vertice Moldavia;

        public static Vertice Monaco;

        public static Vertice MonteNegro;

        public static Vertice Noruega;

        public static Vertice Holanda;

        public static Vertice Polonia;

        public static Vertice Portugal
        {
            get
            {
                return new Vertice
                {
                    Nome = "Portugal",
                    Capital = "Lisboa",
                    Neighbors =
            {
                Espanha
            }
                };
            }
        }

        public static Vertice ReinoUnido;

        public static Vertice Romenia;

        public static Vertice Russia;

        public static Vertice Turquia;

        public static Vertice SanMarino;

        public static Vertice Servia;

        public static Vertice Suecia;

        public static Vertice Suica;

        public static Vertice Ucrania;
        #endregion

        #region
        public static List<Vertice> cidades;
        #endregion

        public Form1()
        {
            InitializeComponent();
            buscas = new Buscas();
            #region      
            //Estonia = new Vertice
            //{
            //    Nome = "Estônia",
            //    Capital = "Tallin",
            //    Neighbors =
            //{
            //    Letonia,
            //    Russia
            //}
            //};
            //Finlandia = new Vertice
            //{
            //    Nome = "Finlândia",
            //    Capital = "Helsinque",
            //    Neighbors =
            //{
            //    Noruega,
            //    Russia
            //}
            //};
            //Grecia = new Vertice
            //{
            //    Nome = "Grécia",
            //    Capital = "Atenas",
            //    Neighbors =
            //{
            //    Albania,
            //    Bulgaria,
            //    RMacedonia,
            //    Turquia
            //}
            //};
            //Hungria = new Vertice
            //{
            //    Nome = "Hungria",
            //    Capital = "Budapeste",
            //    Neighbors =
            //{
            //    Austria,
            //    Croacia,
            //    Eslovaquia,
            //    Eslovenia,
            //    Romenia,
            //    Servia,
            //    Ucrania
            //}
            //};
            //Irlanda = new Vertice
            //{
            //    Nome = "Irlanda",
            //    Capital = "Dublin",
            //    Neighbors =
            //{

            //}
            //};
            //Islandia = new Vertice
            //{
            //    Nome = "Islândia",
            //    Capital = "Reiquiavique",
            //    Neighbors =
            //{

            //}
            //};
            //Italia = new Vertice
            //{
            //    Nome = "Itália",
            //    Capital = "Roma",
            //    Neighbors =
            //{
            //    Austria,
            //    Eslovenia,
            //    SanMarino,
            //    Suica
            //}
            //};
            //Letonia = new Vertice
            //{
            //    Nome = "Letônia",
            //    Capital = "Riga",
            //    Neighbors =
            //{
            //    Bielorrussia,
            //    Estonia,
            //    Lituania,
            //    Russia
            //}
            //};
            //Liechtenstein = new Vertice
            //{
            //    Nome = "Liechtenstein",
            //    Capital = "Vaduz",
            //    Neighbors =
            //{
            //    Austria,
            //    Suica
            //}
            //};
            //Lituania = new Vertice
            //{
            //    Nome = "Lituânia",
            //    Capital = "Vilnius",
            //    Neighbors =
            //{
            //    Bielorrussia,
            //    Letonia,
            //    Polonia,
            //    Russia
            //}
            //};
            //Luxemburgo = new Vertice
            //{
            //    Nome = "Luxemburgo",
            //    Capital = "Luxemburgo",
            //    Neighbors =
            //{
            //    Alemanha,
            //    Belgica,
            //    Franca
            //}
            //};
            //RMacedonia = new Vertice
            //{
            //    Nome = "República da Macedônia",
            //    Capital = "Skopje",
            //    Neighbors =
            //{
            //    Albania,
            //    Bulgaria,
            //    Grecia,
            //    Servia
            //}
            //};
            //Malta = new Vertice
            //{
            //    Nome = "Malta",
            //    Capital = "Valetta",
            //    Neighbors =
            //{

            //}
            //};
            //Moldavia = new Vertice
            //{
            //    Nome = "Moldavia",
            //    Capital = "Chisinau",
            //    Neighbors =
            //{
            //    Romenia,
            //    Ucrania
            //}
            //};
            //Monaco = new Vertice
            //{
            //    Nome = "Mônaco",
            //    Capital = "Monaco-ville",
            //    Neighbors =
            //{
            //    Franca
            //}
            //};
            //MonteNegro = new Vertice
            //{
            //    Nome = "MonteNegro",
            //    Capital = "Podgorica",
            //    Neighbors =
            //{
            //    Albania,
            //    Bosnia,
            //    Servia
            //}
            //};
            //Noruega = new Vertice
            //{
            //    Nome = "Noruega",
            //    Capital = "Oslo",
            //    Neighbors =
            //{
            //    Finlandia,
            //    Russia,
            //    Suecia
            //}
            //};
            //Holanda = new Vertice
            //{
            //    Nome = "Países Baixos (Holanda)",
            //    Capital = "Amsterdã",
            //    Neighbors =
            //{
            //    Alemanha,
            //    Belgica
            //}
            //};
            //Polonia = new Vertice
            //{
            //    Nome = "Polônia",
            //    Capital = "Varsóvia",
            //    Neighbors =
            //{
            //    Alemanha,
            //    Bielorrussia,
            //    Eslovaquia,
            //    Lituania,
            //    RTcheca,
            //    Ucrania
            //}
            //};
            //ReinoUnido = new Vertice
            //{
            //    Nome = "Reino Unido",
            //    Capital = "Londres",
            //    Neighbors =
            //{
            //    Franca
            //}
            //};
            //Romenia = new Vertice
            //{
            //    Nome = "Romênia",
            //    Capital = "Bucareste",
            //    Neighbors =
            //{
            //    Bulgaria,
            //    Hungria,
            //    Moldavia,
            //    Servia,
            //    Ucrania
            //}
            //};
            //Russia = new Vertice
            //{
            //    Nome = "Rússia",
            //    Capital = "Moscou",
            //    Neighbors =
            //{
            //    Bielorrussia,
            //    Estonia,
            //    Finlandia,
            //    Letonia,
            //    Lituania,
            //    Noruega,
            //    Ucrania
            //}
            //};
            //Turquia = new Vertice
            //{
            //    Nome = "Turquia",
            //    Capital = "Ancara",
            //    Neighbors =
            //{
            //    Bulgaria,
            //    Grecia
            //}
            //};
            //SanMarino = new Vertice
            //{
            //    Nome = "San Marino",
            //    Capital = "San Marino",
            //    Neighbors =
            //{
            //    Italia
            //}
            //};
            //Servia = new Vertice
            //{
            //    Nome = "Sérvia",
            //    Capital = "Belgrado",
            //    Neighbors =
            //{
            //    Bosnia,
            //    Bulgaria,
            //    Croacia,
            //    Hungria,
            //    MonteNegro,
            //    RMacedonia,
            //    Romenia
            //}
            //};
            //Suecia = new Vertice
            //{
            //    Nome = "Suécia",
            //    Capital = "Estocolmo",
            //    Neighbors =
            //{
            //    Dinamarca,
            //    Finlandia,
            //    Noruega
            //}
            //};
            //Suica = new Vertice
            //{
            //    Nome = "Suíça",
            //    Capital = "Berna",
            //    Neighbors =
            //{
            //    Alemanha,
            //    Austria,
            //    Franca,
            //    Italia,
            //    Liechtenstein
            //}
            //};
            //Ucrania = new Vertice
            //{
            //    Nome = "Ucrânia",
            //    Capital = "Kiev",
            //    Neighbors =
            //{
            //    Bielorrussia,
            //    Eslovaquia,
            //    Hungria,
            //    Moldavia,
            //    Polonia,
            //    Romenia,
            //    Russia
            //}
            //};
            #endregion
            cidades = new List<Vertice> {
                Espanha,
                Portugal,
                Franca
               //Albania,
               //Alemanha,
               //Andorra,
               //Austria,
               //Belgica,
               //Bielorrussia,
               //Bosnia,
               //Bulgaria,
               //Chipre,
               //Croacia,
               //Dinamarca,
               //Eslovaquia,
               //Eslovenia,
               //Espanha,
               //Estonia,
               //Finlandia,
               //Franca,
               //Grecia,
               //Hungria,
               //Irlanda,
               //Islandia,
               //Italia,
               //Letonia,
               //Liechtenstein,
               //Lituania,
               //Luxemburgo,
               //RMacedonia,
               //Malta,
               //Moldavia,
               //Monaco,
               //MonteNegro,
               //Noruega,
               //Holanda,
               //Polonia,
               //Portugal,
               //ReinoUnido,
               //Romenia,
               //Russia,
               //Turquia,
               //SanMarino,
               //Servia,
               //Suecia,
               //Suica,
               //Ucrania
        };
            comboBoxCidadeOrigem.DataSource = cidades;
        }

        public List<Vertice> PegarVizinhos
    }
}
