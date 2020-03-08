﻿namespace OpenClosed.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
