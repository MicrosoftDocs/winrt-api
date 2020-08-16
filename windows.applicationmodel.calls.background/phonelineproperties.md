---
-api-id: T:Windows.ApplicationModel.Calls.Background.PhoneLineProperties
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Calls.Background.PhoneLineProperties : uint
-->

# PhoneLineProperties

## -description
Indicates a set of property flags that are part of a phone line changed trigger. Multiple properties can be set at one time.

## -enum-fields
### -field None:0
No property.

### -field BrandingOptions:1
The branding options for the phone line.

### -field CanDial:2
The ability to dial outgoing calls on the phone line.

### -field CellularDetails:4
The cellular details for the phone line.

### -field DisplayColor:8
The preferred display color for the phone line.

### -field DisplayName:16
The user assigned friendly name of the phone line.

### -field NetworkName:32
The name of the current network that is being used by the phone line.

### -field NetworkState:64
The current network status of the phone line.

### -field Transport:128
The transport (cellular or voice over IP) for the phone line.

### -field Voicemail:256
The voice mail account associated with the phone line.

## -remarks

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem


