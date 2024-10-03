Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("S = Segundos => 10s = 10 Segundos");
    Console.WriteLine("M = Minutos => 5m = 5 Minutos");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar? ");

    string data = Console.ReadLine().ToLower();
    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int mult = 1;

    if (type == 'm')
        mult = 60; 

    if (time == 0)
        System.Environment.Exit(0); 

    PreStart(time * mult);
}

static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Preparar");
    Thread.Sleep(1000);
    Console.WriteLine("Apontar");
    Thread.Sleep(1000);
    Console.WriteLine("Iniciar");
    Thread.Sleep(3500);

    Start(time);
}

static void Start(int time)
{
 
    int currentTime = 0;

    while (currentTime != time)
    {
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }
        Console.WriteLine("Contagem finalizada!");
        Thread.Sleep(2500);
        Menu();
    
}