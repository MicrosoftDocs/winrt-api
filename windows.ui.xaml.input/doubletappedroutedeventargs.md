---
-api-id: T:Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class DoubleTappedRoutedEventArgs : Windows.UI.Xaml.RoutedEventArgs, Windows.UI.Xaml.Input.IDoubleTappedRoutedEventArgs
-->

# Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs

## -description
Provides event data for the [DoubleTapped](../windows.ui.xaml/uielement_doubletapped.md) event.



## -remarks

A [DoubleTapped](../windows.ui.xaml/uielement_doubletapped.md) event is sent whenever a mouse is double-clicked or a finger or pen taps the object twice in quick succession.

## -examples

The following snippets are from *Scenario 1 - Input events* of the [Basic input sample](https://github.com/Microsoft/Windows-universal-samples/tree/fe8567faf2efdea3672c2ba642ba7b925ff6467e/Samples/BasicInput).

```cppwinrt
Scenario1::Scenario1()
{
    InitializeComponent();

    // pointer press/release handlers
    pressedTarget.PointerPressed(this, &Scenario1::target_PointerPressed);
    pressedTarget.PointerReleased(this, &Scenario1::target_PointerReleased);

    // pointer enter/exit handlers
    enterExitTarget.PointerEntered(this, &Scenario1::target_PointerEntered);
    enterExitTarget.PointerExited(this, &Scenario1::target_PointerExited);

    // gesture handlers
    tapTarget.Tapped(this, &Scenario1::target_Tapped);
    tapTarget.DoubleTapped(this, &Scenario1::target_DoubleTapped);

    holdTarget.Holding(this, &Scenario1::target_Holding);
    holdTarget.RightTapped(this, &Scenario1::target_RightTapped);
}

void Scenario1::target_DoubleTapped(Windows::Foundation::IInspectable const&, Windows::UI::Xaml::Input::DoubleTappedRoutedEventArgs const&)
{
    tapTarget.Background(Windows::UI::Xaml::Media::SolidColorBrush(Windows::UI::Colors::RoyalBlue()));
    tapTargetText.Text(L"Double-Tapped");
}
```

```cppcx
Scenario1::Scenario1()
{
    InitializeComponent();

    // pointer press/release handlers
    pressedTarget->PointerPressed += ref new PointerEventHandler(this, &Scenario1::target_PointerPressed);
    pressedTarget->PointerReleased += ref new PointerEventHandler(this, &Scenario1::target_PointerReleased);

    // pointer enter/exit handlers
    enterExitTarget->PointerEntered += ref new PointerEventHandler(this, &Scenario1::target_PointerEntered);
    enterExitTarget->PointerExited += ref new PointerEventHandler(this, &Scenario1::target_PointerExited);

    // gesture handlers
    tapTarget->Tapped += ref new TappedEventHandler(this, &Scenario1::target_Tapped);
    tapTarget->DoubleTapped += ref new DoubleTappedEventHandler(this, &Scenario1::target_DoubleTapped);

    holdTarget->Holding += ref new HoldingEventHandler(this, &Scenario1::target_Holding);
    holdTarget->RightTapped += ref new RightTappedEventHandler(this, &Scenario1::target_RightTapped);
}

void Scenario1::target_DoubleTapped(Object^ sender, DoubleTappedRoutedEventArgs^ e)
{
    tapTarget->Background = ref new SolidColorBrush(Windows::UI::Colors::RoyalBlue);
    tapTargetText->Text = "Double-Tapped";
}
```

```csharp
public Scenario1()
{
    this.InitializeComponent();

    // pointer press/release handlers
    pressedTarget.PointerPressed += new PointerEventHandler(target_PointerPressed);
    pressedTarget.PointerReleased += new PointerEventHandler(target_PointerReleased);

    // pointer enter/exit handlers
    enterExitTarget.PointerEntered += new PointerEventHandler(target_PointerEntered);
    enterExitTarget.PointerExited += new PointerEventHandler(target_PointerExited);

    // gesture handlers
    tapTarget.Tapped += new TappedEventHandler(target_Tapped);
    tapTarget.DoubleTapped += new DoubleTappedEventHandler(target_DoubleTapped);
    holdTarget.Holding += new HoldingEventHandler(target_Holding);
    holdTarget.RightTapped += new RightTappedEventHandler(target_RightTapped);
}

void target_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
{
    tapTarget.Background = new SolidColorBrush(Windows.UI.Colors.RoyalBlue);
    tapTargetText.Text = "Double-Tapped";
}
```

```vb
Public Sub New()
    Me.InitializeComponent()
    AddHandler pressedTarget.PointerPressed, New PointerEventHandler(AddressOf target_PointerPressed)
    AddHandler pressedTarget.PointerReleased, New PointerEventHandler(AddressOf target_PointerReleased)
    AddHandler enterExitTarget.PointerEntered, New PointerEventHandler(AddressOf target_PointerEntered)
    AddHandler enterExitTarget.PointerExited, New PointerEventHandler(AddressOf target_PointerExited)
    AddHandler tapTarget.Tapped, New TappedEventHandler(AddressOf target_Tapped)
    AddHandler tapTarget.DoubleTapped, New DoubleTappedEventHandler(AddressOf target_DoubleTapped)
    AddHandler holdTarget.Holding, New HoldingEventHandler(AddressOf target_Holding)
    AddHandler holdTarget.RightTapped, New RightTappedEventHandler(AddressOf target_RightTapped)
End Sub

Sub target_DoubleTapped(sender As Object, e As DoubleTappedRoutedEventArgs)
    tapTarget.Background = New SolidColorBrush(Windows.UI.Colors.RoyalBlue)
    tapTargetText.Text = "Double-Tapped"
End Sub
```

## -see-also
[RoutedEventArgs](../windows.ui.xaml/routedeventargs.md), [Basic input sample](https://github.com/Microsoft/Windows-universal-samples/tree/fe8567faf2efdea3672c2ba642ba7b925ff6467e/Samples/BasicInput)
