---
-api-id: M:Windows.UI.Composition.Diagnostics.CompositionDebugSettings.TryGetSettings(Windows.UI.Composition.Compositor)
-api-type: winrt method
---

<!-- Method syntax.
public CompositionDebugSettings CompositionDebugSettings.TryGetSettings(Compositor compositor)
-->

# Windows.UI.Composition.Diagnostics.CompositionDebugSettings.TryGetSettings

## -description

Attempts to get an instance of CompositionDebugSettings for the specified compositor.


## -parameters
### -param compositor

The compositor to get debug settings for.

## -returns

An instance of composition debug settings, or `null` (see Remarks).

## -remarks

If [developer mode](/windows/apps/get-started/enable-your-device-for-development) is not enabled, a call to `TryGetSettings` returns `null`.

## -see-also

## -examples

