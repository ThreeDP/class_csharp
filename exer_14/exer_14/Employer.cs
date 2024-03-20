using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_14
{
    internal class Employer
    {
        int _id;
        string _name;
        double _grossSalary;
        static int _amountEmployers = 0;
        const double _security = 11.0;

        private Employer()
        {
            this._id = 0;
            this._name = string.Empty;
            this._grossSalary = 0;
        }

        public Employer (string name, double grossSalary)
        {
            _amountEmployers++;
            this._id = _amountEmployers;
            this._name = name;
            this._grossSalary = grossSalary;
        }

        public double Security { get { return _security; } }
        public double GrossSalary { get {  return _grossSalary; } }
        public int Id { get { return _id; } }
        public string Name { get { return _name; } }

        public double CalculateNetSalary()
        {
            return this._grossSalary - (this._grossSalary * _security);
        }
    }
}
