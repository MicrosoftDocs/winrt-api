---
-api-id: M:Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetLocalizedControlTypeCore
-api-type: winrt method
---

<!-- Method syntax
virtual protected string GetLocalizedControlTypeCore()
-->

# Windows.UI.Xaml.Automation.Peers.AutomationPeer.GetLocalizedControlTypeCore

## -description
Provides the peer's behavior when a Microsoft UI Automation client calls [GetLocalizedControlType](automationpeer_getlocalizedcontroltype_677460473.md) or an equivalent Microsoft UI Automation client API.



## -returns
The type of the control, as a string that is localized to be suitable for direct presentation to users by assistive technology.

## -remarks
This method is very rarely overridden by peers. So long as you provide a value for [GetAutomationControlTypeCore](automationpeer_getautomationcontroltypecore_1718556232.md), all the enumerated constant names from [AutomationControlType](automationcontroltype.md) are already available in localized form to Microsoft UI Automation clients. The necessary translated strings are part of the Microsoft UI Automation support in every Microsoft Windows client. However, if you specify [Custom](automationcontroltype.md) as the control type, you must support a localized control type string that represents the role of the element (for example, "color picker" for a custom control that enables users to choose and specify colors).

## -examples

## -see-also
[Custom automation peers](/windows/uwp/accessibility/custom-automation-peers)
