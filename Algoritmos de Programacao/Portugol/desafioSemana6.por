programa
{
	
	funcao inicio()
	{
		real valorCompra

		escreva("Qual o valor da comrpra? \n")
		leia(valorCompra)

		se (valorCompra<0) {
			escreva("Valor inválido!")
		} senao se (valorCompra<100) {
			escreva("Faltam R$", 100-valorCompra, " para o cliente ganhar um brinde")
		} senao {
			escreva("O cliente ganhou um brinde!")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 319; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */