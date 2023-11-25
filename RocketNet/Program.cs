using System;

namespace ControleEstoqueRocketNet
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
    }

    public class EstoqueService
    {
        // Método para verificar e atualizar o estoque de um produto
        // Luiz: Responsável por implementar esse método
        public void AtualizarEstoque(Produto produto, int quantidadeVendida)
        {
            if (produto != null && quantidadeVendida > 0)
            {
                if (produto.QuantidadeEstoque >= quantidadeVendida)
                {
                    produto.QuantidadeEstoque -= quantidadeVendida;
                    Console.WriteLine($"Estoque do produto {produto.Nome} atualizado: {produto.QuantidadeEstoque} unidades restantes.");
                }
                else
                {
                    Console.WriteLine("Quantidade insuficiente em estoque.");
                }
            }
            else
            {
                Console.WriteLine("Produto inválido ou quantidade inválida.");
            }
        }

        // Método que simula uma adição de estoque
        // Pedro: Responsável por implementar o método de adição de estoque
        public void AdicionarEstoque(Produto produto, int quantidadeAdicionada)
        {
            if (produto != null && quantidadeAdicionada > 0)
            {
                produto.QuantidadeEstoque += quantidadeAdicionada;
                Console.WriteLine($"Estoque do produto {produto.Nome} atualizado: {produto.QuantidadeEstoque} unidades.");
            }
            else
            {
                Console.WriteLine("Produto inválido ou quantidade inválida para adição de estoque.");
            }
        }

        // Método que verifica o estoque de um produto
        // Cícero: Responsável por implementar a verificação do estoque
        public void VerificarEstoque(Produto produto)
        {
            if (produto != null)
            {
                Console.WriteLine($"Estoque do produto {produto.Nome}: {produto.QuantidadeEstoque} unidades.");
            }
            else
            {
                Console.WriteLine("Produto inválido.");
            }
        }

        // Método que remove um produto do estoque
        // Nicolas: Responsável por implementar a remoção de um produto do estoque
        public void RemoverProdutoDoEstoque(Produto produto)
        {
            if (produto != null && produto.QuantidadeEstoque > 0)
            {
                produto.QuantidadeEstoque--;
                Console.WriteLine($"Produto {produto.Nome} removido do estoque. Novo estoque: {produto.QuantidadeEstoque} unidades.");
            }
            else
            {
                Console.WriteLine("Produto inválido ou estoque vazio.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Simulação de uso do serviço de controle de estoque
            Produto produto1 = new Produto { Id = 1, Nome = "Caneta", Preco = 1.50m, QuantidadeEstoque = 50 };
            EstoqueService estoqueService = new EstoqueService();

            // Chamada dos métodos para simulação
            estoqueService.AtualizarEstoque(produto1, 10); // Atualiza o estoque
            estoqueService.AdicionarEstoque(produto1, 20); // Adiciona estoque
            estoqueService.VerificarEstoque(produto1); // Verifica o estoque
            estoqueService.RemoverProdutoDoEstoque(produto1); // Remove um produto do estoque
        }
    }
}
