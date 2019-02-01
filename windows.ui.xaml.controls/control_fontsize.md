---
-api-id: P:Windows.UI.Xaml.Controls.Control.FontSize
-api-type: winrt property
---

<!-- Property syntax
public double FontSize { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.FontSize

## -description
Gets or sets the size of the text in this control.

## -xaml-syntax
```xaml
<control FontSize="double"/>
```


## -property-value
The size of the text in the [Control](control.md), in pixels.

## -remarks
The unit measure for [FontSize](control_fontsize.md) is pixels, measuring the line height of the characters in the font. The apparent size of text in the UI can vary based on the current scaling. If you want to use different [FontSize](control_fontsize.md) values for different scalings, you can do this using the resources system. 
<!--Need good for more info target here-->

The default value of [FontSize](control_fontsize.md) is 11.

## -examples

## -see-also
[UX guidelines for layout and scaling](https://msdn.microsoft.com/library/c388f639-6f35-4d52-bffe-53ff3f537d4b), [Quickstart: Displaying text](https://msdn.microsoft.com/library/3efa9d2a-71a5-41d3-bba4-ec6cc356d47f)
