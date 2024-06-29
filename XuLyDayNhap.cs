using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BT010_NapDaySoTinhTong
{
    internal class XuLyDayNhap
    {
        //ham kiem tra chuoi

        public static bool IsChuoiSo(string input)
        {
            // Sử dụng regex để kiểm tra chuỗi
            return Regex.IsMatch(input, @"^(\d+\s*)+$");
        }
        public static int[] PareNumber(string input)
        {
            // Chuyển chuỗi nhập vào thành mảng số nguyên
            string[] numberStrings = input.Split(' ');
            int[] numbers = new int[numberStrings.Length];
            for (int i =0; i < numberStrings.Length;i++)
            {
                int.TryParse(numberStrings[i], out numbers[i]);
                
            }
            return numbers;

        }
        //ham tinh tong cac so
        public static int CaculateSum(int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num  ;
            }
            return sum;
        }
        public static int SumString(string input)
        {
            // chuyển chuỗi thành dãy số 
            return CaculateSum( XuLyDayNhap.PareNumber(input));
        }
       
       public static  (int evenSum, int oddSum) CalculateEvenAndOddSumString(string input)
        {
            // chuyển chuỗi thành dãy số rồi tính tổng chẵn lẻ
            int[] numbers = XuLyDayNhap.PareNumber(input);

             return CalculateEvenAndOddSum(numbers);
        }
        public static ( int evenSum , int oddSum) CalculateEvenAndOddSum(int[] numbers)
        {
            // Tính tổng chẵn và lẻ
            int evenSum = 0;
            int oddSum = 0;
            foreach(int num in numbers)
            {
                if(num%2 == 0)
                {
                    evenSum +=num;
                }
                else
                {
                    oddSum +=num;
                }
            }
            return (evenSum, oddSum);
        }
    }
}
