import java.util.Scanner;

public class Exercicio09 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int anoAtual = 2024;
        int idade;

        System.out.print("Qual o seu ano de nascimento? ");
        idade = scanner.nextInt();

        System.out.println("Você possui " + (anoAtual-idade) + " anos." );
        System.out.println("Você possui " + ((anoAtual-idade)*12) + " meses." );
        System.out.println("Você possui " + ((anoAtual-idade)*365) + " dias." );
        System.out.println("Você possui " + ((anoAtual-idade)*52) + " semanas." );
    }
}
