---
-api-id: T:Windows.ApplicationModel.Background.SecondaryAuthenticationFactorAuthenticationTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class SecondaryAuthenticationFactorAuthenticationTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger, Windows.ApplicationModel.Background.ISecondaryAuthenticationFactorAuthenticationTrigger
-->

# Windows.ApplicationModel.Background.SecondaryAuthenticationFactorAuthenticationTrigger

## -description
Represents a trigger that launches a background task on behalf of a companion device.

## -remarks
A companion device acts in conjunction with your Windows 10 for desktop editions (Home, Pro, Enterprise, and Education) or Windows 10 Mobile device to enhance the user authentication experience. For instance, a user may attach their companion device to PC via USB, touch the fingerprint reader on the companion device, which automatically unlocks their PC.

When the companion device app registers the first companion device, it should also register its background task component which will pass authentication information between device and companion device authentication service.

## -examples

## -see-also
[IBackgroundTrigger](ibackgroundtrigger.md)