﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupperumServer
{
    public class GrumServer : IGrumServer
    {
        public string SayHello()
        {
            return "hej med dig!";
        }
    }
}