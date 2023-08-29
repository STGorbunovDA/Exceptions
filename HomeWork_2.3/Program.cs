﻿#region Java

public static void main(String[] args) throws FileNotFoundException
{
try {
        int a = 90;
        int b = 3;
        System.out.println(a / b);
        printSum(23, 234);
        int[] abc = { 1, 2 };
        abc[3] = 9;
    }
catch (NullPointerException ex) {
        System.out.println("Указатель не может указывать на null!");
    }
catch (ArithmeticException ex) {
        System.out.println("Ошибка при делении на ноль!");
    }
catch (ArrayIndexOutOfBoundsException ex) {
        System.out.println("Индекс массива выходит за пределы его размера!");
    }
catch (Exception ex) {
        System.out.println("Что-то пошло не так...");
    }
}

public static void printSum(Integer a, Integer b) throws FileNotFoundException
{
    System.out.println(a + b);
}

#endregion