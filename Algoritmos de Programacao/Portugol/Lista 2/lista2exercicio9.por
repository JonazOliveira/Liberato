programa
{
	
	funcao inicio()
	{
		inteiro anoAtual, anoNascimento, idadeAno, idadeMeses, idadeDia, idadeSemana

		escreva("Em que ano estamos? \n")
		leia(anoAtual)

		escreva("Em que ano você nasceu? \n")
		leia(anoNascimento)

		idadeAno = anoAtual-anoNascimento
		idadeMeses = idadeAno*12
		idadeDia = idadeAno*365
		idadeSemana = idadeAno*52

		escreva("A sua idade em anos é de ", idadeAno, "\n")
		escreva("A sua idade em meses é de ", idadeMeses, "\n")
		escreva("A sua idade em dias é de ", idadeDia, "\n")
		escreva("A sua idade em semanas é de ", idadeSemana, "\n")
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 575; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */