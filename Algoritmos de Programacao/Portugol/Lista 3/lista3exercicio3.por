programa
{
	
	funcao inicio()
	{
		real salario, emprestimo, valorPrestacao
		inteiro numeroPrestacoes

		escreva("Digite o salário do funcionário: \n")
		leia(salario)

		escreva("Digite o valor do emprestimo desejado: \n")
		leia(emprestimo)

		escreva("Digite quantas prestações deseja: \n")
		leia(numeroPrestacoes)

		valorPrestacao = emprestimo/numeroPrestacoes

		se (valorPrestacao<=(salario*0.1)*3) {
			escreva("Empréstimo concedido!")
		} senao {
			escreva("Empréstimo não concedido!")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 497; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */