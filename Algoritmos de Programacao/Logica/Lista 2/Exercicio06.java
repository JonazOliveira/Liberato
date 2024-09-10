import java.util.Scanner;

public class Exercicio06 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double preco, desconto, valorFinal;

        System.out.println("Calculo do preço com desconto do produto");

        System.out.print("Digite o preço do produto: ");
        preco = scanner.nextDouble();

        System.out.print("Digite quanto desconto deseja: ");
        desconto = scanner.nextDouble();

        valorFinal = preco - (desconto/100*preco);

        System.out.println("O valor final é " + valorFinal);
    }
}
