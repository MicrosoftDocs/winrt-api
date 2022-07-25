---
-api-id: P:Windows.UI.Xaml.FrameworkElement.Style
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Style Style { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.Style

## -description
Gets or sets an instance [Style](style.md) that is applied for this object during layout and rendering.



## -xaml-syntax
```xaml
<frameworkElement Style="{StaticResource styleResourceKey}"/>
```


## -xaml-values
<dl><dt>styleResourceKey</dt><dd>styleResourceKeyThe key that identifies the style being requested. The key refers to an existing resource in a ResourceDictionary.XAML property element syntax to define an inline style is technically possible, but not recommended for setting FrameworkElement.Style. This is because any property set through a single-use inline style could just as easily have been set by directly setting the property as a XAML attribute (or property element). Defining a one-use style to set that same property is generally poor markup style and can cause a confusing run-time property setting behavior.</dd>
</dl>
## -property-value
The applied style for the object, if present; otherwise, **null**. The default for a default-constructed [FrameworkElement](frameworkelement.md) is **null**.

## -remarks
Setting the Style property directly is not the most common way to style a UI element's appearance. Instead, you influence a UI element's appearance through one of the these techniques:
+ You often set individual UI properties of a UI element as attributes in XAML. **FrameworkElement.Style** only applies to the current element, and any value from a Style**FrameworkElement.Style** is overwritten by a local property value, so setting the local value is more direct and more predictable. For more info on how a [Style](style.md) value and a local property value relate, see [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).
+ Control authors typically write a control that is templatable, but also comes with a default template. Your app can use the control and change its appearance by providing a new [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md), which is part of a [Style](style.md) defined in resources. This style is typically applied using the *implicit style* feature, not by setting Style. For more info, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls).
+ Control authors also expose properties that reference parts of a control that can have styles or values applied to just that part, so you don't have to totally retemplate the control. Here you're setting a more specific property, not **FrameworkElement.Style**.
+ The visual state model frequently resets the style of control at run time in response to changes in states that manifest themselves to the users visually. For example, control templates typically have a "Focused" state that adds a visual focus indicator to the control appearance so that a keyboard user can see which element in UI has the current keyboard focus. For more info on the visual state concept, see [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)).


You can change the values of individual properties that have been set within a style. For example, you can set the [Template](../windows.ui.xaml.controls/control_template.md) property at run time even if this property has been set by a style. Or you can add setters to the collection in [Setters](style_setters.md). However, as soon as that style is placed in use by a loaded object, the [Style](style.md) should be considered sealed. You can detect this state by checking the value of [IsSealed](style_issealed.md) for the [Style](style.md). A style is considered to be in use as soon as it is referenced by a loaded object that is connected to the object tree of a displayed page of UI. A [Style](style.md) and its [Setters](style_setters.md) can also be considered sealed when the object using that style raises its [Loaded](frameworkelement_loaded.md) event. Attempting to change an individual property of an in-use style (such as a property in the [Setters](style_setters.md) collection) throws an exception.

Classes derived from [Control](../windows.ui.xaml.controls/control.md) have an additional entry point that is useful to control authors in regard to style and template application. [FrameworkElement](frameworkelement.md) defines the virtual callback [OnApplyTemplate](frameworkelement_onapplytemplate_1955470198.md) that is invoked prior to [Loaded](frameworkelement_loaded.md). Classes derived from [Control](../windows.ui.xaml.controls/control.md) can override this callback to adjust the property values that were set by templates before the style is in use.

If queried at run time, the Style property does not return styles that come from an applied template, or active visual states. It only returns styles that were explicitly set by the Style property. In addition, it does not return implicit styles.

## -examples

## -see-also
[Styling controls](/windows/uwp/controls-and-patterns/styling-controls), Style, [Control](../windows.ui.xaml.controls/control.md)
