namespace NullableV2
{
    public class Student
    {
        private string _id;
        private string? _name;
        private int _yob;
        private double? _gpa; //biến gpa có thể lưu giá trị null

        public Student(string id, string? name, int yob, double? gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public void ShowProfile()
        {
            Console.WriteLine($"{_id} | {_name} | {_yob} | {_gpa} ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("SE1", null, 2004, null);
            s1.ShowProfile();

            Student s2 = new Student("SE2", "BINH", 2004, 8.6);
            s2.ShowProfile();

            Student s3 = new Student("SE3", "CUONG", 2003, null);
            s3.ShowProfile();

            Student s4 = null;
            Console.WriteLine("Check Null Object Null ?");
            s4?.ShowProfile();

            //double gpa = null;
            //Console.WriteLine("Gpa: "+ gpa);
            double? gpa = null;
            Console.WriteLine("Gpa: "+gpa);

            //Student? s1 = null;
            //Student? s2 = null;

            //Dấu hỏi chấm ? đi kèm tên kiểu dữ liệu, ạp dụng cho biến object hoặc primitive data type/ value-type đều đc mang ý nghĩa : Biến có thể chứa giá trị null- vô thường, chưa xác định giá trị
            //với biến primitive value-type(lưu value thuần- dùng luôn)
            //Ngoài việc lưu value như truyền thống còn thêm việc lưu giá trị null để hàm ý ko gì cả
            //int? long? char? bool? double? float? decimal? DateTime?
            //Vẫn lưu value thường và thêm giá trị null
            //các data type lúc này đc gọi là nullable data type
        }
    }
}
