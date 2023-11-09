using System; // para o print
using System.Collections.Generic; // para o array list

public enum TiposArquivo {
	Texto,
	Imagem,
	PDF
}

public class Arquivo {
	public String nome, extensao;
	public TiposArquivo tipo;
	public float tamanho;
	
	public void imprimeNome() {
	    Console.WriteLine(nome+"."+extensao);
	}
}

public class Diretorio {
	public String nome;
	public List<Arquivo> arquivos;
	public List<Diretorio> subdiretorios;
	
	//////////////// construtor
	public Diretorio() {}
	
	public Diretorio(String Nome) {
		nome = Nome;
		arquivos = new List<Arquivo>();
		subdiretorios = new List<Diretorio>();
	}
	//////////////
	
	public void imprimeNome() {
	    Console.WriteLine(nome+"/");
	}
	
	public void imprimeConteudo() {
	    Console.WriteLine("# Diretório: "+nome);
	    
	    if (subdiretorios.Count > 0) { // se tiver subdiretorios
	        Console.WriteLine("* Sub-diretórios:");
	        for (var i = 0; i < subdiretorios.Count; i++) {
	            subdiretorios[i].imprimeNome();
	        }
	    }
	    
	    if (arquivos.Count > 0) {
	       Console.WriteLine("* Arquivos:");
	        for (var i = 0; i < arquivos.Count; i++) {
	            arquivos[i].imprimeNome();
	        }
	    }
	}

	// Nessa versão recursiva serão impressas todas as subpastas e arquivos das subpastas também
	public void imprimeConteudo(char recursivo) {
		if (recursivo != 'r') {
			imprimeConteudo();
			return;
		}

	    imprimeConteudo();
		Console.WriteLine();
    
	    if (subdiretorios.Count > 0) {
	        for (int i = 0; i < subdiretorios.Count ; i++) {
	            subdiretorios[i].imprimeConteudo('r');
	        }
	    }
	}

}

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		
		Diretorio raiz = new Diretorio("Raiz");
		//raiz.arquivos = new List<Arquivo>();
		//raiz.subdiretorios = new List<Diretorio>();
		//raiz.nome = "Raiz";
		
		Diretorio imagens = new Diretorio();
		imagens.arquivos = new List<Arquivo>();
		imagens.subdiretorios = new List<Diretorio>();
		imagens.nome = "Raiz";
		
		raiz.subdiretorios.Add(imagens);
		
		Console.WriteLine("## Impressão das Pastas ##");
		raiz.imprimeConteudo();
		Console.WriteLine();

		Console.WriteLine("## Impressão das Pastas RECURSIVO ##");
		raiz.imprimeConteudo('r');
	}
}
}