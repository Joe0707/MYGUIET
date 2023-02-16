using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public enum AccountType
    {
        General = 0,
        BlackList = 1
    }
    public class Account:Entity,IAwake
    {
        public string AccountName { get; set; } //账户名
        public string Password { get; set; } //账户密码
        public long CreateTime { get; set; }//账号创建时间
        public int AccountType { get; set; }//账号类型
    }
}
