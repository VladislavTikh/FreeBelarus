using System;
using System.Collections.Generic;
using System.Text;

namespace FreeBelarus.Shared.Models.Authorization
{
    public class LoginResult
    {
        public bool Successful { get; set; }
        public string Error { get; set; }
        public string Token { get; set; }
    }
}
