programa
{
	
	funcao inicio()
	{
		logico loop = verdadeiro
		
		enquanto (loop) {
			
		inteiro num

		escreva("Digite um número: ")
		leia(num)

		se (num<0) {
			escreva("Atenção! número negativo digitado. \n")
		} senao se (num%2==0) {
			escreva("Número par")
			loop = falso
		} senao {
			escreva("Número ímpar")
			loop = falso
		}

		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 292; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */