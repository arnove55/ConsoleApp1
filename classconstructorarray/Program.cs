// See https://aka.ms/new-console-template for more information
class A {
    public void display()
    {
        Console.WriteLine("Inside class");
    }
    public void change(ref int n) {
        n = n + 1;
    }
    public void change1(int n1 ,out int result)
    {
       result=n1+2;
    }
    public A()
    {

    }
    public A(int a,int b) {
        int c = a + b;
        Console.WriteLine (c);
    }
    public void arraywithparams(params int[] ar)
    {
        foreach (int i in ar)
        {
            Console.WriteLine(i);
        }
    }


}

enum Week { mon, tue, wed };

class classconstructorarray {
    
    static public void Main(String[] args)
    {
        A a = new A();
        A b1 = new A(9, 3);
        int n = 2;
        int result;
        
        a.change1 (2,out result);
        
        Console.WriteLine("before ref"+n);
        a.change(ref n);
        Console.WriteLine("after ref"+n);

        a.arraywithparams(1,2,3,4);
        Console.WriteLine(b1);
        a.display();
        int[] aa = { 1, 2, 3, 4 };
        foreach (int b in aa) { 
            Console.WriteLine(b);
        }
        int[,] bb = { { 26, 17,9 }, { 12, 13 ,9} };
        foreach (int b2 in bb) {
            Console.WriteLine(b2);
        }
        Week getday = Week.mon;
        Console.WriteLine(getday);

    }
}



