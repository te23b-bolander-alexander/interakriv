Console.WriteLine("Du är påväg till skolan och möter dig själv vid 2 övergångställen. Väljer du att gå över övergångstället åt höger eller vänster");
string hoger = Console.ReadLine();

if (hoger == "höger")
{
    Console.WriteLine("Du fortsätter dig mot skolan och ser en busshållsplats där det står att bussen kommer om 5 minuter. väntar du på bussen eller fortsätter du gå?");
    string stanna = Console.ReadLine();

    if (stanna == "vänta")
    {
        Console.WriteLine("medans du väntar på bussen kommer det en väldigt gammal dam som säger till dig att du inte borde gå på bussen. Ignorerar du henne eller lyssnar du på henne och börjar gå mot skolan?");
        string Ignorerar = Console.ReadLine();

        if (Ignorerar == "ignorera")
        {
            Console.WriteLine("Bussen kommer och du går på. Bussen börjar åka på fel sida vägen och börjar köra fortare och fortare tills den har kommit upp till 200km/t. Den kör igenom folk och bilar utan att avsluta sin bana. Du kastas runt i bussen och börjar be att bussen ska stanna. Bussen får tillslut ett stopp när den kör in i en betöngvägg och mosar alla innuti bussen inkluderande dig. Du är död!");
        }
        if (Ignorerar == "gå")
        {
            Console.WriteLine("När du börjar gå mot skolan så ramlar du ner ett sjukhål och faller 2km ner under jordens yta. Du är DÖD!");
        }
    }
    else if (stanna == "gå")
    {
        Console.WriteLine("Medans du går så kommer du till 2 till övergångsställen. Den åt vänster gör din promenad till skolan 5 min kortare medans den åt höger gör den 5 min längre. Går du höger eller vänster?");
        
        string action = Console.ReadLine();

        if (action == "vänster")
        {
            Console.WriteLine("När du går över övergångsstället så åker en buss rakt in i dig och plattar till dig som en pannkaka. Du är död!");
        }
        else if (action == "höger")
        {
            Console.WriteLine("Du går över övergångstället och ser till din vänster en buss flyga förbi dig snabbare än någo bil du någonsin har sätt. Du ignorerar alla döda kroppar och förstörda bilar påvägen och fortsätter mot skolan. Du kommer till skolan och när du ska öppna dörren ser du på din mobil att skolan är stängd för idag eftersom alla lärare har dött. Du Klarade dig! YIPPIE!!!!");
        }
     }
    




}
else if (hoger == "vänster")
{
Console.WriteLine("Du går över det vänstra övergångstället och börjar promenera till din skola. Medans du går så ser du 2 personer råna en gammal dam i en återvändsgränd. Hjälper du den gamla damen eller fortsätter du gå?");

    string hjalpa = Console.ReadLine();
    
        if (hjalpa == "hjälpa")
    {
        Console.WriteLine("Du smyger upp bakom en av killarna och slår han det hårdaste du kan i bakhuvudet. Killen vänder sig om utan att verka skadad och medans du inser att du bara är en andraklassare så tar han sin pistol och skjuter dig i ditt huvud. Du är död!");
    }
    else if (hjalpa == "gå")
    {
        Console.WriteLine("du väljer att ingorera tanten som verkerligen behöver din hjälp och medans du går hör du hennes skrik och sedan ett skott innan det blir tyst. Du fortsätter på din väg till du kommer till ett övergångställe. Går du över eller väljer du att gå hem igen och grinda fortnite battlepasset?");
    }
    string skibidi = Console.ReadLine();

    if (skibidi == "gå")
    {
        Console.WriteLine("När du sträcker fram ditt ben så kommer det en buss fram och kapar av det med sin fart. Du ramlar ner på asfalten och medans du blöder ut så kommer du på att du inte hade sagt till din mamma att du älskade henne denna morgon, Du gör det varje morgon men idag försöv du dig och hann inte. Varför idag. Du har förblött och är död!");
    }








}





Console.ReadLine();