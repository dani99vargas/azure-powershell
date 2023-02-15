// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties for the container service agent pool profile.
    /// </summary>
    public partial class ManagedClusterAgentPoolProfileProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterAgentPoolProfileProperties class.
        /// </summary>
        public ManagedClusterAgentPoolProfileProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterAgentPoolProfileProperties class.
        /// </summary>
        /// <param name="count">Number of agents (VMs) to host docker
        /// containers. Allowed values must be in the range of 0 to 1000
        /// (inclusive) for user pools and in the range of 1 to 1000
        /// (inclusive) for system pools. The default value is 1.</param>
        /// <param name="vmSize">The size of the agent pool VMs.</param>
        /// <param name="osDiskType">Possible values include: 'Managed',
        /// 'Ephemeral'</param>
        /// <param name="kubeletDiskType">Possible values include: 'OS',
        /// 'Temporary'</param>
        /// <param name="workloadRuntime">Possible values include:
        /// 'OCIContainer', 'WasmWasi'</param>
        /// <param name="vnetSubnetID">The ID of the subnet which agent pool
        /// nodes and optionally pods will join on startup.</param>
        /// <param name="podSubnetID">The ID of the subnet which pods will join
        /// when launched.</param>
        /// <param name="maxPods">The maximum number of pods that can run on a
        /// node.</param>
        /// <param name="osType">Possible values include: 'Linux',
        /// 'Windows'</param>
        /// <param name="osSKU">Possible values include: 'Ubuntu',
        /// 'CBLMariner', 'Windows2019', 'Windows2022'</param>
        /// <param name="maxCount">The maximum number of nodes for
        /// auto-scaling</param>
        /// <param name="minCount">The minimum number of nodes for
        /// auto-scaling</param>
        /// <param name="enableAutoScaling">Whether to enable
        /// auto-scaler</param>
        /// <param name="scaleDownMode">The scale down mode to use when scaling
        /// the Agent Pool.</param>
        /// <param name="type">Possible values include:
        /// 'VirtualMachineScaleSets', 'AvailabilitySet'</param>
        /// <param name="mode">Possible values include: 'System',
        /// 'User'</param>
        /// <param name="orchestratorVersion">The version of Kubernetes
        /// specified by the user.</param>
        /// <param name="currentOrchestratorVersion">The version of Kubernetes
        /// the Agent Pool is running.</param>
        /// <param name="nodeImageVersion">The version of node image</param>
        /// <param name="upgradeSettings">Settings for upgrading the
        /// agentpool</param>
        /// <param name="provisioningState">The current deployment or
        /// provisioning state.</param>
        /// <param name="powerState">Whether the Agent Pool is running or
        /// stopped.</param>
        /// <param name="availabilityZones">The list of Availability zones to
        /// use for nodes. This can only be specified if the AgentPoolType
        /// property is 'VirtualMachineScaleSets'.</param>
        /// <param name="enableNodePublicIP">Whether each node is allocated its
        /// own public IP.</param>
        /// <param name="nodePublicIPPrefixID">The public IP prefix ID which VM
        /// nodes should use IPs from.</param>
        /// <param name="scaleSetPriority">The Virtual Machine Scale Set
        /// priority. If not specified, the default is 'Regular'. Possible
        /// values include: 'Spot', 'Regular'</param>
        /// <param name="scaleSetEvictionPolicy">The Virtual Machine Scale Set
        /// eviction policy to use.</param>
        /// <param name="spotMaxPrice">The max price (in US Dollars) you are
        /// willing to pay for spot instances. Possible values are any decimal
        /// value greater than zero or -1 which indicates default price to be
        /// up-to on-demand.</param>
        /// <param name="tags">The tags to be persisted on the agent pool
        /// virtual machine scale set.</param>
        /// <param name="nodeLabels">The node labels to be persisted across all
        /// nodes in agent pool.</param>
        /// <param name="nodeTaints">The taints added to new nodes during node
        /// pool create and scale. For example, key=value:NoSchedule.</param>
        /// <param name="proximityPlacementGroupID">The ID for Proximity
        /// Placement Group.</param>
        /// <param name="kubeletConfig">The Kubelet configuration on the agent
        /// pool nodes.</param>
        /// <param name="linuxOSConfig">The OS configuration of Linux agent
        /// nodes.</param>
        /// <param name="enableEncryptionAtHost">Whether to enable host based
        /// OS and data drive encryption.</param>
        /// <param name="enableUltraSSD">Whether to enable UltraSSD</param>
        /// <param name="enableFIPS">Whether to use a FIPS-enabled OS.</param>
        /// <param name="gpuInstanceProfile">GPUInstanceProfile to be used to
        /// specify GPU MIG instance profile for supported GPU VM SKU. Possible
        /// values include: 'MIG1g', 'MIG2g', 'MIG3g', 'MIG4g', 'MIG7g'</param>
        /// <param name="creationData">CreationData to be used to specify the
        /// source Snapshot ID if the node pool will be created/upgraded using
        /// a snapshot.</param>
        /// <param name="hostGroupID">The fully qualified resource ID of the
        /// Dedicated Host Group to provision virtual machines from, used only
        /// in creation scenario and not allowed to changed once set.</param>
        public ManagedClusterAgentPoolProfileProperties(int? count = default(int?), string vmSize = default(string), int? osDiskSizeGB = default(int?), string osDiskType = default(string), string kubeletDiskType = default(string), string workloadRuntime = default(string), string vnetSubnetID = default(string), string podSubnetID = default(string), int? maxPods = default(int?), string osType = default(string), string osSKU = default(string), int? maxCount = default(int?), int? minCount = default(int?), bool? enableAutoScaling = default(bool?), string scaleDownMode = default(string), string type = default(string), string mode = default(string), string orchestratorVersion = default(string), string currentOrchestratorVersion = default(string), string nodeImageVersion = default(string), AgentPoolUpgradeSettings upgradeSettings = default(AgentPoolUpgradeSettings), string provisioningState = default(string), PowerState powerState = default(PowerState), IList<string> availabilityZones = default(IList<string>), bool? enableNodePublicIP = default(bool?), string nodePublicIPPrefixID = default(string), string scaleSetPriority = default(string), string scaleSetEvictionPolicy = default(string), double? spotMaxPrice = default(double?), IDictionary<string, string> tags = default(IDictionary<string, string>), IDictionary<string, string> nodeLabels = default(IDictionary<string, string>), IList<string> nodeTaints = default(IList<string>), string proximityPlacementGroupID = default(string), KubeletConfig kubeletConfig = default(KubeletConfig), LinuxOSConfig linuxOSConfig = default(LinuxOSConfig), bool? enableEncryptionAtHost = default(bool?), bool? enableUltraSSD = default(bool?), bool? enableFIPS = default(bool?), string gpuInstanceProfile = default(string), CreationData creationData = default(CreationData), string hostGroupID = default(string))
        {
            Count = count;
            VmSize = vmSize;
            OsDiskSizeGB = osDiskSizeGB;
            OsDiskType = osDiskType;
            KubeletDiskType = kubeletDiskType;
            WorkloadRuntime = workloadRuntime;
            VnetSubnetID = vnetSubnetID;
            PodSubnetID = podSubnetID;
            MaxPods = maxPods;
            OsType = osType;
            OsSKU = osSKU;
            MaxCount = maxCount;
            MinCount = minCount;
            EnableAutoScaling = enableAutoScaling;
            ScaleDownMode = scaleDownMode;
            Type = type;
            Mode = mode;
            OrchestratorVersion = orchestratorVersion;
            CurrentOrchestratorVersion = currentOrchestratorVersion;
            NodeImageVersion = nodeImageVersion;
            UpgradeSettings = upgradeSettings;
            ProvisioningState = provisioningState;
            PowerState = powerState;
            AvailabilityZones = availabilityZones;
            EnableNodePublicIP = enableNodePublicIP;
            NodePublicIPPrefixID = nodePublicIPPrefixID;
            ScaleSetPriority = scaleSetPriority;
            ScaleSetEvictionPolicy = scaleSetEvictionPolicy;
            SpotMaxPrice = spotMaxPrice;
            Tags = tags;
            NodeLabels = nodeLabels;
            NodeTaints = nodeTaints;
            ProximityPlacementGroupID = proximityPlacementGroupID;
            KubeletConfig = kubeletConfig;
            LinuxOSConfig = linuxOSConfig;
            EnableEncryptionAtHost = enableEncryptionAtHost;
            EnableUltraSSD = enableUltraSSD;
            EnableFIPS = enableFIPS;
            GpuInstanceProfile = gpuInstanceProfile;
            CreationData = creationData;
            HostGroupID = hostGroupID;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of agents (VMs) to host docker containers.
        /// Allowed values must be in the range of 0 to 1000 (inclusive) for
        /// user pools and in the range of 1 to 1000 (inclusive) for system
        /// pools. The default value is 1.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets the size of the agent pool VMs.
        /// </summary>
        /// <remarks>
        /// VM size availability varies by region. If a node contains
        /// insufficient compute resources (memory, cpu, etc) pods might fail
        /// to run correctly. For more details on restricted VM sizes, see:
        /// https://learn.microsoft.com/azure/aks/quotas-skus-regions
        /// </remarks>
        [JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "osDiskSizeGB")]
        public int? OsDiskSizeGB { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Managed', 'Ephemeral'
        /// </summary>
        [JsonProperty(PropertyName = "osDiskType")]
        public string OsDiskType { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'OS', 'Temporary'
        /// </summary>
        [JsonProperty(PropertyName = "kubeletDiskType")]
        public string KubeletDiskType { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'OCIContainer', 'WasmWasi'
        /// </summary>
        [JsonProperty(PropertyName = "workloadRuntime")]
        public string WorkloadRuntime { get; set; }

        /// <summary>
        /// Gets or sets the ID of the subnet which agent pool nodes and
        /// optionally pods will join on startup.
        /// </summary>
        /// <remarks>
        /// If this is not specified, a VNET and subnet will be generated and
        /// used. If no podSubnetID is specified, this applies to nodes and
        /// pods, otherwise it applies to just nodes. This is of the form:
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// </remarks>
        [JsonProperty(PropertyName = "vnetSubnetID")]
        public string VnetSubnetID { get; set; }

        /// <summary>
        /// Gets or sets the ID of the subnet which pods will join when
        /// launched.
        /// </summary>
        /// <remarks>
        /// If omitted, pod IPs are statically assigned on the node subnet (see
        /// vnetSubnetID for more details). This is of the form:
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}
        /// </remarks>
        [JsonProperty(PropertyName = "podSubnetID")]
        public string PodSubnetID { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of pods that can run on a node.
        /// </summary>
        [JsonProperty(PropertyName = "maxPods")]
        public int? MaxPods { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Linux', 'Windows'
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Ubuntu', 'CBLMariner',
        /// 'Windows2019', 'Windows2022'
        /// </summary>
        [JsonProperty(PropertyName = "osSKU")]
        public string OsSKU { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of nodes for auto-scaling
        /// </summary>
        [JsonProperty(PropertyName = "maxCount")]
        public int? MaxCount { get; set; }

        /// <summary>
        /// Gets or sets the minimum number of nodes for auto-scaling
        /// </summary>
        [JsonProperty(PropertyName = "minCount")]
        public int? MinCount { get; set; }

        /// <summary>
        /// Gets or sets whether to enable auto-scaler
        /// </summary>
        [JsonProperty(PropertyName = "enableAutoScaling")]
        public bool? EnableAutoScaling { get; set; }

        /// <summary>
        /// Gets or sets the scale down mode to use when scaling the Agent
        /// Pool.
        /// </summary>
        /// <remarks>
        /// This also effects the cluster autoscaler behavior. If not
        /// specified, it defaults to Delete. Possible values include:
        /// 'Delete', 'Deallocate'
        /// </remarks>
        [JsonProperty(PropertyName = "scaleDownMode")]
        public string ScaleDownMode { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'VirtualMachineScaleSets',
        /// 'AvailabilitySet'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'System', 'User'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or sets the version of Kubernetes specified by the user.
        /// </summary>
        /// <remarks>
        /// Both patch version (major.minor.patch) (e.g. 1.20.13) and
        /// (major.minor) (e.g. 1.20) are supported. When (major.minor) is
        /// specified, the latest supported GA patch version is chosen
        /// automatically. Updating the cluster with the same (major.minor)
        /// once it has been created (e.g. 1.14.x -) 1.14) will not trigger an
        /// upgrade, even if a newer patch version is available. As a best
        /// practice, you should upgrade all node pools in an AKS cluster to
        /// the same Kubernetes version. The node pool version must have the
        /// same major version as the control plane. The node pool minor
        /// version must be within two minor versions of the control plane
        /// version. The node pool version cannot be greater than the control
        /// plane version. For more information see [upgrading a node
        /// pool](https://learn.microsoft.com/azure/aks/use-multiple-node-pools#upgrade-a-node-pool).
        /// </remarks>
        [JsonProperty(PropertyName = "orchestratorVersion")]
        public string OrchestratorVersion { get; set; }

        /// <summary>
        /// Gets the version of Kubernetes the Agent Pool is running.
        /// </summary>
        /// <remarks>
        /// If orchestratorVersion is a fully specified version
        /// (major.minor.patch), this field will be exactly equal to it. If
        /// orchestratorVersion is (major.minor), this field will contain the
        /// full (major.minor.patch) version being used.
        /// </remarks>
        [JsonProperty(PropertyName = "currentOrchestratorVersion")]
        public string CurrentOrchestratorVersion { get; private set; }

        /// <summary>
        /// Gets the version of node image
        /// </summary>
        [JsonProperty(PropertyName = "nodeImageVersion")]
        public string NodeImageVersion { get; private set; }

        /// <summary>
        /// Gets or sets settings for upgrading the agentpool
        /// </summary>
        [JsonProperty(PropertyName = "upgradeSettings")]
        public AgentPoolUpgradeSettings UpgradeSettings { get; set; }

        /// <summary>
        /// Gets the current deployment or provisioning state.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets whether the Agent Pool is running or stopped.
        /// </summary>
        /// <remarks>
        /// When an Agent Pool is first created it is initially Running. The
        /// Agent Pool can be stopped by setting this field to Stopped. A
        /// stopped Agent Pool stops all of its VMs and does not accrue billing
        /// charges. An Agent Pool can only be stopped if it is Running and
        /// provisioning state is Succeeded
        /// </remarks>
        [JsonProperty(PropertyName = "powerState")]
        public PowerState PowerState { get; set; }

        /// <summary>
        /// Gets or sets the list of Availability zones to use for nodes. This
        /// can only be specified if the AgentPoolType property is
        /// 'VirtualMachineScaleSets'.
        /// </summary>
        [JsonProperty(PropertyName = "availabilityZones")]
        public IList<string> AvailabilityZones { get; set; }

        /// <summary>
        /// Gets or sets whether each node is allocated its own public IP.
        /// </summary>
        /// <remarks>
        /// Some scenarios may require nodes in a node pool to receive their
        /// own dedicated public IP addresses. A common scenario is for gaming
        /// workloads, where a console needs to make a direct connection to a
        /// cloud virtual machine to minimize hops. For more information see
        /// [assigning a public IP per
        /// node](https://learn.microsoft.com/azure/aks/use-multiple-node-pools#assign-a-public-ip-per-node-for-your-node-pools).
        /// The default is false.
        /// </remarks>
        [JsonProperty(PropertyName = "enableNodePublicIP")]
        public bool? EnableNodePublicIP { get; set; }

        /// <summary>
        /// Gets or sets the public IP prefix ID which VM nodes should use IPs
        /// from.
        /// </summary>
        /// <remarks>
        /// This is of the form:
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}
        /// </remarks>
        [JsonProperty(PropertyName = "nodePublicIPPrefixID")]
        public string NodePublicIPPrefixID { get; set; }

        /// <summary>
        /// Gets or sets the Virtual Machine Scale Set priority. If not
        /// specified, the default is 'Regular'. Possible values include:
        /// 'Spot', 'Regular'
        /// </summary>
        [JsonProperty(PropertyName = "scaleSetPriority")]
        public string ScaleSetPriority { get; set; }

        /// <summary>
        /// Gets or sets the Virtual Machine Scale Set eviction policy to use.
        /// </summary>
        /// <remarks>
        /// This cannot be specified unless the scaleSetPriority is 'Spot'. If
        /// not specified, the default is 'Delete'. Possible values include:
        /// 'Delete', 'Deallocate'
        /// </remarks>
        [JsonProperty(PropertyName = "scaleSetEvictionPolicy")]
        public string ScaleSetEvictionPolicy { get; set; }

        /// <summary>
        /// Gets or sets the max price (in US Dollars) you are willing to pay
        /// for spot instances. Possible values are any decimal value greater
        /// than zero or -1 which indicates default price to be up-to
        /// on-demand.
        /// </summary>
        /// <remarks>
        /// Possible values are any decimal value greater than zero or -1 which
        /// indicates the willingness to pay any on-demand price. For more
        /// details on spot pricing, see [spot VMs
        /// pricing](https://learn.microsoft.com/azure/virtual-machines/spot-vms#pricing)
        /// </remarks>
        [JsonProperty(PropertyName = "spotMaxPrice")]
        public double? SpotMaxPrice { get; set; }

        /// <summary>
        /// Gets or sets the tags to be persisted on the agent pool virtual
        /// machine scale set.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the node labels to be persisted across all nodes in
        /// agent pool.
        /// </summary>
        [JsonProperty(PropertyName = "nodeLabels")]
        public IDictionary<string, string> NodeLabels { get; set; }

        /// <summary>
        /// Gets or sets the taints added to new nodes during node pool create
        /// and scale. For example, key=value:NoSchedule.
        /// </summary>
        [JsonProperty(PropertyName = "nodeTaints")]
        public IList<string> NodeTaints { get; set; }

        /// <summary>
        /// Gets or sets the ID for Proximity Placement Group.
        /// </summary>
        [JsonProperty(PropertyName = "proximityPlacementGroupID")]
        public string ProximityPlacementGroupID { get; set; }

        /// <summary>
        /// Gets or sets the Kubelet configuration on the agent pool nodes.
        /// </summary>
        [JsonProperty(PropertyName = "kubeletConfig")]
        public KubeletConfig KubeletConfig { get; set; }

        /// <summary>
        /// Gets or sets the OS configuration of Linux agent nodes.
        /// </summary>
        [JsonProperty(PropertyName = "linuxOSConfig")]
        public LinuxOSConfig LinuxOSConfig { get; set; }

        /// <summary>
        /// Gets or sets whether to enable host based OS and data drive
        /// encryption.
        /// </summary>
        /// <remarks>
        /// This is only supported on certain VM sizes and in certain Azure
        /// regions. For more information, see:
        /// https://learn.microsoft.com/azure/aks/enable-host-encryption
        /// </remarks>
        [JsonProperty(PropertyName = "enableEncryptionAtHost")]
        public bool? EnableEncryptionAtHost { get; set; }

        /// <summary>
        /// Gets or sets whether to enable UltraSSD
        /// </summary>
        [JsonProperty(PropertyName = "enableUltraSSD")]
        public bool? EnableUltraSSD { get; set; }

        /// <summary>
        /// Gets or sets whether to use a FIPS-enabled OS.
        /// </summary>
        /// <remarks>
        /// See [Add a FIPS-enabled node
        /// pool](https://learn.microsoft.com/azure/aks/use-multiple-node-pools#add-a-fips-enabled-node-pool-preview)
        /// for more details.
        /// </remarks>
        [JsonProperty(PropertyName = "enableFIPS")]
        public bool? EnableFIPS { get; set; }

        /// <summary>
        /// Gets or sets gPUInstanceProfile to be used to specify GPU MIG
        /// instance profile for supported GPU VM SKU. Possible values include:
        /// 'MIG1g', 'MIG2g', 'MIG3g', 'MIG4g', 'MIG7g'
        /// </summary>
        [JsonProperty(PropertyName = "gpuInstanceProfile")]
        public string GpuInstanceProfile { get; set; }

        /// <summary>
        /// Gets or sets creationData to be used to specify the source Snapshot
        /// ID if the node pool will be created/upgraded using a snapshot.
        /// </summary>
        [JsonProperty(PropertyName = "creationData")]
        public CreationData CreationData { get; set; }

        /// <summary>
        /// Gets or sets the fully qualified resource ID of the Dedicated Host
        /// Group to provision virtual machines from, used only in creation
        /// scenario and not allowed to changed once set.
        /// </summary>
        /// <remarks>
        /// This is of the form:
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
        /// For more information see [Azure dedicated
        /// hosts](https://learn.microsoft.com/azure/virtual-machines/dedicated-hosts).
        /// </remarks>
        [JsonProperty(PropertyName = "hostGroupID")]
        public string HostGroupID { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KubeletConfig != null)
            {
                KubeletConfig.Validate();
            }
        }
    }
}
