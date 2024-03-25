using System.Linq.Expressions;
using System.Windows.Forms.VisualStyles;

namespace exer_15
{
    public partial class Form1 : Form
    {
        List<Livro> _livros;
        public Form1()
        {
            InitializeComponent();
            this._livros = new List<Livro>();
            this._livros.Add(new Livro("Harry Potter e o Prisioneiro de Azkaban".Normalize().ToUpper(), "Pew Pew com varinha", "J. K. Rowling", "Rocco", "Aventura; Fantasia", 5));
            this._livros.Add(new Livro("O Senhor dos Anéis: A Sociedade do Anel".Normalize().ToUpper(), "pew pew com espada", "J.R.R. Tolkien", "HarperCollins", "Ação e Aventura", 10));
            this._livros.Add(new Livro("Star Wars: Luz dos Jedi".Normalize().ToUpper(), "pew pew com luz", "Charles Soule", "Universo geek", "Aventura e Ficção Científica", 3));
            this._livros.Add(new Livro("Clube da Luta".Normalize().ToUpper(), "pew pew na mão", "Chuck Palahniuk", "Leya", "Ação e Aventura", 6));
            this._livros.Add(new Livro("1984".Normalize().ToUpper(), "pew pew mental", "George Orwell", "Companhia das Letras", "Política Literatura e Ficção", 10));
            foreach (var item in _livros)
            {
                dUDSelectBook.Items.Add(item.Nome);
            }
        }
        private Livro? findIndex()
        {
            string bookName = dUDSelectBook.Text.Normalize().ToUpper();
            return this._livros.Find(l => l.Nome == bookName);
        }

        private void btnLendBook_Click(object sender, EventArgs e)
        {
            Livro? livro = findIndex();
            if (livro == null) { txtOutputShowBookInfo.Text = "Não Foi possivel pegar o livro: Ele não existe na biblioteca\r\n"; return; }
            if (livro.LendBook()) { txtOutputShowBookInfo.Text = $"Livro {livro.Nome} emprestado com sucesso.\r\n"; return; }
            txtOutputShowBookInfo.Text = $"Todos o livros da obra {livro.Nome} já foram emprestados.\r\n";
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            Livro? livro = findIndex();
            if (livro == null) { txtOutputShowBookInfo.Text = "Não Foi possivel devolver o livro: Ele não existe na biblioteca\r\n"; return; }
            if (livro.ReturnBook()) { txtOutputShowBookInfo.Text = $"Livro {livro.Nome} devolvido com sucesso.\r\n"; return; }
            txtOutputShowBookInfo.Text = $"O livro {livro.Nome} não pertence a biblioteca, acervo completo.\r\n";
        }

        private void btnFindBook_Click(object sender, EventArgs e)
        {
            Livro? livro = findIndex();
            if (livro == null) { txtOutputShowBookInfo.Text = "Não Foi possivel encontrar o livro: Ele não existe na biblioteca\r\n"; return; }
            string bookInfo = $"Nome: {livro.Nome}\r\n";
            bookInfo += $"Autor: {livro.Autor}\r\n";
            bookInfo += $"Descrição: {livro.Descricao}\r\n";
            bookInfo += $"Editora: {livro.Editora}\r\n";
            bookInfo += $"Genero: {livro.Genero}\r\n";
            bookInfo += $"Quantidade disponivel: {livro.BooksAvaiable}\r\n";
            txtOutputShowBookInfo.Text = bookInfo;
        }
    }
}
