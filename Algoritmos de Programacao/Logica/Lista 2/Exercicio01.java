import java.util.Scanner;

public class Exercicio01 {
    public static void main(String[] args) {
        String nome, sobrenome;
        Scanner scanner = new Scanner(System.in);

        System.out.print("Por favor digite seu nome: ");
        nome = scanner.nextLine();

        System.out.print("Por favor digite seu sobrenome: ");
        sobrenome = scanner.nextLine();

        System.out.println("Seja muito bem vindo " + nome + " " + sobrenome + ", é uma honra te-lo(a) aqui!");
    }
}
