using System; 

  public class Produto{
    private int id;
    private string descricao;
    private int qtd;
    private double preco;
    private int categoriaId;
    private Categoria categoria;

    public int Id { get => id; set => id = value; } 
    public string Descricao { get => descricao; set => descricao = value; }  
    public int Qtd { get => qtd; set => qtd = value; } 
    public double Preco { get => preco; set => preco = value; }
    public int CategoriaId { get => categoriaId; set => categoriaId = value; }
    public Produto() { }
  
    public Produto(int id, string descricao, int qtd, double preco, Categoria categoria){
      this.id = id;
      this.descricao = descricao;
      this.qtd = qtd > 0 ? qtd : 0;
      this.preco = preco > 0 ? preco : 0;
      this.categoria = categoria;
      this.categoriaId = categoria.GetId();
    }
  
    public void SetId(int id){
      this.id = id;
    }
    public void SetDescricao(string descricao){
      this.descricao = descricao;
    }
    public void SetQtd(int qtd){
      this.qtd = qtd > 0 ? qtd : 0;
    }
    public void SetPreco(double preco){
      this.preco = preco > 0 ? preco : 0;
    }
    public void SetCategoria(Categoria categoria){
      this.categoria = categoria;
      this.categoriaId = categoria.GetId();
    }
    public int GetId(){
      return id;
    }
    public string GetDescricao(){
      return descricao;
    }
    public int GetQtd(){
      return qtd;
    }
    public double GetPreco(){
      return preco;
    }
    public Categoria GetCategoria(){
      return categoria;
    }
  
    public override string ToString(){
      if (categoria == null)
        return id + " - " + descricao + " - preço: R$" + preco.ToString("0.00");
      else
        return id + " - " + descricao + " - preço: R$" + preco.ToString("0.00") + " | " + categoria.GetDescricao();
    }
}