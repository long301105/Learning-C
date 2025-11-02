using System.Security.Cryptography;

namespace Nullable
{
    internal class Student
    {
        //Quy tắc đặt tên field: danh từ + con lạc Đà + từ đầu tiên của chữ thường kèm SHift gạch shift - dấu cách- underscore
        private string _id; // biến khai báo trong class 
        private string _name; // đc gọi là field, attribute 
        private int _yob; //instance variable (nếu ko có static đi kèm)
        public double _gpa;//class level variable (nếu có chữ static đi kèm)

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            this._gpa = gpa; //dư thừa, ko có nhầm lẫn giữa info bên ngoài và cái tui các nhân bên trong

        }

        //show profile
        public void ShowProfile()
        {
            Console.WriteLine($"{_id} | {_name} | {_yob} | {_gpa} ");
        }

    }//Hàm (gọi là method) là đoạn code đc đặt tên, xử lí các biến
     //Hàm + field đc gọi chung là members of a class 
     //thành phần, thành viên của class
     //biến khai báo ở tham số hàm (có thể xài thêm
     //In OUT REF) và khai báo trong hàm ==> gọi chung là local variable - biến cục bộ
     //Constructor + method xử lí các bieens/ field ở trên


    //Trong khuoon viên NAMESPACE  bạn có thể tạo nhiều
    //class
    //Interface
    //DELEGATE (bản chất là 1 class, class rất đặc biệt, đặc biệt hơn interface)

    //các class/interface, có thể tạo lẻ, tạo file riêng rẽ nhưng khai báo cùng
    //NAMESPACE ở đầu trang -> OKIE luôn, cùng 1 khái niệm


    internal class Program
    {
        
        static void Main(string[] args)
        {
            PlayWithNullV6();
        }

        //Nullable - Có khả năng null
        //với biến object, mọi biến object 1 cách tự nhiên đc quyền lưu null 
        // với ý nghĩa biến ch đề cập đến 1 object cụ thể, từ từ sẽ có 
        //object cụ thể 
        //biến object = null, sau đó có thể trò vùng new nào đó

        //phức tạp hơn với csdl


        static void PlayWithNullV1()
        {
            Student s1;//Xin ram
            //Biến mới khai báo thì chỉ xin ram chứ ch có value, nói thẳng là value rác của app trc để lại
            //Java và C#: khai báo biến xog, phải gắn value nào đó sau đó mới đc dùng
            //C: thoải mái, xin biến xong dùng luôn ko gán giá trị
            Student s2= null;//Có xin ram, gán luôn giá trị cho vùng ram có được dọn dẹp r, lúc này biến lưu tọa độ tần trệt
            s2.ShowProfile();//ko bị cảnh báo lúc viết code là xài rác
            //Lỗi lúc runtime: s2=null nghĩa là biến s2 trỏ đáy ram, byte null
            //Ở đây ko có code của hàm showprofile(), sẽ bị báo lỗi tham chiếu chỗ ko có code
            //Khái niệm null đưa ra để giải quyết nhiều chuyện, chuyện phổ biến nhất lkaf dùng cho hàm search 1 object, 1 student
            //Nếu tìm thấy thì trả về object/ SV nào đó
            // nếu ko tìm thấy thì trả về null, để nói rằng ko có object thỏa 
            // trỏ null là trỏ vùng ko thấy, ko có , răng in thông tin báo lỗi


        }


        static void PlayWithNullV2()
        {
            Student s2= null;
            //s2.ShowProfile();

            if (s2 == null)
                Console.WriteLine("S2 is null");
            else s2.ShowProfile();



            if (s2 is null) Console.WriteLine("S2 is null");
            else s2.ShowProfile();

            //kỹ thuật mới của C#
            Console.WriteLine("The new way to check null");

            s2?.ShowProfile();
            //Câu lệnh ? đi kèm tên biến object giúp kiểm tra xem biến đó có null hay ko, nếu ko null, tức là biến đã trỏ vùng new, thì cứ tự nhiên gọi hàm ko sợ bị báo lỗi runtime reference. thực ra là lệnh gộp của if else ở trên
            //? Đi kèm lời gọi hàm của ọbject, gộp kiểm tra null trước khi gọi hàm
            //? đc gọi là : Null Conditional operator - Toán tử kiểm tra null của object
            //thay vì dùng IS NULL, ==NULL ta dùng ? khi gọi hàm của object
        }

        static void PlayWithNullV3()
        {
            //Gắn các biến object cho nhau
            int a = 10;
            int b = a;//Vùng ram b mang giá trị y chang a nhưng 2 vùng ram rierng biệt; nêm này đổi thì ko ảnh hưởng bên kia
            Console.WriteLine("b = "+b);
            b = 2004;
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);

            Student s3= new Student("SE1","An",2004,8.6);
            Student s4 = s3; // 2 biến object cùng trỏ cùng 1 ram đã new với full info
            Console.WriteLine("Check if s4 points to the same s3 points to ... ");
            s4.ShowProfile();

            //Chứng minh trỏ chung tọa độ
            s4._gpa = 999;
            s3.ShowProfile();
            //Nếu truyền biến object qua tham số hàm F(Student s)
            //khi gọi F(s3) F(s4) thì s, s3, s4 trỏ cùng 1 chỗ new 

            //S3 và S4 đang cùng trỏ vùng new 999, SE1,AN , 2004
            Console.WriteLine("Check Profile after assign null to s3: ");
            s3 = null;// hỏi xem s3 đang trỏ gì, có in4 gì
            s3?.ShowProfile();
            s4.ShowProfile();
        }

        static void PlayWithNullV4()
        {
            //Gán giá trị default nào đó cho biến object
            Student s1 = null;
            Student s2 = s1; //s2 cungx là null ngay từ đầu, cùng trỏ đáy ram
            
            s2?.ShowProfile();

            s2 = s1 ?? new Student("SE2", "BINH", 2004, 9.2);

            Console.WriteLine("s2 first: ");
            s2.ShowProfile();
            if (s1 != null)
                s2 = s1;//check 1 biến object có null ko, ko null thì gán biến
            else 
                s2= new Student("SE2", "BINH", 2004, 9.2);
            //đảm bảo luôn trỏ object tử tế, ko trỏ null
            Console.WriteLine("s2 Later : ");
            s2.ShowProfile();
        }

        static void PlayWithNullV5()
        {
            Student s1 = null;
            Student s2 = s1 ??  new Student("SE1","An",2004,8.6);

            s2.ShowProfile();

            s1 = new Student("SE9", "Chin", 2009, 9.9);
           Student s3 = s1 ?? new Student("SE3", "BA", 2003, 9.3);
            s3.ShowProfile();
        }

        static void PlayWithNullV6()
        {
            //Học thêm về toán tử 3 ngôi ? mà bên C, Java cũng có
            ////Phía sau chính là IF ELSE luôn
            //dựa vào năm sinh thì in ra message: Gen Z, TOO OLD,...
            int yob = 2004;
            string msg;
            if (yob > 2000)
                msg = "GEN Z";
            else
                msg = "TOO OLD";
            msg = yob > 2000 ? "GEN Z" : "TOO OLD";
            Console.WriteLine(msg);

            Student s1= null;
            Student s2 = s1 != null ? s1 : new Student("SE1", "AN", 2004, 9.3); 
            s2.ShowProfile();
             

            //Conditonal TERNANRY OPERATOR _ 3 nggôi
            //? Áp dụng chung cho biến object và biến primitive - value-Type
        }


            static void CreateAStudentObject()
        {
            //tạo tử tế vì sẽ còn tình huống bất thường, học sau
            Student s3= new Student("SE1","An",2004,8.6);
            s3.ShowProfile();

        }
    }
}
