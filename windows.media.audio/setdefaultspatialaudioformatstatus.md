---
-api-id: T:Windows.Media.Audio.SetDefaultSpatialAudioFormatStatus
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum SetDefaultSpatialAudioFormatStatus : int 
-->

# Windows.Media.Audio.SetDefaultSpatialAudioFormatStatus

## -description
Specifies the status of the SetDefaultSpatialAudioFormatResult, whether it failed (and why) or succeeded.

## -enum-fields
### -field UnknownError:5
Something unexpected went wrong.

### -field Succeeded:0
The call succeeded and the format was set.

### -field NotSupportedOnAudioEndpoint:4
This audio endpoint doesn't support this format.

### -field LicenseNotValidForAudioEndpoint:3
This spatial audio format is licensed, but not for this endpoint.

### -field LicenseExpired:2
There is no current license for this spatial audio format.

### -field AccessDenied:1
The caller doesn't have permission to change/set this spatial audio format.

## -remarks

## -see-also

## -examples

