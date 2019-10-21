---
-api-id: M:Windows.ApplicationModel.Calls.PhoneLineTransportDevice.RegisterAppForUser(Windows.System.User)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void PhoneLineTransportDevice.RegisterAppForUser(User user)
-->

# Windows.ApplicationModel.Calls.PhoneLineTransportDevice.RegisterAppForUser

## -description
Registers the app with Windows for the associated PhoneLineTransportDevice.

## -parameters
### -param user
User being registered.

## -remarks
This is used instead of **RegisterApp()** in multi-user applications to differentiate which user to register. Registration is necessary in order to see the PhoneLine for this PhoneLineTransportDevice. Registration is per user, so each user must individually register for the PhoneLineTransportDevice. Registration persists until the app is unregistered or the PhoneLineTransportDevice is removed.

## -see-also

## -examples

## -capabilities
phoneLineTransportManagement
