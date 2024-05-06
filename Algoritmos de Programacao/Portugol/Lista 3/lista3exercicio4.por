programa
{
	
	funcao inicio()
	{
		inteiro  distanciaKM
		
		escreva("Digite a distância a ser percorrida em quilômetros(km): \n")
		leia(distanciaKM)

		se (distanciaKM<5) {
			escreva("As melhores opções de locomoção são: a pé ou de bicicleta.")
		} senao se (distanciaKM>=5 e distanciaKM<20) {
			escreva("As melhores opções de locomoção são: de Ônibus ou de carro.")
		} senao {
			escreva("As melhores opções de locomoção são: de Ônibus, de carro ou de avião.")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 231; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */