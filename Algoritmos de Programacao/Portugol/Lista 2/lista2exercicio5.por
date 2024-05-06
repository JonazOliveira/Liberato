programa
{
	inclua biblioteca Matematica
	
	funcao inicio()
	{
		real raio, area
		
		escreva("Qual o raio do círculo em metros? ")
		leia(raio)
		
		area = Matematica.PI*(Matematica.potencia(raio, 2))
		
		escreva("A área do circulo é de ", area, " metros quadrados")
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 273; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */