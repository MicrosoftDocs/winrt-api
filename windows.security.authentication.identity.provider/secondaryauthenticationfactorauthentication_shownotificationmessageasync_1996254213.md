---
-api-id: M:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthentication.ShowNotificationMessageAsync(System.String,Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationMessage)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ShowNotificationMessageAsync(System.String deviceName, Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthenticationMessage message)
-->

# Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorAuthentication.ShowNotificationMessageAsync

## -description
Shows a message above the lock screen or within the companion device sign in option tile.

> [!NOTE]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft to use the **secondaryAuthenticationFactor** capability, calls to this API will fail. To apply for approval, contact [cdfonboard@microsoft.com](mailto:cdfonboard@microsoft.com). For more information on capabilities, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations). For an overview of the Companion Device Framework, see the [Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock) overview.

## -parameters
### -param deviceName
The name of device to display as part of the notification message (set using the message parameter).

### -param message
The message to show.

## -returns
This method does not return a value.

## -remarks

## -examples

## -see-also
[Windows Unlock with companion (IoT) devices](/windows/uwp/security/companion-device-unlock)