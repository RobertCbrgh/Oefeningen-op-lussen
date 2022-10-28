using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_op_lussen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Robert Coeckelbergh
            * 28/10/2022
            * 
            */

            //velden

            bool _herhalen;
            int _gekozeoptie;



            //programma
            do
            {


                //vraag keuzes
                Console.WriteLine("\nwelk project wilt u uitvoeren");

                Console.WriteLine("\n1) Project ");
                Console.WriteLine("\n2) Project ");
                Console.WriteLine("\n3) project ");
                Console.WriteLine("\n4) project ");
                Console.WriteLine("\n5) project ");
                Console.WriteLine("\n6) project ");
                Console.WriteLine("\n7) project ");
                Console.WriteLine("\n8) PRoject ");

                Console.WriteLine("\nschrijf aub het toegepaste cijfer als keuze");
                _gekozeoptie = int.Parse(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();


                //project 6 getallen optellen
                if (_gekozeoptie == 1)
                {

                    try
                    {


                        int _getal1, _getal2, _getal3, _getal4, _getal5, _getal6, _oplossing;


                        _herhalen = false;
                        Console.WriteLine("Geef getal 1; ");
                        _getal1 = int.Parse(Console.ReadLine());

                        Console.Clear();

                        Console.WriteLine("Geef getal 2; ");
                        _getal2 = int.Parse(Console.ReadLine());

                        Console.Clear();
                        ;
                        Console.WriteLine("Geef getal 3; ");
                        _getal3 = int.Parse(Console.ReadLine());

                        Console.Clear();

                        Console.WriteLine("Geef getal 4; ");
                        _getal4 = int.Parse(Console.ReadLine());

                        Console.Clear();

                        Console.WriteLine("Geef getal 5; ");
                        _getal5 = int.Parse(Console.ReadLine());

                        Console.Clear();

                        Console.WriteLine("Geef getal 6; ");
                        _getal6 = int.Parse(Console.ReadLine());

                        Console.Clear();

                        _oplossing = (_getal1 + _getal2 + _getal3 + _getal4 + _getal5 + _getal6);
                        Console.WriteLine("De optelling van deze getalllen is" + " " + _oplossing);
                        _herhalen = true;

                    }

                    catch
                    {
                        Console.WriteLine("U heeft iets fout ingegeven");
                        Console.WriteLine("probeer get opnieuw");
                        Console.ReadKey();
                        Console.Clear();
                        _herhalen = true;

                    }

                }

                //project grootste getal
                else if (_gekozeoptie == 2)
                {
                    try
                    {


                        int a, i;
                        Console.WriteLine("De veeldvouden van 2 zijn : ");
                        for (i = 1; i < 22; i++)
                        {
                            a = i % 2;
                            if (a == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        _herhalen = true;
                    }
                    catch
                    {
                        Console.WriteLine("U heeft iets fout ingegeven");
                        Console.WriteLine("probeer get opnieuw");
                        Console.ReadKey();
                        Console.Clear();
                        _herhalen = true;
                    }
                }

                //project teken van getal
                else if (_gekozeoptie == 3)
                {
                    try
                    {


                        int _getal, j;

                        Console.WriteLine("geef het eerste getal waarmee je wilt vermenig vuldigen: ");
                        _getal = int.Parse(Console.ReadLine());
                        Console.Clear();


                        for (j = 1; j <= 10; j++)
                        {
                            Console.Write("{0} X {1} = {2} \n", _getal, j, _getal * j);
                        }


                        _herhalen = true;
                    }
                    catch
                    {
                        Console.WriteLine("U heeft iets fout ingegeven");
                        Console.WriteLine("probeer get opnieuw");
                        Console.ReadKey();
                        Console.Clear();
                        _herhalen = true;
                    }


                }

                //project absolute waarden
                else if (_gekozeoptie == 4)
                {
                    try
                    {


                        int j, _getal;
                        for (_getal = 1; _getal <= 10; _getal++)
                        {


                            for (j = 1; j <= 10; j++)
                            {
                                Console.Write("{0} X {1} = {2} \n", _getal, j, _getal * j);
                            }

                            Console.ReadKey();
                            Console.Clear();
                        }

                        _herhalen = true;
                    }
                    catch
                    {
                        Console.WriteLine("U heeft iets fout ingegeven");
                        Console.WriteLine("probeer get opnieuw");
                        Console.ReadKey();
                        Console.Clear();
                        _herhalen = true;
                    }
                }

                //project afronden
                else if (_gekozeoptie == 5)
                {
                    try
                    {
                            int _gekozeoptie2;
                        string _volledigenaam;
                            Console.WriteLine("\nwelk programma wilt u uitvoeren");

                            Console.WriteLine("\n1) Hij geeft zijn volledige naam in en het programma zegt “Hallo <volledige naam>” ");
                            Console.WriteLine("\n2) Het programma zet de cijfers van 0 tot 20 op het scherm ");
                            Console.WriteLine("\n3) Het programma zet de cijfers van 20 tot 0 op het scherm ");

                            Console.WriteLine("\n4) Het programma vraagt een geheime code. Als de code juist is wordt " +
                                                    "er “Je bent ingelogd” getoond op het scherm. Anders wordt de volgende tekst getoond" +
                                                   ": “de code was verkeerd. Maak uw keuze: 1) probeer nogmaals , 2) ga terug naar " +
                                                   "het hoofdmenu (de geheime code is “geheime code”) ");


                            Console.WriteLine("\nschrijf aub het toegepaste cijfer als keuze");
                            _gekozeoptie2 = int.Parse(Console.ReadLine());
                            Console.ReadKey();
                            Console.Clear();

                            if (_gekozeoptie2 == 1)
                            {
                            Console.WriteLine("Geef u volledige naam:");
                            _volledigenaam = Console.ReadLine();
                            Console.Clear();
                           
                            Console.WriteLine("Hallo" + " " + _volledigenaam);
                            Console.ReadKey();
                            Console.Clear();

                            }

                            else if (_gekozeoptie2 == 2)
                            {
                             for(int i = 0; i <=20; i++)
                             {
                             Console.WriteLine(i);
                             }
                             Console.ReadKey();
                             Console.Clear();
                            }

                            else if (_gekozeoptie2 == 3)
                            {
                             for (int i = 20; i > 20; i--)
                             {
                             Console.WriteLine(i);
                             }
                             
                            }



























                        _herhalen = true;
                    }
                    catch
                    {

                    }
                }

                //project machten
                else if (_gekozeoptie == 6)
                {
                    _herhalen = true;
                }

                //project vierkantswortel
                else if (_gekozeoptie == 7)
                {
                    _herhalen = true;
                }

                //project cilinder
                else if (_gekozeoptie == 8)
                {
                    _herhalen = true;

                }


                else if (_gekozeoptie > 8)
                {
                    Console.WriteLine("Dit is geen geldige optie optie");
                }
                else if (_gekozeoptie < 1)
                {
                    Console.WriteLine("Dit is geen geldige optie optie");
                }
                Console.ReadKey();
            }
            while (_herhalen = true);
        }
    }
    
}
