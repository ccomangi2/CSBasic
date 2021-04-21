using System;

namespace CSBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "이" + "수" + "빈";
            Console.Write("개행이 안되는 녀석");
            Console.WriteLine("개행이 되는 녀석");

            var alpha = "알파";
            // var 273alpha = "숫자이름";
            var 한글변수명 = "된당";
            // string 이모지 = "이모지는 안 된다";

            // 인라인 주석
            /*
             * 여러 줄 주석
             */

            Console.WriteLine("Hello C# Programming ..!");

            Console.WriteLine(52);
            // Arithmetic Opertor + - * /
            Console.WriteLine(52 + 273);
            // Opertor
            Console.WriteLine(5 + 3 * 2);
            Console.WriteLine(10 / 5);
            Console.WriteLine(10 % 5);
            Console.WriteLine(7 % 3);

            //실수
            Console.WriteLine(52.273);

            Console.WriteLine(0); // 정수 입니다.
            Console.WriteLine(0.0); // 실수 입니다.

            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0);
            Console.WriteLine(1.0 * 2.0);
            Console.WriteLine(1.0 / 2.0);

            //문자
            Console.WriteLine('A');
            Console.WriteLine('가');
            Console.WriteLine('나');

            Console.WriteLine("안녕하세요");
            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("\"\"\"");
            Console.WriteLine("가나다" + "라마" + "바사아" + "자차카타" + "파하");
            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("안녕하세요"[3]);

            //Console.WriteLine("안녕하세요"[100]); 예외 발생

            //불
            Console.WriteLine(true);
            Console.WriteLine(false);

            //비교 연산자
            Console.WriteLine(52 < 273);
            Console.WriteLine(52 > 273);

            //논리 연산자
            Console.WriteLine(!true);
            Console.WriteLine(!false);
            Console.WriteLine(!(52 < 273));
            Console.WriteLine(!(52 > 273));
        }
    }
}
