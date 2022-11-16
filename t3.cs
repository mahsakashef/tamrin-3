using system;
class test;
{
    public static void main()
    {
        string x=console.readline();
        string y=console.readline();
        console.ToInt32(x,y);
        if(x>y)
        {
            int temp=y;
            y=x;
            x=temp;
        }
        for(int i=2; i<=x;i++)
        {
            if(x%i==0 && y%i==0)
            {
                console.writeline(i);
            }
        }

    }
}