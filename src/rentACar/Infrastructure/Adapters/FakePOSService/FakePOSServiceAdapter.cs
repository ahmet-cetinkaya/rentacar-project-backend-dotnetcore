﻿using Application.Services.POSService;
using Core.CrossCuttingConcerns.Exceptions;

namespace Infrastructure.Adapters.FakePOSService;

public class FakePOSServiceAdapter : IPOSService
{
    public Task Pay(string invoiceNo, decimal price)
    {
        Random random = new();
        bool result = Convert.ToBoolean(random.Next(2));
        if (!result) throw new BusinessException("Pay is not success-full.");
        return Task.CompletedTask;
    }
}