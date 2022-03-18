---
-api-id: M:Windows.UI.Xaml.Automation.AutomationProperties.GetControlledPeers(Windows.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVector<Windows.UI.Xaml.UIElement> GetControlledPeers(Windows.UI.Xaml.DependencyObject element)
-->

# Windows.UI.Xaml.Automation.AutomationProperties.GetControlledPeers

## -description
A static utility method that retrieves the list of controlled peers from a target owner.

Equivalent WinUI method: [Microsoft.UI.Xaml.Automation.AutomationProperties.GetControlledPeers](/windows/winui/api/microsoft.ui.xaml.automation.automationproperties.getcontrolledpeers).

## -parameters
### -param element
The owner object to retrieve controlled peers from.

## -returns
A list containing the peers that the target element controls.

## -remarks
Examining controlled peers is an advanced scenario that most peer implementations won't need to use.

This identifier is commonly used for [Auto-suggest accessibility](/windows/uwp/design/accessibility/accessible-text-requirements#auto-suggest-accessibility).

## -examples

## -see-also
