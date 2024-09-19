using System;
using BuberDinner.Application.Common.Interfaces.Authentication;

namespace BuberDinner.Infrastructure.Authentication.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
