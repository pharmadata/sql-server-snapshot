﻿using CommandLine;

namespace SqlSnap.Cli
{
    [Verb("restore", HelpText = "Restore a SQL Server snapshot backup")]
    public class RestoreOptions
    {
        [Option('i', "instanceName", HelpText = "Name of SQL Server instance for which to connect (optional)")]
        public string InstanceName { get; set; }

        [Option('m', "metadata", Required = true, HelpText = "Path to file to containing the backup metadata")]
        public string MetadataPath { get; set; }

        [Option('d', "database", Required = true, HelpText = "Database to restore")]
        public string Database { get; set; }

        [Option('c', "command", HelpText = "Command to execute that mounts the snapshot (optional - not required if the database is detached and you've already mounted the snapshot)")]
        public string SnapshotCommand { get; set; }

        [Option("noRecovery", HelpText = "Restore the database with the NORECOVERY option")]
        public bool NoRecovery { get; set; }

        [Option('v', "verbose", HelpText = "Include verbose logging information")]
        public bool Verbose { get; set; }
    }
}