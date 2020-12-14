---
-api-id: T:Windows.UI.ViewManagement.ApplicationViewSwitchingOptions
-api-type: winrt enum
ms.custom: project-verbatim
---

<!-- Enumeration syntax
public enum Windows.UI.ViewManagement.ApplicationViewSwitchingOptions : uint
-->

# ApplicationViewSwitchingOptions

## -description
Defines a set of options for window (app view) switching behaviors.

## -enum-fields
### -field Default:0
Perform the standard animated transition between windows upon switching.

### -field SkipAnimation:1
Immediately transition between windows without animation.

### -field ConsolidateViews:2
Close the initial window and remove it from the list of recently used apps, and display the window to which the app is switching.

## -remarks

## -examples
Sample apps that demonstrate **ApplicationViewSwitchingOptions** include the [360-degree video playback sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/360VideoPlayback) and the [Multiple views sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/MultipleViews).

## -see-also
[360-degree video playback sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/360VideoPlayback), [Multiple views sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/MultipleViews)