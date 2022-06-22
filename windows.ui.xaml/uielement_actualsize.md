---
-api-id: P:Windows.UI.Xaml.UIElement.ActualSize
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public Vector2 ActualSize { get; }
-->

# Windows.UI.Xaml.UIElement.ActualSize

## -description

Gets the size that this UIElement computed during the arrange pass of the layout process.  



## -property-value

The size that this UIElement computed during the arrange pass of the layout process.

## -remarks 

The ActualSize property is equivalent to the [ActualWidth](frameworkelement_actualwidth.md) and [ActualHeight](frameworkelement_actualheight.md) properties, but represented as a Vector2. ActualSize can be used as an input property to an [ExpressionAnimation](../windows.ui.composition/expressionanimation.md).

When the ActualSize changes, the [FrameworkElement.SizeChanged](frameworkelement_sizechanged.md) event is raised. The value of [SizeChangedEventArgs.NewSize](sizechangedeventargs_newsize.md) will be the new value of the ActualSize.

## -see-also

## -examples

