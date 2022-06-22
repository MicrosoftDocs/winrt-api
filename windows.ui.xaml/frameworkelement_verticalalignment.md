---
-api-id: P:Windows.UI.Xaml.FrameworkElement.VerticalAlignment
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.VerticalAlignment VerticalAlignment { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.VerticalAlignment

## -description
Gets or sets the vertical alignment characteristics that are applied to a [FrameworkElement](frameworkelement.md) when it is composed in a parent object such as a panel or items control.



## -xaml-syntax
```xaml
<frameworkElement VerticalAlignment="verticalAlignmentMemberName"/>
```


## -xaml-values
<dl><dt>verticalAlignmentMemberName</dt><dd>verticalAlignmentMemberNameA constant name from the VerticalAlignment enumeration, for example Top.</dd>
</dl>
## -property-value
A vertical alignment setting, as a value of the enumeration. The default is **Stretch**.

## -remarks
Alignment properties are intended to hint the desired layout to an adaptive layout container. They're typically set on [FrameworkElement](frameworkelement.md) children and interpreted by another [FrameworkElement](frameworkelement.md) container parent (typically a [ContentControl](../windows.ui.xaml.controls/contentcontrol.md) derived class or a [Panel](../windows.ui.xaml.controls/panel.md) derived class, or perhaps a presenter). Setting alignment properties on a child element is no guarantee that anything happens; the behavior depends on the layout composition and the parent elements involved.

When the [Height](frameworkelement_height.md) and [Width](frameworkelement_width.md) properties are explicitly set or calculated on an object, those measurements are more important to typical layout logic, and can cancel the effects of setting VerticalAlignment to [Stretch](horizontalalignment.md). Layout constraint properties (such as [MaxHeight](frameworkelement_maxheight.md)) also affect the maximum or minimum layout size for a **Stretch** layout situation. **Stretch** is the default so that it's easier to use adaptive layout techniques in the cases where there is no explicit measurement. But if there are either [Height](frameworkelement_height.md) and [Width](frameworkelement_width.md) or clipping, the layout acts as if the value is **Top** for VerticalAlignment, typically **Left** for [HorizontalAlignment](frameworkelement_horizontalalignment.md) (**Right** for right-to-left culture info or explicit [FlowDirection](frameworkelement_flowdirection.md) values). For more info, see [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding).

[Canvas](../windows.ui.xaml.controls/canvas.md) does not use VerticalAlignment when composing layout, because [Canvas](../windows.ui.xaml.controls/canvas.md) is based on absolute positioning. In general, the value of VerticalAlignment is potentially treated differently by any object that is capable of having one or more [FrameworkElement](frameworkelement.md) objects as child content. Each such parent object can have its own layout logic.

Each XAML UI element might apply this property differently based on the [Style](style.md) setters for the implicit style. The apparent "default value" for VerticalAlignment in each UI element can be different. For example, a [Button](../windows.ui.xaml.controls/button.md) control starts with the value **Center**. If the UI element is a control, the VerticalAlignment value might also affect the control's visual template.

In content controls, the control template often uses [{TemplateBinding} markup extension](/windows/uwp/xaml-platform/templatebinding-markup-extension) expressions to bind the [VerticalContentAlignment](../windows.ui.xaml.controls/control_verticalcontentalignment.md) property to a VerticalAlignment property on some element within its template, such as the presenter or the element used as the content area.

## -examples
In this example, the value **Center** is assigned to [HorizontalAlignment](frameworkelement_horizontalalignment.md) and VerticalAlignment to position the [TextBlock](../windows.ui.xaml.controls/textblock.md) elements in the center of the [Grid](../windows.ui.xaml.controls/grid.md) cells.



[!code-xaml[LayoutOvwProperties2](../windows.ui.xaml/code/layout_ovw_all/CSharp/MainPage.xaml#SnippetLayoutOvwProperties2)]

## -see-also
[Width](frameworkelement_width.md), [HorizontalAlignment](frameworkelement_horizontalalignment.md), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding)
