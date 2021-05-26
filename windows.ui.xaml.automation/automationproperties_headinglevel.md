---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.HeadingLevel
-api-type: winrt attachedproperty
---

# Windows.UI.Xaml.Automation.AutomationProperties.HeadingLevel

<!--
see GetHeadingLevel, and SetHeadingLevel
-->

## -description

Gets or sets the heading level for a UI Automation element.

## -remarks

Heading elements organize the user interface and make it easier to navigate. Some assistive technology (AT) allows users to quickly jump between headings. Headings have a level from 1 to 9.  

The heading level property value is returned by the [GetHeadingLevel](automationproperties_getheadinglevel_655629781.md) method.

<ul><li>Type: [AutomationHeadingLevel](../windows.ui.xaml.automation.peers/automationheadinglevel.md)</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.headinglevelproperty">HeadingLevelProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.getheadinglevel">GetHeadingLevel</a>, <a href="/uwp/api/windows.ui.xaml.automation.automationproperties.setheadinglevel">SetHeadingLevel</a></li></ul>

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples

```xaml
<TextBlock
    Text="Mouse Options"
    AutomationProperties.HeadingLevel="1"/>
</TextBlock>

<StackPanel AutomationProperties.AutomationName="Description of Content"  AutomationProperties.HeadingLevel="1">
    <!-- content here -->
</StackPanel>
```

```csharp
public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();

        AutomationProperties.SetHeadingLevel(this, AutomationHeadingLevel.HeadingLevel3);
    }
}

```
