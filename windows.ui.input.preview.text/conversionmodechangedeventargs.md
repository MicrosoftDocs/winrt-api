---
-api-id: T:Windows.UI.Input.Preview.Text.ConversionModeChangedEventArgs
-api-type: winrt class
---

# Windows.UI.Input.Preview.Text.ConversionModeChangedEventArgs

<!--
public sealed class ConversionModeChangedEventArgs
-->


## -description

Provides event data for the [ConversionModeChanged](keyboardinputprocessor_conversionmodechanged.md) event that occurs when the conversion mode changes for the focused textbox.

## -remarks

This class is used as the event argument for the `ConversionModeChanged` event in both [KeyboardInputProcessor](keyboardinputprocessor.md) and [TextInputProvider](textinputprovider.md) classes. The conversion mode change can occur due to user actions, application changes, or focus movement between textboxes with different input requirements.

The conversion mode determines how keyboard input is processed and converted by the Input Method Editor (IME). For more information about keyboard IME conversion modes, see [IME Conversion Mode Values](/windows/win32/intl/ime-conversion-mode-values).

## -see-also

[NewConversionMode](conversionmodechangedeventargs_newconversionmode.md), [TextConversionMode](textconversionmode.md), [KeyboardInputProcessor.ConversionModeChanged](keyboardinputprocessor_conversionmodechanged.md), [TextInputProvider.ConversionModeChanged](textinputprovider_conversionmodechanged.md)

## -examples

```cpp
// Example with KeyboardInputProcessor
keyboardIme.ConversionModeChanged(auto_revoke, [](const KeyboardInputProcessor& sender, const ConversionModeChangedEventArgs& args) {
    TextConversionMode newMode = args.NewConversionMode();
    
    // Update IME UI or behavior based on the new conversion mode
    switch (newMode)
    {
        case TextConversionMode::NativeHalfWidth:
            // Handle native half-width character mode
            break;
        case TextConversionMode::AlphanumericHalfWidth:
            // Handle alphanumeric half-width character mode
            break;
        default:
            // Handle other conversion modes
            break;
    }
});

// Example with TextInputProvider
textInputProvider.ConversionModeChanged(auto_revoke, [](const TextInputProvider& sender, const ConversionModeChangedEventArgs& args) {
    TextConversionMode newMode = args.NewConversionMode();
    
    // Adjust text input provider behavior based on conversion mode
    printf("Conversion mode changed to: %d\n", static_cast<int>(newMode));
});
```


