---
-api-id: P:Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.ConfigurationContent
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.UIElement ConfigurationContent { get;  set; }
-->

# Windows.UI.Xaml.Controls.InkToolbarCustomPenButton.ConfigurationContent

## -description
Gets or sets the content of an optional ink stroke configuration flyout associated with the [InkToolbarCustomPenButton](inktoolbarcustompenbutton.md).

## -property-value
The contents of the flyout. The default is **null**.

## -remarks
Each feature on the [InkToolbar](inktoolbar.md) can support supplementary functionality in a flyout (an "extension glyph" on the feature button indicates to the user that the functionality is available).

To access the functionality, the feature button must be selected already, and the user must select the button again.

## -examples

## -see-also
[InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md), [IsExtensionGlyphShown](inktoolbartoolbutton_isextensionglyphshown.md)