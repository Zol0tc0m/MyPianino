ConsoleKeyInfo txt = Console.ReadKey();

Console.WriteLine(txt.Key);
int[] octava = new int[] { 1047, 1109, 1175, 1245, 1319, 1397,1480,1568 };

while (true)
{
    if (txt.Key == ConsoleKey.C)
    {
        Console.Beep(octava[0], 100);
    }
    else if (txt.Key == ConsoleKey.F)
    {
        Console.Beep(octava[1], 100);
    }
    else if (txt.Key == ConsoleKey.V)
    {
        Console.Beep(octava[2], 100);
    }
    else if (txt.Key == ConsoleKey.G)
    {
        Console.Beep(octava[3], 100);
    }
    else if (txt.Key == ConsoleKey.B)
    {
        Console.Beep(octava[4], 100);
    }
    else if (txt.Key == ConsoleKey.H)
    {
        Console.Beep(octava[5], 100);
    }
    else if (txt.Key == ConsoleKey.N)
    {
        Console.Beep(octava[6], 100);
    }
    else if (txt.Key == ConsoleKey.J)
    {
        Console.Beep(octava[7], 100);
    }
    else if (txt.Key == ConsoleKey.F4)
    {
        octava = Oct(4);
    }
    else if (txt.Key == ConsoleKey.F5)
    {
        octava = Oct(5);
    }
    else if (txt.Key == ConsoleKey.F6)
    {
        octava = Oct(6);
    }
    txt = Console.ReadKey();

}
int[] Oct (int num)
{
    int[] Four = new int[] { 261, 277, 293, 311, 329, 349, 370, 392 };
    int[] Five = new int[] { 523, 554, 587, 622, 659, 698, 740, 784 };
    int[] Six = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568 };
    
    if (num == 4)
    {
        return Four;
    }
    else if( num == 5)
    {
        return Five;
    }
    else 
    {
        return Six; 
    }
}