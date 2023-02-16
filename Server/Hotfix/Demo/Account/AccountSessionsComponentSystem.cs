using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class AccountSessionsComponentDestroySystem : DestroySystem<AccountSessionsComponet>
    {
        public override void Destroy(AccountSessionsComponet self)
        {
            self.AccountSessionDictionary.Clear();
        }
    }
    [FriendClass(typeof(AccountSessionsComponet))]
    public static class AccountSessionsComponentSystem
    {
        public static long Get(this AccountSessionsComponet self,long accountId)
        {
            if(!self.AccountSessionDictionary.TryGetValue(accountId,out long instanceId))
            {

            }
            return instanceId;
        }

        public static void Add(this AccountSessionsComponet self,long accountId,long sessionInstanceId)
        {
            if (self.AccountSessionDictionary.ContainsKey(accountId))
            {
                self.AccountSessionDictionary[accountId] = sessionInstanceId;
                return;
            }
            self.AccountSessionDictionary.Add(accountId, sessionInstanceId);
        }

        public static void Remove(this AccountSessionsComponet self,long accountId)
        {
            if (self.AccountSessionDictionary.ContainsKey(accountId))
            {
                self.AccountSessionDictionary.Remove(accountId);
            }
        }
    }
}
