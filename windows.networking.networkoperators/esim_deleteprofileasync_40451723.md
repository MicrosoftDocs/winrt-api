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
> To use this API you will need to contact Microsoft to request the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see the **Special and restricted capabilities** section under [App capability declarations](/windows/uwp/packaging/app-capability-declarations?branch=live).

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