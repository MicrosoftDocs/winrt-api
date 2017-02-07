---
-api-id: T:Windows.Media.Core.MediaStreamSourceClosedReason
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Core.MediaStreamSourceClosedReason : int
-->

# MediaStreamSourceClosedReason

## -description
Specifies the reason why a [MediaStreamSource](mediastreamsource.md) was closed.

## -enum-fields
### -field Done:0
No error has occurred.

### -field UnknownError:1
An unspecified error has occurred.

### -field AppReportedError:2
The app reported an error by calling the [NotifyError](mediastreamsource_notifyerror.md) method on the [MediaStreamSource](mediastreamsource.md).

### -field UnsupportedProtectionSystem:3
Components needed to implement the protection system are missing.

### -field ProtectionSystemFailure:4
A failure occurred while initializing the protection system

### -field UnsupportedEncodingFormat:5
One or more media streams use an encoding format which cannot be handled by the media pipeline.

### -field MissingSampleRequestedEventHandler:6
The [MediaStreamSource](mediastreamsource.md) object does not have an event handler for the [SampleRequested](mediastreamsource_samplerequested.md) event.


## -remarks

## -examples

## -see-also