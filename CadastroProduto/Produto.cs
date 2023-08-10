public class Produto
{
    public string Id { get; set; }
    public double preco { get; set; }
    public double porcentagem { get; set; }
    public string descricao { get; set; }
    public double venda { get; set; }

    public Produto()
    {

    }

    public Produto(string id, string descricao, double preco, double porcentagem, double venda)
    {
        this.Id = id;
        this.descricao = descricao;
        this.preco = preco;
        this.porcentagem = porcentagem;
        
        
    }

}
    