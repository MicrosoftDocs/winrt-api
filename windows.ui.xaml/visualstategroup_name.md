---
-api-id: P:Windows.UI.Xaml.VisualStateGroup.Name
-api-type: winrt property
---

<!-- Property syntax
public string Name { get; }
-->

# Windows.UI.Xaml.VisualStateGroup.Name

## -description
Gets the name of the [VisualStateGroup](visualstategroup.md).



## -xaml-syntax
```xaml
<VisualStateGroup x:Name="groupName"/>
```


## -xaml-values
<dl><dt>groupName</dt><dd>groupNameThe name of the VisualStateGroup. Name is a read-only property, so specify the name of the VisualStateGroup by setting the x:Name attribute. An unprefixed string Name won't work.</dd>
</dl>
## -property-value
The name of the [VisualStateGroup](visualstategroup.md).

## -remarks
Name is a read-only property that you can check with code at run-time to read the value of the [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) that was applied to a [VisualStateGroup](visualstategroup.md) in a XAML control template. You can't literally set Name because it's read-only, and [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) can only be set in XAML. The value is available as soon as the XAML that contains the control template and the [VisualStateGroup](visualstategroup.md) definition is loaded.

The need to check the [Name](visualstate_name.md) of a [VisualStateGroup](visualstategroup.md) at run-time is anticipated to be relatively uncommon, and would only be relevant to advanced scenarios. For the most part, the definition of a [VisualStateGroup](visualstategroup.md) in XAML combined with using [VisualStateManager](visualstatemanager.md) and [VisualStateGroup](visualstategroup.md) events in code provides you all that you need to define and invoke visual states for a custom or Windows Runtime-defined control.



## -examples

## -see-also
[Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)), [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute), [VisualStateManager](visualstatemanager.md)
