---
-api-id: P:Windows.UI.Input.PointerPointProperties.IsPrimary
-api-type: winrt property
---

<!-- Property syntax
public bool IsPrimary { get; }
-->

# Windows.UI.Input.PointerPointProperties.IsPrimary

## -description
Gets a value that indicates whether the input is from the primary pointer when multiple pointers are registered.

## -property-value
True if the input is from the pointer designated as primary; otherwise false.

## -remarks
The primary pointer is a single pointer (touch, mouse, and pen/stylus) in the current interaction.

For mouse, the primary pointer is the only pointer for which mouse events can be generated.

For touch (where there can be multiple concurrent pointers), the primary pointer is the first contact in an interaction. For any interaction after the first **[PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md)** event, IsPrimary returns false.

A new primary pointer is only registered when all contacts in that interaction are removed and a new contact is subsequently detected.

A primary pointer can perform actions that are not available to other pointers. For example, when a primary pointer generates a [WM_POINTERDOWN](/previous-versions/windows/desktop/inputmsg/wm-pointerdown) message on an inactive window, a [WM_POINTERACTIVATE](/previous-versions/windows/desktop/inputmsg/wm-pointeractivate)] message is also sent to that window.

## -examples
This example uses different colored ellipses to show whether the pointer associated with the [PointerRoutedEventArgs](/uwp/api/windows.ui.xaml.input.pointerroutedeventargs) is the primary pointer.

```csharp
private void MainPage_PointerPressed(object sender, PointerRoutedEventArgs e)
{
    PointerPoint pt = e.GetCurrentPoint(pointerCanvas);
    contacts[pt.PointerId] = pt;
    PointerCounter.Text = contacts.Count.ToString();

    Ellipse ellipse = new Ellipse();
    ellipse.StrokeThickness = 2;
    ellipse.Width = ellipseDiameter;
    ellipse.Height = ellipseDiameter;
    ellipse.Tag = pt.PointerId;
    TranslateTransform translate = new TranslateTransform();
    translate.X = pt.Position.X - ellipseDiameter / 2;
    translate.Y = pt.Position.Y - ellipseDiameter / 2;
    ellipse.RenderTransform = translate;
    pointerCanvas.Children.Add(ellipse);

    if (pt.Properties.IsPrimary == true)
    {
        primaryPointer = pt;
        primaryEllipse = ellipse;
        primaryEllipse.Scale(scaleX: 2, scaleY: 2, centerX: 0, centerY: 0).Start();
        ellipse.Stroke = new SolidColorBrush(Windows.UI.ColorHelper.FromArgb(255, 255, 0, 0));

        // Create the transform
        ScaleTransform scaleTransform = new ScaleTransform();
        scaleTransform.ScaleX = primaryEllipse.Width * 1.25;
        scaleTransform.ScaleY = primaryEllipse.Height * 1.25;
        primaryEllipse.RenderTransform = scaleTransform;

        PointerPrimary.Text = pt.PointerId.ToString();
    }
    else
        ellipse.Stroke = new SolidColorBrush(Windows.UI.ColorHelper.FromArgb(255, 0, 0, 255));

    e.Handled = true;
}
```

## -see-also
