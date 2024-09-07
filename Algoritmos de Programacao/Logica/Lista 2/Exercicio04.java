import java.util.Scanner;

public class Exercicio04 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double base, altura, area;

        System.out.println("Calcular a área de um retângulo");

        System.out.print("Digite o valor da base: ");
        base = scanner.nextDouble();

        System.out.print("Digite o valor da altura: ");
        altura = scanner.nextDouble();

        area = base * altura;
        System.out.println("A área do retangulo é de " + area);
    }
}
