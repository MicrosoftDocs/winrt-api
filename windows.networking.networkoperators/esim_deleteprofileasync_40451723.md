---
-api-id: M:Windows.Networking.NetworkOperators.ESim.DeleteProfileAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ESimOperationResult> ESim.DeleteProfileAsync(String profileId)
-->

# Windows.Networking.NetworkOperators.ESim.DeleteProfileAsync

## -description
Asynchronously deletes the specified eSIM profile.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Store then you will need to request special approval to use the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Special and restricted capabilities](/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).


## -parameters
### -param profileId
The identification number (an ICCID) of the eSIM profile to delete.

## -returns
An asynchronous delete operation. On successful completion, contains an [ESimOperationResult](esimoperationresult.md) object representing the result of the delete operation.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe