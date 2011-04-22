using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AdventureWorksManagement.ServiceAgents
{
    /// <summary>
    /// Interface for all service agent repository
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IAdventureWorksRepository<TEntity>
    {
        void GetEmployees(Action<IEnumerable<TEntity>> func);
    }

}
