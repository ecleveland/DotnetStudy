﻿namespace PrimeService;

public class PrimeService
{
    public bool IsPrime(int candidate)
    {
        if(candidate == 1)
        {
            return true;
        }
        throw new NotImplementedException("Not fully implemented.");
    }
}
