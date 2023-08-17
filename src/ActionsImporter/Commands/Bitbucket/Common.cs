﻿using System.CommandLine;

namespace ActionsImporter.Commands.Bitbucket;

public static class Common
{
    public static readonly Option<string> InstanceUrl = new("--bitbucket-instance-url")
    {
        Description = "The URL of the Bitbucket instance.",
        IsRequired = false,
    };

    public static readonly Option<string[]> Namespace = new(new[] { "--namespace", "-n" })
    {
        Description = "The Bitbucket namespace(s).",
        IsRequired = false,
        AllowMultipleArgumentsPerToken = true
    };

    public static readonly Option<string> AccessToken = new("--bitbucket-access-token")
    {
        Description = "Access token for the Bitbucket instance.",
        IsRequired = false,
    };

    public static readonly Option<string> Workspace = new("--workspace")
    {
        Description = "The Bitbucket workspace name.",
        IsRequired = true,
    };

    public static readonly Option<string> Project = new("--project")
    {
        Description = "The Bitbucket project name.",
        IsRequired = false,
    };

    public static readonly Option<string> Repository = new("--repository")
    {
        Description = "The Bitbucket repository name.",
        IsRequired = true,
    };

    public static readonly Option<FileInfo> ConfigFilePath = new("--config-file-path")
    {
        Description = "The file path to the GitHub Actions Importer configuration file.",
        IsRequired = false,
    };

    public static readonly Option<FileInfo> SourceFilePath = new("--source-file-path")
    {
        Description = "The file path corresponding to the Bamboo pipeline file.",
        IsRequired = false,
    };
}