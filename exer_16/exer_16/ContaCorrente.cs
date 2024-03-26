using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace exer_16
{
    public class ContaCorrente : IEqualityComparer<ContaCorrente>
    {
        int _agencia;
        string _numeroConta;
        string _nomeTitular;
        double _saldo;

        public double Saldo { get { return this._saldo; } }
        public string NumeroConta { get { return this._numeroConta; } }
        private ContaCorrente()
        {
            this._agencia = 0;
            this._saldo = 0;
            this._numeroConta = "";
            this._nomeTitular = "";
        }

        public ContaCorrente(int agencia,  string nomeTitular, string numeroConta, double saldo)
        {
            this._saldo = saldo;
            this._agencia = agencia;
            this._nomeTitular = nomeTitular;
            this._numeroConta = numeroConta;
        }

        public void Saque(double valor)
        {
            this._saldo -= Math.Abs(valor);
        }

        public void Deposito(double valor)
        {
            this._saldo += Math.Abs(valor);
        }

        public bool Equals(ContaCorrente? thisO, ContaCorrente? otherO)
        {
            if (thisO == null || otherO == null)
                return thisO == otherO;
            return thisO.NumeroConta == otherO.NumeroConta;
        }

        public static bool operator ==(ContaCorrente cc1, ContaCorrente cc2)
        {
            if (cc1 is null || cc2 is null) return false;
            if (cc1.Equals(cc2)) { return true; }
            return false;
        }

        public static bool operator !=(ContaCorrente cc1, ContaCorrente cc2)
        {
            return !(cc1 == cc2);
        }

        public int GetHashCode(ContaCorrente obj) { return obj.NumeroConta.GetHashCode(); }
    }

}
