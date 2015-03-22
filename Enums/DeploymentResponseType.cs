﻿namespace Servant.Shared.Enums
{
    public enum DeploymentResponseType
    {
        DeploymentRequestReceived = 0,
        CreateDirectory = 1,
        PackageDownload = 2,
        PackageUnzipping = 3,
        Warmup = 4,
        Rollback = 5,
        ChangeSitePath = 6,
        WarmupResult = 7
    }
}