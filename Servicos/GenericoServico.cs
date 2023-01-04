using Basico.interfaces;
using Basico.Models;

namespace Basico.Servicos;

public class GenericoServico
{

    public static void ImprimeNome (IObjeto iObjeto)
    {

        Console.WriteLine($"O nome é  {iObjeto.Nome}, da classe {iObjeto.ToString()}");
    }
}

