Console.Clear();
double [] intersection(double []arr1,double []arr2){
    double pre=arr1[0]-arr2[0];
    if (pre<0)pre*=-1;
    double x=pre/(arr1[1]-arr2[1]);
    double y=arr1[1]*x+arr1[0];
    double []arr={x,y};
    return arr;
}

Console.Write("insert k1: ");
double k1=double.Parse(Console.ReadLine()!);
Console.Write("insert b1: ");
double b1=double.Parse(Console.ReadLine()!);

Console.Write("insert k2: ");
double k2=double.Parse(Console.ReadLine()!);
Console.Write("insert b2: ");
double b2=double.Parse(Console.ReadLine()!);
double[]arr1={b1,k1};
double[]arr2={b2,k2};
Console.WriteLine($"the intersection is [{string.Join("; ",intersection(arr1,arr2))}] ");
