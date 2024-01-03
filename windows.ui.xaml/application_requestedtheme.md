---
-api-id: P:Windows.UI.Xaml.Application.RequestedTheme
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.ApplicationTheme RequestedTheme { get;  set; }
-->

# Windows.UI.Xaml.Application.RequestedTheme

## -description

Gets or sets a value that determines the light-dark preference for the overall theme of an app.



## -xaml-syntax

```xaml
<application RequestedTheme="applicationThemeMemberName" .../>
```

## -property-value

A value of the enumeration. The initial value is the default theme set by the user in Windows settings.

## -remarks

There are two built in themes: "Light" and "Dark". By default your app runs using the theme set by the user in Windows settings (Settings > Personalization > Colors > Choose your default app mode). You can set the app's RequestedTheme property to override the user default and specify which theme is used.

The theme can only be set when the app is started, not while it's running. Attempting to set RequestedTheme while the app is running throws an exception (**NotSupportedException** for Microsoft .NET code). If you give the user an option to pick a theme that's part of app UI, you must save the setting in the app data and apply it when the app is restarted. (For more info about app settings, see [Store and retrieve settings and other app data](/windows/uwp/design/app-settings/store-and-retrieve-app-data)).

You can change specific theme values at run-time after Application.RequestedTheme is applied, if you use the [FrameworkElement.RequestedTheme](frameworkelement_requestedtheme.md) property and sets values on specific elements in the UI.

There is also a "HighContrast" theme that uses system values, but apps and app code use a different technique for switching the app to high contrast. The RequestedTheme property is ignored if the user is running in high contrast mode. See [High-contrast themes](/windows/uwp/accessibility/high-contrast-themes) and [XAML high contrast style sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20high%20contrast%20style%20sample).

Although the app can't switch the themes at run-time, the user can (starting with Windows 8.1). For example, a user might enable a high-contrast theme while your app is running, by using the Alt+Shift+PrtScn key shortcut. If this happens, the XAML resource system will recalculate the resource values for any [{ThemeResource} markup extension](/windows/uwp/xaml-platform/themeresource-markup-extension) usage. Theme-appropriate resources such as colors and brushes then use values appropriate for the current theme, even though it wasn't the app that requested that theme originally.

The resources that are theme-specific are typically defined in a separate resource dictionary in XAML. This resource dictionary comes from the [ThemeDictionaries](resourcedictionary_themedictionaries.md) property of the primary [ResourceDictionary](resourcedictionary.md) that is used for control templates. The default system resource dictionary for theme-specific resources is named ThemeResources.xaml. This file is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic folder from a Windows Software Development Kit (SDK) installation.

### Notes for previous versions

> **Windows 8.x**
> By default your app runs using the "Dark" theme (in the themeresources.xaml file, the key name for the "Dark" resources is "Default").

- On Windows, setting RequestedTheme to [ElementTheme.Default](elementtheme.md) will always result in "Dark" being the theme.
- On Windows Phone, using the [ElementTheme.Default](elementtheme.md) value will result in a query for the system theme, as set by the user.

## -examples

This example shows how to save the requested theme in local app settings, and then retrieve and apply it when the app is restarted.

```xaml
<ToggleSwitch Header="Theme" OnContent="Light" OffContent="Dark"
              Toggled="ToggleSwitch_Toggled" Loaded="ToggleSwitch_Loaded"/>
```

```csharp
private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
{
    // Save theme choice to LocalSettings. 
    // ApplicationTheme enum values: 0 = Light, 1 = Dark
    ApplicationData.Current.LocalSettings.Values["themeSetting"] =
                                                     ((ToggleSwitch)sender).IsOn ? 0 : 1;
}

private void ToggleSwitch_Loaded(object sender, RoutedEventArgs e)
{
    ((ToggleSwitch)sender).IsOn = App.Current.RequestedTheme == ApplicationTheme.Light;
}
```

**App.xaml.cs**

```csharp
public App()
{
    this.InitializeComponent();

    // Get theme choice from LocalSettings.
    object value = ApplicationData.Current.LocalSettings.Values["themeSetting"];

    if (value != null)
    {
        // Apply theme choice.
        App.Current.RequestedTheme = (ApplicationTheme)(int)value;
    }
}
```

## -see-also

[FrameworkElement.RequestedTheme](frameworkelement_requestedtheme.md), [XAML requested theme sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20requested%20theme%20sample), [High-contrast themes](/windows/uwp/accessibility/high-contrast-themes)
