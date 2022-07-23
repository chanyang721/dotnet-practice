using System;

namespace PracticeTypes {
    class Types {
        // 한정자, 리턴 타입, 메서드 이름, 입력값 형식, 입력값 변수명
        static void MainNumberTypes (number[] args) {
            sbyte a = -127; // signed byte 1byte(8bit) -128 ~ 127
            byte b = 255; // unsigned byte 1byte(8bit) 0 ~ 255
            byte overflow = byte.MaxValue + 1; // 0
            byte underflow = byte.MinValue - 1; // 255
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"overflow = {overflow}, underflow = {underflow}");
            //! 오버플로우 (overflow)
            // 데이터 형식의 최대값을 넘어간 데이터를 저장하는 경우 발생하는 현상
            // 오버된 데이터만 저장된다
            // ex) byte b = 255 + 1 => b = 0 이 저장됨
            //! 언더플로우 (underflow)
            // 오버플로우와 같이 데이터 형식의 최소값보다 작은 데이터를 저장하는 경우 발생하는 현상
            // 언더된 데이터만 저장된다.
            // ex) byte b = -1 => b = 255 이 저장됨

            short c = -32768; // signed 정수 2byte(16bit) -32,768 ~ 32,768
            ushort d = 65535; // unsigned 정수 2byte(16bit) 0 ~ 65,535
            Console.WriteLine($"c = {c}, d = {d}");

            int e = 2147483647; // signed 정수 4byte(32bit) -2,147,483,647 ~ 2,147,483,647
            uint f = 4294967285; // unsigned 정수 4byte(32bit) 0 ~ 4,294,967,285
            Console.WriteLine($"e = {e}, f = {f}");

            long g = -922337203685477507; // signed 정수 8 byte(64bit) -922,337,203,685,477,507 ~ 922,337,203,685,477,507
            ulong h = 18_446_744_073_709_551_615; // unsigned 정수 8 byte(64bit) 0 ~ 18,446,744,073,709,551,615
            Console.WriteLine($"g = {g}, h = {h}");

        }

        //* 진수 리터럴 표현
        static void MainBinaryTypes (string[] args) {
            byte a = 255; // 10진수 리터럴

            byte b = 0b100101; // 0b + 2진수숫자: 2진수 리터럴

            byte c = 0XF0; // 0X + 16진수 숫자: 16진수 리터럴
            uint d = 0x1234_f0; // 0x + 16진수 숫자: 16진수 리터럴 
        }

        //* 부동소수점 표현
        //? 부동 소수점이란?
            // 소수점이 고정되지 않고 움직이면서 수를 표현
                // 제한된 비트를 사용해 넓은 범위의 값을 표현
            // 소수점 표현, 부호 표현에 비트를 사용하기 때문에 정수 계열 형식과 같은 크기 사용을 못한다.
            // 연산 과정이 정수 계열 형식보다 복잡하여 계산이 느리다
        static void FloatingPoint (float a, double b) {
            //! float 형식은 수 뒤에 f를 붙여준다
            float a = -3.402823e38f; // 4byte(32bit) -3.402823e38 ~ 3.402823e38;
            // float: 1bit(sign bit)[부호] + 8bit(Exponent)[지수부] + 23bit(Mantissa)[기수부]

            double b = 2.2250738585072014e-308; // 8byte(64bit)


            // ---------- 형변환 주의 사항 ---------- //
            //! 소수를 이진수로 변환하여 메모리에 보관하기 때문에, 형변환 시 정밀한 수를 얻기 어렵다(ex: 1/3)
            float c = 64.4242f;
            double d = (double)c; // 64.4242 == d => true
            Console.WriteLine($"64.4242 == d : { 64.4242 == d }");

            float e = 0.1f;
            double f = (double)e; // 0.1 == f -> false, f = 0.10000001490116
            Console.WriteLine($"0.1 == f : {0.1 == f}");

            //! 부동 소수점 -> 정수 형변환
            //! 소수점 이하 제거한 수가 저장된다
            float g = 0.9f;
            int h = (int)g; // h = 0


            float i = 1.1f;
            int j = (int)i; // j = 1
        }

        // 실수(Decimal) 표현
        // 29 자리 데이터를 표현할 수 있는 소수 형식
        static void DecimalType() {
            decimal a = 1; // 16byte (128bit) 
        }

        static void StringType(char a, string b) {
            char a = '가'; // 2byte (16bit) 단일 문자 형식으로 작은 따옴표('') 로 묶는다.
            Console.WriteLine($"a = {a}");

            string b = "문자열"; // 문자열 형식으로 큰 따옴표("")로 묶는다.
            Console.WriteLine($"b = {b}");


            //! 문자열 -> 숫자 형변환 float.Parse(x), Convert.ToInt32(x)
            string c = "123456"; // 정수 모양의 문자열
            int d = Convert.ToInt32(c); // d = 123456

            string c = "1.2341";
            float d = float.Parse(c); // d = 1.2341


            //! 숫자 -> 문자열 형변환 ToString()
            int e = 1234;
            string f = e.ToString(); // f = "1234"

            float g = 3.14f;
            string h = g.ToString(); // h = "3.14"
        }

        //* boolean 형식
        static void BooleanType(bool args) {
            bool a = true;

            bool b = false;
        }
    }

    class ReferenceTypes {
        static void ObjectType() {
            //! 모든 데이터 형식을 담을 수 있는 형식
            //! 힙에 데이터를 저장하고, 해당 힙의 주소를 스택의 변수에 저장하여 접근

            object a = 1; //? 어떤 데이터 형식으로 저장 ??
            object b = true;
            object c = "문자열 데이터 저장";
        }

        //* Object 내부의 데이터를 힙에 저장하는 것을 박싱(boxing)이라고 한다.
        static void Boxing() {
            object a = 20;
        }

        //* Object에 저장된 데이터를 일반 데이터 변수에 재할당하는 경우를 언박싱(unboxing)이라고 한다.
        static void Unboxing() {
            object a = 20;
            int b = (int)a; // 형변환()을 명시적으로 해주는 것이 좋다
        }
    }

    class Constants {

        //! 값을 변경하면 안되는 변수를 선언하는 방법
        static void Constants() {
            // const 자료형 상수명 = 값;
            const int a = 3;

            a = 1000; // 재할당 시 오류 발생
        }
        //! 종류는 같지만 다른 값을 갖는 상수 모음
        // 기반자료형: byte, sbyte, short, ushort, int, uint, long, ulong, char만 사용
        // 기반자료형이 없다면 default = int
        enum DialogResult { YES, NO, CANCEL, OK };      
        enum DialogDefault { YES = 10, NO, CANCEL = 50, OK };      
        static void EnumType() {
            Console.WriteLine((int)DialogResult.YES); // 0
            Console.WriteLine((int)DialogResult.NO); // 1
            Console.WriteLine((int)DialogResult.CANCEL); // 2
            Console.WriteLine((int)DialogResult.OK); // 3

            // enum 타입을 자료형 형식으로 사용하는 것이 가능하다.
            DialogResult a = DialogResult.NO;

            // enum 타입에서 초기값 설정 시 이후의 넘버링이 달라지게 된다
            Console.WriteLine((int)DialogDefault.YES); // 10
            Console.WriteLine((int)DialogDefault.NO); // 11
            Console.WriteLine((int)DialogDefault.CANCEL); // 50
            Console.WriteLine((int)DialogDefault.OK); // 51
        }
    }

}