using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loan_calculator
{
    class Loan
    {
        public Loan()
        {
            this._loanAmount = 0;
            this._interestPercentage = 0;
            this._noofMonths = 0;
        }
        private int _loanAmount;
        public int LoanAmount
        {
            get
            {
                return _loanAmount;
            }
            set
            {
                _loanAmount=value;
            }
        }
        private double _interestPercentage;
        public double InterestPercentage
        {
            get
            {
                return _interestPercentage;
            }
            set
            {
                _interestPercentage=value;
            }
        }
        private int _noofMonths;
        public int NumberOfMonths
        {
            get
            {
                return _noofMonths;
            }
            set
            {
                _noofMonths=value;
            }
        }
        

        public int Emicalculate()
        {
            double Value=0;
            double interest = (_interestPercentage*0.01)/12;
            double cal =Math.Pow((1 + interest), _noofMonths);
            double v = cal / (cal - 1);
            Value = (_loanAmount * interest) * v;
            return (int)Value;
        }
    }
}
