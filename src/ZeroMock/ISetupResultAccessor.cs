﻿namespace ZeroMock;

internal interface ISetupResultAccessor
{
    /// <summary>
    /// How many times the setup method has been invoked
    /// </summary>
    int InvocationAmount { get; }

    /// <summary>
    /// If the user setup a return
    /// </summary>
    Func<dynamic[], dynamic>? GetReturnValue { get; }

    /// <summary>
    /// If the user setup a callback
    /// </summary>
    public Action<dynamic[]>? Callback { get; }

    /// <summary>
    /// If the user setup throws
    /// </summary>
    public Action? Throws { get; }

    /// <summary>
    /// If this setup arguments match the passed arguments
    /// </summary>
    /// <param name="args"></param>
    public bool Match(object[] args);
}