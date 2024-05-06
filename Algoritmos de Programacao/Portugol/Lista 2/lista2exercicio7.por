programa {
	// perguntar para sora se a resposta devia ser true ou false
	funcao inicio() 
	{
	    inteiro anoAtual, anoNascimento, idade
	    anoAtual = 2024
	
	    escreva("Em que ano você nasceu? ")
	    leia(anoNascimento)
	    
	    idade = anoAtual-anoNascimento
	
	    escreva("Liberada a venda de bebida alcoólica? \n")
	    
	    se (idade>=18) {
	      escreva("Liberada a venda!") // verdadeira
	    }
	    senao {
	      escreva("Não liberada a venda!") // falsa
	    }
  	}
}


/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 232; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */