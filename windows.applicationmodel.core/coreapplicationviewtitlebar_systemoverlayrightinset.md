---
-api-id: P:Windows.ApplicationModel.Core.CoreApplicationViewTitleBar.SystemOverlayRightInset
-api-type: winrt property
---

<!-- Property syntax
public double SystemOverlayRightInset { get; }
-->

# Windows.ApplicationModel.Core.CoreApplicationViewTitleBar.SystemOverlayRightInset

## -description
Gets the width of the system-reserved region of the upper-right corner of the app window. This region is reserved when the current language is a left-to-right language.

## -property-value
The width of the system-reserved region of the upper-right corner of the app window.

## -remarks
For applications with custom title bars, the system reserves the option to have system UI drawn in the upper-left or upper-right corner of the app window. The system draws caption buttons in the upper-right for left-to-right languages and the upper-left for right-to-left languages. The width of the reserved region on each side is given by [SystemOverlayLeftInset](coreapplicationviewtitlebar_systemoverlayleftinset.md) or [SystemOverlayRightInset](coreapplicationviewtitlebar_systemoverlayrightinset.md), and its height is given by [CoreApplicationViewTitleBar.Height](coreapplicationviewtitlebar_height.md). In the areas described by these regions, apps should not put any UI which they expect the user to be able to interact with.

## -examples

## -see-also
