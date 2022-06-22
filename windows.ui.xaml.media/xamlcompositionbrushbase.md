---
-api-id: T:Windows.UI.Xaml.Media.XamlCompositionBrushBase
-api-type: winrt class
---

<!-- Class syntax.
public class XamlCompositionBrushBase : Brush, Brush
-->

# Windows.UI.Xaml.Media.XamlCompositionBrushBase

## -description
Provides a base class used to create XAML brushes that paint an area with a [CompositionBrush](./../windows.ui.composition/compositionbrush.md).



## -remarks
You can use XamlCompositionBrushBase to create custom brushes. 

For example, it can be used to create a brush that applies [effects](/windows/uwp/composition/composition-effects) to XAML UIElements using a [CompositionEffectBrush](/uwp/api/Windows.UI.Composition.CompositionEffectBrush), or a [SceneLightingEffect](/uwp/api/Windows.UI.Composition.Effects.SceneLightingEffect) that controls the reflective properties of elements when being lit by a [XamlLight](xamllight.md), or a whole series of effects chained together to produce something more complex.

When creating a brush, it's usually a good practice to delay creating a [CompositionBrush](./../windows.ui.composition/compositionbrush.md) and any related resources until the brush is being used. The [OnConnected](xamlcompositionbrushbase_onconnected_591765711.md) method is called when a brush is first used on screen to paint an element, so you can override [OnConnected](xamlcompositionbrushbase_onconnected_591765711.md) to safely create resources only when they're needed. This means you can create an instance of a brush in a ResourceDictionary then reference that brush resource later from other parts of UI definitions and only pay the cost of creating composition resources when the brush is actually in use.

It's also a good practice to dispose of composition resources when they're no longer in use. The [OnDisconnected](xamlcompositionbrushbase_ondisconnected_510183142.md) method is called when a brush instance is no longer in use anywhere on the screen, so you can override [OnDisconnected](xamlcompositionbrushbase_ondisconnected_510183142.md) to safely dispose of resources. If the brush is later used again after being disconnected then [OnConnected](xamlcompositionbrushbase_onconnected_591765711.md) will be called again.

## -examples

This example shows the definition for a custom brush that draws a blurred copy of whatever is behind a UIElement where the brush is applied using a [Win2D](https://github.com/Microsoft/Win2D) blur effect and a [CompositionBackdropBrush](/uwp/api/Windows.UI.Composition.CompositionBackdropBrush):

```csharp
public sealed class BackdropBlurBrush : XamlCompositionBrushBase
{
    public static readonly DependencyProperty BlurAmountProperty = DependencyProperty.Register(
        "BlurAmount",
        typeof(double),
        typeof(BackdropBlurBrush),
        new PropertyMetadata(0.0, new PropertyChangedCallback(OnBlurAmountChanged)
        )
    );

    public double BlurAmount
    {
        get { return (double)GetValue(BlurAmountProperty); }
        set { SetValue(BlurAmountProperty, value); }
    }

    private static void OnBlurAmountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var brush = (BackdropBlurBrush)d;
        // Unbox and set a new blur amount if the CompositionBrush exists.
        brush.CompositionBrush?.Properties.InsertScalar("Blur.BlurAmount", (float)(double)e.NewValue);            
    }

    public BackdropBlurBrush()
    {
    }

    protected override void OnConnected()
    {
        // Delay creating composition resources until they're required.
        if (CompositionBrush == null)
        {
            var backdrop = Window.Current.Compositor.CreateBackdropBrush();                

            // Use a Win2D blur affect applied to a CompositionBackdropBrush.
            var graphicsEffect = new GaussianBlurEffect
            {
                Name = "Blur",
                BlurAmount = (float)this.BlurAmount,
                Source = new CompositionEffectSourceParameter("backdrop")
            };

            var effectFactory = Window.Current.Compositor.CreateEffectFactory(graphicsEffect, new[] { "Blur.BlurAmount" });
            var effectBrush = effectFactory.CreateBrush();

            effectBrush.SetSourceParameter("backdrop", backdrop);

            CompositionBrush = effectBrush;
        }
    }

    protected override void OnDisconnected()
    {
        // Dispose of composition resources when no longer in use.
        if (CompositionBrush != null)
        {
            CompositionBrush.Dispose();
            CompositionBrush = null;
        }
    }
}
```

```vb
Public NotInheritable Class BackdropBlurBrush
    Inherits XamlCompositionBrushBase

    Public Shared ReadOnly BlurAmountProperty As DependencyProperty = DependencyProperty.Register(
            "BlurAmount",
            GetType(Double),
            GetType(BackdropBlurBrush),
            New PropertyMetadata(0.0, New PropertyChangedCallback(AddressOf OnBlurAmountChanged)
            )
        )

    Public Property BlurAmount As Double
        Get
            Return DirectCast(GetValue(BlurAmountProperty), Double)
        End Get
        Set
            SetValue(BlurAmountProperty, Value)
        End Set
    End Property

    Private Shared Sub OnBlurAmountChanged(d As DependencyObject, e As DependencyPropertyChangedEventArgs)
        Dim brush = DirectCast(d, BackdropBlurBrush)
        ' Unbox And set a New blur amount if the CompositionBrush exists.
        brush.CompositionBrush?.Properties.InsertScalar("Blur.BlurAmount", Convert.ToSingle(DirectCast(e.NewValue, Double)))
    End Sub

    Protected Overrides Sub OnConnected()
        If Me.CompositionBrush Is Nothing Then

            Dim backdrop As CompositionBackdropBrush = Window.Current.Compositor.CreateBackdropBrush()

            ' Use a Win2D blur affect applied to a CompositionBackdropBrush.
            Dim graphicsEffect As GaussianBlurEffect = New GaussianBlurEffect()
            graphicsEffect.Name = "Blur"
            graphicsEffect.BlurAmount = Me.BlurAmount
            graphicsEffect.Source = New CompositionEffectSourceParameter("backdrop")

            Dim effectFactory As CompositionEffectFactory = Window.Current.Compositor.CreateEffectFactory(graphicsEffect, New String() {"Blur.BlurAmount"})
            Dim effectBrush As CompositionEffectBrush = effectFactory.CreateBrush()

            effectBrush.SetSourceParameter("backdrop", backdrop)

            CompositionBrush = effectBrush
        End If
    End Sub

    Protected Overrides Sub OnDisconnected()
        ' Dispose of composition resources when no longer in use.
        If CompositionBrush IsNot Nothing Then
            CompositionBrush.Dispose()
            CompositionBrush = Nothing
        End If
    End Sub
End Class
```

For the [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/intro-to-using-cpp-with-winrt) code example below, you'll need to add a **Midl File (.idl)** file to your project.

```idl
// BackdropBlurBrush.idl
namespace MyApp
{
    [default_interface]
    runtimeclass BackdropBlurBrush : Windows.UI.Xaml.Media.XamlCompositionBrushBase
    {
        BackdropBlurBrush();
        static Windows.UI.Xaml.DependencyProperty BlurAmountProperty{ get; };
        Double BlurAmount;
    }
}
```

```cppwinrt
// pch.h
// You'll need to install the Microsoft Win2D NuGet package for this code example.
#include <winrt/Microsoft.Graphics.Canvas.Effects.h>
#include <winrt/Windows.Graphics.Effects.h>

// BackdropBlurBrush.h.
struct BackdropBlurBrush : BackdropBlurBrushT<BackdropBlurBrush>
{
    BackdropBlurBrush() = default;

    static Windows::UI::Xaml::DependencyProperty BlurAmountProperty() { return m_blurAmountProperty; }

    double BlurAmount()
    {
        return winrt::unbox_value<double>(GetValue(m_blurAmountProperty));
    }

    void BlurAmount(double value)
    {
        SetValue(m_blurAmountProperty, winrt::box_value(value));
    }

    void OnConnected();
    void OnDisconnected();

    static void OnBlurAmountChanged(Windows::UI::Xaml::DependencyObject const& d, Windows::UI::Xaml::DependencyPropertyChangedEventArgs const& e);

private:
    static Windows::UI::Xaml::DependencyProperty m_blurAmountProperty;
};

// WindowBlurBrush.cpp.
Windows::UI::Xaml::DependencyProperty BackdropBlurBrush::m_blurAmountProperty =
    Windows::UI::Xaml::DependencyProperty::Register(
        L"BlurAmount",
        winrt::xaml_typename<double>(),
        winrt::xaml_typename<MyApp::BackdropBlurBrush>(),
        Windows::UI::Xaml::PropertyMetadata{ winrt::box_value(0.), Windows::UI::Xaml::PropertyChangedCallback{ &BackdropBlurBrush::OnBlurAmountChanged } }
);

void BackdropBlurBrush::OnBlurAmountChanged(Windows::UI::Xaml::DependencyObject const& d, Windows::UI::Xaml::DependencyPropertyChangedEventArgs const& e)
{
    auto brush{ d.as<MyApp::BackdropBlurBrush>() };
    // Unbox and set a new blur amount if the CompositionBrush exists.
    if (brush.CompositionBrush() != nullptr)
    {
        brush.CompositionBrush().Properties().InsertScalar(L"Blur.BlurAmount", (float)winrt::unbox_value<double>(e.NewValue()));
    }
}

void BackdropBlurBrush::OnConnected()
{
    // Delay creating composition resources until they're required.
    if (!CompositionBrush())
    {
        auto backdrop{ Windows::UI::Xaml::Window::Current().Compositor().CreateBackdropBrush() };

        // Use a Win2D blur affect applied to a CompositionBackdropBrush.
        Microsoft::Graphics::Canvas::Effects::GaussianBlurEffect graphicsEffect{};
        graphicsEffect.Name(L"Blur");
        graphicsEffect.BlurAmount(this->BlurAmount());
        graphicsEffect.Source(Windows::UI::Composition::CompositionEffectSourceParameter(L"backdrop"));

        auto effectFactory{ Windows::UI::Xaml::Window::Current().Compositor().CreateEffectFactory(graphicsEffect, { L"Blur.BlurAmount" }) };
        auto effectBrush{ effectFactory.CreateBrush() };

        effectBrush.SetSourceParameter(L"backdrop", backdrop);

        CompositionBrush(effectBrush);
    }
}

void BackdropBlurBrush::OnDisconnected()
{
    // Dispose of composition resources when no longer in use.
    if (CompositionBrush())
    {
        CompositionBrush(nullptr);
    }
}
```

```cppcx
// WindowBlurBrush.h:
public ref class BackdropBlurBrush sealed :
    public Windows::UI::Xaml::Media::XamlCompositionBrushBase
{
public:
    BackdropBlurBrush();

    static property Windows::UI::Xaml::DependencyProperty^ BlurAmountProperty
    {
        Windows::UI::Xaml::DependencyProperty^ get() { return m_blurAmountProperty; }
    };

    property double BlurAmount
    {
        double get() 
        {
            return static_cast<double>(GetValue(BlurAmountProperty));
        }
        void set(double value) 
        {
            SetValue(BlurAmountProperty, value);
        }
    };

protected:
    virtual void OnConnected() override;
    virtual void OnDisconnected() override;	
    private:
    static Windows::UI::Xaml::DependencyProperty^ m_blurAmountProperty;
    static void OnBlurAmountChanged(Windows::UI::Xaml::DependencyObject^ d, Windows::UI::Xaml::DependencyPropertyChangedEventArgs^ e);
};

// WindowBlurBrush.cpp:
DependencyProperty^ BackdropBlurBrush::m_blurAmountProperty = DependencyProperty::Register(
    "BlurAmount",
    Platform::String::typeid,
    BackdropBlurBrush::typeid,
    ref new PropertyMetadata(0.0, ref new PropertyChangedCallback(OnBlurAmountChanged))
);

BackdropBlurBrush::BackdropBlurBrush()
{
}

void BackdropBlurBrush::OnBlurAmountChanged(DependencyObject^ d, DependencyPropertyChangedEventArgs^ e)
{
    auto brush = static_cast<BackdropBlurBrush^>(d);
    // Unbox and set a new blur amount if the CompositionBrush exists
    if (brush->CompositionBrush != nullptr)
    {
        brush->CompositionBrush->Properties->InsertScalar("Blur.BlurAmount", (float)static_cast<double>(e->NewValue));
    }
}

void BackdropBlurBrush::OnConnected()
{
    // Delay creating composition resources until they're required
    if (CompositionBrush == nullptr)
    {
        auto backdrop = Window::Current->Compositor->CreateBackdropBrush();
        
        // Use a Win2D blur affect applied to a CompositionBackdropBrush
        auto graphicsEffect = ref new GaussianBlurEffect();
        graphicsEffect->Name = "Blur";
        graphicsEffect->BlurAmount = static_cast<float>(this->BlurAmount);
        graphicsEffect->Source = ref new CompositionEffectSourceParameter("backdrop");
        
        auto animatableProperties = ref new Platform::Collections::Vector<Platform::String^>();
        animatableProperties->Append("Blur.BlurAmount");

        auto effectFactory = Window::Current->Compositor->CreateEffectFactory(graphicsEffect, animatableProperties);
        auto effectBrush = effectFactory->CreateBrush();

        effectBrush->SetSourceParameter("backdrop", backdrop);

        CompositionBrush = effectBrush;
    }
}

void BackdropBlurBrush::OnDisconnected()
{
    // Dispose of composition resources when no longer in use
    if (CompositionBrush != nullptr)
    {
        delete CompositionBrush;
        CompositionBrush = nullptr;
    }
}
```

The above brush can then be used like any other XAML brush type to paint UIElements, for example:

For [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/intro-to-using-cpp-with-winrt), also add `#include "BackdropBlurBrush.h"` to `MainPage.h`.

```xaml
<Ellipse Width="100" Height="100">
    <Ellipse.Fill>
        <local:BackdropBlurBrush BlurAmount="10" />
    </Ellipse.Fill>
</Ellipse>
```

## -see-also

[Using XAML brushes](/windows/uwp/graphics/using-brushes), [Using the composition Visual Layer with XAML](/windows/uwp/composition/using-the-visual-layer-with-xaml),[Composition brushes](/windows/uwp/composition/composition-brushes)
