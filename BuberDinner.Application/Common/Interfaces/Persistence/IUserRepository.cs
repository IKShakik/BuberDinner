using System;
using BuberDinner.Domain;

namespace BuberDinner.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
     User? GetUserByEmail(string email);
     void Add(User user);
}
