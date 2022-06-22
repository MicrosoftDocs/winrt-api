---
-api-id: M:Windows.UI.Xaml.Automation.AutomationProperties.GetFlowsFrom(Windows.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVector<Windows.UI.Xaml.DependencyObject> GetFlowsFrom(Windows.UI.Xaml.DependencyObject element)
-->

# Windows.UI.Xaml.Automation.AutomationProperties.GetFlowsFrom

## -description

Gets a list of automation elements that suggests the reading order before the specified automation element.



## -parameters

### -param element

The element for which to get the preceding reading order elements.

## -returns

A list of automation elements that suggests the reading order before the automation element specified by the *element* parameter.

## -remarks

Get the list, then call the [Add](/dotnet/api/system.collections.generic.icollection-1.add?view=dotnet-uwp-10.0&preserve-view=true) method to add a new element.

> [!IMPORTANT]
> When modifying the flow, be careful not to create a situation where the user gets stuck in a navigation loop that they can't escape if they are only using a keyboard.

## -examples

```xaml
<StackPanel>
    <Button x:Name="first">First</Button>
    <Button x:Name="third">Third</Button>
    <Button x:Name="second">Second</Button>
    <Button x:Name="fourth">Fourth</Button>
</StackPanel>
```

```csharp
public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();

        // Override the default flow for next/previous items in 
        // UI Automation to differ from the sequence of items 
        // declared in markup
        FlowBetween(first, second);
        FlowBetween(second, third);
        FlowBetween(third, fourth);
    }

    public void FlowBetween(UIElement fromElement, UIElement toElement)
    {
        // Set up the flow as bi-directional so that moving next/previous is
        // consistent.
        var flowsToList = AutomationProperties.GetFlowsTo(fromElement);
        var flowsFromList = AutomationProperties.GetFlowsFrom(toElement);

        flowsToList.Add(toElement);
        flowsFromList.Add(fromElement);
    }
}
```

## -see-also
