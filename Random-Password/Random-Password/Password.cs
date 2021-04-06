using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Password
{
    class Password
    {
        public char[] GenaratePassword;
        public List<char> passlist = new List<char>();
        private string _password;

        public string _Password
        {
            get
            {
                return _password;
            }
        }
        private int _length;
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }
        private int _count;
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }
        public Password()
        {
            this._password = "";
            this._length = 0;
            this.GenaratePassword = new char[_length];
            this._count = 0;
        }


       
        public void GetChar(int s,int l,int len)
        {
            Random number = new Random();
            for (int i = 0; i <len; i++)
            {
                int value = number.Next(s,l);
                GenaratePassword[_count]=(char.Parse(char.ConvertFromUtf32(value)));
                _count++;
            }

        }

        public string getPassword()
        {
            Suffle();
            StringBuilder sb = new StringBuilder();
            foreach(char c in GenaratePassword)
            {
                sb.Append(c);
            }
            return sb.ToString();
        }
        public void Suffle()
        {
            Random ra = new Random();
            for (int i = 0; i < 10; i++)
            {
                int number = ra.Next(_length);
                int num = ra.Next(_length);
                passSuffle(number, num);
            }
        }

        public void passSuffle(int First, int Last)
        {
            while (First <= Last)
            {
                char temp = GenaratePassword[First];
                GenaratePassword[First] = GenaratePassword[Last];
                GenaratePassword[Last] = temp;
                First++;
                Last--;
            }

        }
        public void passGenerate(bool? v1, bool? v2, bool? v3, bool? v4)
        {
            int l = 0;
            if (v1 == true) { l += 1; }
            if (v2 == true) { l += 1; }
            if (v3 == true) { l += 1; }
            if (v4 == true) { l += 1; }
            int sub = _length / l;
            if(_length==sub*l)
            {
                if(v1==true)
                {
                    GetChar(48, 57, sub);
                }
                if(v2==true)
                {
                    GetChar(97, 122,sub);
                }
                if(v3==true)
                {
                    GetChar(65, 90, sub);
                }
                if(v4==true)
                {
                    GetChar(33, 47, sub);
                }
            }
            else if(_length != sub * l)
            {
                if (v1 == true)
                {
                    GetChar(48, 57, sub);
                }
                if (v2 == true)
                {
                    GetChar(97, 122, sub);
                }
                if (v3 == true)
                {
                    GetChar(65, 90, sub);
                }
                if (v4 == true)
                {
                    GetChar(33, 47, sub);
                }
                int rem = Length % l;
                GetChar(33, 122, rem);

            }
        }
    }
}
