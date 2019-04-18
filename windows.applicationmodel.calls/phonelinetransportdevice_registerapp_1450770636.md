---
-api-id: M:Windows.ApplicationModel.Calls.PhoneLineTransportDevice.RegisterApp
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void PhoneLineTransportDevice.RegisterApp()
-->

# Windows.ApplicationModel.Calls.PhoneLineTransportDevice.RegisterApp

## -description
Registers the app with Windows for the associated PhoneLineTransportDevice. 

## -remarks
Registration is necessary in order to see the PhoneLine for this PhoneLineTransportDevice. Registration is per user, so each user must individually register for the PhoneLineTransportDevice. Registration persists until the app is unregistered or the PhoneLineTransportDevice is removed.

For multi-user applications, use [RegisterAppForUser](phonelinetransportdevice_registerappforuser_1944233497.md).

## -see-also

## -examples

## -capabilities
phoneLineTransportManagement
