// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Extensions;

    /// <summary>Sysctl settings for Linux agent nodes.</summary>
    public partial class SysctlConfig :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ISysctlConfig,
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ISysctlConfigInternal
    {

        /// <summary>Backing field for <see cref="FsAioMaxNr" /> property.</summary>
        private int? _fsAioMaxNr;

        /// <summary>Sysctl setting fs.aio-max-nr.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? FsAioMaxNr { get => this._fsAioMaxNr; set => this._fsAioMaxNr = value; }

        /// <summary>Backing field for <see cref="FsFileMax" /> property.</summary>
        private int? _fsFileMax;

        /// <summary>Sysctl setting fs.file-max.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? FsFileMax { get => this._fsFileMax; set => this._fsFileMax = value; }

        /// <summary>Backing field for <see cref="FsInotifyMaxUserWatch" /> property.</summary>
        private int? _fsInotifyMaxUserWatch;

        /// <summary>Sysctl setting fs.inotify.max_user_watches.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? FsInotifyMaxUserWatch { get => this._fsInotifyMaxUserWatch; set => this._fsInotifyMaxUserWatch = value; }

        /// <summary>Backing field for <see cref="FsNrOpen" /> property.</summary>
        private int? _fsNrOpen;

        /// <summary>Sysctl setting fs.nr_open.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? FsNrOpen { get => this._fsNrOpen; set => this._fsNrOpen = value; }

        /// <summary>Backing field for <see cref="KernelThreadsMax" /> property.</summary>
        private int? _kernelThreadsMax;

        /// <summary>Sysctl setting kernel.threads-max.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? KernelThreadsMax { get => this._kernelThreadsMax; set => this._kernelThreadsMax = value; }

        /// <summary>Backing field for <see cref="NetCoreNetdevMaxBacklog" /> property.</summary>
        private int? _netCoreNetdevMaxBacklog;

        /// <summary>Sysctl setting net.core.netdev_max_backlog.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetCoreNetdevMaxBacklog { get => this._netCoreNetdevMaxBacklog; set => this._netCoreNetdevMaxBacklog = value; }

        /// <summary>Backing field for <see cref="NetCoreOptmemMax" /> property.</summary>
        private int? _netCoreOptmemMax;

        /// <summary>Sysctl setting net.core.optmem_max.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetCoreOptmemMax { get => this._netCoreOptmemMax; set => this._netCoreOptmemMax = value; }

        /// <summary>Backing field for <see cref="NetCoreRmemDefault" /> property.</summary>
        private int? _netCoreRmemDefault;

        /// <summary>Sysctl setting net.core.rmem_default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetCoreRmemDefault { get => this._netCoreRmemDefault; set => this._netCoreRmemDefault = value; }

        /// <summary>Backing field for <see cref="NetCoreRmemMax" /> property.</summary>
        private int? _netCoreRmemMax;

        /// <summary>Sysctl setting net.core.rmem_max.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetCoreRmemMax { get => this._netCoreRmemMax; set => this._netCoreRmemMax = value; }

        /// <summary>Backing field for <see cref="NetCoreSomaxconn" /> property.</summary>
        private int? _netCoreSomaxconn;

        /// <summary>Sysctl setting net.core.somaxconn.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetCoreSomaxconn { get => this._netCoreSomaxconn; set => this._netCoreSomaxconn = value; }

        /// <summary>Backing field for <see cref="NetCoreWmemDefault" /> property.</summary>
        private int? _netCoreWmemDefault;

        /// <summary>Sysctl setting net.core.wmem_default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetCoreWmemDefault { get => this._netCoreWmemDefault; set => this._netCoreWmemDefault = value; }

        /// <summary>Backing field for <see cref="NetCoreWmemMax" /> property.</summary>
        private int? _netCoreWmemMax;

        /// <summary>Sysctl setting net.core.wmem_max.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetCoreWmemMax { get => this._netCoreWmemMax; set => this._netCoreWmemMax = value; }

        /// <summary>Backing field for <see cref="NetIpv4IPLocalPortRange" /> property.</summary>
        private string _netIpv4IPLocalPortRange;

        /// <summary>Sysctl setting net.ipv4.ip_local_port_range.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public string NetIpv4IPLocalPortRange { get => this._netIpv4IPLocalPortRange; set => this._netIpv4IPLocalPortRange = value; }

        /// <summary>Backing field for <see cref="NetIpv4NeighDefaultGcThresh1" /> property.</summary>
        private int? _netIpv4NeighDefaultGcThresh1;

        /// <summary>Sysctl setting net.ipv4.neigh.default.gc_thresh1.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetIpv4NeighDefaultGcThresh1 { get => this._netIpv4NeighDefaultGcThresh1; set => this._netIpv4NeighDefaultGcThresh1 = value; }

        /// <summary>Backing field for <see cref="NetIpv4NeighDefaultGcThresh2" /> property.</summary>
        private int? _netIpv4NeighDefaultGcThresh2;

        /// <summary>Sysctl setting net.ipv4.neigh.default.gc_thresh2.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetIpv4NeighDefaultGcThresh2 { get => this._netIpv4NeighDefaultGcThresh2; set => this._netIpv4NeighDefaultGcThresh2 = value; }

        /// <summary>Backing field for <see cref="NetIpv4NeighDefaultGcThresh3" /> property.</summary>
        private int? _netIpv4NeighDefaultGcThresh3;

        /// <summary>Sysctl setting net.ipv4.neigh.default.gc_thresh3.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetIpv4NeighDefaultGcThresh3 { get => this._netIpv4NeighDefaultGcThresh3; set => this._netIpv4NeighDefaultGcThresh3 = value; }

        /// <summary>Backing field for <see cref="NetIpv4TcpFinTimeout" /> property.</summary>
        private int? _netIpv4TcpFinTimeout;

        /// <summary>Sysctl setting net.ipv4.tcp_fin_timeout.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetIpv4TcpFinTimeout { get => this._netIpv4TcpFinTimeout; set => this._netIpv4TcpFinTimeout = value; }

        /// <summary>Backing field for <see cref="NetIpv4TcpKeepaliveProbe" /> property.</summary>
        private int? _netIpv4TcpKeepaliveProbe;

        /// <summary>Sysctl setting net.ipv4.tcp_keepalive_probes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetIpv4TcpKeepaliveProbe { get => this._netIpv4TcpKeepaliveProbe; set => this._netIpv4TcpKeepaliveProbe = value; }

        /// <summary>Backing field for <see cref="NetIpv4TcpKeepaliveTime" /> property.</summary>
        private int? _netIpv4TcpKeepaliveTime;

        /// <summary>Sysctl setting net.ipv4.tcp_keepalive_time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetIpv4TcpKeepaliveTime { get => this._netIpv4TcpKeepaliveTime; set => this._netIpv4TcpKeepaliveTime = value; }

        /// <summary>Backing field for <see cref="NetIpv4TcpMaxSynBacklog" /> property.</summary>
        private int? _netIpv4TcpMaxSynBacklog;

        /// <summary>Sysctl setting net.ipv4.tcp_max_syn_backlog.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetIpv4TcpMaxSynBacklog { get => this._netIpv4TcpMaxSynBacklog; set => this._netIpv4TcpMaxSynBacklog = value; }

        /// <summary>Backing field for <see cref="NetIpv4TcpMaxTwBucket" /> property.</summary>
        private int? _netIpv4TcpMaxTwBucket;

        /// <summary>Sysctl setting net.ipv4.tcp_max_tw_buckets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetIpv4TcpMaxTwBucket { get => this._netIpv4TcpMaxTwBucket; set => this._netIpv4TcpMaxTwBucket = value; }

        /// <summary>Backing field for <see cref="NetIpv4TcpTwReuse" /> property.</summary>
        private bool? _netIpv4TcpTwReuse;

        /// <summary>Sysctl setting net.ipv4.tcp_tw_reuse.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public bool? NetIpv4TcpTwReuse { get => this._netIpv4TcpTwReuse; set => this._netIpv4TcpTwReuse = value; }

        /// <summary>Backing field for <see cref="NetIpv4TcpkeepaliveIntvl" /> property.</summary>
        private int? _netIpv4TcpkeepaliveIntvl;

        /// <summary>Sysctl setting net.ipv4.tcp_keepalive_intvl.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetIpv4TcpkeepaliveIntvl { get => this._netIpv4TcpkeepaliveIntvl; set => this._netIpv4TcpkeepaliveIntvl = value; }

        /// <summary>Backing field for <see cref="NetNetfilterNfConntrackBucket" /> property.</summary>
        private int? _netNetfilterNfConntrackBucket;

        /// <summary>Sysctl setting net.netfilter.nf_conntrack_buckets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetNetfilterNfConntrackBucket { get => this._netNetfilterNfConntrackBucket; set => this._netNetfilterNfConntrackBucket = value; }

        /// <summary>Backing field for <see cref="NetNetfilterNfConntrackMax" /> property.</summary>
        private int? _netNetfilterNfConntrackMax;

        /// <summary>Sysctl setting net.netfilter.nf_conntrack_max.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? NetNetfilterNfConntrackMax { get => this._netNetfilterNfConntrackMax; set => this._netNetfilterNfConntrackMax = value; }

        /// <summary>Backing field for <see cref="VMMaxMapCount" /> property.</summary>
        private int? _vMMaxMapCount;

        /// <summary>Sysctl setting vm.max_map_count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? VMMaxMapCount { get => this._vMMaxMapCount; set => this._vMMaxMapCount = value; }

        /// <summary>Backing field for <see cref="VMSwappiness" /> property.</summary>
        private int? _vMSwappiness;

        /// <summary>Sysctl setting vm.swappiness.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? VMSwappiness { get => this._vMSwappiness; set => this._vMSwappiness = value; }

        /// <summary>Backing field for <see cref="VMVfsCachePressure" /> property.</summary>
        private int? _vMVfsCachePressure;

        /// <summary>Sysctl setting vm.vfs_cache_pressure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public int? VMVfsCachePressure { get => this._vMVfsCachePressure; set => this._vMVfsCachePressure = value; }

        /// <summary>Creates an new <see cref="SysctlConfig" /> instance.</summary>
        public SysctlConfig()
        {

        }
    }
    /// Sysctl settings for Linux agent nodes.
    public partial interface ISysctlConfig :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.IJsonSerializable
    {
        /// <summary>Sysctl setting fs.aio-max-nr.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting fs.aio-max-nr.",
        SerializedName = @"fsAioMaxNr",
        PossibleTypes = new [] { typeof(int) })]
        int? FsAioMaxNr { get; set; }
        /// <summary>Sysctl setting fs.file-max.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting fs.file-max.",
        SerializedName = @"fsFileMax",
        PossibleTypes = new [] { typeof(int) })]
        int? FsFileMax { get; set; }
        /// <summary>Sysctl setting fs.inotify.max_user_watches.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting fs.inotify.max_user_watches.",
        SerializedName = @"fsInotifyMaxUserWatches",
        PossibleTypes = new [] { typeof(int) })]
        int? FsInotifyMaxUserWatch { get; set; }
        /// <summary>Sysctl setting fs.nr_open.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting fs.nr_open.",
        SerializedName = @"fsNrOpen",
        PossibleTypes = new [] { typeof(int) })]
        int? FsNrOpen { get; set; }
        /// <summary>Sysctl setting kernel.threads-max.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting kernel.threads-max.",
        SerializedName = @"kernelThreadsMax",
        PossibleTypes = new [] { typeof(int) })]
        int? KernelThreadsMax { get; set; }
        /// <summary>Sysctl setting net.core.netdev_max_backlog.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.core.netdev_max_backlog.",
        SerializedName = @"netCoreNetdevMaxBacklog",
        PossibleTypes = new [] { typeof(int) })]
        int? NetCoreNetdevMaxBacklog { get; set; }
        /// <summary>Sysctl setting net.core.optmem_max.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.core.optmem_max.",
        SerializedName = @"netCoreOptmemMax",
        PossibleTypes = new [] { typeof(int) })]
        int? NetCoreOptmemMax { get; set; }
        /// <summary>Sysctl setting net.core.rmem_default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.core.rmem_default.",
        SerializedName = @"netCoreRmemDefault",
        PossibleTypes = new [] { typeof(int) })]
        int? NetCoreRmemDefault { get; set; }
        /// <summary>Sysctl setting net.core.rmem_max.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.core.rmem_max.",
        SerializedName = @"netCoreRmemMax",
        PossibleTypes = new [] { typeof(int) })]
        int? NetCoreRmemMax { get; set; }
        /// <summary>Sysctl setting net.core.somaxconn.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.core.somaxconn.",
        SerializedName = @"netCoreSomaxconn",
        PossibleTypes = new [] { typeof(int) })]
        int? NetCoreSomaxconn { get; set; }
        /// <summary>Sysctl setting net.core.wmem_default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.core.wmem_default.",
        SerializedName = @"netCoreWmemDefault",
        PossibleTypes = new [] { typeof(int) })]
        int? NetCoreWmemDefault { get; set; }
        /// <summary>Sysctl setting net.core.wmem_max.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.core.wmem_max.",
        SerializedName = @"netCoreWmemMax",
        PossibleTypes = new [] { typeof(int) })]
        int? NetCoreWmemMax { get; set; }
        /// <summary>Sysctl setting net.ipv4.ip_local_port_range.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.ipv4.ip_local_port_range.",
        SerializedName = @"netIpv4IpLocalPortRange",
        PossibleTypes = new [] { typeof(string) })]
        string NetIpv4IPLocalPortRange { get; set; }
        /// <summary>Sysctl setting net.ipv4.neigh.default.gc_thresh1.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.ipv4.neigh.default.gc_thresh1.",
        SerializedName = @"netIpv4NeighDefaultGcThresh1",
        PossibleTypes = new [] { typeof(int) })]
        int? NetIpv4NeighDefaultGcThresh1 { get; set; }
        /// <summary>Sysctl setting net.ipv4.neigh.default.gc_thresh2.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.ipv4.neigh.default.gc_thresh2.",
        SerializedName = @"netIpv4NeighDefaultGcThresh2",
        PossibleTypes = new [] { typeof(int) })]
        int? NetIpv4NeighDefaultGcThresh2 { get; set; }
        /// <summary>Sysctl setting net.ipv4.neigh.default.gc_thresh3.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.ipv4.neigh.default.gc_thresh3.",
        SerializedName = @"netIpv4NeighDefaultGcThresh3",
        PossibleTypes = new [] { typeof(int) })]
        int? NetIpv4NeighDefaultGcThresh3 { get; set; }
        /// <summary>Sysctl setting net.ipv4.tcp_fin_timeout.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.ipv4.tcp_fin_timeout.",
        SerializedName = @"netIpv4TcpFinTimeout",
        PossibleTypes = new [] { typeof(int) })]
        int? NetIpv4TcpFinTimeout { get; set; }
        /// <summary>Sysctl setting net.ipv4.tcp_keepalive_probes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.ipv4.tcp_keepalive_probes.",
        SerializedName = @"netIpv4TcpKeepaliveProbes",
        PossibleTypes = new [] { typeof(int) })]
        int? NetIpv4TcpKeepaliveProbe { get; set; }
        /// <summary>Sysctl setting net.ipv4.tcp_keepalive_time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.ipv4.tcp_keepalive_time.",
        SerializedName = @"netIpv4TcpKeepaliveTime",
        PossibleTypes = new [] { typeof(int) })]
        int? NetIpv4TcpKeepaliveTime { get; set; }
        /// <summary>Sysctl setting net.ipv4.tcp_max_syn_backlog.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.ipv4.tcp_max_syn_backlog.",
        SerializedName = @"netIpv4TcpMaxSynBacklog",
        PossibleTypes = new [] { typeof(int) })]
        int? NetIpv4TcpMaxSynBacklog { get; set; }
        /// <summary>Sysctl setting net.ipv4.tcp_max_tw_buckets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.ipv4.tcp_max_tw_buckets.",
        SerializedName = @"netIpv4TcpMaxTwBuckets",
        PossibleTypes = new [] { typeof(int) })]
        int? NetIpv4TcpMaxTwBucket { get; set; }
        /// <summary>Sysctl setting net.ipv4.tcp_tw_reuse.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.ipv4.tcp_tw_reuse.",
        SerializedName = @"netIpv4TcpTwReuse",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NetIpv4TcpTwReuse { get; set; }
        /// <summary>Sysctl setting net.ipv4.tcp_keepalive_intvl.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.ipv4.tcp_keepalive_intvl.",
        SerializedName = @"netIpv4TcpkeepaliveIntvl",
        PossibleTypes = new [] { typeof(int) })]
        int? NetIpv4TcpkeepaliveIntvl { get; set; }
        /// <summary>Sysctl setting net.netfilter.nf_conntrack_buckets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.netfilter.nf_conntrack_buckets.",
        SerializedName = @"netNetfilterNfConntrackBuckets",
        PossibleTypes = new [] { typeof(int) })]
        int? NetNetfilterNfConntrackBucket { get; set; }
        /// <summary>Sysctl setting net.netfilter.nf_conntrack_max.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting net.netfilter.nf_conntrack_max.",
        SerializedName = @"netNetfilterNfConntrackMax",
        PossibleTypes = new [] { typeof(int) })]
        int? NetNetfilterNfConntrackMax { get; set; }
        /// <summary>Sysctl setting vm.max_map_count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting vm.max_map_count.",
        SerializedName = @"vmMaxMapCount",
        PossibleTypes = new [] { typeof(int) })]
        int? VMMaxMapCount { get; set; }
        /// <summary>Sysctl setting vm.swappiness.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting vm.swappiness.",
        SerializedName = @"vmSwappiness",
        PossibleTypes = new [] { typeof(int) })]
        int? VMSwappiness { get; set; }
        /// <summary>Sysctl setting vm.vfs_cache_pressure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sysctl setting vm.vfs_cache_pressure.",
        SerializedName = @"vmVfsCachePressure",
        PossibleTypes = new [] { typeof(int) })]
        int? VMVfsCachePressure { get; set; }

    }
    /// Sysctl settings for Linux agent nodes.
    internal partial interface ISysctlConfigInternal

    {
        /// <summary>Sysctl setting fs.aio-max-nr.</summary>
        int? FsAioMaxNr { get; set; }
        /// <summary>Sysctl setting fs.file-max.</summary>
        int? FsFileMax { get; set; }
        /// <summary>Sysctl setting fs.inotify.max_user_watches.</summary>
        int? FsInotifyMaxUserWatch { get; set; }
        /// <summary>Sysctl setting fs.nr_open.</summary>
        int? FsNrOpen { get; set; }
        /// <summary>Sysctl setting kernel.threads-max.</summary>
        int? KernelThreadsMax { get; set; }
        /// <summary>Sysctl setting net.core.netdev_max_backlog.</summary>
        int? NetCoreNetdevMaxBacklog { get; set; }
        /// <summary>Sysctl setting net.core.optmem_max.</summary>
        int? NetCoreOptmemMax { get; set; }
        /// <summary>Sysctl setting net.core.rmem_default.</summary>
        int? NetCoreRmemDefault { get; set; }
        /// <summary>Sysctl setting net.core.rmem_max.</summary>
        int? NetCoreRmemMax { get; set; }
        /// <summary>Sysctl setting net.core.somaxconn.</summary>
        int? NetCoreSomaxconn { get; set; }
        /// <summary>Sysctl setting net.core.wmem_default.</summary>
        int? NetCoreWmemDefault { get; set; }
        /// <summary>Sysctl setting net.core.wmem_max.</summary>
        int? NetCoreWmemMax { get; set; }
        /// <summary>Sysctl setting net.ipv4.ip_local_port_range.</summary>
        string NetIpv4IPLocalPortRange { get; set; }
        /// <summary>Sysctl setting net.ipv4.neigh.default.gc_thresh1.</summary>
        int? NetIpv4NeighDefaultGcThresh1 { get; set; }
        /// <summary>Sysctl setting net.ipv4.neigh.default.gc_thresh2.</summary>
        int? NetIpv4NeighDefaultGcThresh2 { get; set; }
        /// <summary>Sysctl setting net.ipv4.neigh.default.gc_thresh3.</summary>
        int? NetIpv4NeighDefaultGcThresh3 { get; set; }
        /// <summary>Sysctl setting net.ipv4.tcp_fin_timeout.</summary>
        int? NetIpv4TcpFinTimeout { get; set; }
        /// <summary>Sysctl setting net.ipv4.tcp_keepalive_probes.</summary>
        int? NetIpv4TcpKeepaliveProbe { get; set; }
        /// <summary>Sysctl setting net.ipv4.tcp_keepalive_time.</summary>
        int? NetIpv4TcpKeepaliveTime { get; set; }
        /// <summary>Sysctl setting net.ipv4.tcp_max_syn_backlog.</summary>
        int? NetIpv4TcpMaxSynBacklog { get; set; }
        /// <summary>Sysctl setting net.ipv4.tcp_max_tw_buckets.</summary>
        int? NetIpv4TcpMaxTwBucket { get; set; }
        /// <summary>Sysctl setting net.ipv4.tcp_tw_reuse.</summary>
        bool? NetIpv4TcpTwReuse { get; set; }
        /// <summary>Sysctl setting net.ipv4.tcp_keepalive_intvl.</summary>
        int? NetIpv4TcpkeepaliveIntvl { get; set; }
        /// <summary>Sysctl setting net.netfilter.nf_conntrack_buckets.</summary>
        int? NetNetfilterNfConntrackBucket { get; set; }
        /// <summary>Sysctl setting net.netfilter.nf_conntrack_max.</summary>
        int? NetNetfilterNfConntrackMax { get; set; }
        /// <summary>Sysctl setting vm.max_map_count.</summary>
        int? VMMaxMapCount { get; set; }
        /// <summary>Sysctl setting vm.swappiness.</summary>
        int? VMSwappiness { get; set; }
        /// <summary>Sysctl setting vm.vfs_cache_pressure.</summary>
        int? VMVfsCachePressure { get; set; }

    }
}