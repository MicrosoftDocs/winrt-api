---
-api-id: M:Windows.UI.ViewManagement.UIViewSettings.GetPreferredInteractionMode(Windows.UI.ViewManagement.UserInteractionMode[])
-api-type: winrt method
---

# Windows.UI.ViewManagement.UIViewSettings.GetPreferredInteractionMode(Windows.UI.ViewManagement.UserInteractionMode[])

<!--
public Windows.UI.ViewManagement.UserInteractionMode GetPreferredInteractionMode (Windows.UI.ViewManagement.UserInteractionMode[] supportedModes);
-->


## -description

Of the passed-in values, and based on the current system state, retrieves the system's preferred (most appropriate) user interaction mode among the modes it supports. You can get the user interaction mode that's currently in effect for a system from [UserInteractionMode](./uiviewsettings_userinteractionmode.md).

## -parameters

### -param supportedModes

A list of user interaction modes for the system to choose a preferred one from. You must pass at least one value. And [UserInteractionMode.Mouse](./uiviewsettings_userinteractionmode.md) must be one of the values.

## -returns

Returns the system's preferred (most appropriate) user interaction mode among the modes it supports.

If the API is present but not supported, then it will return [UserInteractionMode.Mouse](./uiviewsettings_userinteractionmode.md).

## -remarks

The system's preferred user interaction mode indicates the input modality for which you should optimize your app's user interface. For example, if the preferred interaction mode is touch, then for easier touchability your app might want to add extra padding around the controls in its user interface (UI).

## -see-also

[UserInteractionMode](./uiviewsettings_userinteractionmode.md)
[PreferredInteractionModeChanged](./uiviewsettings_preferredinteractionmodechanged.md)

## -examples
