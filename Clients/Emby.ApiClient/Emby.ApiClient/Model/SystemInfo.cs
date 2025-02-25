// <copyright file="SystemInfo.cs" company="Emby LLC">
// Emby.ApiClient. Autogenerated Code. No license applied. 
// </copyright>
// <autogenerated />
namespace Emby.ApiClient.Model
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Text;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class SystemInfo  .
    /// </summary>
    /// <seealso>MediaBrowser.Model.System.SystemInfo</seealso>
    public partial class SystemInfo :  IEquatable<SystemInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfo" /> class.
        /// </summary>
        public SystemInfo()
        {
        }
        
        /// <summary>
        /// Gets or Sets SystemUpdateLevel
        /// </summary>
        /// <value>The SystemUpdateLevel.</value>
        public PackageVersionClass SystemUpdateLevel { get; set; }

        /// <summary>
        /// The display name of the operating system.
        /// </summary>
        /// <value>The OperatingSystemDisplayName.</value>
        public string OperatingSystemDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets PackageName
        /// </summary>
        /// <value>The PackageName.</value>
        public string PackageName { get; set; }

        /// <summary>
        /// A value indicating whether this instance has pending restart.
        /// </summary>
        /// <value>The HasPendingRestart.</value>
        public bool? HasPendingRestart { get; set; }

        /// <summary>
        /// Gets or Sets IsShuttingDown
        /// </summary>
        /// <value>The IsShuttingDown.</value>
        public bool? IsShuttingDown { get; set; }

        /// <summary>
        /// Gets or Sets HasImageEnhancers
        /// </summary>
        /// <value>The HasImageEnhancers.</value>
        public bool? HasImageEnhancers { get; set; }

        /// <summary>
        /// The operating sytem.
        /// </summary>
        /// <value>The OperatingSystem.</value>
        public string OperatingSystem { get; set; }

        /// <summary>
        /// A value indicating whether \\[supports library monitor\\].
        /// </summary>
        /// <value>The SupportsLibraryMonitor.</value>
        public bool? SupportsLibraryMonitor { get; set; }

        /// <summary>
        /// Gets or Sets SupportsLocalPortConfiguration
        /// </summary>
        /// <value>The SupportsLocalPortConfiguration.</value>
        public bool? SupportsLocalPortConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets SupportsWakeServer
        /// </summary>
        /// <value>The SupportsWakeServer.</value>
        public bool? SupportsWakeServer { get; set; }

        /// <summary>
        /// The web socket port number.
        /// </summary>
        /// <value>The WebSocketPortNumber.</value>
        public int? WebSocketPortNumber { get; set; }

        /// <summary>
        /// The completed installations.
        /// </summary>
        /// <value>The CompletedInstallations.</value>
        public List<InstallationInfo> CompletedInstallations { get; set; }

        /// <summary>
        /// A value indicating whether this instance can self restart.
        /// </summary>
        /// <value>The CanSelfRestart.</value>
        public bool? CanSelfRestart { get; set; }

        /// <summary>
        /// A value indicating whether this instance can self update.
        /// </summary>
        /// <value>The CanSelfUpdate.</value>
        public bool? CanSelfUpdate { get; set; }

        /// <summary>
        /// Gets or Sets CanLaunchWebBrowser
        /// </summary>
        /// <value>The CanLaunchWebBrowser.</value>
        public bool? CanLaunchWebBrowser { get; set; }

        /// <summary>
        /// The program data path.
        /// </summary>
        /// <value>The ProgramDataPath.</value>
        public string ProgramDataPath { get; set; }

        /// <summary>
        /// The items by name path.
        /// </summary>
        /// <value>The ItemsByNamePath.</value>
        public string ItemsByNamePath { get; set; }

        /// <summary>
        /// The cache path.
        /// </summary>
        /// <value>The CachePath.</value>
        public string CachePath { get; set; }

        /// <summary>
        /// The log path.
        /// </summary>
        /// <value>The LogPath.</value>
        public string LogPath { get; set; }

        /// <summary>
        /// The internal metadata path.
        /// </summary>
        /// <value>The InternalMetadataPath.</value>
        public string InternalMetadataPath { get; set; }

        /// <summary>
        /// The transcoding temporary path.
        /// </summary>
        /// <value>The TranscodingTempPath.</value>
        public string TranscodingTempPath { get; set; }

        /// <summary>
        /// The HTTP server port number.
        /// </summary>
        /// <value>The HttpServerPortNumber.</value>
        public int? HttpServerPortNumber { get; set; }

        /// <summary>
        /// A value indicating whether \\[enable HTTPS\\].
        /// </summary>
        /// <value>The SupportsHttps.</value>
        public bool? SupportsHttps { get; set; }

        /// <summary>
        /// The HTTPS server port number.
        /// </summary>
        /// <value>The HttpsPortNumber.</value>
        public int? HttpsPortNumber { get; set; }

        /// <summary>
        /// A value indicating whether this instance has update available.
        /// </summary>
        /// <value>The HasUpdateAvailable.</value>
        public bool? HasUpdateAvailable { get; set; }

        /// <summary>
        /// A value indicating whether \\[supports automatic run at startup\\].
        /// </summary>
        /// <value>The SupportsAutoRunAtStartup.</value>
        public bool? SupportsAutoRunAtStartup { get; set; }

        /// <summary>
        /// Gets or Sets HardwareAccelerationRequiresPremiere
        /// </summary>
        /// <value>The HardwareAccelerationRequiresPremiere.</value>
        public bool? HardwareAccelerationRequiresPremiere { get; set; }

        /// <summary>
        /// Gets or Sets WakeOnLanInfo
        /// </summary>
        /// <value>The WakeOnLanInfo.</value>
        public List<WakeOnLanInfo> WakeOnLanInfo { get; set; }

        /// <summary>
        /// The local address.
        /// </summary>
        /// <value>The LocalAddress.</value>
        public string LocalAddress { get; set; }

        /// <summary>
        /// Gets or Sets LocalAddresses
        /// </summary>
        /// <value>The LocalAddresses.</value>
        public List<string> LocalAddresses { get; set; }

        /// <summary>
        /// The wan address.
        /// </summary>
        /// <value>The WanAddress.</value>
        public string WanAddress { get; set; }

        /// <summary>
        /// Gets or Sets RemoteAddresses
        /// </summary>
        /// <value>The RemoteAddresses.</value>
        public List<string> RemoteAddresses { get; set; }

        /// <summary>
        /// The name of the server.
        /// </summary>
        /// <value>The ServerName.</value>
        public string ServerName { get; set; }

        /// <summary>
        /// The version.
        /// </summary>
        /// <value>The Version.</value>
        public string Version { get; set; }

        /// <summary>
        /// The id.
        /// </summary>
        /// <value>The Id.</value>
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemInfo {\n");
            sb.Append("  SystemUpdateLevel: ").Append(SystemUpdateLevel).Append("\n");
            sb.Append("  OperatingSystemDisplayName: ").Append(OperatingSystemDisplayName).Append("\n");
            sb.Append("  PackageName: ").Append(PackageName).Append("\n");
            sb.Append("  HasPendingRestart: ").Append(HasPendingRestart).Append("\n");
            sb.Append("  IsShuttingDown: ").Append(IsShuttingDown).Append("\n");
            sb.Append("  HasImageEnhancers: ").Append(HasImageEnhancers).Append("\n");
            sb.Append("  OperatingSystem: ").Append(OperatingSystem).Append("\n");
            sb.Append("  SupportsLibraryMonitor: ").Append(SupportsLibraryMonitor).Append("\n");
            sb.Append("  SupportsLocalPortConfiguration: ").Append(SupportsLocalPortConfiguration).Append("\n");
            sb.Append("  SupportsWakeServer: ").Append(SupportsWakeServer).Append("\n");
            sb.Append("  WebSocketPortNumber: ").Append(WebSocketPortNumber).Append("\n");
            sb.Append("  CompletedInstallations: ").Append(CompletedInstallations).Append("\n");
            sb.Append("  CanSelfRestart: ").Append(CanSelfRestart).Append("\n");
            sb.Append("  CanSelfUpdate: ").Append(CanSelfUpdate).Append("\n");
            sb.Append("  CanLaunchWebBrowser: ").Append(CanLaunchWebBrowser).Append("\n");
            sb.Append("  ProgramDataPath: ").Append(ProgramDataPath).Append("\n");
            sb.Append("  ItemsByNamePath: ").Append(ItemsByNamePath).Append("\n");
            sb.Append("  CachePath: ").Append(CachePath).Append("\n");
            sb.Append("  LogPath: ").Append(LogPath).Append("\n");
            sb.Append("  InternalMetadataPath: ").Append(InternalMetadataPath).Append("\n");
            sb.Append("  TranscodingTempPath: ").Append(TranscodingTempPath).Append("\n");
            sb.Append("  HttpServerPortNumber: ").Append(HttpServerPortNumber).Append("\n");
            sb.Append("  SupportsHttps: ").Append(SupportsHttps).Append("\n");
            sb.Append("  HttpsPortNumber: ").Append(HttpsPortNumber).Append("\n");
            sb.Append("  HasUpdateAvailable: ").Append(HasUpdateAvailable).Append("\n");
            sb.Append("  SupportsAutoRunAtStartup: ").Append(SupportsAutoRunAtStartup).Append("\n");
            sb.Append("  HardwareAccelerationRequiresPremiere: ").Append(HardwareAccelerationRequiresPremiere).Append("\n");
            sb.Append("  WakeOnLanInfo: ").Append(WakeOnLanInfo).Append("\n");
            sb.Append("  LocalAddress: ").Append(LocalAddress).Append("\n");
            sb.Append("  LocalAddresses: ").Append(LocalAddresses).Append("\n");
            sb.Append("  WanAddress: ").Append(WanAddress).Append("\n");
            sb.Append("  RemoteAddresses: ").Append(RemoteAddresses).Append("\n");
            sb.Append("  ServerName: ").Append(ServerName).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SystemInfo);
        }

        /// <summary>
        /// Returns true if SystemInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SystemUpdateLevel == input.SystemUpdateLevel ||
                    (this.SystemUpdateLevel != null &&
                    this.SystemUpdateLevel.Equals(input.SystemUpdateLevel))
                ) && 
                (
                    this.OperatingSystemDisplayName == input.OperatingSystemDisplayName ||
                    (this.OperatingSystemDisplayName != null &&
                    this.OperatingSystemDisplayName.Equals(input.OperatingSystemDisplayName))
                ) && 
                (
                    this.PackageName == input.PackageName ||
                    (this.PackageName != null &&
                    this.PackageName.Equals(input.PackageName))
                ) && 
                (
                    this.HasPendingRestart == input.HasPendingRestart ||
                    (this.HasPendingRestart != null &&
                    this.HasPendingRestart.Equals(input.HasPendingRestart))
                ) && 
                (
                    this.IsShuttingDown == input.IsShuttingDown ||
                    (this.IsShuttingDown != null &&
                    this.IsShuttingDown.Equals(input.IsShuttingDown))
                ) && 
                (
                    this.HasImageEnhancers == input.HasImageEnhancers ||
                    (this.HasImageEnhancers != null &&
                    this.HasImageEnhancers.Equals(input.HasImageEnhancers))
                ) && 
                (
                    this.OperatingSystem == input.OperatingSystem ||
                    (this.OperatingSystem != null &&
                    this.OperatingSystem.Equals(input.OperatingSystem))
                ) && 
                (
                    this.SupportsLibraryMonitor == input.SupportsLibraryMonitor ||
                    (this.SupportsLibraryMonitor != null &&
                    this.SupportsLibraryMonitor.Equals(input.SupportsLibraryMonitor))
                ) && 
                (
                    this.SupportsLocalPortConfiguration == input.SupportsLocalPortConfiguration ||
                    (this.SupportsLocalPortConfiguration != null &&
                    this.SupportsLocalPortConfiguration.Equals(input.SupportsLocalPortConfiguration))
                ) && 
                (
                    this.SupportsWakeServer == input.SupportsWakeServer ||
                    (this.SupportsWakeServer != null &&
                    this.SupportsWakeServer.Equals(input.SupportsWakeServer))
                ) && 
                (
                    this.WebSocketPortNumber == input.WebSocketPortNumber ||
                    (this.WebSocketPortNumber != null &&
                    this.WebSocketPortNumber.Equals(input.WebSocketPortNumber))
                ) && 
                (
                    this.CompletedInstallations == input.CompletedInstallations ||
                    this.CompletedInstallations != null &&
                    input.CompletedInstallations != null &&
                    this.CompletedInstallations.SequenceEqual(input.CompletedInstallations)
                ) && 
                (
                    this.CanSelfRestart == input.CanSelfRestart ||
                    (this.CanSelfRestart != null &&
                    this.CanSelfRestart.Equals(input.CanSelfRestart))
                ) && 
                (
                    this.CanSelfUpdate == input.CanSelfUpdate ||
                    (this.CanSelfUpdate != null &&
                    this.CanSelfUpdate.Equals(input.CanSelfUpdate))
                ) && 
                (
                    this.CanLaunchWebBrowser == input.CanLaunchWebBrowser ||
                    (this.CanLaunchWebBrowser != null &&
                    this.CanLaunchWebBrowser.Equals(input.CanLaunchWebBrowser))
                ) && 
                (
                    this.ProgramDataPath == input.ProgramDataPath ||
                    (this.ProgramDataPath != null &&
                    this.ProgramDataPath.Equals(input.ProgramDataPath))
                ) && 
                (
                    this.ItemsByNamePath == input.ItemsByNamePath ||
                    (this.ItemsByNamePath != null &&
                    this.ItemsByNamePath.Equals(input.ItemsByNamePath))
                ) && 
                (
                    this.CachePath == input.CachePath ||
                    (this.CachePath != null &&
                    this.CachePath.Equals(input.CachePath))
                ) && 
                (
                    this.LogPath == input.LogPath ||
                    (this.LogPath != null &&
                    this.LogPath.Equals(input.LogPath))
                ) && 
                (
                    this.InternalMetadataPath == input.InternalMetadataPath ||
                    (this.InternalMetadataPath != null &&
                    this.InternalMetadataPath.Equals(input.InternalMetadataPath))
                ) && 
                (
                    this.TranscodingTempPath == input.TranscodingTempPath ||
                    (this.TranscodingTempPath != null &&
                    this.TranscodingTempPath.Equals(input.TranscodingTempPath))
                ) && 
                (
                    this.HttpServerPortNumber == input.HttpServerPortNumber ||
                    (this.HttpServerPortNumber != null &&
                    this.HttpServerPortNumber.Equals(input.HttpServerPortNumber))
                ) && 
                (
                    this.SupportsHttps == input.SupportsHttps ||
                    (this.SupportsHttps != null &&
                    this.SupportsHttps.Equals(input.SupportsHttps))
                ) && 
                (
                    this.HttpsPortNumber == input.HttpsPortNumber ||
                    (this.HttpsPortNumber != null &&
                    this.HttpsPortNumber.Equals(input.HttpsPortNumber))
                ) && 
                (
                    this.HasUpdateAvailable == input.HasUpdateAvailable ||
                    (this.HasUpdateAvailable != null &&
                    this.HasUpdateAvailable.Equals(input.HasUpdateAvailable))
                ) && 
                (
                    this.SupportsAutoRunAtStartup == input.SupportsAutoRunAtStartup ||
                    (this.SupportsAutoRunAtStartup != null &&
                    this.SupportsAutoRunAtStartup.Equals(input.SupportsAutoRunAtStartup))
                ) && 
                (
                    this.HardwareAccelerationRequiresPremiere == input.HardwareAccelerationRequiresPremiere ||
                    (this.HardwareAccelerationRequiresPremiere != null &&
                    this.HardwareAccelerationRequiresPremiere.Equals(input.HardwareAccelerationRequiresPremiere))
                ) && 
                (
                    this.WakeOnLanInfo == input.WakeOnLanInfo ||
                    this.WakeOnLanInfo != null &&
                    input.WakeOnLanInfo != null &&
                    this.WakeOnLanInfo.SequenceEqual(input.WakeOnLanInfo)
                ) && 
                (
                    this.LocalAddress == input.LocalAddress ||
                    (this.LocalAddress != null &&
                    this.LocalAddress.Equals(input.LocalAddress))
                ) && 
                (
                    this.LocalAddresses == input.LocalAddresses ||
                    this.LocalAddresses != null &&
                    input.LocalAddresses != null &&
                    this.LocalAddresses.SequenceEqual(input.LocalAddresses)
                ) && 
                (
                    this.WanAddress == input.WanAddress ||
                    (this.WanAddress != null &&
                    this.WanAddress.Equals(input.WanAddress))
                ) && 
                (
                    this.RemoteAddresses == input.RemoteAddresses ||
                    this.RemoteAddresses != null &&
                    input.RemoteAddresses != null &&
                    this.RemoteAddresses.SequenceEqual(input.RemoteAddresses)
                ) && 
                (
                    this.ServerName == input.ServerName ||
                    (this.ServerName != null &&
                    this.ServerName.Equals(input.ServerName))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SystemUpdateLevel != null)
                    hashCode = hashCode * 59 + this.SystemUpdateLevel.GetHashCode();
                if (this.OperatingSystemDisplayName != null)
                    hashCode = hashCode * 59 + this.OperatingSystemDisplayName.GetHashCode();
                if (this.PackageName != null)
                    hashCode = hashCode * 59 + this.PackageName.GetHashCode();
                if (this.HasPendingRestart != null)
                    hashCode = hashCode * 59 + this.HasPendingRestart.GetHashCode();
                if (this.IsShuttingDown != null)
                    hashCode = hashCode * 59 + this.IsShuttingDown.GetHashCode();
                if (this.HasImageEnhancers != null)
                    hashCode = hashCode * 59 + this.HasImageEnhancers.GetHashCode();
                if (this.OperatingSystem != null)
                    hashCode = hashCode * 59 + this.OperatingSystem.GetHashCode();
                if (this.SupportsLibraryMonitor != null)
                    hashCode = hashCode * 59 + this.SupportsLibraryMonitor.GetHashCode();
                if (this.SupportsLocalPortConfiguration != null)
                    hashCode = hashCode * 59 + this.SupportsLocalPortConfiguration.GetHashCode();
                if (this.SupportsWakeServer != null)
                    hashCode = hashCode * 59 + this.SupportsWakeServer.GetHashCode();
                if (this.WebSocketPortNumber != null)
                    hashCode = hashCode * 59 + this.WebSocketPortNumber.GetHashCode();
                if (this.CompletedInstallations != null)
                    hashCode = hashCode * 59 + this.CompletedInstallations.GetHashCode();
                if (this.CanSelfRestart != null)
                    hashCode = hashCode * 59 + this.CanSelfRestart.GetHashCode();
                if (this.CanSelfUpdate != null)
                    hashCode = hashCode * 59 + this.CanSelfUpdate.GetHashCode();
                if (this.CanLaunchWebBrowser != null)
                    hashCode = hashCode * 59 + this.CanLaunchWebBrowser.GetHashCode();
                if (this.ProgramDataPath != null)
                    hashCode = hashCode * 59 + this.ProgramDataPath.GetHashCode();
                if (this.ItemsByNamePath != null)
                    hashCode = hashCode * 59 + this.ItemsByNamePath.GetHashCode();
                if (this.CachePath != null)
                    hashCode = hashCode * 59 + this.CachePath.GetHashCode();
                if (this.LogPath != null)
                    hashCode = hashCode * 59 + this.LogPath.GetHashCode();
                if (this.InternalMetadataPath != null)
                    hashCode = hashCode * 59 + this.InternalMetadataPath.GetHashCode();
                if (this.TranscodingTempPath != null)
                    hashCode = hashCode * 59 + this.TranscodingTempPath.GetHashCode();
                if (this.HttpServerPortNumber != null)
                    hashCode = hashCode * 59 + this.HttpServerPortNumber.GetHashCode();
                if (this.SupportsHttps != null)
                    hashCode = hashCode * 59 + this.SupportsHttps.GetHashCode();
                if (this.HttpsPortNumber != null)
                    hashCode = hashCode * 59 + this.HttpsPortNumber.GetHashCode();
                if (this.HasUpdateAvailable != null)
                    hashCode = hashCode * 59 + this.HasUpdateAvailable.GetHashCode();
                if (this.SupportsAutoRunAtStartup != null)
                    hashCode = hashCode * 59 + this.SupportsAutoRunAtStartup.GetHashCode();
                if (this.HardwareAccelerationRequiresPremiere != null)
                    hashCode = hashCode * 59 + this.HardwareAccelerationRequiresPremiere.GetHashCode();
                if (this.WakeOnLanInfo != null)
                    hashCode = hashCode * 59 + this.WakeOnLanInfo.GetHashCode();
                if (this.LocalAddress != null)
                    hashCode = hashCode * 59 + this.LocalAddress.GetHashCode();
                if (this.LocalAddresses != null)
                    hashCode = hashCode * 59 + this.LocalAddresses.GetHashCode();
                if (this.WanAddress != null)
                    hashCode = hashCode * 59 + this.WanAddress.GetHashCode();
                if (this.RemoteAddresses != null)
                    hashCode = hashCode * 59 + this.RemoteAddresses.GetHashCode();
                if (this.ServerName != null)
                    hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }
}