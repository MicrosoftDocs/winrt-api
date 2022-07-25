---
-api-id: P:Windows.UI.Xaml.UIElement.Visibility
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Visibility Visibility { get;  set; }
-->

# Windows.UI.Xaml.UIElement.Visibility

## -description
Gets or sets the visibility of a [UIElement](uielement.md). A [UIElement](uielement.md) that is not visible is not rendered and does not communicate its desired size to layout.



## -xaml-syntax
```xaml
<uiElement Visibility="Visible"/>
-or-
<uiElement Visibility="Collapsed"/>
```


## -property-value
A value of the enumeration. The default value is **Visible**.

## -remarks
A UI element that has Visibility equals **Collapsed** is still loaded along with the rest of the XAML on a page and exists in the runtime object tree.

An element that has Visibility equals **Collapsed** has no location in the UI and does not participate in input or hit testing. They are also not in a tab sequence and cannot be focused, not even programmatically. If you still want input, focus or hit testing, rather than set Visibility use a zero [Opacity](uielement_opacity.md).

### BooleanToVisibilityConverter

A common scenario in apps that use data from a data source is to identify a property of the data or the view model for the data that controls whether the data should display. A related scenario is writing a template that can alter the Visibility of a control part based on a Boolean property of the parent control or of another part. To make it easier to define this behavior as part of a [Binding](../windows.ui.xaml.data/binding.md), some of the default project templates include a BooleanToVisibilityConverter helper class in the Common folder. For more info on how to use a value converter for a data binding, see [IValueConverter](../windows.ui.xaml.data/ivalueconverter.md).

## -examples
**Visibility in a visual state** As part of defining visual states for a control, you will sometimes want to change the Visibility state of an object to **Collapsed**. Visual states rely on animations. The property value type of Visibility is [Visibility](visibility.md), an enumeration. To animate values that are enumerations, you must use a [DiscreteObjectKeyFrame](../windows.ui.xaml.media.animation/discreteobjectkeyframe.md). (You also use this technique for Boolean values). This XAML example shows a visual state that uses [DiscreteObjectKeyFrame](../windows.ui.xaml.media.animation/discreteobjectkeyframe.md) to change visibility.

```xaml
<VisualState x:Name="Focused">
  <Storyboard>
    <ObjectAnimationUsingKeyFrames Storyboard.TargetName="FocusVisualElement" Storyboard.TargetProperty="Visibility" Duration="0">
      <DiscreteObjectKeyFrame KeyTime="0" Value="Visible"/>
    </ObjectAnimationUsingKeyFrames>
  </Storyboard>
</VisualState>
```



## -see-also
[Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
