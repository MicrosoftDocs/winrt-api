---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.IsDataValidForForm
-api-type: winrt method
---

<!-- Method syntax
public bool IsDataValidForForm()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.IsDataValidForForm

## -description
Gets a Boolean value that indicates whether the entered or selected value is valid for the form rule associated with the automation element.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Automation.Peers.AutomationPeer.IsDataValidForForm](/windows/winui/api/microsoft.ui.xaml.automation.peers.automationpeer.isdatavalidforform) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -returns
A Boolean value that indicates whether the entered or selected value is valid for the form rule associated with the automation element. The default return value is **true**.

## -remarks
As an example, if the user entered "425-555-5555" for a zip code field that requires 5 or 9 digits, the IsDataValidForForm property can be set to **false** to indicate that the data is not valid.

## -examples

## -see-also
