// Välkomnande meddelande DONE
// En lista för att spara historik för räkningar DONE??
// Användaren matar in tal och matematiska operation DONE?? NEGATIVA TAL??
//OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!
// Ifall användaren skulle dela 0 med 0 visa Ogiltig inmatning!
// Lägga resultat till listan DONE?
//Visa resultat DONE
//Fråga användaren om den vill visa tidigare resultat. 
//Visa tidigare resultat
//Fråga användaren om den vill avsluta eller fortsätta.

//BYTA ORDNING PÅ ALLT I MENYN AVSLUTA SIST
//KOMMENTERA VAD ALLT GÖR kort
//KOMMENTERA VAD MAN KAN FÖRBÄTTRA
//SPLIT ?

//FÖRSÖK LÄGGA SAKER I METODER O ANROPA



using Kalkylator;
Console.ForegroundColor = ConsoleColor.DarkBlue;
//STRING list ist
List<string> beräkningar = new List<string>();
List<string> tomLista = new List<string>(); //TABORT
//List<double> beräkningar = new List<double>();
Console.Title = "Kalkylator";
Console.WriteLine("Välkommen till Miniräknaren skapad av Filip!");
string menyLoop = "";




while (menyLoop != "3" || menyLoop != "y" )
{
    //Skriv ut meny
    
    Class1.SkrivUtMeny();
    menyLoop = Console.ReadLine();
    

    switch (menyLoop)
    {
        case "1": //Ta med allt´inne i switch utom ´de olika casen tex case1
            

        case "startover"://GOTO STATEMENTS
            Console.Clear();
            string matteTal = "";
            while (true)
            {


                Console.WriteLine("Skriv in ett tal du vill räkna ut");

                // fungerar = double.TryParse(Console.ReadLine(), out matteTal); //IF BOOL TRUE FALSE
                 matteTal = Console.ReadLine();

                Console.Beep();
                //ConvertTo(fungerar, matteTal);
                //   if (!fungerar)
                //       Console.WriteLine("Skriv in siffror istället tack");

                Console.Clear();

                if (matteTal.Contains("+"))
                {
                    //För att ite krrascha vid inmatningen av annat ön siffror while loop och tryparsr
                    int plussIndex = matteTal.IndexOf("+");
                    string tal1TextPluss = matteTal[..plussIndex];
                    string tal2TextPluss = matteTal[(plussIndex + 1)..];
                    // double tal1Pluss = double.TryParse(tal1TextPluss(), out matteTal;
                    double tal1Pluss;
                    bool fungerar = double.TryParse(tal1TextPluss, out tal1Pluss);
                    double tal2Pluss;
                    bool fungerar2 = double.TryParse(tal2TextPluss, out tal2Pluss);
                    double summaPluss = tal1Pluss + tal2Pluss;
                    if (!fungerar || !fungerar2)
                    {
                        Console.WriteLine("Skriv in siffror");

                    }

                    else
                    {
                        string helaTalet = matteTal + " " + "=" + " " + summaPluss;
                        Console.WriteLine($"{matteTal} = {summaPluss}");
                        Console.WriteLine();
                        beräkningar.Add(helaTalet);
                        break;
                    }
                    //gör samma på tal2 OSV
                    //Om den är sann fortstt annars skriv nytt tal
                    //ALLT HÄR ÄR TEST!!!!!
                    //if (matteTal.Contains("+")&& matteTal.Contains("+"))
                    //    {
                    //    int andraPlussIndex = matteTal.IndexOf("+");
                    //    string tal3TextPluss = matteTal[(andraPlussIndex + 1)..];
                    //    double tal3Pluss = double.Parse(tal3TextPluss);
                    //    double summaPluss2 = tal1Pluss + tal2Pluss + tal3Pluss;
                    //    string helaTalet2 = matteTal + " " + "=" + " " + summaPluss;
                    //    Console.WriteLine($"{matteTal} = {summaPluss}");
                    //}
                    //tiLL HÄR ÄR TEST

                    
                    //Console.WriteLine("Tryck ned valfri tagent för att gå till menyn");
                   // Console.ReadKey();
                   // Console.Clear();
                    // Console.WriteLine("Vill du fortsätta (y/n)");
                    //  string fortsätt = Console.ReadLine();
                    // Console.Clear();
                    //if(fortsätt == "y")
                    //{

                    //    break;

                    //}
                    //else if(fortsätt == "n")
                    //{
                    //    Environment.Exit(0);
                    //}
                    //else Console.WriteLine("Var vänlig och skriv in (y/n");

                    //DETTA FUNGERAR EJ ÄN SKA FÖRLSÖKA LÖSA SÅ MAN KAN HA 3 TAL ELLER FLER
                    //if (tal2TextPluss.Contains("+"))
                    //{
                    //    int andraPlussIndex = tal2TextPluss.IndexOf("+");
                    //    string tal3TextPluss = tal2TextPluss[(andraPlussIndex + 1)..];
                    //    double tal3Pluss = double.Parse(tal3TextPluss);
                    //    Console.WriteLine($"Summan av {matteTal} = {tal1Pluss + tal2Pluss + tal3Pluss}");
                    //}
                    
                }
            }
            if (matteTal.Contains("-"))
            {
                //Följande kod är för att räkna ut minus
                int minusIndex = matteTal.IndexOf("-");
                string tal1TextMinus = matteTal[..minusIndex];
                string tal2TextMinus = matteTal[(minusIndex + 1)..];
                double tal1Minus = Double.Parse(tal1TextMinus);
                double tal2Minus = Double.Parse(tal2TextMinus);
                double summaMinus = tal1Minus - tal2Minus;
                string helaTalet = matteTal + " " + "=" + " " + summaMinus;
                beräkningar.Add(helaTalet);
                Console.WriteLine($"{matteTal} = {summaMinus}");
                Console.WriteLine("Tryck ned valfri tagent för att gå till menyn");
                Console.ReadKey();
                Console.Clear();
            }
            if (matteTal.Contains("*"))
            {
                //Följande kod är för att räkna ut gånger
                int gångerIndex = matteTal.IndexOf("*");
                string tal1TextGånger = matteTal[..gångerIndex];
                string tal2TextGånger = matteTal[(gångerIndex + 1)..];
                double tal1Gånger = double.Parse(tal1TextGånger);
                double tal2Gånger = double.Parse(tal2TextGånger);
                double summaGånger = tal1Gånger * tal2Gånger;
                string helaTalet = matteTal + " " + "=" + " " + summaGånger;
                beräkningar.Add(helaTalet);
                Console.WriteLine($"{matteTal} = {summaGånger}");
                Console.WriteLine("Tryck ned valfri tagent för att gå till menyn");
                Console.ReadKey();
                Console.Clear();

            }
            if (matteTal.Contains("/"))
            {
                //Följande kod är för att räkna ut delat
                int delatIndex = matteTal.IndexOf("/");
                string tal1TextDelat = matteTal[..delatIndex];
                string tal2TextDelat = matteTal[(delatIndex + 1)..];
                double tal1Delat = double.Parse(tal1TextDelat);
                double tal2Delat = double.Parse(tal2TextDelat);
                double summaDelat = tal1Delat / tal2Delat;
                if (tal2Delat == 0)//OAvsätt tal delat med 0
                {
                    Console.WriteLine("Oj något blev fel");

                }
                else
                {
                string helaTalet = matteTal + " " + "=" + " " + summaDelat;
                beräkningar.Add(helaTalet);
                Console.WriteLine($"{matteTal} = {summaDelat}");

                }//FIXA SÅ M

                Console.WriteLine("Tryck ned valfri tagent för att gå till menyn");
                Console.ReadKey();
                Console.Clear();
                int menyVal = 0;
                if (tal2Delat == 0)//OAvsätt tal delat med 0
                {
                    Console.WriteLine("Oj något blev fel");
                    
                }   //FIXA SÅ MAN KAN SKRIVA IN TALET IGEN
            }
            //FIXA DENNA MED LOOP SÅ DU FÅR SKRIVA IN TAL IGEN
            //else Console.WriteLine("Ogiltigt räknesätt försök igen");
            //KOLLA UPP DETTA OBS
            //if (matteTal.Contains("+") && matteTal.Contains("-"))
            //{
            //    //DETTA ÄR TVEKSSMT HUR JAG SKA GÖRA
            //    //TANKEN ÄR ATT KUNNA SKRIVA TEX 5+5-5/2
            //    //HUR SKA JAG GÖRA FÖR ATT LÖSA DET
            //}

            break;

            case "2":
           // bool visaResultat = true;
          //  Console.WriteLine("Vill du visa resultat (j/n)? ");
         //   string villDUResultat = Console.ReadLine();
         //   while (villDUResultat != "n")
            {
                Console.Clear();
                Console.WriteLine("Här är dina senaste beräkningar");
                Console.WriteLine();
                
                foreach (string tal in beräkningar)
                {
                    Console.WriteLine(tal);
                    Console.WriteLine();

                    if (beräkningar == tomLista)
                    {
                        Console.WriteLine("Listan du försöker kolla i är tyvärr tom.");
                        Console.ReadKey();
                    }
                   // Console.WriteLine("Tryck ned valfri tagent för att gå till menyn");
                    //Console.ReadKey();
                    
                }
                
                //Console.Clear();
               // break;
            }
           // Console.Clear();
            break;


        case "3": //DETTA FUNGERAR EJ 
            //För att lösa detta kolla på annan lösning än while(menyLoop !=3)
            //Kanske kan använda bool o sätta den false/true
            Console.WriteLine("Vill du Avsluta Programmet? (j/n)");
            string avslutaProgram = Console.ReadLine();
            while (avslutaProgram == "n")
            {
                Console.WriteLine("Då återgår vi till menyn");
                break;
            }
            Console.WriteLine("Avslutar program");
            Environment.Exit(0);
            break;

        case "4":
            Console.WriteLine("OBS allt innehåll i listan kommer att raderas är du säker (y/n)");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            string raderaAllt = Console.ReadLine();
            if(raderaAllt == "y")
            {
                beräkningar.Clear();
                Console.WriteLine("Listan är nu tom");
            }
            else if (raderaAllt == "n")
            {
                Console.WriteLine("Då behåller vi listan");
                Console.ReadKey();
                break;
            }
            break;

        case "5":
            Console.WriteLine("Vill du sortera listan (y/n)?");
            string sorteraListan = Console.ReadLine();
            if(sorteraListan == "y")
            {
                beräkningar.Sort();
                Console.WriteLine("Nu är din lista sorterad från minsta till största summa");
            }
            else if (sorteraListan == "n")
            {
                Console.WriteLine("Då sorterar vi inte listan");

            }
            else Console.WriteLine("Vänligen ange (y/n)");
            break;
           
        default:
            Console.WriteLine("Vänligen skriv in en siffra mellan (1-3)");
            break;
    }

    //string FelHantering()
    //{
    //    string talMetod = "";
    //    while ()
    //    {
    //        Console.WriteLine("Fel inmatning");
    //    }
    //}
    //static string ConvertTo(bool fungerar, double matteTal)
    //{

    //    fungerar = double.TryParse(Console.ReadLine(), out matteTal); //IF BOOL TRUE FALSE
    //                                                                  //matteTal = Console.ReadLine();

    //    if (!fungerar)
    //        Console.WriteLine("Skriv in siffror istället tack");
    //    return matteTal.ToString();
    //}
}

    

























