﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GrupperumServer.ModelLayer
{
    [DataContract]
    class Group
    {
        private int id;
        private String name;
        public Group(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
