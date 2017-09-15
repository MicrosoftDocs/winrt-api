---
-api-id: T:Windows.Media.Protection.ProtectionCapabilityResult
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum ProtectionCapabilityResult : int 
-->

# Windows.Media.Protection.ProtectionCapabilityResult

## -description
Specifies the result of a query for hardware DRM capability support using [IsTypeSupported](protectioncapabilities_istypesupported_2024884020.md).


## -enum-fields

### -field NotSupported:0
The queried features are not supported.

### -field Maybe:1
Only relevant to output protection (HDCP) subsystem queries.  [ProtectionCapabilities.IsTypeSupported](protectioncapabilities_istypesupported_2024884020.md) is a synchronous, blocking call which is constrained to only block for very short periods (goal is < 100 milliseconds).  As underlying HDCP establishment may take significantly longer than the blocking period, this **Maybe** result is returned while establishment is in progress.  Once establishment succeeds or fails, the HDCP subsystem query will stabilize on **Probably** or **NotSupported**, respectively.  As no event or promise mechanism is provided, the query must be repeated until **NotSupported** or **Probably** is returned. 

### -field Probably:2
The queried features are supported as of the time of the query.  Display configurations can change dynamically, so Display subsystem and HDCP subsystem query results may become invalid after the query.

## -remarks

## -see-also

## -examples

