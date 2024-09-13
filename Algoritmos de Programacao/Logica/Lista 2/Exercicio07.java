import java.util.Scanner;

public class Exercicio07 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int anoNasc;
        final int ANOATUAL = 2024;

        System.out.println("Verificação de maioridade");

        System.out.print("Digite o seu ano de nascimento: ");
        anoNasc = scanner.nextInt();

        System.out.println("Liberada a venda de bebida alcoólica?");
        if(ANOATUAL - anoNasc >= 18) {
            System.out.println("Sim!");
        } else {
            System.out.println("Não!");
        }
    }
}
