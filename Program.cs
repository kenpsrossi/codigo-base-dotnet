//interfCUsuario
//using Basico.InterfaceComUsuario;
//using Basico.Condicionais;
//using Basico.Recursividade;

using System.Text.Json;
using Basico.Models;
using Basico.Servicos;

namespace basico;

    class Program
    {
        public const string CAMINHO_ARQUIVO = @"/c/Users/kenps/OneDrive/Área de Trabalho/codigo-do-futuro-back/dotnet/basico/imports";
        static void Main(string[] args)
        {

           //AULA 15 A PARTI DAQUI//

           
             var cliente = new Cliente
             {
                Nome = "Jucileia"

             };
             
             GenericoServico.ImprimeNome(cliente);

             var fornecedor = new Fornecedor
             {
                Nome = "Didox business"

             };
             
             GenericoServico.ImprimeNome(fornecedor);

            //funcoes
              //interfCUsuario
              //LeiaMostre.lerOuEscreverNaTela();
              //antes lerOuEscreverNaTela();
              //UsandoCondicional.usandoSwitchParaOpcoesDeMenu();
         //   utilizandoLoop();
         //   utilizandoArrayOuLista();
         //   Recursiva.MostraNumeros();
         //   Recursiva.CapturaNome();
             
              
           /*   var lista = Recursiva.CalculaValores(new List<double>());

              foreach(var item in lista)
              {
                Console.WriteLine(item);
              }
              */

              /*//////AULA DO DIA 12 AQUI DESCOMENTADO//
              string conteudoDoArquivo = """
              {"nome": "Kenps", "telefone": "11989898989"}
              """;

              var cliente = JsonSerializer.Deserialize<Cliente>(conteudoDoArquivo, new JsonSerializerOptions
              {
                PropertyNameCaseInsensitive = true
              });
              
              var nivalda = new Cliente();

              nivalda.Nome = "Nivalda";
              nivalda.Telefone = "(11)11111111";

              Console.WriteLine(nivalda.ClientePorCompleto("Com mensagem para cliente Nivalda"));

              var leticia = new Cliente();
              
              leticia.Nome = "Leticia";
              leticia.Telefone = "(11)22222222";

              Console.WriteLine(leticia.ClientePorCompleto());
            /*///ATE AQUIDIA 12 /////
        //////////////////////////////////////////////
            //criado funcao lerOuEscreverNaTela================
           // Console.WriteLine($"Digite o nome");
            //var nome = Console.ReadLine();

           //if(nome== "Kenps")
           //{
            //Console.WriteLine($"Você digitou o nome : {nome}");
           //}
           //else
           //{
            //Console.WriteLine($"Nome não encontrado");
           //}

        ///////////////////////////////////////////////    
             // criado funcao usandoSwitchOpcoesDeMenu===============
            //Console.WriteLine($"Digite as opcoes\n 1\n 2");
            /*var opcao = Convert.ToInt16(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                      Console.WriteLine("Voce digitou a opcao 1");
                      break;
                case 2:
                      Console.WriteLine("voce digitou a opcao 2");
                      break;
                default:
                      Console.WriteLine("Nenhuma das opcoes");
                      break;
            }
        }
        */

        /////////////////////////////////////////////////////
        //criado funcao utilizandoLoop =====================
        ////////////
        /*int i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        }
        while(i < 100);
        }*/

        ////////////
        /*int x = 0;
        while(x<100)
        {
            Console.WriteLine(x);
            x++;
        }*/

        ///////////////////////////
       /* for (var y=0; y<100; y++)
        {
            Console.WriteLine(y);
        }
        */

        /////////////////////////////////////

       // string[] nomes = new string[4];
        //nomes[0] = "Dani";
        //nomes[1] = "Kenps";
        //nomes[2] = "Carina";
        //nomes[3] = "Bia";

        //foreach (var nome in nomes)
        //{
         //   Console.WriteLine(nome);
        //}

        ///////////////////////////////////////////
    /*
        string[] nomes = new string[] 
        {
            "Dani",
            "Kenps",
            "Carina",
            "Bia",
        };

        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }
   */
   ////////////////////////////////

   /*List<string> nomes = new List<string>(){"Dani","Kenps","Carina","Bia"};
   nomes.Add("Daniela");
   nomes.Add("Fabiana");

   foreach (var nome in nomes)
   {
      Console.WriteLine(nome);
   }
    */
    ///////////////////////////////////////////////////////////

        }


//888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888



    ///////////////funcoes///////////////////
    //===============================================================
    /*private static void utilizandoArrayOuLista()
    {
        //string[] nomes = new string[] 
        //{
            //"Dani",
            //"Kenps",
            //"Carina",
            //"Bia",
        //};

        //foreach (var nome in nomes)
        //{
            //Console.WriteLine(nome);
        //}
    //}

        /////////////////////////////////
        
        List<string> nomes1 = new List<string>(){"Dani","Kenps","Carina","Bia"};
          nomes1.Add("Daniela");
          nomes1.Add("Fabiana");

          foreach (var nome in nomes1)
        {
           Console.WriteLine(nome);
         }

    }
/*
//====================================================================
   
    /*private static void utilizandoLoop()
    {
        //////////
        //int i = 0;
        //do
        //{
            //Console.WriteLine(i);
            //i++;
        //}
        //while(i < 100);
    //}        

        ////////////
        //int x = 0;
        //while(x<100)
        //{
            //Console.WriteLine(x);
            //x++;
        //}
    //}

        ///////////////////////////
       //for (var y=0; y<100; y++)
        //{
            //Console.WriteLine(y);
        //}
    //}
*/
    //===============================================================
 //11111111111111111111111111111111111111111111111111111
 /*   private static void usandoSwitchParaOpcoesDeMenu()
    {
        Console.WriteLine($"Digite as opcoes\n 1\n 2");
        var opcao = Convert.ToInt16(Console.ReadLine());
        switch (opcao)
            {
                case 1:
                      Console.WriteLine("Voce digitou a opcao 1");
                      break;
                case 2:
                      Console.WriteLine("voce digitou a opcao 2");
                      break;
                default:
                      Console.WriteLine("Nenhuma das opcoes");
                      break;
            }
        }
 */   
//===================================================================
//111111111111111111111111111111111111111111111 
  /*  private static void lerOuEscreverNaTela()
    {
         Console.WriteLine($"Digite o nome");
            var nome = Console.ReadLine();

           if(nome== "Kenps")
           {
            Console.WriteLine($"Você digitou o nome : {nome}");
           }
           else
           {
            Console.WriteLine($"Nome não encontrado");
           }
    }
    */
}



