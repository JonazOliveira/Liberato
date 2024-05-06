programa
{
	
	funcao inicio()
	{
		caracter opcao
		real num1, num2

		escreva(">>>CALCULADORA SIMPLES<<< \n\n")

		escreva("Digite o primeiro número: \n")
		leia(num1)

		escreva("Digite o segundo número: \n")
		leia(num2)
		
		escreva("Qual operação deseja realizar? \n")
		leia(opcao)


		escolha (opcao) {
			
			caso '+':
			escreva(num1+num2)
			pare
			
			caso '-':
			escreva(num1-num2)
			pare
			
			caso '*':
			escreva(num1*num2)
			pare
			
			caso '/':
			escreva(num1/num2)
			pare
		}
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 502; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */