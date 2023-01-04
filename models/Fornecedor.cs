using Basico.interfaces;

namespace Basico.Models;

public class Fornecedor : IObjeto
{

    public string Nome { get;set; } = default!;
    public string Telefone { get;set; } = default!;

}
