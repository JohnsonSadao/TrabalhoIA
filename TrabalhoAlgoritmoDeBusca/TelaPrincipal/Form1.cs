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

        public static Vertice Estonia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Estônia",
                    Capital = "Tallin",
                    Neighbors =
                {
                      Letonia,
                      Russia
                }

                };
            }
        }


        public static Vertice Finlandia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Finlândia",
                    Capital = "Helsinque",
                    Neighbors =
            {
                Noruega,
                Russia
            }
                };
            }
        }

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

        public static Vertice Grecia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Grécia",
                    Capital = "Atenas",
                    Neighbors =
            {
                Albania,
                Bulgaria,
                RMacedonia,
                Turquia
            }
                };
            }
        }

        public static Vertice Hungria
        {
            get
            {
                return new Vertice
                {
                    Nome = "Hungria",
                    Capital = "Budapeste",
                    Neighbors =
            {
                Austria,
                Croacia,
                Eslovaquia,
                Eslovenia,
                Romenia,
                Servia,
                Ucrania
            }
                };
            }
        }

        public static Vertice Irlanda
        {
            get
            {
                return new Vertice
                {
                    Nome = "Irlanda",
                    Capital = "Dublin",
                    Neighbors =
            {

            }
                };
            }
        }

        public static Vertice Islandia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Islândia",
                    Capital = "Reiquiavique",
                    Neighbors =
            {

            }
                };
            }
        }


        public static Vertice Italia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Itália",
                    Capital = "Roma",
                    Neighbors =
            {
                Austria,
                Eslovenia,
                SanMarino,
                Suica
            }
                };
            }
        }

        public static Vertice Letonia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Letônia",
                    Capital = "Riga",
                    Neighbors =
            {
                Bielorrussia,
                Estonia,
                Lituania,
                Russia
            }
                };
            }
        }

        public static Vertice Liechtenstein
        {
            get
            {
                return new Vertice
                {
                    Nome = "Liechtenstein",
                    Capital = "Vaduz",
                    Neighbors =
            {
                Austria,
                Suica
            }
                };
            }
        }

        public static Vertice Lituania
        {
            get
            {
                return new Vertice
                {
                    Nome = "Lituânia",
                    Capital = "Vilnius",
                    Neighbors =
            {
                Bielorrussia,
                Letonia,
                Polonia,
                Russia
            }
                };
            }
        }

        public static Vertice Luxemburgo
        {
            get
            {
                return new Vertice
                {
                    Nome = "Luxemburgo",
                    Capital = "Luxemburgo",
                    Neighbors =
            {
                Alemanha,
                Belgica,
                Franca
            }
                };
            }
        }

        public static Vertice RMacedonia
        {
            get
            {
                return new Vertice
                {
                    Nome = "República da Macedônia",
                    Capital = "Skopje",
                    Neighbors =
            {
                Albania,
                Bulgaria,
                Grecia,
                Servia
            }
                };
            }
        }

        public static Vertice Malta
        {
            get
            {
                return new Vertice
                {
                    Nome = "Malta",
                    Capital = "Valetta",
                    Neighbors =
            {

            }
                };
            }
        }

        public static Vertice Moldavia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Moldavia",
                    Capital = "Chisinau",
                    Neighbors =
            {
                Romenia,
                Ucrania
            }
                };
            }
        }

        public static Vertice Monaco
        {
            get
            {
                return new Vertice
                {
                    Nome = "Mônaco",
                    Capital = "Monaco-ville",
                    Neighbors =
            {
                Franca
            }
                };
            }
        }

        public static Vertice MonteNegro
        {
            get
            {
                return new Vertice
                {
                    Nome = "MonteNegro",
                    Capital = "Podgorica",
                    Neighbors =
            {
                Albania,
                Bosnia,
                Servia
            }
                };
            }
        }

        public static Vertice Noruega
        {
            get
            {
                return new Vertice
                {
                    Nome = "Noruega",
                    Capital = "Oslo",
                    Neighbors =
            {
                Finlandia,
                Russia,
                Suecia
            }
                };
            }
        }

        public static Vertice Holanda
        {
            get
            {
                return new Vertice
                {
                    Nome = "Países Baixos (Holanda)",
                    Capital = "Amsterdã",
                    Neighbors =
            {
                    Alemanha,
                    Belgica
            }
                };
            }
        }

        public static Vertice Polonia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Polônia",
                    Capital = "Varsóvia",
                    Neighbors =
            {
                Alemanha,
                Bielorrussia,
                Eslovaquia,
                Lituania,
                RTcheca,
                Ucrania
            }
                };
            }
        }

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

        public static Vertice ReinoUnido
        {
            get
            {
                return new Vertice
                {
                    Nome = "Reino Unido",
                    Capital = "Londres",
                    Neighbors =
            {
                Franca
            }
                };
            }
        }

        public static Vertice Romenia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Romênia",
                    Capital = "Bucareste",
                    Neighbors =
            {
                Bulgaria,
                Hungria,
                Moldavia,
                Servia,
                Ucrania
            }
                };
            }
        }

        public static Vertice Russia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Rússia",
                    Capital = "Moscou",
                    Neighbors =
            {
                Bielorrussia,
                Estonia,
                Finlandia,
                Letonia,
                Lituania,
                Noruega,
                Ucrania
            }
                };
            }
        }

        public static Vertice Turquia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Turquia",
                    Capital = "Ancara",
                    Neighbors =
            {
                Bulgaria,
                Grecia
            }
                };
            }
        }

        public static Vertice SanMarino
        {
            get
            {
                return new Vertice
                {
                    Nome = "San Marino",
                    Capital = "San Marino",
                    Neighbors =
            {
                Italia
            }
                };
            }
        }

        public static Vertice Servia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Sérvia",
                    Capital = "Belgrado",
                    Neighbors =
            {
                Bosnia,
                Bulgaria,
                Croacia,
                Hungria,
                MonteNegro,
                RMacedonia,
                Romenia
            }
                };
            }
        }

        public static Vertice Suecia
        {
            get
            {
                return new Vertice
                {
                    Nome = "Suécia",
                    Capital = "Estocolmo",
                    Neighbors =
            {
                Dinamarca,
                Finlandia,
                Noruega
            }
                };
            }
        }

        public static Vertice Suica
        {
            get
            {
                return new Vertice
                {
                    Nome = "Suíça",
                    Capital = "Berna",
                    Neighbors =
            {
                Alemanha,
                Austria,
                Franca,
                Italia,
                Liechtenstein
            }
                };
            }
        }

        public static Vertice Ucrania
        {
            get
            {
                return new Vertice
                {
                    Nome = "Ucrânia",
                    Capital = "Kiev",
                    Neighbors =
            {
                Bielorrussia,
                Eslovaquia,
                Hungria,
                Moldavia,
                Polonia,
                Romenia,
                Russia
            }
                };
            }
        }
        #endregion

        #region
        public static List<Vertice> cidades;
        #endregion

        public Form1()
        {
            InitializeComponent();
            buscas = new Buscas();
            #region
           
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

    }
}
