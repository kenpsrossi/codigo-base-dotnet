namespace Basico.Servicos;

public class GenericoServico
{

    public void ImprimeNome(object objeto)
    {
        Console.WriteLine("O nome é" + objeto.ToString());
    }
}

