﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ServerInfosComponentDestroySystem:DestroySystem<ServerInfosComponent>
    {
        public override void Destroy(ServerInfosComponent self)
        {
            foreach(var serverInfo in self.ServerInfoList)
            {
                serverInfo?.Dispose();
            }
            self.ServerInfoList.Clear();
        }
    }

    [FriendClass(typeof(ServerInfosComponent))]
    public static class ServerInfosComponentSystem
    {
        public static void Add(this ServerInfosComponent self,ServerInfo serverInfo)
        {
            self.ServerInfoList.Add(serverInfo);
        }
    }
}
