---
-api-id: P:Windows.UI.StartScreen.SecondaryTile.Arguments
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string Arguments { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTile.Arguments

## -description
Gets or sets an app-defined set of information that is passed from the secondary tile to the app on activation. This property is required when you create a tile.

## -property-value
The argument string, of 2048 or fewer characters. This contents of this string are understood by the app. Any string longer than 2048 characters will cause an exception to be thrown. This string is passed to the app through the [LaunchActivatedEventArgs.Arguments](../windows.applicationmodel.activation/launchactivatedeventargs_arguments.md) property.

## -remarks
When an app is activated through this secondary tile (by click, touch, or keyboard), the tile sends this argument string to the app.

## -examples

## -see-also