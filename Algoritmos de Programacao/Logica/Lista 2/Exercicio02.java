import java.util.Scanner;

public class Exercicio02 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double numberOne, numberTwo, sumTwoNumbers;

        System.out.println("Digite dois números para realizar uma soma");
        System.out.print("Primeiro número: ");
        numberOne = scanner.nextDouble();

        System.out.print("Segundo número: ");
        numberTwo = scanner.nextDouble();

        sumTwoNumbers = numberOne + numberTwo;
        System.out.println("A soma deles é " + sumTwoNumbers);
    }
}
