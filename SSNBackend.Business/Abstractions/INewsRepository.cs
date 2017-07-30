using System.Collections.Generic;
using SSNBackend.DatabaseModel.Models;

namespace SSNBackend.Business.Abstractions
{
    public interface INewsRepository
    {
        IEnumerable<News> News { get; }
    }
}