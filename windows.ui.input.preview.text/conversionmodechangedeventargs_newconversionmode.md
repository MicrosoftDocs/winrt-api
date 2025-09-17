---
-api-id: P:Windows.UI.Input.Preview.Text.ConversionModeChangedEventArgs.NewConversionMode
-api-type: winrt property
---

# Windows.UI.Input.Preview.Text.ConversionModeChangedEventArgs.NewConversionMode

<!--
public Windows.UI.Input.Preview.Text.TextConversionMode NewConversionMode { get; }
-->

## -description

Gets the new conversion mode for the focused textbox after the conversion mode change event.

## -property-value

A [TextConversionMode](textconversionmode.md) value that represents the new conversion mode state for the focused textbox.

## -remarks

This property indicates the conversion mode that has been applied to the focused textbox as a result of user actions, application changes, or focus movement. The conversion mode determines how keyboard input is processed and converted by the Input Method Editor (IME).

The conversion mode change can occur due to:

- User switching between different input modes
- Application programmatically changing the conversion mode
- Focus moving between textboxes with different input requirements
- Changes in the textbox's input scope or settings

## -see-also

[ConversionModeChangedEventArgs](conversionmodechangedeventargs.md), [TextConversionMode](textconversionmode.md), [KeyboardInputProcessor](keyboardinputprocessor.md), [TextInputProvider](textinputprovider.md)

## -examples

```cpp
// Subscribe to conversion mode changes in a KeyboardInputProcessor
keyboardIme.ConversionModeChanged(auto_revoke, [](const KeyboardInputProcessor& sender, const ConversionModeChangedEventArgs& args) {
    // Get the new conversion mode
    TextConversionMode newMode = args.NewConversionMode();
    
    // Update IME behavior based on the new conversion mode
    switch (newMode)
    {
        case TextConversionMode::NativeHalfWidth:
            // Configure IME for native half-width character input
            break;
        case TextConversionMode::AlphanumericHalfWidth:
            // Configure IME for alphanumeric half-width character input
            break;
        default:
            // Handle other conversion modes
            break;
    }
});
```


