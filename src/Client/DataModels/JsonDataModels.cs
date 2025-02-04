﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace dotMorten.Unifi.Protect.DataModels
{
    // TODO: Most of these classes are autogenerated, and needs some clean up and merging - properties of type object needs proper models

    public class Motion
    {
        public int Today { get; set; }
        public int Average { get; set; }
        public List<int> LastDays { get; set; }
        public List<int> RecentHours { get; set; }
    }

    public class Smart
    {
        public int Today { get; set; }
        public int Average { get; set; }
        public List<int> LastDays { get; set; }
    }

    public class EventStats
    {
        public Motion Motion { get; set; }
        public Smart Smart { get; set; }
    }

    public class WiredConnectionState
    {
        public int? PhyRate { get; set; }
    }

    public class Channel
    {
        public int Id { get; set; }
        public string VideoId { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
        public bool IsRtspEnabled { get; set; }
        public string RtspAlias { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Fps { get; set; }
        public int Bitrate { get; set; }
        public int MinBitrate { get; set; }
        public int MaxBitrate { get; set; }
        public int MinClientAdaptiveBitRate { get; set; }
        public int MinMotionAdaptiveBitRate { get; set; }
        public List<int> FpsValues { get; set; }
        public int IdrInterval { get; set; }
    }

    public class IspSettings
    {
        public string AEMode { get; set; }
        public string IRLedMode { get; set; }
        public int IRLedLevel { get; set; }
        public int Wdr { get; set; }
        public int IcrSensitivity { get; set; }
        public int Brightness { get; set; }
        public int Contrast { get; set; }
        public int Hue { get; set; }
        public int Saturation { get; set; }
        public int Sharpness { get; set; }
        public int Denoise { get; set; }
        public bool IsFlippedVertical { get; set; }
        public bool IsFlippedHorizontal { get; set; }
        public bool IsAutoRotateEnabled { get; set; }
        public bool IsLdcEnabled { get; set; }
        public bool Is3dnrEnabled { get; set; }
        public bool IsExternalIrEnabled { get; set; }
        public bool IsAggressiveAntiFlickerEnabled { get; set; }
        public bool IsPauseMotionEnabled { get; set; }
        public int DZoomCenterX { get; set; }
        public int DZoomCenterY { get; set; }
        public int DZoomScale { get; set; }
        public int DZoomStreamId { get; set; }
        public string FocusMode { get; set; }
        public int FocusPosition { get; set; }
        public int? TouchFocusX { get; set; }
        public int? TouchFocusY { get; set; }
        public int ZoomPosition { get; set; }
    }

    public class TalkbackSettings
    {
        public string TypeFmt { get; set; }
        public string TypeIn { get; set; }
        public string BindAddr { get; set; }
        public int BindPort { get; set; }
        public string FilterAddr { get; set; }
        public int? FilterPort { get; set; }
        public int Channels { get; set; }
        public int SamplingRate { get; set; }
        public int BitsPerSample { get; set; }
        public int Quality { get; set; }
    }

    public class OsdSettings
    {
        public bool IsNameEnabled { get; set; }
        public bool IsDateEnabled { get; set; }
        public bool IsLogoEnabled { get; set; }
        public bool IsDebugEnabled { get; set; }
    }

    public class LedSettings
    {
        public bool IsEnabled { get; set; }
        public int BlinkRate { get; set; }
    }

    public class SpeakerSettings
    {
        public bool IsEnabled { get; set; }
        public bool AreSystemSoundsEnabled { get; set; }
        public int Volume { get; set; }
    }

    public class RecordingSettings
    {
        public int PrePaddingSecs { get; set; }
        public int PostPaddingSecs { get; set; }
        public int MinMotionEventTrigger { get; set; }
        public int EndMotionEventDelay { get; set; }
        public bool SuppressIlluminationSurge { get; set; }
        public string Mode { get; set; }
        public string Geofencing { get; set; }
        public string MotionAlgorithm { get; set; }
        public bool EnablePirTimelapse { get; set; }
        public bool UseNewMotionAlgorithm { get; set; }
        public object RetentionDurationMs { get; set; }
    }

    public class SmartDetectSettings
    {
        public List<string> ObjectTypes { get; set; }
    }

    public class MotionZone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public List<List<double>> Points { get; set; }
        public int Sensitivity { get; set; }
    }

    public class PrivacyZone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public List<List<double>> Points { get; set; }
    }

    public class SmartDetectZone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public List<List<double>> Points { get; set; }
        public int Sensitivity { get; set; }
        public List<string> ObjectTypes { get; set; }
    }

    public class Wifi
    {
        public int? Channel { get; set; }
        public int? Frequency { get; set; }
        public int? LinkSpeedMbps { get; set; }
        public int SignalQuality { get; set; }
        public int SignalStrength { get; set; }
    }

    public class Battery
    {
        public object Percentage { get; set; }
        public bool IsCharging { get; set; }
        public string SleepState { get; set; }
    }

    public class Video
    {
        public object RecordingStart { get; set; }
        public object RecordingEnd { get; set; }
        public object RecordingStartLQ { get; set; }
        public object RecordingEndLQ { get; set; }
        public object TimelapseStart { get; set; }
        public object TimelapseEnd { get; set; }
        public object TimelapseStartLQ { get; set; }
        public object TimelapseEndLQ { get; set; }
    }

    public class Storage
    {
        public long Used { get; set; }
        public double Rate { get; set; }
        public long Available { get; set; }
        public bool IsRecycling { get; set; }
        public long Size { get; set; }
        public string Type { get; set; }
        public List<Device> Devices { get; set; }
    }

    public class Stats
    {
        public long RxBytes { get; set; }
        public long TxBytes { get; set; }
        public Wifi WiFi { get; set; }
        public Battery Battery { get; set; }
        public Video Video { get; set; }
        public Storage Storage { get; set; }
        public int WiFiQuality { get; set; }
        public int WiFiStrength { get; set; }
    }

    public class PrivacyMaskCapability
    {
        public int MaxMasks { get; set; }
        public bool RectangleOnly { get; set; }
    }

    public class Steps
    {
        public object Max { get; set; }
        public object Min { get; set; }
        public object Step { get; set; }
    }

    public class Degrees
    {
        public object Max { get; set; }
        public object Min { get; set; }
        public object Step { get; set; }
    }

    public class Focus
    {
        public Steps Steps { get; set; }
        public Degrees Degrees { get; set; }
    }

    public class Pan
    {
        public Steps Steps { get; set; }
        public Degrees Degrees { get; set; }
    }

    public class Tilt
    {
        public Steps Steps { get; set; }
        public Degrees Degrees { get; set; }
    }

    public class Zoom
    {
        public Steps Steps { get; set; }
        public Degrees Degrees { get; set; }
    }

    public class FeatureFlags
    {
        public bool CanAdjustIrLedLevel { get; set; }
        public bool CanMagicZoom { get; set; }
        public bool CanOpticalZoom { get; set; }
        public bool CanTouchFocus { get; set; }
        public bool HasAccelerometer { get; set; }
        public bool HasAec { get; set; }
        public bool HasBattery { get; set; }
        public bool HasBluetooth { get; set; }
        public bool HasChime { get; set; }
        public bool HasExternalIr { get; set; }
        public bool HasIcrSensitivity { get; set; }
        public bool HasLdc { get; set; }
        public bool HasLedIr { get; set; }
        public bool HasLedStatus { get; set; }
        public bool HasLineIn { get; set; }
        public bool HasMic { get; set; }
        public bool HasPrivacyMask { get; set; }
        public bool HasRtc { get; set; }
        public bool HasSdCard { get; set; }
        public bool HasSpeaker { get; set; }
        public bool HasWifi { get; set; }
        public bool HasHdr { get; set; }
        public bool HasAutoICROnly { get; set; }
        public List<string> VideoModes { get; set; }
        public List<int> VideoModeMaxFps { get; set; }
        public bool HasMotionZones { get; set; }
        public bool HasLcdScreen { get; set; }
        public List<string> SmartDetectTypes { get; set; }
        public List<string> MotionAlgorithms { get; set; }
        public PrivacyMaskCapability PrivacyMaskCapability { get; set; }
        public Focus Focus { get; set; }
        public Pan Pan { get; set; }
        public Tilt Tilt { get; set; }
        public Zoom Zoom { get; set; }
        public bool HasSmartDetect { get; set; }
        public bool Beta { get; set; }
        public bool Dev { get; set; }
    }

    public class PirSettings
    {
        public int PirSensitivity { get; set; }
        public int PirMotionClipLength { get; set; }
        public int TimelapseFrameInterval { get; set; }
        public int TimelapseTransferInterval { get; set; }
    }

    public class LcdMessage
    {
        public string Type { get; set; }
        public string Text { get; set; }
        public object ResetAt { get; set; }
    }

    public class WifiConnectionState
    {
        public int? Channel { get; set; }
        public int? Frequency { get; set; }
        public int? PhyRate { get; set; }
        public int? SignalQuality { get; set; }
        public int? SignalStrength { get; set; }
    }

    public class Camera : ProtectNetworkDevice
    {
        public bool IsDeleting { get; set; }
        public string ConnectionHost { get; set; }
        public string Type { get; set; }
        public long? UpSince { get; set; }
        public object LastSeen { get; set; }
        public object ConnectedSince { get; set; }
        public string State { get; set; }
        public string HardwareRevision { get; set; }
        public string FirmwareVersion { get; set; }
        public string LatestFirmwareVersion { get; set; }
        public string FirmwareBuild { get; set; }
        public bool IsUpdating { get; set; }
        public bool IsAdopting { get; set; }
        public bool IsAdopted { get; set; }
        public bool IsAdoptedByOther { get; set; }
        public bool IsProvisioned { get; set; }
        public bool IsRebooting { get; set; }
        public bool? IsSshEnabled { get; set; }
        public bool CanAdopt { get; set; }
        public bool IsAttemptingToConnect { get; set; }
        public object LastMotion { get; set; }
        public int MicVolume { get; set; }
        public bool IsMicEnabled { get; set; }
        public bool IsRecording { get; set; }
        public bool IsMotionDetected { get; set; }
        public int PhyRate { get; set; }
        public bool? HdrMode { get; set; }
        public string VideoMode { get; set; }
        public bool IsProbingForWifi { get; set; }
        public object APMac { get; set; }
        public object APRssi { get; set; }
        public object ElementInfo { get; set; }
        public int ChimeDuration { get; set; }
        public bool IsDark { get; set; }
        public object LastPrivacyZonePositionId { get; set; }
        public long? LastRing { get; set; }
        public bool IsLiveHeatmapEnabled { get; set; }
        public string AnonymousDeviceId { get; set; }
        public EventStats EventStats { get; set; }
        public WiredConnectionState WiredConnectionState { get; set; }
        public List<Channel> Channels { get; set; }
        public IspSettings IspSettings { get; set; }
        public TalkbackSettings TalkbackSettings { get; set; }
        public OsdSettings OsdSettings { get; set; }
        public LedSettings LedSettings { get; set; }
        public SpeakerSettings SpeakerSettings { get; set; }
        public RecordingSettings RecordingSettings { get; set; }
        public SmartDetectSettings SmartDetectSettings { get; set; }
        public object RecordingSchedule { get; set; }
        public List<MotionZone> MotionZones { get; set; }
        public List<PrivacyZone> PrivacyZones { get; set; }
        public List<SmartDetectZone> SmartDetectZones { get; set; }
        public List<object> SmartDetectLines { get; set; }
        public Stats Stats { get; set; }
        public FeatureFlags FeatureFlags { get; set; }
        public PirSettings PirSettings { get; set; }
        public LcdMessage LcdMessage { get; set; }
        public WifiConnectionState WiFiConnectionState { get; set; }
        public bool IsConnected { get; set; }
        public string Platform { get; set; }
        public bool HasSpeaker { get; set; }
        public bool HasWifi { get; set; }
        public int AudioBitrate { get; set; }
        public bool CanManage { get; set; }
        public bool IsManaged { get; set; }
        public List<string> ConnectDisconnect { get; set; }
        public List<string> Motion { get; set; }
        public string camera { get; set; }
        public List<string> Ring { get; set; }
        public override string ToString() => $"{Name} - {Type} ({Id})";
    }

    public class Flags
    {
    }

    public class Web
    {
        [JsonProperty("liveview.includeGlobal")]
        public bool LiveViewIncludeGlobal { get; set; }

        [JsonProperty("elements.viewmode")]
        public string ElementsViewmode { get; set; }
    }

    public class Settings
    {
        public Flags Flags { get; set; }
        public Web Web { get; set; }
        public List<string> CameraOrder { get; set; }
    }

    public class Location
    {
        public bool IsAway { get; set; }
        public long HomeAwaySince { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string ModelKey { get; set; }
    }

    public class Schedule
    {
        public List<object> Items { get; set; }
    }

    public class System
    {
        public List<object> ConnectDisconnect { get; set; }
        public List<object> Update { get; set; }
    }

    public class UserAccount : ProtectDevice
    {
        public List<object> Arrive { get; set; }
        public List<object> Depart { get; set; }
        public string User { get; set; }
        public List<string> Permissions { get; set; }
        public string LastLoginIp { get; set; }
        public long? LastLoginTime { get; set; }
        public bool IsOwner { get; set; }
        public bool EnableNotifications { get; set; }
        public Settings Settings { get; set; }
        public List<string> Groups { get; set; }
        public Location Location { get; set; }
        public List<AlertRule> AlertRules { get; set; }
        public bool HasAcceptedInvite { get; set; }
        public List<string> AllPermissions { get; set; }
        public CloudAccount CloudAccount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string LocalUsername { get; set; }
    }

    public class AlertRule
    {
        public string Id { get; set; }
        public string Mame { get; set; }
        public string When { get; set; }
        public Schedule Schedule { get; set; }
        public System System { get; set; }
        public List<Camera> Cameras { get; set; }
        public List<UserAccount> Users { get; set; }
        public string Geofencing { get; set; }
    }

    public class CloudAccount : ProtectDevice
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public object ProfileImg { get; set; }
        public string User { get; set; }
        public string CloudId { get; set; }
        public Location Location { get; set; }
    }

    public class Group : ProtectDevice
    {
        public List<string> Permissions { get; set; }
        public string Type { get; set; }
        public bool IsDefault { get; set; }
    }

    public class Slot
    {
        public List<string> Cameras { get; set; }
        public string CycleMode { get; set; }
        public int CycleInterval { get; set; }
    }

    public class LiveView : ProtectDevice
    {
        public bool IsDefault { get; set; }
        public bool IsGlobal { get; set; }
        public int Layout { get; set; }
        public List<Slot> Slots { get; set; }
        public string Owner { get; set; }
    }

    public class Ports
    {
        public int Ump { get; set; }
        public int Http { get; set; }
        public int Https { get; set; }
        public int Rtsp { get; set; }
        public int Rtsps { get; set; }
        public int Rtmp { get; set; }
        public int DevicesWss { get; set; }
        public int CameraHttps { get; set; }
        public int CameraTcp { get; set; }
        public int LiveWs { get; set; }
        public int LiveWss { get; set; }
        public int TcpStreams { get; set; }
        public int Playback { get; set; }
        public int EmsCLI { get; set; }
        public int EmsLiveFLV { get; set; }
        public int CameraEvents { get; set; }
        public int TcpBridge { get; set; }
        public int Ucore { get; set; }
        public int DiscoveryClient { get; set; }
    }

    public class WifiSettings
    {
        public bool UseThirdPartyWifi { get; set; }
        public object Ssid { get; set; }
        public object Password { get; set; }
    }

    public class LocationSettings
    {
        public bool IsAway { get; set; }
        public bool IsGeofencingEnabled { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Radius { get; set; }
    }

    public class Cpu
    {
        public double AverageLoad { get; set; }
        public double Temperature { get; set; }
    }

    public class Memory
    {
        public int Available { get; set; }
        public int Free { get; set; }
        public int Total { get; set; }
    }

    public class Device
    {
        public string Model { get; set; }
        public long Size { get; set; }
        public bool Healthy { get; set; }
    }

    public class Tmpfs
    {
        public int Available { get; set; }
        public int Total { get; set; }
        public int Used { get; set; }
        public string Path { get; set; }
    }

    public class SystemInfo
    {
        public Cpu Cpu { get; set; }
        public Memory Memory { get; set; }
        public Storage Storage { get; set; }
        public Tmpfs Tmpfs { get; set; }
    }

    public class AllMessage
    {
        public string Type { get; set; }
        public string Text { get; set; }
    }

    public class DoorbellSettings
    {
        public string DefaultMessageText { get; set; }
        public int DefaultMessageResetTimeoutMs { get; set; }
        public List<object> CustomMessages { get; set; }
        public List<AllMessage> AllMessages { get; set; }
    }

    public class SmartDetectAgreement
    {
        public string Status { get; set; }
        public long LastUpdateAt { get; set; }
    }

    public class RecordingSpace
    {
        public long Total { get; set; }
        public long Used { get; set; }
        public long Available { get; set; }
    }

    public class StorageStats
    {
        public double Utilization { get; set; }
        public long Capacity { get; set; }
        public long RemainingCapacity { get; set; }
        public RecordingSpace RecordingSpace { get; set; }
    }

    public class MaxCameraCapacity
    {
        public int _4K { get; set; }
        public int HD { get; set; }
    }

    public class Nvr : ProtectNetworkDevice
    {
        public bool CanAutoUpdate { get; set; }
        public bool IsStatsGatheringEnabled { get; set; }
        public string Timezone { get; set; }
        public string Version { get; set; }
        public string FirmwareVersion { get; set; }
        public object UIVersion { get; set; }
        public string HardwarePlatform { get; set; }
        public Ports Ports { get; set; }
        public long Uptime { get; set; }
        public long LastSeen { get; set; }
        public bool IsUpdating { get; set; }
        public long LastUpdateAt { get; set; }
        public bool IsStation { get; set; }
        public bool EnableAutomaticBackups { get; set; }
        public bool EnableStatsReporting { get; set; }
        public bool IsSshEnabled { get; set; }
        public object ErrorCode { get; set; }
        public string ReleaseChannel { get; set; }
        public List<string> Hosts { get; set; }
        public bool EnableBridgeAutoAdoption { get; set; }
        public string HardwareId { get; set; }
        public string HardwareRevision { get; set; }
        public int HostType { get; set; }
        public string HostShortname { get; set; }
        public bool IsHardware { get; set; }
        public string TimeFormat { get; set; }
        public long? RecordingRetentionDurationMs { get; set; }
        public bool EnableCrashReporting { get; set; }
        public bool? DisableAudio { get; set; }
        public string AnalyticsData { get; set; }
        public string AnonymousDeviceId { get; set; }
        public int CameraUtilization { get; set; }
        public bool IsRecycling { get; set; }
        public WifiSettings WifiSettings { get; set; }
        public LocationSettings LocationSettings { get; set; }
        public FeatureFlags FeatureFlags { get; set; }
        public SystemInfo SystemInfo { get; set; }
        public DoorbellSettings DoorbellSettings { get; set; }
        public SmartDetectAgreement SmartDetectAgreement { get; set; }
        public StorageStats StorageStats { get; set; }
        public bool IsAway { get; set; }
        public bool IsSetup { get; set; }
        public string Network { get; set; }
        public string Type { get; set; }
        public long? UpSince { get; set; }
        public bool IsRecordingDisabled { get; set; }
        public MaxCameraCapacity MaxCameraCapacity { get; set; }
    }

    public class LightDeviceSettings
    {
        public bool IsIndicatorEnabled { get; set; }
        public int LedLevel { get; set; }
        public string LuxSensitivity { get; set; }
        public int PirDuration { get; set; }
        public int PirSensitivity { get; set; }
    }

    public class LightOnSettings
    {
        public bool IsLedForceOn { get; set; }
    }

    public class LightModeSettings
    {
        public string Mode { get; set; }
        public string EnableAt { get; set; }
    }

    public class Light
    {
        public string Mac { get; set; }
        public string Host { get; set; }
        public string ConnectionHost { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public long UpSince { get; set; }
        public long LastSeen { get; set; }
        public long ConnectedSince { get; set; }
        public string State { get; set; }
        public object HardwareRevision { get; set; }
        public string FirmwareVersion { get; set; }
        public string LatestFirmwareVersion { get; set; }
        public string FirmwareBuild { get; set; }
        public bool IsUpdating { get; set; }
        public bool IsAdopting { get; set; }
        public bool IsAdopted { get; set; }
        public bool IsAdoptedByOther { get; set; }
        public bool IsProvisioned { get; set; }
        public bool IsRebooting { get; set; }
        public bool IsSshEnabled { get; set; }
        public bool CanAdopt { get; set; }
        public bool IsAttemptingToConnect { get; set; }
        public bool IsPirMotionDetected { get; set; }
        public object LastMotion { get; set; }
        public bool IsDark { get; set; }
        public bool IsLightOn { get; set; }
        public bool IsLocating { get; set; }
        public WiredConnectionState WiredConnectionState { get; set; }
        public LightDeviceSettings LightDeviceSettings { get; set; }
        public LightOnSettings LightOnSettings { get; set; }
        public LightModeSettings LightModeSettings { get; set; }
        public string Camera { get; set; }
        public string Id { get; set; }
        public bool IsConnected { get; set; }
        public bool IsCameraPaired { get; set; }
        public string ModelKey { get; set; }
    }

    public class Bridge : ProtectNetworkDevice
    {
        public string ConnectionHost { get; set; }
        public string Type { get; set; }
        public long UpSince { get; set; }
        public long LastSeen { get; set; }
        public long ConnectedSince { get; set; }
        public string State { get; set; }
        public int HardwareRevision { get; set; }
        public string FirmwareVersion { get; set; }
        public object LatestFirmwareVersion { get; set; }
        public string FirmwareBuild { get; set; }
        public bool IsUpdating { get; set; }
        public bool IsAdopting { get; set; }
        public bool IsAdopted { get; set; }
        public bool IsAdoptedByOther { get; set; }
        public bool IsProvisioned { get; set; }
        public bool IsRebooting { get; set; }
        public bool IsSshEnabled { get; set; }
        public bool CanAdopt { get; set; }
        public bool IsAttemptingToConnect { get; set; }
        public WiredConnectionState WiredConnectionState { get; set; }
        public bool IsConnected { get; set; }
        public string Platform { get; set; }
    }
    public abstract class ProtectDevice
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ModelKey { get; set; }
        public override string ToString() => $"{ModelKey}: {Name} ({Id})";
    }
    public abstract class ProtectNetworkDevice : ProtectDevice
    {
        public string Mac { get; set; }
        public string Host { get; set; }
    }

    public class ProtectSystemStatus
    {
        public string AuthUserId { get; set; }
        public string AccessKey { get; set; }
        public List<Camera> Cameras { get; set; }
        public List<UserAccount> Users { get; set; }
        public List<Group> Groups { get; set; }
        public List<LiveView> LiveViews { get; set; }
        public Nvr Nvr { get; set; }
        public List<object> LegacyUFVs { get; set; }
        public string LastUpdateId { get; set; }
        public List<object> Viewers { get; set; }
        public List<object> Displays { get; set; }
        public List<Light> Lights { get; set; }
        public List<Bridge> Bridges { get; set; }
        public List<object> Sensors { get; set; }
        public List<object> Doorlocks { get; set; }
    }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
