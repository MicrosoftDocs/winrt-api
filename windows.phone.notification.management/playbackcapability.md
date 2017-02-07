---
-api-id: T:Windows.Phone.Notification.Management.PlaybackCapability
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Phone.Notification.Management.PlaybackCapability : uint
-->

# PlaybackCapability

## -description
Represents the type of media playback capability.

## -enum-fields
### -field None:0
No playback capability.

### -field Play:1
Play playback capability.

### -field Pause:2
Pause playback capability.

### -field Stop:4
Stop playback capability.

### -field Record:8
Record playback capability.

### -field FastForward:16
Fast forward playback capability.

### -field Rewind:32
Rewind playback capability.

### -field Next:64
Next playback capability.

### -field Previous:128
Previous playback capability.

### -field ChannelUp:256
Channel up playback capability.

### -field ChannelDown:512
Channel down playback capability.


## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also