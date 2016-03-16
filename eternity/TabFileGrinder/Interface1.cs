using System.Collections.Generic;

namespace Eternity
{
    internal interface ITabFileSource
    {
        List<string> GetLines();
    }
}