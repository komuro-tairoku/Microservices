using System;
using MediatR;

namespace PolicyService.Api.Events;

public sealed record PolicyCreated(
    string PolicyNumber,
    DateTime PolicyFrom,
    DateTime PolicyTo,
    PolicyHolder PolicyHolder,
    string ProductCode,
    decimal TotalPremium,
    string AgentLogin) : INotification;

public sealed record PolicyHolder(string FirstName, string LastName);
