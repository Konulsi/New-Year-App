﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICalculateService
    {
        string Calculate(double num1 , double num2, string op);

    }
}
