---
-api-id: T:Windows.UI.Xaml.Media.XamlLight
-api-type: winrt class
---

<!-- Class syntax.
public class XamlLight : DependencyObject, DependencyObject
-->

# Windows.UI.Xaml.Media.XamlLight

## -description
Provides a base class used to create XAML lights that use a [CompositionLight](./../windows.ui.composition/compositionlight.md) to apply lighting effects to XAML elements and brushes.

## -remarks

You can use XamlLight to create custom lights.

For example, it can be used to create a light that applies a composition [SpotLight](https://docs.microsoft.com/en-us/uwp/api/Windows.UI.Composition.SpotLight) to target elements to light them.

XamlLight provides methods for targeting UIElements or XAML Brushes, applying lights to trees of UIElements, and helping manage the lifetime of CompositionLight resources based on whether they're currently in use.

Custom XamlLights can be used in conjunction with custom Brushes derived from [XamlCompositionBrushBase](xamlcompositionbrushbase.md) which use a [SceneLightingEffect](https://docs.microsoft.com/en-us/uwp/api/Windows.UI.Composition.Effects.SceneLightingEffect) to controls the reflective properties of elements when being lit by a XamlLight.

### Targeting objects

If you target a [Brush](https://docs.microsoft.com/en-us/uwp/api/Windows.UI.Xaml.Media.Brush) with a XamlLight then the portions of any UIElements using that Brush will be lit by the light.

If you target a [UIElement](https://docs.microsoft.com/en-us/uwp/api/Windows.UI.Xaml.UIElement) with a XamlLight then the entire UIElement and its child UIElements will all be lit by the light.

Targets can be added and removed by calling methods on a XamlLight instance. XamlLights can also define [custom attached properties](https://docs.microsoft.com/en-us/windows/uwp/xaml-platform/custom-attached-properties) to add and remove targets from markup.

### Managing resources

When creating a XamlLight, it's usually a good practice to delay creating a [CompositionLight](https://docs.microsoft.com/en-us/uwp/api/windows.ui.composition.compositionlight) and any related resources until the light is being used. The [OnConnected](xamllight_onconnected.md) method is called when a XamlLight is first used to target an element or brush on screen, so you can override [OnConnected](xamllight_onconnected.md) to safely create resources only when they're needed.

It's also a good practice to dispose of composition resources when they're no longer in use. The [OnDisconnected](xamllight_ondisconnected.md) method is called when a XamlLight instance is no longer in use anywhere on the screen, so you can override [OnDisconnected](xamllight_disonconnected.md) to safely dispose of resources. If the XamlLight is later used again after being disconnected then [OnConnected](xamllight_onconnected.md) will be called again.

> [!WARNING]
> On Windows 10 Creators Update (SDK 15063), CompositionLight can't be accessed after Dispose is called, so setting it to **null** after calling Dispose causes an error. To work around this issue, you can save the CompositionLight to a temporary variable and call Dispose on that after you set CompositionLight to null. `var temp = CompostionLight; CompositionLight = null; temp.Dispose();`
> This issue is fixed in later versions of the SDK. See [Version adaptive apps](https://docs.microsoft.com/windows/uwp/debug-test-perf/version-adaptive-apps) for info about how to target different SDK versions.

## -examples

This example shows the definition for a custom XamlLight that applies a multicolored spotlight to targeted UIElements and Brushes:

```csharp
public sealed class OrangeSpotLight : XamlLight
{
    // Register an attached property that enables apps to set a UIElement
    // or Brush as a target for this light type in markup.
    public static readonly DependencyProperty IsTargetProperty =
        DependencyProperty.RegisterAttached(
        "IsTarget",
        typeof(bool),
        typeof(OrangeSpotLight),
        new PropertyMetadata(null, OnIsTargetChanged)
    );
    public static void SetIsTarget(DependencyObject target, bool value)
    {
        target.SetValue(IsTargetProperty, value);
    }
    public static Boolean GetIsTarget(DependencyObject target)
    {
        return (bool)target.GetValue(IsTargetProperty);
    }

    // Handle attached property changed to automatically target and untarget UIElements and Brushes.
    private static void OnIsTargetChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
    {
        var isAdding = (bool)e.NewValue;

        if (isAdding)
        {
            if (obj is UIElement)
            {
                XamlLight.AddTargetElement(GetIdStatic(), obj as UIElement);
            }
            else if (obj is Brush)
            {
                XamlLight.AddTargetBrush(GetIdStatic(), obj as Brush);
            }
        }
        else
        {
            if (obj is UIElement)
            {
                XamlLight.RemoveTargetElement(GetIdStatic(), obj as UIElement);
            }
            else if (obj is Brush)
            {
                XamlLight.RemoveTargetBrush(GetIdStatic(), obj as Brush);
            }
        }
    }

    protected override void OnConnected(UIElement newElement)
    {
        if (CompositionLight == null)
        {
            // OnConnected is called when the first target UIElement is shown on the screen.
            // This enables delaying composition object creation until it's actually necessary.
            var spotLight = Window.Current.Compositor.CreateSpotLight();
            spotLight.InnerConeColor = Colors.Orange;
            spotLight.OuterConeColor = Colors.Yellow;
            spotLight.InnerConeAngleInDegrees = 30;
            spotLight.OuterConeAngleInDegrees = 45;
            spotLight.Offset = new System.Numerics.Vector3(30, 30, 200);
            CompositionLight = spotLight;
        }
    }

    protected override void OnDisconnected(UIElement oldElement)
    {
        // OnDisconnected is called when there are no more target UIElements on the screen.
        // The CompositionLight should be disposed when no longer required.
        // For SDK 15063, see Remarks.
        if (CompositionLight != null)
        {
            CompositionLight.Dispose();
            CompositionLight = null;
        }
    }

    protected override string GetId()
    {
        return GetIdStatic();
    }

    private static string GetIdStatic()
    {
        // This specifies the unique name of the light.
        // In most cases you should use the type's FullName.
        return typeof(OrangeSpotLight).FullName;
    }
}
```

```vb
Public NotInheritable Class OrangeSpotLight
    Inherits XamlLight

    ' Register an attached property that enables apps to set a UIElement
    ' or Brush as a target for this light type in markup.
    Public Shared ReadOnly IsTargetProperty As DependencyProperty = DependencyProperty.RegisterAttached(
            "IsTarget",
            GetType(Boolean),
            GetType(OrangeSpotLight),
            New PropertyMetadata(Nothing, New PropertyChangedCallback(AddressOf OnIsTargetChanged)
            )
        )

    Public Shared Sub SetIsTarget(target As DependencyObject, value As Boolean)
        target.SetValue(IsTargetProperty, value)
    End Sub

    Public Shared Function GetIsTarget(target As DependencyObject) As Boolean
        Return DirectCast(target.GetValue(IsTargetProperty), Boolean)
    End Function

    ' Handle attached property changed to automatically target And untarget UIElements And Brushes.
    Public Shared Sub OnIsTargetChanged(obj As DependencyObject, e As DependencyPropertyChangedEventArgs)
        Dim isAdding = DirectCast(e.NewValue, Boolean)

        If isAdding Then
            If TypeOf obj Is UIElement Then
                XamlLight.AddTargetElement(GetIdStatic(), TryCast(obj, UIElement))
            ElseIf TypeOf obj Is Brush Then
                XamlLight.AddTargetBrush(GetIdStatic(), TryCast(obj, Brush))
            End If
        Else
            If TypeOf obj Is UIElement Then
                XamlLight.RemoveTargetElement(GetIdStatic(), TryCast(obj, UIElement))
            ElseIf TypeOf obj Is Brush Then
                XamlLight.RemoveTargetBrush(GetIdStatic(), TryCast(obj, Brush))
            End If
        End If
    End Sub

    Protected Overrides Sub OnConnected(newElement As UIElement)
        If CompositionLight Is Nothing Then
            ' OnConnected Is called when the first target UIElement Is shown on the screen.
            ' This enables delaying composition object creation until it's actually necessary.
            Dim spotLight = Window.Current.Compositor.CreateSpotLight()
            spotLight.InnerConeColor = Colors.Orange
            spotLight.OuterConeColor = Colors.Yellow
            spotLight.InnerConeAngleInDegrees = 30
            spotLight.OuterConeAngleInDegrees = 45
            spotLight.Offset = New System.Numerics.Vector3(30, 30, 200)
            CompositionLight = spotLight
        End If
    End Sub

    Protected Overrides Sub OnDisconnected(oldElement As UIElement)
        ' OnDisconnected Is called when there are no more target UIElements on the screen.
        ' The CompositionLight should be disposed when no longer required.
        If CompositionLight IsNot Nothing Then
            CompositionLight.Dispose()
            CompositionLight = Nothing
        End If
    End Sub

    Protected Overrides Function GetId() As String
        Return GetIdStatic()
    End Function

    Private Shared Function GetIdStatic() As String
        ' This specifies the unique name of the light.
        ' In most cases you should use the type's FullName.
        Return GetType(OrangeSpotLight).FullName
    End Function
End Class
```

```cpp
// OrangeSpotLight.h:
public ref class OrangeSpotLight sealed :
    public Windows::UI::Xaml::Media::XamlLight
{
public:
    OrangeSpotLight();

    static property Windows::UI::Xaml::DependencyProperty^ IsTargetProperty
    {
        Windows::UI::Xaml::DependencyProperty^ get() { return m_isTargetProperty; }
    };
    static void SetIsTarget(Windows::UI::Xaml::DependencyObject^ target, bool value);
    static bool GetIsTarget(Windows::UI::Xaml::DependencyObject^ target);

protected:
    virtual void OnConnected(Windows::UI::Xaml::UIElement^ newElement) override;
    virtual void OnDisconnected(Windows::UI::Xaml::UIElement^ oldElement) override;
    virtual Platform::String^ GetId() override;

private:
    static Windows::UI::Xaml::DependencyProperty^ m_isTargetProperty;
    static void OnIsTargetChanged(Windows::UI::Xaml::DependencyObject^ obj, Windows::UI::Xaml::DependencyPropertyChangedEventArgs^ e);

    inline static Platform::String^ GetIdStatic()
    {
        // This specifies the unique name of the light. In most cases you should use the type's FullName.
        return OrangeSpotLight::typeid->FullName;
    }
};

//OrangeSpotLight.cpp:

// Register an attached property that enables apps to set a UIElement or Brush as a target for this light type in markup.
DependencyProperty^ OrangeSpotLight::m_isTargetProperty = DependencyProperty::RegisterAttached(
    "IsTarget",
    bool::typeid,
    OrangeSpotLight::typeid,
    ref new PropertyMetadata(0.0, ref new PropertyChangedCallback(OnIsTargetChanged))
);

OrangeSpotLight::OrangeSpotLight()
{
}

void OrangeSpotLight::SetIsTarget(DependencyObject^ target, bool value)
{
    target->SetValue(IsTargetProperty, value);
}

bool OrangeSpotLight::GetIsTarget(DependencyObject^ target)
{
    return static_cast<bool>(target->GetValue(IsTargetProperty));
}

void OrangeSpotLight::OnIsTargetChanged(DependencyObject^ obj, DependencyPropertyChangedEventArgs^ e)
{
    auto isAdding = static_cast<bool>(e->NewValue);

    if (isAdding)
    {
        if (dynamic_cast<UIElement^>(obj))
        {
            XamlLight::AddTargetElement(GetIdStatic(), static_cast<UIElement^>(obj));
        }
        else if (dynamic_cast<Brush^>(obj))
        {
            XamlLight::AddTargetBrush(GetIdStatic(), static_cast<Brush^>(obj));
        }
    }
    else
    {
        if (dynamic_cast<UIElement^>(obj))
        {
            XamlLight::RemoveTargetElement(GetIdStatic(), static_cast<UIElement^>(obj));
        }
        else if (dynamic_cast<Brush^>(obj))
        {
            XamlLight::RemoveTargetBrush(GetIdStatic(), static_cast<Brush^>(obj));
        }
    }
}
void OrangeSpotLight::OnConnected(UIElement^ newElement)
{
    if (CompositionLight == nullptr)
    {
        // OnConnected is called when the first target UIElement is shown on the screen. This enables delaying composition object creation until it's actually necessary.
        auto spotLight = Window::Current->Compositor->CreateSpotLight();
        spotLight->InnerConeColor = Colors::Orange;
        spotLight->OuterConeColor = Colors::Yellow;
        spotLight->InnerConeAngleInDegrees = 30;
        spotLight->OuterConeAngleInDegrees = 45;
        spotLight->Offset = float3(30, 30, 200);

        CompositionLight = spotLight;
    }
}

void OrangeSpotLight::OnDisconnected(UIElement^ oldElement)
{
    // OnDisconnected is called when there are no more target UIElements on the screen. The CompositionLight should be disposed when no longer required.
    if (CompositionLight != nullptr)
    {
        delete CompositionLight;
        CompositionLight = nullptr;
    }
}

Platform::String^ OrangeSpotLight::GetId()
{
    return GetIdStatic();
}

```

The above light can then be applied to any XAML UIElement or Brush to light them. This example shows different potential usages:


```xaml
<Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
    <Grid.Lights>
        <!-- Attach a light, similar to setting a CompositionLight's CoordinateSpace property -->
        <local:OrangeSpotLight />
    </Grid.Lights>

    <StackPanel>
        <!-- this border will be lit by a OrangeSpotLight, but not its children -->
        <Border BorderThickness="5">
            <Border.BorderBrush>
                <SolidColorBrush Color="White" local:OrangeSpotLight.IsTarget="true" />
            </Border.BorderBrush>
            <TextBlock Text="hello world" />
        </Border>

        <!-- this border and its content will be lit by OrangeSpotLight -->
        <Border BorderThickness="5" BorderBrush="White" Background="White" local:OrangeSpotLight.IsTarget="true">
            <TextBlock Text="hello world" Foreground="Gray" />
        </Border>

        <!-- this border will not be lit -->
        <Border BorderThickness="5">
            <Border.BorderBrush>
                <SolidColorBrush Color="Green" />
            </Border.BorderBrush>
            <TextBlock Text="hello world" />
        </Border>
    </StackPanel>
</Grid>
```

> [!Important]
> Setting UIElement.Lights in markup as shown in the above example is only supported for apps with a Minimum Version equal to the Windows 10 Creators Update or later. For apps that target earlier minimum versions, lights must be created in code-behind.

## -see-also

- [UIElement.Lights](./../windows.ui.xaml/uielement_lights.md)

- [Using the composition Visual Layer with XAML](https://docs.microsoft.com/en-us/windows/uwp/composition/using-the-visual-layer-with-xaml)

- [Composition lighting](https://docs.microsoft.com/en-us/windows/uwp/composition/lighting)

- [CompositionLight](https://docs.microsoft.com/en-us/uwp/api/windows.ui.composition.compositionlight)
