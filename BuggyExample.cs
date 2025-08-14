using System;

namespace SonarTest
{
    class BuggyExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sonar Buggy Example");

            int a = 5;
            int b = 0;

            // Bug: chia cho 0
            int c = a / b;
            Console.WriteLine("C: " + c);

            string unused = "Not used"; // Biến chưa sử dụng

            // Bug: phương thức không được gọi
            ShowMessage();

            // Bug: vòng lặp tiềm ẩn vô hạn
            int i = 0;
            while (i < 3)
            {
                // i++; // comment sẽ gây loop vô hạn
            }

            Console.WriteLine("End of BuggyExample");
        }

        public static void ShowMessage()
        {
            Console.WriteLine("Hello Sonar!");
        }
    }
}
