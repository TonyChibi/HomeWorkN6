Console.Clear();
bool state=true;
void Counter(){
    Console.WriteLine("insert some integer positive or negative or 0 to stop: ");
    int n=0;
    int count=0;
    while(state){
    n=int.Parse(Console.ReadLine()!);
    if(n>0)count++;
    else if(n==0)state=false;
    }

    Console.WriteLine($"{count} positive integers");
}
Counter();