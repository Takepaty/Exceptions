try //tente fazer algo
{
  string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

  foreach (string linha in linhas)
  {
    Console.WriteLine(linha);
  }
}
catch (FileNotFoundException ex) //catch => pegar obter
{
  Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado! {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
  Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado! {ex.Message}");
}
catch (Exception ex)
{
  Console.WriteLine($"Ocorreu uma exceção genérica! {ex.Message}");
}
finally
{
  Console.WriteLine("CHegou até awui!");
}



