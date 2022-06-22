---
-api-id: P:Windows.UI.Xaml.VisualState.Name
-api-type: winrt property
---

<!-- Property syntax
public string Name { get; }
-->

# Windows.UI.Xaml.VisualState.Name

## -description
Gets the name of the [VisualState](visualstate.md).



## -xaml-syntax
```xaml
<VisualState x:Name="stateName"/>
```


## -xaml-values
<dl><dt>stateName</dt><dd>stateNameThe name of the VisualState. Name is a read-only property. You specify the name of the VisualState by setting the x:Name attribute. An unprefixed string Name won't work.</dd>
</dl>
## -property-value
The name of the [VisualState](visualstate.md).

## -remarks
Name is a read-only property that you can check with code at run-time to read the value of the [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) that was applied to a [VisualState](visualstate.md) in a XAML control template. You can't literally set Name because it's read-only, and [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) can only be set in XAML. The value is available as soon as the XAML that contains the control template and the [VisualState](visualstate.md) definition is loaded.

The need to check the Name of a [VisualState](visualstate.md) at run-time is anticipated to be relatively uncommon, and would only be relevant to advanced scenarios. For the most part, the definition of a [VisualState](visualstate.md) in XAML combined with using [VisualStateManager](visualstatemanager.md) and [VisualStateGroup](visualstategroup.md) events in code provides you all that you need to define and invoke visual states for a custom or Windows Runtime-defined control.

## -examples

## -see-also
[x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute)
