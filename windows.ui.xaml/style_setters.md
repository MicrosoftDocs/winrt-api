---
-api-id: P:Windows.UI.Xaml.Style.Setters
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.SetterBaseCollection Setters { get; }
-->

# Windows.UI.Xaml.Style.Setters

## -description
Gets a collection of [Setter](setter.md) objects.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Style.Setters](/windows/winui/api/microsoft.ui.xaml.style.setters) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Style ...>
  oneOrMoreSetters
</Style>
- or -
<Style>
  <Style.Setters>
    oneOrMoreSetters
  </Style.Setters>
</Style>
```


## -xaml-values
<dl><dt>oneOrMoreSetters</dt><dd>oneOrMoreSettersOne or more object elements for objects that derive from SetterBase. Generally, these are Setter object elements.</dd>
</dl>
## -property-value
A collection of [Setter](setter.md) objects. The default is an empty collection.

## -remarks

## -examples

## -see-also
