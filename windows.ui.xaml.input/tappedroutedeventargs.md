---
-api-id: T:Windows.UI.Xaml.Input.TappedRoutedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class TappedRoutedEventArgs : Windows.UI.Xaml.RoutedEventArgs, Windows.UI.Xaml.Input.ITappedRoutedEventArgs
-->

# Windows.UI.Xaml.Input.TappedRoutedEventArgs

## -description

Provides event data for the [Tapped](../windows.ui.xaml/uielement_tapped.md) event.



## -remarks

A [Tapped](../windows.ui.xaml/uielement_tapped.md) event is sent whenever a mouse is clicked or a finger or pen taps the object

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

void Scenario1::target_Tapped(Windows::Foundation::IInspectable const&, Windows::UI::Xaml::Input::TappedRoutedEventArgs const& args)
{
    tapTarget.Background(Windows::UI::Xaml::Media::SolidColorBrush(Windows::UI::Colors::DeepSkyBlue()));
    tapTargetText.Text(L"Tapped");
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

void Scenario1::target_Tapped(Object^ sender, TappedRoutedEventArgs^ e)
{
    tapTarget->Background = ref new SolidColorBrush(Windows::UI::Colors::DeepSkyBlue);
    tapTargetText->Text = "Tapped";
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

void target_Tapped(object sender, TappedRoutedEventArgs e)
{
    tapTarget.Background = new SolidColorBrush(Windows.UI.Colors.DeepSkyBlue);
    tapTargetText.Text = "Tapped";
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

Sub target_Tapped(sender As Object, e As TappedRoutedEventArgs)
    tapTarget.Background = New SolidColorBrush(Windows.UI.Colors.DeepSkyBlue)
    tapTargetText.Text = "Tapped"
End Sub
```

## -see-also
[RoutedEventArgs](../windows.ui.xaml/routedeventargs.md), [Basic input sample](https://github.com/Microsoft/Windows-universal-samples/tree/fe8567faf2efdea3672c2ba642ba7b925ff6467e/Samples/BasicInput)
