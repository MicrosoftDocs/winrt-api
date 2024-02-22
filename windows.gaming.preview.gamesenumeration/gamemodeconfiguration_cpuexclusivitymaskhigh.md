---
-api-id: P:Windows.Gaming.Preview.GamesEnumeration.GameModeConfiguration.CpuExclusivityMaskHigh
-api-type: winrt property
---

<!-- Property syntax.
public IReference<int> CpuExclusivityMaskHigh { get;  set; }
-->

# Windows.Gaming.Preview.GamesEnumeration.GameModeConfiguration.CpuExclusivityMaskHigh

## -description
CPU exclusivity mask of logical cores dedicated to the game represented by a bitmask. Core 0 is specified by the lowest bit in the low int and each core is the next highest bit. No bits can be set beyond the number of cores returned by [GetSystemCpuSetInformation](https://learn.microsoft.com/en-us/windows/win32/procthread/getsystemcpusetinformation) or set function will throw.

## -property-value

## -remarks
This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -see-also

## -examples


## -capabilities
gameList
