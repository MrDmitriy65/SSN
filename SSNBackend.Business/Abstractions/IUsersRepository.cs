using System.Collections.Generic;
using SSNBackend.DatabaseModel.Models;

namespace SSNBackend.Business.Abstractions
{
    public interface IUsersRepository
    {
        IEnumerable<Teacher> Teachers { get; }
        IEnumerable<Student> Students { get; }
        IEnumerable<UserBaseModel> Users { get; }
    }
}