using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_15
{
    public class Livro
    {
        static int _genId = 0;
        readonly int _id;
        readonly string _name;
        readonly string _description;
        readonly string _author;
        readonly string _publish;
        readonly string _bookGenre;
        readonly int _amount;
        int _borrowed;

        public string Nome { get { return _name; } }
        public string Descricao { get { return _description; } }
        public string Autor { get { return this._author; } }
        public string Editora { get { return this._publish;  } }
        public string Genero { get { return this._bookGenre; } }
        public int BooksAvaiable { get { return this._amount - this._borrowed; } }
        public bool LendBook()
        {
            if (this._amount - this._borrowed >= 0)
            {
                this._borrowed++;
                return true;
            }
            return false;
        }

        public bool ReturnBook()
        {
            if (this._borrowed > 0)
            {
                this._borrowed--;
                return true;
            }
            return false;
        }

        private Livro() {
            this._id = 0;
            this._name = string.Empty;
            this._description = string.Empty;
            this._author = string.Empty;
            this._publish = string.Empty;
            this._bookGenre = string.Empty;
            this._borrowed = 0;
            this._amount = 0;
        }

        public Livro(string name, string desc,
            string ath, string pub,
            string bg, int amount)
        {
            _genId++;
            this._id = _genId;
            this._name = name;
            this._description = desc;
            this._author = ath;
            this._publish = pub;
            this._bookGenre = bg;
            this._borrowed = 0;
            this._amount = Math.Abs(amount);
        }
    }
}
