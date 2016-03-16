using System.Collections.Generic;

namespace Eternity
{
    public interface ITabFileSource
    {
        List<string> GetContent();
    }
}
