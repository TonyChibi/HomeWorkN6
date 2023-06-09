Console.Clear();
double Square(double[]arr1,double[]arr2,double[]arr3){
    double a=Math.Sqrt(Math.Pow((arr1[0]-arr2[0]),2)+Math.Pow((arr1[1]-arr2[1]),2));
    double b=Math.Sqrt(Math.Pow((arr2[0]-arr3[0]),2)+Math.Pow((arr2[1]-arr3[1]),2));
    double c=Math.Sqrt(Math.Pow((arr3[0]-arr1[0]),2)+Math.Pow((arr3[1]-arr1[1]),2));
    double p=(a+b+c)/2;
    
    
    return Math.Round(Math.Sqrt(p*(p-a)*(p-b)*(p-c)),2);
}

Console.WriteLine("insert x1: ");
double x1=double.Parse(Console.ReadLine()!);
Console.WriteLine("insert y1: ");
double y1=double.Parse(Console.ReadLine()!);
Console.WriteLine("insert x2: ");
double x2=double.Parse(Console.ReadLine()!);
Console.WriteLine("insert y2: ");
double y2=double.Parse(Console.ReadLine()!);
Console.WriteLine("insert x3: ");
double x3=double.Parse(Console.ReadLine()!);
Console.WriteLine("insert y3: ");
double y3=double.Parse(Console.ReadLine()!);


double []a={x1,y1};
double []b={x2,y2};
double []c={x3,y3};

Console.WriteLine($"square is {Square(a,b,c)}");