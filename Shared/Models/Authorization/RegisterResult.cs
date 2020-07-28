using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace FreeBelarus.Shared.Models.Authorization
{
    public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
