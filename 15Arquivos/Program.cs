using System;
using System.IO;

namespace _15Arquivos // Note: actual namespace depends on the project name.
{
class Program
{
    static void Main()
    {
        // Caminho e nome do arquivo a ser criado, a ser escrito, a ser lido, a ser copiado, a ser deletado.
        string arquivo = @"C:\caminho\para\o\arquivo.txt";

        // Caminho e nome do arquivo de origem e destino
        string arquivoOrigem = @"C:\caminho\para\arquivo_origem.txt";
        string arquivoDestino = @"C:\caminho\para\arquivo_destino.txt";

        // Verifica se o arquivo já existe
        if (!File.Exists(arquivo))
        {
            // Cria o arquivo vazio
            File.Create(arquivo).Close();
            Console.WriteLine("Arquivo criado com sucesso!");
        }
        else
        {
            Console.WriteLine("O arquivo já existe!");
        }

        // Escreve no arquivo
        File.WriteAllText(arquivo, "Hello, World!");
        Console.WriteLine("Texto escrito no arquivo com sucesso!");

        // Lê o conteúdo do arquivo
        string conteudo = File.ReadAllText(arquivo);
        Console.WriteLine("Conteúdo do arquivo: ");
        Console.WriteLine(conteudo);

        // Copia o arquivo de origem para o destino
        File.Copy(arquivoOrigem, arquivoDestino);
        Console.WriteLine("Arquivo copiado com sucesso!");

        // Deleta o arquivo
        File.Delete(arquivo);
        Console.WriteLine("Arquivo deletado com sucesso!");





       // Caminho do diretório a ser criado, a ser listado, a ser deletado, a ser pesquisado
        string diretorio = @"C:\caminho\para\o\diretorio";

        // Verifica se o diretório já existe
        if (!Directory.Exists(diretorio))
        {
            // Cria o diretório
            Directory.CreateDirectory(diretorio);
            Console.WriteLine("Diretório criado com sucesso!");
        }
        else
        {
            Console.WriteLine("O diretório já existe!");
        }

        // Lista os arquivos no diretório
        string[] arquivos = Directory.GetFiles(diretorio);
        Console.WriteLine("Arquivos no diretório: ");
        foreach (string arquivo in arquivos)
        {
            Console.WriteLine(arquivo);
        }

        // Lista os diretórios no diretório
        string[] diretorios = Directory.GetDirectories(diretorio);

        Console.WriteLine("Diretórios no diretório: ");
        foreach (string dir in diretorios)
        {
            Console.WriteLine(dir);
        }

        // Deleta o diretório e todos os arquivos e diretórios contidos nele
        Directory.Delete(diretorio, true);
        Console.WriteLine("Diretório deletado com sucesso!");

        // Lista apenas os arquivos no diretório, sem incluir subdiretórios
        string[] arquivos = Directory.GetFiles(diretorio, "*.txt", SearchOption.TopDirectoryOnly);
        Console.WriteLine("Arquivos no diretório: ");
        foreach (string arquivo in arquivos)
        {
            Console.WriteLine(arquivo);
        }

         // Lista todos os arquivos no diretório e em seus subdiretórios
        string[] arquivos = Directory.GetFiles(diretorio, "*.txt", SearchOption.AllDirectories);
        Console.WriteLine("Arquivos no diretório e em seus subdiretórios: ");
        foreach (string arquivo in arquivos)
        {
            Console.WriteLine(arquivo);
        }

        
    }
}
}