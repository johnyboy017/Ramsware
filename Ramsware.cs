using System;
using System.IO;

// Diogo Araujo RA: 082180013
// Humberto Gonzaga RA: 082180036
// João Vitor Rocha RA: 082180024

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a chave de cifragem (um número inteiro): ");
            int chave = Convert.ToInt32(Console.ReadLine());

        string arquivoEntrada = "codigo.txt";
        string arquivoBackup = "backup_codigo.txt";
        string arquivoSaida = "codigo_criptografado.txt";

        File.Copy(arquivoEntrada, arquivoBackup, true);
        string conteudo = File.ReadAllText(arquivoEntrada);
        string conteudoCriptografado = CriptografarCifraDeCesar(conteudo, chave);
        File.WriteAllText(arquivoSaida, conteudoCriptografado);

        Console.WriteLine("Código criptografado salvo em " + arquivoSaida);
    }

    // Função da Cifra de Julio Cesar feito pelo ChatGPT
    static string CriptografarCifraDeCesar(string texto, int chave)
    {
        string resultado = "";

        foreach (char letra in texto)
        {
            // Converte a letra em um número ASCII
            int ascii = (int)letra;

            // Aplica a cifra de César
            ascii = (ascii + chave) % 256;

            // Converte o número ASCII de volta para uma letra
            char novaLetra = (char)ascii;

            resultado += novaLetra;
        }

        return resultado;
    }
}
