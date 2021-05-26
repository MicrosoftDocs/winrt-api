---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.Level
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.Level

<!--
see GetLevel, and SetLevel
-->

## -description

Gets or sets a 1-based integer that describes the location of an element inside hierarchical or broken hierarchical structures.

## -remarks

The `Level` property describes the location of an element inside hierarchical or broken hierarchical structures. For example, a bulleted or numbered list, headings, or other structured data items can have various parent/child relationships. `Level` describes where in the structure the item is located.

Use the [CustomNavigation Control Pattern](/windows/desktop/WinAuto/uiauto-implementingcustomnavigation) in tandem with `Level`.

<ul><li>Type: int</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.levelproperty">LevelProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.getlevel">GetLevel</a>, <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.setlevel">SetLevel</a></li></ul>

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples
