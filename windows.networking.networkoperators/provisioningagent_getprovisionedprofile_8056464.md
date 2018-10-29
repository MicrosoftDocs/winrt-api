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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

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
