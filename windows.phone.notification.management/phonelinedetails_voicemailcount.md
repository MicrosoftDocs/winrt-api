---
-api-id: P:Windows.Phone.Notification.Management.PhoneLineDetails.VoicemailCount
-api-type: winrt property
---

<!-- Property syntax
public uint VoicemailCount { get; }
-->

# Windows.Phone.Notification.Management.PhoneLineDetails.VoicemailCount

## -description
Gets the number of voicemail messages on the phone line.

## -property-value
The number of voicemail messages on the phone line.

## -remarks
Cellular networks are not required to report this information, in which case this property may not correctly report the number of voicemails.

Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also
