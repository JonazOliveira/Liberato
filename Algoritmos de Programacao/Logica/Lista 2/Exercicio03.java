import java.util.Scanner;

public class Exercicio03 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double numberOne, numberTwo, numberThree, median;

        System.out.println("Digite 3 números para realizar a média deles");

        System.out.print("Primeiro número: ");
        numberOne = scanner.nextDouble();

        System.out.print("Segundo número: ");
        numberTwo = scanner.nextDouble();

        System.out.print("Terceiro número: ");
        numberThree = scanner.nextDouble();

        median = (numberOne + numberTwo + numberThree) / 3;
        System.out.print("A média deles é " + median);
    }
}
