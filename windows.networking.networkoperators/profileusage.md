---
-api-id: T:Windows.Networking.NetworkOperators.ProfileUsage
-api-type: winrt struct
-api-device-family-note: xbox
---

<!-- Structure syntax.
public struct ProfileUsage 
-->

# ProfileUsage

## -description
Used to update the usage of plan data.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -struct-fields

### -field UsageInMegabytes
Updates the usage in megabytes.
    

### -field LastSyncTime
The last time *UsageInMegabytes* was updated.
    

## -remarks

## -examples

## -see-also
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
