using System;
using System.Collections.Generic;

namespace Eternity
{
    public class TabFileLine
    {
        public TabFileLine(IDictionary<string, string> rawLine)
        {
            this.rawLine = new Dictionary<string, string>(rawLine);
        }

        public virtual int GetInt32(string header)
        {
            throw new NotImplementedException();
        }

        public virtual float GetFloat(string header)
        {
            throw new NotImplementedException();
        }

        public virtual string GetString(string header)
        {
            throw new NotImplementedException();
        }

        private Dictionary<string, string> rawLine;
    }
}