using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class BMI
    {
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        private double _height;
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height=value;
            }
        }
        private int _weight;
        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight=value;
            }
        }
        private string _gender;
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                 _gender=value;
            }
        }
        private double _bmi;
        public double _BMI
        {
            get
            {
                return _bmi;
            }
            
        }
        public double casecheck(int v)
        {
            double value = 0;
            switch(v)
            {
                case 1:
                    value = BMICalulate(_height, _weight);
                    break;
                case 2:
                    value = BMIinFeet(_height, _weight);
                    break;
            }
            return value;
        }
        public double BMICalulate(double H,int W)
        {
            double value = 0;
            double  h = H *0.01;
            value= W / (h * h);
            return value;
        }
        
        public double BMIinFeet(double H,int W)
        {
            double value = 0;
            double h = H / 30.48;
            value = W / (h * h);
            return value;
        }
      
    }
}
