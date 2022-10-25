---
-api-id: M:Windows.Networking.NetworkOperators.ProvisioningAgent.CreateFromNetworkAccountId(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Networking.NetworkOperators.ProvisioningAgent CreateFromNetworkAccountId(System.String networkAccountId)
-->

# Windows.Networking.NetworkOperators.ProvisioningAgent.CreateFromNetworkAccountId

## -description
Creates a provisioning agent for the mobile device associated with the supplied network account ID.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -parameters
### -param networkAccountId
The network account ID to use to select the corresponding mobile broadband device to use for the provisioning agent.

## -returns
The provisioning agent for the mobile device associated with the supplied network account ID.

## -remarks

## -examples

## -see-also


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
networkConnectionManagerProvisioning
networkDataPlanProvisioning
