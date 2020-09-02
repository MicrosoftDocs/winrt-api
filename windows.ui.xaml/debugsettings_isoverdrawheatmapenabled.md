---
-api-id: P:Windows.UI.Xaml.DebugSettings.IsOverdrawHeatMapEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsOverdrawHeatMapEnabled { get;  set; }
-->

# Windows.UI.Xaml.DebugSettings.IsOverdrawHeatMapEnabled

## -description
Gets or sets a value that enables a debug setting that visualizes overdraw operations. This visualization is useful during application development for detecting layout, animation, and other operations that are graphics processing intensive.

## -property-value
**true** to enable the visualization, otherwise, **false**.

## -remarks
Use this property as a debugging aid to visibly detect areas of the UI where applying a [CacheMode](uielement_cachemode.md) for textures might be useful. For more info, see "Cache static content" section of [Optimize your XAML markup](/windows/uwp/debug-test-perf/optimize-xaml-loading).

[OnLaunched](application_onlaunched_859642554.md) is a good place to change [DebugSettings](debugsettings.md) values.

## -examples

## -see-also
[EnableFrameRateCounter](debugsettings_enableframeratecounter.md), [Performance best practices for ](/previous-versions/windows/apps/hh750313(v=win.10))
