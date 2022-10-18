namespace OOP_2_Inheritance
{
    public class Square : Rectangle
    {
        public Square()
        {

        }
        public Square(int x, int y) : base(x, y)
        {

        }
        new public void Calculate()   // Base classtan aldığınız calculate methodunu geçersiz kılmak istiyorsanız
                                      // onun yerine buradaki methodu kullanmk istiyorsanız new sözcüğünü ekle.
        {
            System.Console.WriteLine("Calculated by Square...");
        }
    }
}



