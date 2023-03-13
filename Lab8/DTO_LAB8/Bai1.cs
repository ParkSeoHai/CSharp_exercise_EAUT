using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_LAB8
{
    public class Bai1
    {
        private int _So1;
        private int _So2;
        private int _Result;
        public int So1 { get => _So1; set => _So1 = value; }
        public int So2 { get => _So2; set => _So2 = value; }
        public int Result { get => _Result; set => _Result = value; }

        public Bai1(string So1, string So2)
        {
            this._So1 = Convert.ToInt32(So1);
            this._So2 = Convert.ToInt32(So2);
        }
        public Bai1(int So1, int So2)
        {
            this._So1 = So1;
            this._So2 = So2;
        }
    }
}
