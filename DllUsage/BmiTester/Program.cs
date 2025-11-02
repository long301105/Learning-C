using Bmi;

namespace BmiTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BmiCalculator.GetBmi(77, 1.7);
            var bmi= BmiCalculator.GetBmi(77, 1.7);
            Console.WriteLine("BMI(70kg, 1.7m: )" + bmi);//concatenation
            Console.WriteLine("BMI(70kg, 1.7m: {0})", bmi);//placeholder
            Console.WriteLine($"BMI(70kg, 1.7m: {bmi}");//interpolation
            Console.WriteLine($@"BMI(70kg, 1.7m: {bmi})" );//interpolation
           String bmimessagge=$"BMI(70kg, 1.7m: {bmi})";//tạo chuỗi lẻ r ghép vào sau
            Console.WriteLine(bmimessagge);
            //nguyên lí dấu bằng, a =b thì ở đâu xài b thì ở đó xài a đc

            //DLL: DYNAMIC LINK LIBRARY - thư vien liên kết động, package, thư mục , folder, namepace
            //chứa bên trong nhiều class/ methods để cung cấp tiên ích cho dân developer để làm việc nhanh hơn
            //DLL: nó ko phải file nhị phân mà là code/ mã trung tính trung gian ko gắn với 1 os cụ thể, nó hcayj với runtime, runtime chơi với os
            //app chạy đa nền/ ,,platform independent, cross-platform bản chất là phải có runtime ở dưới gắn vói os/nền cụ thể 
            //app chỉ chạy trên runtime 
            //app chỉ chạy trên runtime -- MacOS
            //app chỉ chạy trên runtime -- Windows
            ///app chỉ chạy trên runtime -- Linux

            //APP trung tính - code trung tính này gọi là msil - microsoft intermediate language
            // từ msil --> back ngược lại .cs source code gốc dev viết ra - reverse engineering - dịch ngược về source code
            //Decompiler - công cụ dịch ngược

            // từ msil lúc run thfi biến thành machine code - mã máy - mã nhị phân - binary code thật gắn os chỉ dùng ngôn ngữ lập trình cấp thấp assembly để xem 
        }
    }
}
