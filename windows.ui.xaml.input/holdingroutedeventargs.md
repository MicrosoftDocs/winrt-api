---
-api-id: T:Windows.UI.Xaml.Input.HoldingRoutedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class HoldingRoutedEventArgs : Windows.UI.Xaml.RoutedEventArgs, Windows.UI.Xaml.Input.IHoldingRoutedEventArgs
-->

# Windows.UI.Xaml.Input.HoldingRoutedEventArgs

## -description

Provides event data for the [Holding](../windows.ui.xaml/uielement_holding.md) event.



## -remarks

A [Holding](../windows.ui.input/gesturerecognizer_holding.md) event is sent whenever a finger, pen, or similar pointing device is pressed and held on an object.

Once a short time threshold has elapsed, the event is sent with a [HoldingState](../windows.ui.input/holdingstate.md) of type [Started](../windows.ui.input/holdingstate.md).

When the device has been lifted (after a [Holding](../windows.ui.input/gesturerecognizer_holding.md) event), another [Holding](../windows.ui.input/gesturerecognizer_holding.md) event is sent with a [HoldingState](../windows.ui.input/holdingstate.md) of type [Completed](../windows.ui.input/holdingstate.md).

If the user cancels the hold after it has been started, but before it completes, a [Holding](../windows.ui.input/gesturerecognizer_holding.md) event is sent with a [HoldingState](../windows.ui.input/holdingstate.md) of type [Canceled](../windows.ui.input/holdingstate.md).

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

void Scenario1::target_Holding(Windows::Foundation::IInspectable const&, Windows::UI::Xaml::Input::HoldingRoutedEventArgs const& args)
{
    if (args.HoldingState() == Windows::UI::Input::HoldingState::Started)
    {
        holdTarget.Background(Windows::UI::Xaml::Media::SolidColorBrush(Windows::UI::Colors::DeepSkyBlue()));
        holdTargetText.Text(L"Holding");
    }
    else if (args.HoldingState() == Windows::UI::Input::HoldingState::Completed)
    {
        holdTarget.Background(Windows::UI::Xaml::Media::SolidColorBrush(Windows::UI::Colors::LightGray()));
        holdTargetText.Text(L"Held");
    }
    else
    {
        holdTarget.Background(Windows::UI::Xaml::Media::SolidColorBrush(Windows::UI::Colors::LightGray()));
        holdTargetText.Text(L"Hold Canceled");
    }
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

void Scenario1::target_Holding(Object^ sender, HoldingRoutedEventArgs^ e)
{
    if (e->HoldingState == Windows::UI::Input::HoldingState::Started)
    {
        holdTarget->Background = ref new SolidColorBrush(Windows::UI::Colors::DeepSkyBlue);
        holdTargetText->Text = "Holding";
    }
    else if (e->HoldingState == Windows::UI::Input::HoldingState::Completed)
    {
        holdTarget->Background = ref new SolidColorBrush(Windows::UI::Colors::LightGray);
        holdTargetText->Text = "Held";
    }
    else
    {
        holdTarget->Background = ref new SolidColorBrush(Windows::UI::Colors::LightGray);
        holdTargetText->Text = "Hold Canceled";
    }
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

void target_Holding(object sender, HoldingRoutedEventArgs e)
{
    if (e.HoldingState == Windows.UI.Input.HoldingState.Started)
    {
        holdTarget.Background = new SolidColorBrush(Windows.UI.Colors.DeepSkyBlue);
        holdTargetText.Text = "Holding";
    }
    else if (e.HoldingState == Windows.UI.Input.HoldingState.Completed)
    {
        holdTarget.Background = new SolidColorBrush(Windows.UI.Colors.LightGray);
        holdTargetText.Text = "Held";
    }
    else
    {
        holdTarget.Background = new SolidColorBrush(Windows.UI.Colors.LightGray);
        holdTargetText.Text = "Hold Canceled";
    }
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

Sub target_Holding(sender As Object, e As HoldingRoutedEventArgs)
    If e.HoldingState = Windows.UI.Input.HoldingState.Started Then
        holdTarget.Background = New SolidColorBrush(Windows.UI.Colors.DeepSkyBlue)
        holdTargetText.Text = "Holding"
    ElseIf e.HoldingState = Windows.UI.Input.HoldingState.Completed Then
        holdTarget.Background = New SolidColorBrush(Windows.UI.Colors.LightGray)
        holdTargetText.Text = "Held"
    Else
        holdTarget.Background = New SolidColorBrush(Windows.UI.Colors.LightGray)
        holdTargetText.Text = "Hold Canceled"
    End If
End Sub
```

## -see-also
[RoutedEventArgs](../windows.ui.xaml/routedeventargs.md), [Basic input sample](https://github.com/Microsoft/Windows-universal-samples/tree/fe8567faf2efdea3672c2ba642ba7b925ff6467e/Samples/BasicInput)
