using System.Collections.Generic;
using SSNBackend.DatabaseModel.Models;

namespace SSNBackend.Business.Abstractions
{
    public interface ILectureRepository
    {
        IEnumerable<Lecture> Lectures { get; }
    }
}