using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Common.Enums
{
    [TypeConverter(typeof(EnumConverter<AccountKind>))]
    public enum AccountKind
    {
        Guest,
        User
    }
}
