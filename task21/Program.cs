void Distance3d()
{
   
    Console.WriteLine("Введите координаты точки X1 ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки Y1 ");
    int y1  = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки Z1 ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки X2 ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки Y2 ");
    int y2  = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки Z2 ");
    int z2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Расстояние между точками = " + Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1))
    +((z2-z1)*(z2-z1))));

}

Distance3d();
