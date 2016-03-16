using System;
using System.Collections.ObjectModel;

namespace Eternity
{
    public delegate T Suprise<out T>(TabFileLine line);

    public class TabFileGrinder
    {
        public TabFileGrinder()
        {
            tabFileSources = TabFileSourceResolver.Resolve(sourceDefineJsonFile);
        }

        public bool Initialize(string sourceDefineJsonFile)
        {
            foreach (var tabFile in tabFileSources)
            {
                TabFileEntity entity = TabFileParser.Parse(tabFile);
                entities.Add(entity);
            }
            return true;
        }

        public TabFileLine GetLine(string sourceKey, int line)
        {
            throw new NotImplementedException();
        }

        // TODO maybe id
        public T GetSuprise<T>(string sourceKey, int line, Suprise<T> suprise)
        {
            throw new NotImplementedException();
        }

        private Collection<ITabFileSource> tabFileSources;
        private Collection<TabFileEntity> entities;
    }
}