programa
{
	
	funcao inicio()
	{
		real saldo, valorCompra, chequeEspecial
		chequeEspecial = 500
		
		escreva("Qual o seu saldo bancário em R$? \n")
		leia(saldo)
		
		escreva("Qual o valor da compra em R$? \n")
		leia(valorCompra)
		
		se (saldo+chequeEspecial>=valorCompra) {
			escreva(verdadeiro)
		} senao {
			escreva(falso)
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 306; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */