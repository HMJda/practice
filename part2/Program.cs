using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("이름 나이 학교 주소를 입력하시오.");
            string k = Console.ReadLine();
            string [] km = k.Split(' ');
            string name = km[0];
            int age = int.Parse(km[1]);
            string university = km[2];
            string adress = km[3];
            Console.WriteLine($"이름: {name}, 나이: {age} \n학교: {university}, 주소: {adress}");
        }
    }
}
