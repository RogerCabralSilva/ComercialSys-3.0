using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ComClassSys
{
    public class ItemPedido
    {
        // Propriedade
        public int Id { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public double ValorUnit { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }

        // Construtores
        public ItemPedido()
        {
            Pedido = new();
        }

        public ItemPedido(int id, Pedido pedido, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Id = id;
            Pedido = pedido;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;

        }

        public ItemPedido(Pedido pedido, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Pedido = pedido;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        
        // Métodos Manter Itens de pedido

        // Inserir Item
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("sppedido_id", Pedido.Id);
            cmd.Parameters.AddWithValue("spproduto_id", Produto.Id);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        // Consultar item de pedido (obter por id pedido e id produto)
        public static ItemPedido ObterItem(int idPedido, int idProduto=0)
        {
            ItemPedido itemPedido = new();

            return itemPedido;
        }

        public static List<ItemPedido> ObterListaPorPedido(int idPedido, int idProduto = 0)
        {
            List<ItemPedido> lista = new();

            return lista;
        }
        // alterar Item
        public bool Alterar(int id)
        {
            return true;
        }
        // Exclui item
        public void Remover(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_delete";
            cmd.Parameters.AddWithValue("spid", id);
            cmd.ExecuteNonQuery();
        }
    }
}


















