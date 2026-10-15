//Toto je jednořádkobvý komentář

/* Toto je víceroádkový komentář
 * Může být rozdělen do více řádků
 * a je ukončen znakem */

//nejprve budeme rešít opakování programu, proto si vytvoříme metodu, která bude vypisovat řadu čísel
    string again = "a"; //string je datový typ, který uchovává text, v tomto případě písmeno a

// Tolower () provede vstup na malá pismena,  takže program bude pokračovár pei zadávani malého a.
    while (again.ToLower() == "a")
    {
        // dotaz směrem k uživateli na opakovani
     Console.Clear();
    Console.WriteLine ();
    Console.WriteLine ( "Pro opakování programu stisknete klavesu a, nasledně ENTER, pro podtvrzení.");
    Console.WriteLine ("Jakoukoliv jinou klávesou program ukončíte.");
    Console.WriteLine ();
    Console.WriteLine ("Chcete program spoustit znovu?");
    again = Console.ReadLine() ??""; //pokud uživatel nezadá žádný vstup, tak se do proměnné again uloží prázdný řetězec
    } 

             


