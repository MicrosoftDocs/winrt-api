---
-api-id: T:Windows.UI.Xaml.Media.AcrylicBrush
-api-type: winrt class
---

<!-- Class syntax.
public class AcrylicBrush : XamlCompositionBrushBase, XamlCompositionBrushBase
-->

# Windows.UI.Xaml.Media.AcrylicBrush

## -description

Paints an area with a semi-transparent material that uses multiple effects including blur and a noise texture.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Media.AcrylicBrush](/windows/winui/api/microsoft.ui.xaml.media.acrylicbrush) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | TintLuminosityOpacity |

## -see-also
[Acrylic material overview](/windows/uwp/design/style/acrylic)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Acrylic material](/windows/uwp/design/style/acrylic).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see Acrylic in action](winui2gallery:/item/Acrylic).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

To add an acrylic brush, define the three resources for dark, light and high contrast themes. Note that in high contrast, we recommend using a SolidColorBrush with the same `x:Key` as the dark/light AcrylicBrush.

> [!NOTE]
> If you don't specify a TintLuminosityOpacity value, the system will automatically adjust its value based on your TintColor and TintOpacity.

```xaml
<ResourceDictionary.ThemeDictionaries>
    <ResourceDictionary x:Key="Default">
        <AcrylicBrush x:Key="MyAcrylicBrush"
            BackgroundSource="HostBackdrop"
            TintColor="#FFFF0000"
            TintOpacity="0.8"
            TintLuminosityOpacity="0.5"
            FallbackColor="#FF7F0000"/>
    </ResourceDictionary>

    <ResourceDictionary x:Key="HighContrast">
        <SolidColorBrush x:Key="MyAcrylicBrush"
            Color="{ThemeResource SystemColorWindowColor}"/>
    </ResourceDictionary>

    <ResourceDictionary x:Key="Light">
        <AcrylicBrush x:Key="MyAcrylicBrush"
            BackgroundSource="HostBackdrop"
            TintColor="#FFFF0000"
            TintOpacity="0.8"
            TintLuminosityOpacity="0.5"
            FallbackColor="#FFFF7F7F"/>
    </ResourceDictionary>
</ResourceDictionary.ThemeDictionaries>
```

This example shows how to create an AcrylicBrush in code. If your app supports multiple OS targets, be sure to check that this API is available on the user’s machine before you use it.

```csharp
if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.Xaml.Media.AcrylicBrush"))
{
    Windows.UI.Xaml.Media.AcrylicBrush myBrush = new Windows.UI.Xaml.Media.AcrylicBrush();
    myBrush.BackgroundSource = Windows.UI.Xaml.Media.AcrylicBackgroundSource.HostBackdrop;
    myBrush.TintColor = Color.FromArgb(255, 202, 24, 37);
    myBrush.FallbackColor = Color.FromArgb(255, 202, 24, 37);
    myBrush.TintOpacity = 0.6;

    grid.Fill = myBrush;
}
else
{
    SolidColorBrush myBrush = new SolidColorBrush(Color.FromArgb(255, 202, 24, 37));

    grid.Fill = myBrush;
}
```
