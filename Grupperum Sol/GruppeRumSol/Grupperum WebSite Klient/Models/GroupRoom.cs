﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grupperum_Website_Klient.Models.Home
{
    public class GroupRoom
    {
        public int GroupRoomId { get; set; }
        public string GroupRoomName { get; set; }
        public bool Selected { get; set; }
    
        public GroupRoom()
        {

        }

        public GroupRoom(int id)
        {
            GroupRoomId = id;
        }
    }
}
