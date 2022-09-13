Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int XA = 40, YA = 1;
int XB = 1, YB = 20;
int XC = 80, YC = 20;

Console.SetCursorPosition(XA, YA);
Console.WriteLine("+");

Console.SetCursorPosition(XB, YB);
Console.WriteLine("+");

Console.SetCursorPosition(XC, YC);
Console.WriteLine("+");

int x = XA, y = YA;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3);
    if(what == 0)
    {
        x = (x+XA)/2;
        y = (y+YA)/2;
    }

    if(what == 1)
    {
        x = (x+XB)/2;
        y = (y+YB)/2;
    }

    if(what == 2)
    {
        x = (x+XC)/2;
        y = (y+YC)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;

}