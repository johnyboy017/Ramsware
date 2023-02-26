using System;
using System.IO;

// Diogo Araujo RA: 082180013 
// Humberto Gonzaga RA: 082180036 
// João Vitor Rocha RA: 082180024 

class Program { 
    static void Main(string[] args) { 
        Console.WriteLine("Digite a chave de cifragem (um número inteiro): "); 
        int chave = Convert.ToInt32(Console.ReadLine()); 
        string arquivoEntrada = "C:\Users\odair.rocha\Desktop\Ramsware\Codigo.txt"; 
        string arquivoBackup = "C:\Users\odair.rocha\Desktop\Ramsware\CodigoBackup.txt"; 
        string arquivoSaida = "C:\Users\odair.rocha\Desktop\Ramsware\CodigoCriptografado.txt"; 
        
        File.Copy(arquivoEntrada, arquivoBackup, true); 
        string conteudo = File.ReadAllText(arquivoEntrada); 
        string conteudoCriptografado = CriptografarCifraDeCesar(conteudo, chave); 
        File.WriteAllText(arquivoSaida, conteudoCriptografado); 
        
        Console.WriteLine("Código criptografado salvo em " + arquivoSaida); 

// Leitura do Arquivo Criptografado 
string textoCifrado = File.ReadAllText(arquivoSaida); 
string textoDescifrado = ""; 

//Descriptografando o texto (Feito pelo ChatGPT) 
foreach (char c in textoCifrado) { 
    int letra = (int)c; 
    if (letra >= 65 && letra <= 90) { 
        letra = (letra - 65 - chave + 26) % 26 + 65; 
        } 
        else if (letra >= 97 && letra <= 122) { 
            letra = (letra - 97 - chave + 26) % 26 + 97;
             } 
            textoDescifrado += (char)letra;
         } 
         File.WriteAllText("C:\Users\odair.rocha\Desktop\Ramsware\CodigoDescriptografado.tx", textoDescifrado); 
         Console.WriteLine("Texto descriptografado com sucesso!"); 
         Console.ReadLine(); 
         } 

  // Função da Cifra de Julio Cesar feito pelo ChatGPT 
static string CriptografarCifraDeCesar(string texto, int chave) { 
    string resultado = ""; 
    foreach (char letra in texto) { 

    // Converte a letra em um número ASCII 
    int ascii = (int)letra; 
    
    // Aplica a cifra de César 
    ascii = (ascii + chave) % 256; 
    
    // Converte o número ASCII de volta para uma letra 
    char novaLetra = (char)ascii; resultado += novaLetra; } return resultado; 
    } 
}