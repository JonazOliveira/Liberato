import java.util.Scanner;

public class Exercicio05 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double raio, area;

        System.out.println("Calcular a área de um círculo");

        System.out.print("Digite o valor do raio: ");
        raio = scanner.nextDouble();

        area = Math.PI * Math.pow(raio, 2);
        System.out.println("A área do círculo é de " + area);
    }
}
