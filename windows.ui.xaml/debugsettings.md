---
-api-id: T:Windows.UI.Xaml.DebugSettings
-api-type: winrt class
---

<!-- Class syntax.
public class DebugSettings : Windows.UI.Xaml.IDebugSettings, Windows.UI.Xaml.IDebugSettings2, Windows.UI.Xaml.IDebugSettings3
-->

# Windows.UI.Xaml.DebugSettings

## -description
Declares how certain aspects of the app behave when it is run in a debug environment



## -remarks
This class can't be constructed. Get the value from [Application.DebugSettings](application_debugsettings.md) and then change the properties as necessary.

[OnLaunched](application_onlaunched_859642554.md) is a good place to change DebugSettings values.

Not all modes enabled by DebugSettings require that a debugger is attached. For example, the frame-rate counter associated with [EnableFrameRateCounter](debugsettings_enableframeratecounter.md) will appear in an app that runs with that setting even if you activate it as a tile without the debugger.

Don't leave any DebugSettings properties explicitly set in your production code.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | FailFastOnErrors |

## -examples
This example shows an [OnLaunched](application_onlaunched_859642554.md) override that accesses [Application.DebugSettings](application_debugsettings.md) and sets two properties of the singleton DebugSettings value to **true**. The context of this code is the app.xaml code-behind, so **this** refers to the created [Application](application.md) object for the app.

```csharp
protected override void OnLaunched(LaunchActivatedEventArgs args) {
    this.DebugSettings.EnableFrameRateCounter = true;
    this.DebugSettings.IsOverdrawHeatMapEnabled = true;
    //...
}
```



## -see-also
[Application.DebugSettings](application_debugsettings.md), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth), [Performance best practices for ](/previous-versions/windows/apps/hh750313(v=win.10))
