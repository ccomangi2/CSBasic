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

            //정수 자료형
            int a = 273;
            int b = 52;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            //오버 플로우
            a = 2147483640;
            b = 52273;

            Console.WriteLine(a + b);

            //실수 자료형
            double c = 52.273;
            double d = 103.32;

            Console.WriteLine(c + d);
            Console.WriteLine(c - d);
            Console.WriteLine(c * d);
            Console.WriteLine(c / d);

            //문자 자료형
            char e = 'e';
            Console.WriteLine(e);

            //sizeof(자료형)
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("char: " + sizeof(char));

            //문자열 자료형
            string message = "안녕하세요";

            Console.WriteLine(message + "!");
            Console.WriteLine(message[0]);
            Console.WriteLine(message[1]);
            Console.WriteLine(message[2]);

            //불 자료형
            bool one = 10 < 0;
            bool other = 20 > 100;

            Console.WriteLine(one);
            Console.WriteLine(other);

            //복합 대입 연산자
            //숫자
            int output = 0;
            output += 52;
            output += 273;
            output += 103;

            Console.WriteLine(output);

            //문자열
            string output2 = "hello";
            output2 += "world";
            output2 += "!";

            Console.WriteLine(output2);

            //증감 연산자
            int number = 10;
            number++;
            Console.WriteLine(number);
            number--;
            Console.WriteLine(number);

            //전위
            Console.WriteLine(number);
            Console.WriteLine(number++);
            Console.WriteLine(number--);
            Console.WriteLine(number);

            //후위
            Console.WriteLine(number);
            Console.WriteLine(++number);
            Console.WriteLine(--number);
            Console.WriteLine(number);

            //자료형 검사
            int _int = 273;
            long _long = 522731033265;

            float _float = 52.273F;
            double _double = 52.273;
            char _char = '귤';
            string _string = "문자열";

            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());

            //직접적인 GetType()
            Console.WriteLine((273).GetType());
            Console.WriteLine((522731033265L).GetType());
            Console.WriteLine((52.273F).GetType());
            Console.WriteLine((52.273).GetType());
            Console.WriteLine(('자').GetType());
            Console.WriteLine(("문자열").GetType());

            //var 키워드
            var num = 100;

            //입력
            string input = Console.ReadLine();
            Console.WriteLine("input: " + input);

            //강제 형변환
            //long longNumber = 2147483647L + 2147483647L;
            long longNumber = 100;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            //자동 형변환
            intNumber = 100;
            longNumber = intNumber;
            Console.WriteLine(longNumber);

            //int -> long, float, double
            //long -> float, double
            //char -> int, long, float, double
            //float -> double

            //Widening Casting 자동 형변환
            //byte -> short -> char -> int -> long -> float -> double

            //Narrwing Casting 강제 형변환
            //double -> float -> long -> int -> char -> short -> byte

            //int.Parse() / long.Parse()
            //float.Parse() / double.Parse()
            string numberString = "52273";
            //intNumber = (int)numberString;
            intNumber = int.Parse(numberString);
            Console.WriteLine(intNumber);

            try
            {
                Console.WriteLine(int.Parse("52.273"));
                Console.WriteLine(int.Parse("오십일"));
                Console.WriteLine(int.Parse("seven"));
            } catch(FormatException fe)
            {
                Console.WriteLine("숫자로 변경할 수 없습니다.");
            } catch(Exception ee)
            {
                Console.WriteLine("알 수 없는 오류:" + ee.Message);
            }

            Console.WriteLine((10).ToString());
            Console.WriteLine((52.273).ToString());
            Console.WriteLine(('a').ToString());
            Console.WriteLine((true).ToString());
            Console.WriteLine((false).ToString());

            double number2 = 52.273103;
            Console.WriteLine(number2.ToString("0.0"));
            Console.WriteLine(number2.ToString("0.00"));
            Console.WriteLine(number2.ToString("0.000"));
            Console.WriteLine(number2.ToString("0.0000"));

            Console.WriteLine(52 + "");
            Console.WriteLine(52 + 3 + "");
            Console.WriteLine("" + 52 + 3);
            Console.WriteLine(52 + "" + 3);

            number = 273;
            string outputA = number + "";
            Console.WriteLine(number);

            char ch = 'a';
            string outputB = ch + "";
            //string outputD = 3;
            Console.WriteLine(outputB);

            //string to bool 변환
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("Frue"));
            Console.WriteLine(bool.Parse("frue"));
            //최댓값 최솟값은 상수로!
            Console.WriteLine(-1 * int.MaxValue);
            //Console.WriteLine(-1 * int.MinValue);
            Console.WriteLine(-1L * int.MinValue);
        }
    }
}
