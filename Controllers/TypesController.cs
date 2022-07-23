using System;

//
namespace PracticeTypes {
    class Types {
        // 한정자, 리턴 타입, 메서드 이름, 입력값 형식, 입력값 변수명
        static void MainNumberTypes (string[] args) {
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
            ulong h = 18446744073709551615; // unsigned 정수 8 byte(64bit) 0 ~ 18,446,744,073,709,551,615
            Console.WriteLine($"g = {g}, h = {h}");

            char a = "유니코드 문자"; // 2byte (16bit)
            Console.WriteLine($"a = {a}");
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
        static void FloatingPoint (string[] args) {
            float a = -3.402823e38; // 4byte(32bit) -3.402823e38 ~ 3.402823e38;
            // float: 1bit(sign bit)[부호] + 8bit(Exponent)[지수부] + 23bit(Mantissa)[기수부]

            double b = 2.2250738585072014e-308; // 8byte(64bit) 
        }

        // 실수(Decimal) 표현
        // 29 자리 데이터를 표현할 수 있는 소수 형식
        static void DecimalType () {
            decimal a = 1; // 16byte (128bit)
        }

    }

}