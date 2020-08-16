---
-api-id: P:Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation.Id
-api-type: winrt property
---

<!-- Property syntax
public System.Guid Id { get; }
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation.Id

## -description
Returns the identifier of the local device.

## -property-value
The identifier of the local device. The value range is 16 bytes.

## -remarks
> UWP apps only. The Id property represents the DeviceId using the [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) truncated from the first 16 bytes of the SHA256 hash of the MachineID, User SID, and Package Family Name where the MachineID uses the SID of the local users group. Each component of the GUID is returned in network byte order.

## -examples

## -see-also
