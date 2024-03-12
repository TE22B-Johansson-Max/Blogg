
/* ************** Bloggappen ************** */
/* ************** Av: Max Johansson ************** */

// Presentera programmet för användaren

Console.WriteLine("Välkommen till din blogg!");
Console.WriteLine("Här kan du skapa och redigera din egna blogg!");


// Skapa en lista för att lagra blogginlägg
List<string> inlägg = new List<string>();

// Programloopen

while (true) {

    Console.WriteLine("Blogg." +
    "1. Skriv ut ett blogginlägg" +
    "2. Skriv ut hela bloggen" +
    "3. Radera bloggen" +
    "4. Avsluta programmet");
    Console.Write("Ange ditt val (1-4): ");
    string val = Console.ReadLine();

    switch (val)
    {
        case "1":
            SkrivInlägg(inlägg);
            break;
            
        case "2":
            SkrivUtBlogg(inlägg);
            break;

        case "3":
            RaderaBlogg(inlägg);
            break;

        case "4":
            Console.WriteLine("Tack o hej");
            return; 

        default:
        Console.Write("Ditt val måste vara en siffra mellan 1-4: ");
        val = Console.ReadLine();
        break;
    }



}

    // Visa meny

    

    // Hantera menyval
        //

/* ************** Metoder ************** */


static void SkrivInlägg(List<string> lista) {
    Console.Write("Skriv ditt inlägg: ");
    string inläggString = Console.ReadLine();
    lista.Add(inläggString);
}

static void SkrivUtBlogg(List<string> lista ) {
    foreach (var Inlägg in lista)
    {
        Console.WriteLine(Inlägg);
    }
}

static void RaderaBlogg(List<string> lista) {
    lista.Clear();
}

