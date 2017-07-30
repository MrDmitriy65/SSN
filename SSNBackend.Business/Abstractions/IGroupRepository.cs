using System.Collections.Generic;
using SSNBackend.DatabaseModel.Models;

namespace SSNBackend.Business.Abstractions
{
    public interface IGroupRepository
    {
        IEnumerable<Group> Groups { get; }
    }
}