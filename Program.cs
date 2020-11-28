using System;

namespace Sistema_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            float[] preco = new float[10];
            string[] promo = new string[10];

            //menu
            int opcao;
            int cont = 0;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Cadastrar um Produto");
                Console.WriteLine("[2] - Listar os Produto");
                Console.WriteLine("[0] - Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                
                switch (opcao)
                {
                    case 1: 
                    //Cadastrar um Produto
                    string resposta;

                    do
                    {
                        if (cont < 10)
                        {
                            Console.WriteLine($"Digite o nome do {cont+1}º produto");
                            nome[cont] = Console.ReadLine();
                            Console.WriteLine($"Digite o preço do {cont+1}° produto");
                            preco[cont] = float.Parse(Console.ReadLine());
                            Console.WriteLine($"O {cont+1}º produto está em promoção? s/n");
                            promo[cont] = Console.ReadLine();
                            cont++;
                        }else{
                            Console.WriteLine("Limite de produtos atingido");
                            break;
                        }
                        Console.WriteLine("Gostaria de cadastrar mais um produto? s/n");
                        resposta = Console.ReadLine();
                    } while (resposta == "s");
                    break;
                    
                    case 2:
                    //Listar os produtos
                        
                        for (var i = 0; i <= cont; i++)
                        {
                            Console.WriteLine($"Produto: {nome[i]}  Preço: {preco[i]}  Promoção: {promo[i]}");
                        }
                        break;

                    case 0:
                    //sair
                    Console.WriteLine("Agradecemos pela sua preferencia!");
                    break;

                    default:
                        Console.WriteLine("Opção inválida");
                break;}
            
            } while (opcao != 0);
            
        }//fim do main
    }
}
