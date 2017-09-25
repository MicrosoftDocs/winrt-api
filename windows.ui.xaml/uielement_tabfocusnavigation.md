---
-api-id: P:Windows.UI.Xaml.UIElement.TabFocusNavigation
-api-type: winrt property
---

<!-- Property syntax.
public KeyboardNavigationMode TabFocusNavigation { get;  set; }
-->

# Windows.UI.Xaml.UIElement.TabFocusNavigation

## -description
Gets or sets a value that modifies how tabbing and [TabIndex](../windows.ui.xaml.controls/control_tabindex.md) work for this control.

## -xaml-syntax
```xaml
<uiElement TabFocusNavigation="keyboardNavigationModeMemberName"/>
```

## -xaml-values
<dl><dt>keyboardNavigationModeMemberName</dt><dd>keyboardNavigationModeMemberNameA named constant of the [KeyboardNavigationMode](../windows.ui.xaml.input/keyboardnavigationmode.md) enumeration, for example, **Cycle**.</dd>
</dl>

## -property-value
A value of the enumeration. The default is **Local**.

## -remarks

This property behaves the same as Control's [TabNavigation](../windows.ui.xaml.controls/control_tabnavigation.md) property. The reason that both properties exist is an accident of history. [TabNavigation](../windows.ui.xaml.controls/control_tabnavigation.md) is an older property. A problem with it was that it was only supported by [Controls]( ../windows.ui.xaml.controls/control.md) which forced developers to wrap non-[Controls]( ../windows.ui.xaml.controls/control.md) with a [Control]( ../windows.ui.xaml.controls/control.md) just so that they could leverage this property. [TabFocusNavigation](uielement_tabfocusnavigation.md) was introduced on [UIElement](uielement.md) to solve this problem.

## -examples

## -see-also
[Keyboard interactions](http://msdn.microsoft.com/library/ff819bac-67c0-4ec9-8921-f087be188138), [Keyboard accessibility](http://msdn.microsoft.com/library/ddae8c4b-7907-49fe-9645-f105f8dfad8b)

