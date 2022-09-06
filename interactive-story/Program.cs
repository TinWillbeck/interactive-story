
string flingor = "";
string mode = "";
string byxor = "";
while (byxor != "blåa" && byxor != "svarta")
{
    Console.WriteLine("Tar du svarta eller blåa byxor?");
    byxor = Console.ReadLine();
    if (byxor == "svarta")
    {
        Console.WriteLine("Bra där!");
               
        while (mode != "light" && mode != "dark")
        {
            Console.WriteLine("Har du light mode eller dark mode?");
            mode = Console.ReadLine();
            if (mode == "dark")
            {
                Console.WriteLine("Bra där, good ending");
            }
            else if(mode == "light")
            {
                Console.WriteLine("Light mode är dåligt, neutral ending");
            }
            else
            {
                Console.WriteLine("det var inte svar på frågan (skriv light eller dark)");
            }
        }

    }
    else if (byxor == "blåa")
    {
        Console.WriteLine("Helt okej...");

        while (flingor != "innan" && flingor != "efter")
        {
            Console.WriteLine("Tar du flingor innan eller efter mjölken?");
            flingor = Console.ReadLine();
            if(flingor == "innan")
            {
                Console.WriteLine("Bra, men blåa byxor går inte hem helt, neutral ending");
            }
            else if (flingor == "efter"){
                Console.WriteLine("Dåligt, blåa byxor och flingor efter mjölken... Blir riktigt besviken. Bad ending");
            }
            else{
                Console.WriteLine("det var inte svar på frågan (skriv innan eller efter)");
            }
        }

    }

    else
    {
        Console.WriteLine("det var inte svar på frågan (skriv blåa eller svarta)");

    }
}




Console.ReadLine();

