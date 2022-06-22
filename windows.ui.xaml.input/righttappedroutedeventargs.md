---
-api-id: T:Windows.UI.Xaml.Input.RightTappedRoutedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class RightTappedRoutedEventArgs : Windows.UI.Xaml.RoutedEventArgs, Windows.UI.Xaml.Input.IRightTappedRoutedEventArgs
-->

# Windows.UI.Xaml.Input.RightTappedRoutedEventArgs

## -description

Provides event data for the [RightTapped](../windows.ui.xaml/uielement_righttapped.md) event.



## -remarks

A [RightTapped](../windows.ui.xaml/uielement_righttapped.md) event is sent whenever a mouse is right-clicked or a finger, pen, or similar pointer device completes a [Holding](../windows.ui.xaml/uielement_holding.md) event and is intended for handling secondary actions on an object.

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

void Scenario1::target_RightTapped(Windows::Foundation::IInspectable const&, Windows::UI::Xaml::Input::RightTappedRoutedEventArgs const& args)
{
    holdTarget.Background(Windows::UI::Xaml::Media::SolidColorBrush(Windows::UI::Colors::RoyalBlue()));
    holdTargetText.Text(L"Right-Tapped");
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

void Scenario1::target_RightTapped(Object^ sender, RightTappedRoutedEventArgs^ e)
{
    holdTarget->Background = ref new SolidColorBrush(Windows::UI::Colors::RoyalBlue);
    holdTargetText->Text = "Right Tapped";
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

void target_RightTapped(object sender, RightTappedRoutedEventArgs e)
{
    holdTarget.Background = new SolidColorBrush(Windows.UI.Colors.RoyalBlue);
    holdTargetText.Text = "Right Tapped";
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

Sub target_RightTapped(sender As Object, e As RightTappedRoutedEventArgs)
    holdTarget.Background = New SolidColorBrush(Windows.UI.Colors.RoyalBlue)
    holdTargetText.Text = "Right Tapped"
End Sub
```

## -see-also
[RoutedEventArgs](../windows.ui.xaml/routedeventargs.md), [Basic input sample](https://github.com/Microsoft/Windows-universal-samples/tree/fe8567faf2efdea3672c2ba642ba7b925ff6467e/Samples/BasicInput)
