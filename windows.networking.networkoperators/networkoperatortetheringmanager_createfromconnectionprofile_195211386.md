---
-api-id: M:Windows.Networking.NetworkOperators.NetworkOperatorTetheringManager.CreateFromConnectionProfile(Windows.Networking.Connectivity.ConnectionProfile)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Networking.NetworkOperators.NetworkOperatorTetheringManager CreateFromConnectionProfile(Windows.Networking.Connectivity.ConnectionProfile profile)
-->

# Windows.Networking.NetworkOperators.NetworkOperatorTetheringManager.CreateFromConnectionProfile

## -description
Creates a [NetworkOperatorTetheringManager](networkoperatortetheringmanager.md) using the given profile as the public interface and Wi-Fi as the private interface.

## -parameters
### -param profile
Connection profile to be used.

## -returns
The resulting manager object.

## -remarks
In previous releases, only privileged apps from network operators could create a [NetworkOperatorTetheringManager](networkoperatortetheringmanager.md) object and use it to control tethering. In this release, any app can create the object by calling CreateFromConnectionProfile. In order for the call to succeed, however, the app must have the appropriate Wi-Fi control device capability declared in its manifest. The following example shows part of a manifest with the necessary **DeviceCapability** tag, with the **wiFiControl** attribute.



```xml
<Capabilities>
  <DeviceCapability Name="wiFiControl"/>
</Capabilities>

```

If the **wiFiControl** device capability is not set in the manifest, then calls to CreateFromConnectionProfile fail by throwing an exception.

Your code can determine whether the capability is set at runtime by calling [GetTetheringCapabilityFromConnectionProfile](networkoperatortetheringmanager_gettetheringcapabilityfromconnectionprofile_854560136.md). If **DisabledBySystemCapability** is returned, then the manifest does not set the required device capability. Note that even if **Enabled** is returned, your code should be written to handle errors and exceptions, since tethering capability can change at any time, outside your app's control or notice.

## -examples

## -see-also
[CreateFromConnectionProfile(ConnectionProfile, NetworkAdapter)](networkoperatortetheringmanager_createfromconnectionprofile_969206938.md)

## -capabilities
wiFiControl
