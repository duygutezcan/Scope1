// See https://aka.ms/new-console-template for more information
Basla();

void Basla()
{
    int x = 100;
    Console.WriteLine("x ilk değeri:" + x);
    IkiyeKatla(x);
    Console.WriteLine("x metotdan döndükten sonrası değeri:" + x);

}

void IkiyeKatla(int x)
{
    
    x = x * 2;
    Console.WriteLine("x metot içi değeri:" + x);
}