using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Kata
{
    public static bool IsPangram( string str )
    {
        var charList = Enumerable.Range( 'a' , 'z' - 'a' + 1 ).Select( c => (char) c ).ToList();

        return ! charList.Except( str.ToLower() ).Any();
    }
}
