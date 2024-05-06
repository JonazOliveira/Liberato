programa
{
	inclua biblioteca Calendario
	
	funcao inicio()
	{
		logico loopMaior = verdadeiro
		logico loopMenor
		caracter repetir
		inteiro opcao
		
		
		enquanto (loopMaior==verdadeiro) {
			
			limpa()
			escreva("---PROGRAMA DE TESTES--- \n\n")
			escreva("Escolha uma das opções abaixo \n\n")
			escreva("1 - Verificar maioridade \n")
			escreva("2 - Filtro de precos \n")
			escreva("3 - Média acima da nota mínima \n")
			escreva("4 - Verificar número par ou ímpar \n")
			escreva("99 - Sair \n")
			escreva("R: ")
			leia(opcao)
	
			escolha(opcao) {
				
				caso 1 :
				
					loopMenor = verdadeiro
					
					faca {
						
						limpa()
						
						se (maioridade()==verdadeiro) {
							escreva(verdadeiro, "\n\n")
						} senao {
							escreva(falso, "\n\n")
						}
		
						escreva("Gostaria de repetir o teste? \n")
						escreva("s/n \n")
						leia(repetir)
		
						se (repetir=='n') {
							loopMenor = falso
						}
					} enquanto (loopMenor==verdadeiro)
					
					pare
				
	
				caso 2 :

					loopMenor = verdadeiro
					
					faca {
						
						limpa()
						
						se (filtro_preco()==verdadeiro) {
							escreva(verdadeiro, "\n\n")
						} senao {
							escreva(falso, "\n\n")
						}
	
						escreva("Gostaria de repetir o teste? \n")
						escreva("s/n \n")
						leia(repetir)
		
						se (repetir=='n') {
							loopMenor = falso
						}
					} enquanto (loopMenor==verdadeiro)
					
					pare

	
				caso 3 :

					loopMenor = verdadeiro
					
					faca {
	
						limpa()
					
						se (aprovado_ou_nao()==verdadeiro) {
							escreva(verdadeiro, "\n\n")
						} senao {
							escreva(falso, "\n\n")
						}
	
						escreva("Gostaria de repetir o teste? \n")
						escreva("s/n \n")
						leia(repetir)
		
						se (repetir=='n') {
							loopMenor = falso
						}
					} enquanto (loopMenor==verdadeiro)
					
					pare

	
				caso 4 :

					loopMenor = verdadeiro
					
					faca {
	
						limpa()
					
						se (par_ou_impar()==verdadeiro) {
							escreva(verdadeiro, "\n\n")
						} senao {
							escreva(falso, "\n\n")
						}
	
						escreva("Gostaria de repetir o teste? \n")
						escreva("s/n \n")
						leia(repetir)
		
						se (repetir=='n') {
							loopMenor = falso
						}
					} enquanto (loopMenor==verdadeiro)
					
					pare


				caso 99 : 
					loopMaior = falso
			}
			
		}
	}


	
	funcao logico maioridade() {

		inteiro anoAtual, anoNascimento
		anoAtual = Calendario.ano_atual()

		escreva("Digite o ano de nascimento: \n")
		leia(anoNascimento)
		
		se (anoAtual-anoNascimento>=18) {
			retorne verdadeiro
		} senao {
			retorne falso
		}
	}
	

	funcao logico filtro_preco() {

		real preco, valorMin, valorMax // valor minimo de 10 e maximo de 50

		escreva("Digite o valor mínimo: \n")
		leia(valorMin)
		
		escreva("Digite o valor maxímo: \n")
		leia(valorMax)

		escreva("Agora digite o preço: \n")
		leia(preco)
		
		se (preco>=valorMin e preco<=valorMax) {
			retorne verdadeiro
		} senao {
			retorne falso
		}
	}


	funcao logico aprovado_ou_nao () {

		real nota1, nota2, nota3, media, notaMin // media de 6

		escreva("Digite a nota mínima: \n")
		leia(notaMin)

		escreva("Digite a primeira nota: \n")
		leia(nota1)

		escreva("Digite a segunda nota: \n")
		leia(nota2)

		escreva("Digite a terceira nota: \n")
		leia(nota3)
		
		media = (nota1+nota2+nota3)/3
		
		se (media>=notaMin) {
			retorne verdadeiro
		} senao {
			retorne falso
		}
	}


	funcao logico par_ou_impar () {

		inteiro num

		escreva("Digite o número: \n")
		leia(num)

		se (num%2==0) {
			retorne verdadeiro
		} senao {
			retorne falso
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 422; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */