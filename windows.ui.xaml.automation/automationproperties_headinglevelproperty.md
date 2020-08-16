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
Heading elements organize the user interface and make it easier to navigate. Some assistive technology (AT) allows users to quickly jump between headings. Headings have a level from 1 to 9.  

The heading level property value is returned by the [GetHeadingLevel](automationproperties_getheadinglevel_655629781.md) method.

## -see-also
[GetHeadingLevel](automationproperties_getheadinglevel_655629781.md), [SetHeadingLevel](automationproperties_setheadinglevel_870496555.md), [Landmarks and Headings](https://docs.microsoft.com/windows/uwp/design/accessibility/landmarks-and-headings)

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
