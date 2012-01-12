﻿namespace Kudu.Core
{
    public interface IEnvironment
    {
        string RepositoryPath { get; }
        string DeploymentRepositoryTargetPath { get; }
        string DeploymentRepositoryPath { get; }
        string DeploymentTargetPath { get; }
        string DeploymentCachePath { get; }
        string ApplicationRootPath { get; }
        string AppName { get; }
    }
}
