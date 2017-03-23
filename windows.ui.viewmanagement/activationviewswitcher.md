---
-api-id: T:Windows.UI.ViewManagement.ActivationViewSwitcher
-api-type: winrt class
---

<!-- Class syntax.
public class ActivationViewSwitcher : Windows.UI.ViewManagement.IActivationViewSwitcher
-->

# Windows.UI.ViewManagement.ActivationViewSwitcher

## -description
Provides methods for switching to an app view in response to an activation.

## -remarks
Get an instance of **ActivationViewSwitcher** from the **ViewSwitcher** property of the activation event args.
To use the **ActivationViewSwitcher** you must first disable the system view activation policy by calling [DisableSystemViewActivationPolicy](applicationviewswitcher_disablesystemviewactivationpolicy_991265837.md).
The first activation of an app cannot use the **ActivationViewSwitcher** to control which view to show. Apps can only use it in subsequent activations.

## -examples

## -see-also
