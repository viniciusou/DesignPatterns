using System.Collections.Generic;

namespace DependencyInversion.Interfaces
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}
