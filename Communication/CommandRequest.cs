﻿using System;

namespace Servant.Shared.Communication
{
    public class CommandRequest
    {
        public CommandRequestType Command { get; set; }
        public string JsonObject { get; set; }
        public string Value { get; set; }
        public Guid Guid { get; set; }
    }

    public enum CommandRequestType
    {
        UpdateSite,
        DeleteSite,
        CreateSite,
        GetSites,
        GetApplicationPools,
        GetCertificates,
        StopSite,
        StartSite,
        RestartSite,
        RecycleApplicationPool,
        Unauthorized,
        ForceUpdate,
        DeploySite,
        CmdExeCommand,
        StopApplicationPool,
        StartApplicationPool,
        UpdateApplicationPool,
        DeleteApplicationPool,
        GetAll,
        CreateApplicationPool,
        RollbackDeployment
    }
}