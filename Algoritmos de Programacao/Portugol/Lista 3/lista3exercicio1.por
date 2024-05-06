programa
{
	
	funcao inicio()
	{
		inteiro anoAtual, anoNascimento, idade

		escreva("Digite o ano atual: \n")
		leia(anoAtual)

		escreva("Digite o seu ano de nascimento: \n")
		leia(anoNascimento)

		idade = anoAtual-anoNascimento

		se (idade>=16) {
			escreva("Você pode votar esse ano!")
		} senao {
			escreva("Você não pode votar esse ano!")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 351; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */