---
-api-id: T:Windows.UI.Xaml.Automation.Peers.AutomationLiveSetting
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Automation.Peers.AutomationLiveSetting : int
-->

# AutomationLiveSetting

## -description
Describes the notification characteristics of a particular live region in an app UI. Used by [GetLiveSetting](automationpeer_getlivesetting_295263812.md) and [AutomationProperties.LiveSetting](/uwp/api/windows.ui.xaml.automation.automationproperties.livesetting).

## -xaml-syntax
```xaml
<object property="enumMemberName" .../>
```


## -enum-fields
### -field Off:0
The element does not send notifications if the content of the live region has changed.

### -field Polite:1
The element sends non-interruptive notifications if the content of the live region has changed. With this setting, Microsoft UI Automation clients and assistive technology are expected to not interrupt the user to inform of changes to the live region.

### -field Assertive:2
The element sends interruptive notifications if the content of the live region has changed. With this setting, Microsoft UI Automation clients and assistive technology are expected to interrupt the user to inform of changes to the live region.


## -remarks

## -examples

## -see-also
[AutomationProperties.LiveSetting](/uwp/api/windows.ui.xaml.automation.automationproperties.livesetting), [GetLiveSetting](automationpeer_getlivesetting_295263812.md), [GetLiveSettingCore](automationpeer_getlivesettingcore_2008424374.md), [Custom automation peers](/windows/uwp/accessibility/custom-automation-peers), [Practices to avoid](/windows/uwp/accessibility/practices-to-avoid)
