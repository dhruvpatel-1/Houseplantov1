﻿namespace StudioB.Data
{
    public interface INetworkConnection
    {
        bool IsConnected { get; }

        void CheckNetworkConnection();
    }
}