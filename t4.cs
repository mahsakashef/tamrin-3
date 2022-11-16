using system;
class test;
{
    public static void main()
    {
        int roz;
        roz=Convert.ToInt32(Console.ReadLine());
         Age(roz);
    }
    private static void Age(int roz)
    {
        int sal,mah,hafte;
        sal=roz/365;
        roz%=365
        mah=roz/30;
        roz%=30;
        hafte=roz/7;
        roz%=7;
         Console.WriteLine(sal);
            Console.WriteLine(mah);
            Console.WriteLine(hafte);
            Console.WriteLine(roz);
    }
}