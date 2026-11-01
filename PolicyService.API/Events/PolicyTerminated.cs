using System;
using MediatR;

namespace PolicyService.Api.Events;

public sealed record PolicyTerminated(
    string PolicyNumber,
    DateTime PolicyTo,
    decimal? AmountToReturn) : INotification;
