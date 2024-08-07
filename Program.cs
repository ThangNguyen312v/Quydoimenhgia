using System;
namespace quydoitiente{
    class Program{
        static void Main(string[] args){
            float USD;
            float VND;
            float rate = 25150;
            
            Console.WriteLine("nhap so tien muon quy doi: ");
            USD = Int16.Parse(Console.ReadLine());
            VND = USD * rate;
            Console.WriteLine("So tien quy doi la: " + VND);
            


        }
    }
}
