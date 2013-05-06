﻿using SafetyProgram.Base.Interfaces;

namespace SafetyProgram.Configuration
{
    public interface IRepositoryInfo : IStorable
    {
        string Source { get; }
        string ContentType { get; }
        string Path { get; }
        string Login { get; }
        string Password { get; }
    }
}