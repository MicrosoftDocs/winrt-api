---
-api-id: T:Windows.UI.Xaml.Automation.Peers.AutomationLiveSetting
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Automation.Peers.AutomationLiveSetting : int
-->

# AutomationLiveSetting

## -description
Describes the notification characteristics of a particular live region in an app UI. Used by [GetLiveSetting](automationpeer_getlivesetting.md) and [AutomationProperties.LiveSetting](../windows.ui.xaml.automation/automationproperties_livesetting.md).

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
[AutomationProperties.LiveSetting](../windows.ui.xaml.automation/automationproperties_livesetting.md), [GetLiveSetting](automationpeer_getlivesetting.md), [GetLiveSettingCore](automationpeer_getlivesettingcore.md), [Custom automation peers](http://msdn.microsoft.com/library/aa8da53b-fe6e-40ac-9f0a-cb09637c87b4), [Practices to avoid](http://msdn.microsoft.com/library/024a9b70-9821-45bb-93f1-61c0b2ecf53e)