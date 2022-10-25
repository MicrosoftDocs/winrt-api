---
-api-id: M:Windows.Networking.NetworkOperators.ProvisioningAgent.GetProvisionedProfile(Windows.Networking.NetworkOperators.ProfileMediaType,System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Networking.NetworkOperators.ProvisionedProfile GetProvisionedProfile(Windows.Networking.NetworkOperators.ProfileMediaType mediaType, System.String profileName)
-->

# Windows.Networking.NetworkOperators.ProvisioningAgent.GetProvisionedProfile

## -description
Retrieves cost and plan information associated with the mobile broadband profile.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -parameters
### -param mediaType
The media type that the profile belongs to.

### -param profileName
The name of the profile that the cost will be applied to.

## -returns
The profile.

## -remarks

## -examples

## -see-also


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
networkConnectionManagerProvisioning
networkDataPlanProvisioning
