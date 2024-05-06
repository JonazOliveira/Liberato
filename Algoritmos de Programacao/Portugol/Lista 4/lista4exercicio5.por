programa
{
	
	funcao inicio()
	{
		inteiro numDigit, numSoma=0, numMenor=0, media, numPar=0, indice=0
		caracter continue

		faca {
			escreva("Digite um número: ")
			leia(numDigit)
			indice++

			numSoma = numSoma + numDigit

			se(indice==1 ou numDigit<numMenor) {
				numMenor = numDigit
			}
			
			media = numSoma/indice

			se(numDigit%2==0) {
				numPar++
			}

			escreva("Deseja continuar? \nS/N \n")
			leia(continue)
		} enquanto(continue=='s' ou continue=='S')

		limpa()
		escreva("A soma dos números é de: ", numSoma, "\n")
		escreva("O menor número foi o: ", numMenor, "\n")
		escreva("A média da soma dos números é de: ", media, "\n")
		escreva("Foram digitados ", numPar, " pares")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 265; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */