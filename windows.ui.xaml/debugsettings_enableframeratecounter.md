---
-api-id: P:Windows.UI.Xaml.DebugSettings.EnableFrameRateCounter
-api-type: winrt property
---

<!-- Property syntax
public bool EnableFrameRateCounter { get;  set; }
-->

# Windows.UI.Xaml.DebugSettings.EnableFrameRateCounter

## -description
Gets or sets a value that indicates whether to display frame-rate and per-frame CPU usage info. These display as an overlay of counters in the window chrome while the app runs.



## -property-value
**true** to display the overlay debug counters; otherwise, **false**.

## -remarks
The overlay debug counters have two sets of numbers. The set that appears on the upper left of the screen applies to just your app. The set that appears on the upper right applies to the system overall, and is also accounting for other apps that are drawing to the composited desktop. The right-side counter comes from the Microsoft DirectComposition components that are handling compositing for Microsoft Windows in general. Basically, if you set EnableFrameRateCounter to **true**, this also calls [IDCompositionDeviceDebug.EnableDebugCounters](/windows/desktop/api/dcomp/nf-dcomp-idcompositiondevicedebug-enabledebugcounters) in the underlying components. The result is that both the counters specific to apps using XAML and the Microsoft DirectComposition counters for all apps appear when you debug your UWP app.

The format for the frame-rate counter displayed in the window chrome is:

| *App fps* | *App CPU* | … | … | *Sys fps* | *Sys CPU* |
| --- | --- | --- | --- | --- | --- |
| 000 | 000 | … | … | 000 | 000 |
| The app's UI thread frame rate, in frames per second. | The CPU usage of the app's UI thread per frame, in milliseconds. | … | … | The system-wide composition engine frame rate, in frames per second. This is typically pegged to 60. | The system-wide overall CPU usage of the composition thread per frame, in milliseconds. |

The *App fps* value is specifically reporting on the UI thread. There could be a much higher apparent refresh rate happening in your app that's related to the composition thread, but not to the UI thread. For more info on what each thread is responsible for, see [Performance best practices for ](/previous-versions/windows/apps/hh750313(v=win.10)).

[OnLaunched](application_onlaunched_859642554.md) is a good place to change [DebugSettings](debugsettings.md) values. Another possibility is the `App()` constructor.

### Notes for previous versions

<!--The following remark is relevant for Windows 8 > 8.1 migration. No WBB not breaking-->
> **Windows 8**
> In Windows 8, the counters used a different format and didn't incorporate the Microsoft DirectComposition counters. That format was:

<table>
   <tr><td>000</td><td>000</td><td>000000</td><td>000</td><td>000</td><td>000</td></tr>
   <tr><td>*Comp fps*</td><td>*UI fps*</td><td>*Memory*</td><td>*Batch*</td><td>*Comp ms*</td><td>*UI ms*</td></tr>
</table>


+ **Comp fps:** the frame rate for the composition thread
+ **UI fps:** the frame rate for the UI thread
+ **Memory:** memory utilization for textures
+ **Batch:** the count of surfaces that are sent to the graphics processing unit (GPU)
+ **Comp ms:** time in milliseconds per frame spent on the composition thread
+ **UI ms:** time in milliseconds per frame spent on the UI thread


## -examples

## -see-also
[Performance best practices for ](/previous-versions/windows/apps/hh750313(v=win.10))
