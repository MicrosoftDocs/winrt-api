---
-api-id: P:Windows.UI.Xaml.Controls.Control.TabNavigation
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Input.KeyboardNavigationMode TabNavigation { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.TabNavigation

## -description
Gets or sets a value that modifies how tabbing and [TabIndex](control_tabindex.md) work for this control.

> [!NOTE]
> For Windows 10 Creators Update (build 10.0.15063) and newer, the [TabFocusNavigation](../windows.ui.xaml/uielement_tabfocusnavigation.md) property is available on the [UIElement]() base class to include objects in the tab sequence that do not use a [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md).

## -xaml-syntax
```xaml
<control TabNavigation="keyboardNavigationModeMemberName"/>
```


## -xaml-values
<dl><dt>keyboardNavigationModeMemberName</dt><dd>keyboardNavigationModeMemberNameA named constant of the KeyboardNavigationMode enumeration, for example Cycle.</dd>
</dl>
## -property-value
A value of the enumeration. The default is **Local**.

## -remarks

## -examples

## -see-also
[IsTabStop](control_istabstop.md), [TabIndex](control_tabindex.md), [Keyboard interactions](http://msdn.microsoft.com/library/ff819bac-67c0-4ec9-8921-f087be188138), [Keyboard accessibility](http://msdn.microsoft.com/library/ddae8c4b-7907-49fe-9645-f105f8dfad8b)