using System;
using System.Data.Common;
using System.Reflection.Emit;


namespace UocChungLonNhat
{
    class Program
    {
        static void Main(string[]args)
        {
            int soNguyenA;
            int soNguyenB;
            int ucln=1;
           
            Console.Write("Nhap so nguyen A: ");
            while (true)
            {
                if(Int32.TryParse(Console.ReadLine(), out soNguyenA))
                {
                    break;
                }
                else
                {
                    Console.Write("Nhap lai so nguyen A: ");
                }
            }
            Console.Write("Nhap so nguyen B: ");
            while (true)
            {
                if(Int32.TryParse(Console.ReadLine(), out soNguyenB))
                {
                    break;
                }
                else
                {
                    Console.Write("Nhap lai so nguyen B: ");
                }
            }
            int a=Math.Abs(soNguyenA);
            int b=Math.Abs(soNguyenB);
            if(a==0||b==0)
            {
                Console.WriteLine("Khong co uoc chung lon nhat");
            }
            while (a!=b)
            {
                if(a>b)
                {
                    if(a%b!=0)
                    {
                        a=a%b; 
                        ucln=a;
                    }
                    else
                    {
                        ucln=b;
                        break;
                    }
                    
                }
                else
                {
                    
                    if(b%a!=0)
                    {
                        b=b%a;
                        ucln=b;
                    }
                    else
                    {
                        ucln=a;
                        break;
                    }
                }
                               
            }
           
            Console.Write("Uoc chung lon nhat cua {0} va {1} la: {2}",soNguyenA,soNguyenB, ucln);
         
            
        }
    }
}