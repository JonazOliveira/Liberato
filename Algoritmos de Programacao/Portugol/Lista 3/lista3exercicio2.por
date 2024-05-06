programa
{
	
	funcao inicio()
	{
		inteiro nota1, nota2, nota3, media

		escreva("Digite a primeira nota: \n")
		leia(nota1)

		escreva("Digite a segunda nota: \n")
		leia(nota2)

		escreva("Digite a terceira nota: \n")
		leia(nota3)

		media = (nota1+nota2+nota3)/3

		se (media<3) {
			escreva('E')
		} senao se (media>=3 e media<=5) {
			escreva('D')
		} senao se (media>=6 e media<=7) {
			escreva('C')
		} senao se (media>=8 e media<=9) {
			escreva('B')
		} senao {
			escreva('A')
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 491; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */