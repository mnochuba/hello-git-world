﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGitWorld
{
    public class Add
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public Add(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public int AddNum()
        {
            return Num1 + Num2;
        }
    }
}
