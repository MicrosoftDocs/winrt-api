---
-api-id: M:Windows.Networking.NetworkOperators.ESimProfile.SetNicknameAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<ESimOperationResult> ESimProfile.SetNicknameAsync(String newNickname)
-->

# Windows.Networking.NetworkOperators.ESimProfile.SetNicknameAsync

## -description
Asynchronously sets the nickname of the eSIM profile.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Store then you will need to request special approval to use the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Special and restricted capabilities](/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -parameters
### -param newNickname
The nickname to set.

## -returns
An asynchronous nickname set operation. On successful completion, contains an [ESimOperationResult](esimoperationresult.md) object representing the result of the nickname set operation.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe