import java.util.Scanner;

public class Exercicio08 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double chequeEspecial = 500.00;
        double saldoBancario, precoProduto;

        System.out.println("Verificação de compra");

        System.out.print("Quanto possui de saldo no banco? ");
        saldoBancario =  scanner.nextDouble();

        System.out.print("Quanto custa o produto? ");
        precoProduto =  scanner.nextDouble();

        System.out.println("É possível fazer a compra?");
        if(saldoBancario+chequeEspecial >= precoProduto){
            System.out.println("Sim!");
        } else {
            System.out.println("Não!");
        }
    }
}
