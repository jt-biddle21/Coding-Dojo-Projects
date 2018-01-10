import java.util.Scanner;

public class Pythagorean {
    public static double legA;
    public static double legB;
    public static double hypo;
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        System.out.println("Type in the height length:");
        legA = sc.nextInt();
        System.out.println("Type in the base length:");
        legB = sc.nextInt();
        sc.close();
        hypo = calculateHypotenuse(legA, legB);
        System.out.println("The hypotenuse of the triangle is " + hypo);
    }
    public static double calculateHypotenuse(double legA, double legB)
    {
        double hypotenuse;
        double height = Math.pow(legA, 2);
        double base = Math.pow(legB, 2);
        hypotenuse = Math.sqrt(height + base);
        return hypotenuse;
    }
}
