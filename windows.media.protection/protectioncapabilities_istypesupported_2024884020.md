---
-api-id: M:Windows.Media.Protection.ProtectionCapabilities.IsTypeSupported(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public ProtectionCapabilityResult ProtectionCapabilities.IsTypeSupported(String type, String keySystem)
-->

# Windows.Media.Protection.ProtectionCapabilities.IsTypeSupported

## -description
Gets a value that indicates whether the specified hardware DRM capabilities are likely supported, are possibly supported, or are unsupported.

## -parameters

### -param type
A string representing the capabilities for which support is queried.

### -param keySystem
A string specifying the key system to which the query applies.

## -returns
A value indicating if the queried capabilities are likely supported, are possibly supported, or are unsupported.

## -remarks
If the value returned from this method is [ProtectionCapabilityResult.Maybe](protectioncapabilityresult.md), the requested capabilities may be supported, but the supported status is not yet known by the system. In this case, the app may want to query again through polling or in response to UI events.

## -see-also

## -examples

