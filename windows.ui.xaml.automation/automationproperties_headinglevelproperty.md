---
-api-id: P:Windows.UI.Xaml.Automation.AutomationProperties.HeadingLevelProperty
-api-type: winrt property
---

<!-- Property syntax.
public DependencyProperty HeadingLevelProperty { get; }
-->

# Windows.UI.Xaml.Automation.AutomationProperties.HeadingLevelProperty

## -description
Gets the identifier for the **HeadingLevel** attached property, which indicates the heading level for a UI Automation element. 

## -property-value
The identifier for the **HeadingLevel** attached property.

## -remarks
The heading level property value is returned by the [GetHeadingLevel](automationproperties_getheadinglevel_655629781.md) method.

A heading is an element that has special importance in the context of an app. Assistive Technology (AT) users should be able to quickly jump between headings. Headings have a level from 1 to 9.

## -see-also
[GetHeadingLevel](automationproperties_getheadinglevel_655629781.md)
[SetHeadingLevel](automationproperties_setheadinglevel_870496555.md)

## -examples
```xaml
<TextBlock 
    Text="Mouse Options"
    AutomationProperties.HeadingLevel="1"/>
</TextBlock>

<StackPanel AutomationProperties.HeadingLevel="1">
    <<!-- content here -->
</StackPanel>
```

```csharp
public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();

        AutomationProperties.SetHeadingLevel(AutomationHeadingLevel.HeadingLevel3);
    }
}

```
