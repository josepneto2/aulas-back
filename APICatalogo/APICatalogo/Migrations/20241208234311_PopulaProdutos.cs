using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations {
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb) {
            mb.Sql("insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "Values('Coca-Cola', 'Refrigerante de cola 350ml', 5.50, 'cocacola.jpg', 10, getdate(), 1)");
            mb.Sql("insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "Values('Nosliw', 'Suco de laranja 300ml', 7.15, 'nosliw.jpg', 20, getdate(), 1)");
            mb.Sql("insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "Values('X-Bacon', 'Sanduiche de bacon', 15, 'xbacon.jpg', 30, getdate(), 2)");
            mb.Sql("insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "Values('Sorvete', 'Sorvete natural', 3.50, 'sorvete.jpg', 40, getdate(), 3)");
            mb.Sql("insert into Produtos(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "Values('Brigadeiro', 'Doce de chocolate', 2, 'brigadeiro.jpg', 50, getdate(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb) {
            mb.Sql("delete from Produtos");
        }
    }
}
