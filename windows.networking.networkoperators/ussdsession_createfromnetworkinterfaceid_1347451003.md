---
-api-id: M:Windows.Networking.NetworkOperators.UssdSession.CreateFromNetworkInterfaceId(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Networking.NetworkOperators.UssdSession CreateFromNetworkInterfaceId(System.String networkInterfaceId)
-->

# Windows.Networking.NetworkOperators.UssdSession.CreateFromNetworkInterfaceId

## -description
Creates a USSD session for the mobile device associated with the supplied network interface ID.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -parameters
### -param networkInterfaceId
The network interface ID to use to select the corresponding mobile broadband device to use for the USSD session.

## -returns
The USSD session for the mobile device associated with the supplied network interface ID.

## -remarks

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
