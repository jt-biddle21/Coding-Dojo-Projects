import java.util.Scanner;

public class FizzBuzzTest {
    public static int number;
    public static String fizzy;
    public static String f;
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Type in a number:");
        number = sc.nextInt();
        sc.close();
        FizzBuzz fizzy = new FizzBuzz();
        String f = fizzy.fizzBuzz(number);
        System.out.println(f);
    }
}