namespace Basico.Models;

public class Cliente
{
    ////Um construtor sem parametos , vazio///
    public Cliente (){ }
    
     /////////com parametos////////
    public Cliente (string _nome)
    {
          this.Nome = _nome;
    }
        /////com parametos////
    public Cliente (string _nome, string _telefone)
    {
         this.Nome = _nome;
         this.Telefone = _telefone;
    }
///////////////////////////////////////////////////8888888888

    public string Nome { get;set; } = default!;
    public string Telefone { get;set; } = default!;

    public string ClientePorCompleto()
    {
        return $"Nome: {this.Nome} - Telefone: {this.Telefone}";
    }

      //aqui mesmo com mensagem, AGREGEIT///

     public string ClientePorCompleto(string mensagem)
    {
        return $"{mensagem} - Nome: {this.Nome} - Telefone: {this.Telefone}";
    }


//////////////////1111111111111111111
     internal string ClientePorCompleto2()
    {
        return $"Nome: {this.Nome} - Telefone: {this.Telefone}";
    }
             ////assim tambem e interna//
      string ClientePorCompleto22()
    {
        return $"Nome: {this.Nome} - Telefone: {this.Telefone}";
    }
/////////////////11111111111111111111111

     protected string ClientePorCompleto3()
    {
        return $"Nome: {this.Nome} - Telefone: {this.Telefone}";
    }

/////////////////1111111111111111111111111

      private string ClientePorCompleto4()
    {
        return $"Nome: {this.Nome} - Telefone: {this.Telefone}";
    }

}
