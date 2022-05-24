---
-api-id: T:Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticEventBufferLatencies
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum PlatformDiagnosticEventBufferLatencies : uint {
	CostDeferred = 2
	Normal = 1
	Realtime = 4
}
-->

# Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticEventBufferLatencies

## -description
Specifies the kinds of network connections that can be used to transfer diagnostic data.

## -enum-fields

## -field Realtime:4
Trace data will be uploaded as soon as a network connection (of any kind) is available.

## -field Normal:1
Trace data will be transferred unless the device is on a metered connection.

## -field CostDeferred:2
Less strict than **Normal**. If, after three days, there has been no opportunity to connect over a non-cellular connection, trace data will be transferred even if the device is still on a cellular connection.

## -remarks
> [!IMPORTANT]
> Only first-party applications should use this type.

## -see-also
[ForceUpload()](platformdiagnosticactions_forceupload_1947368557.md)
