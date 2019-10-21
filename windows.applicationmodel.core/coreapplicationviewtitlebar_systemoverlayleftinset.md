---
-api-id: P:Windows.ApplicationModel.Core.CoreApplicationViewTitleBar.SystemOverlayLeftInset
-api-type: winrt property
---

<!-- Property syntax
public double SystemOverlayLeftInset { get; }
-->

# Windows.ApplicationModel.Core.CoreApplicationViewTitleBar.SystemOverlayLeftInset

## -description
Gets the width of the system-reserved region of the upper-left corner of the app window. This region is reserved when the current language is a right-to-left language.

## -property-value
The width of the system-reserved region of the upper-left corner of the app window

## -remarks
For applications with custom title bars, the system reserves the option to have system UI drawn in the upper-left or upper-right corner of the app window. The system draws caption buttons in the upper-right for left-to-right languages and the upper-left for right-to-left languages. The width of the reserved region on each side is given by SystemOverlayLeftInset or [SystemOverlayRightInset](coreapplicationviewtitlebar_systemoverlayrightinset.md), and its height is given by [CoreApplicationViewTitleBar.Height](coreapplicationviewtitlebar_height.md). In the areas described by these regions, apps should not put any UI which they expect the user to be able to interact with.

## -examples

## -see-also
