---
-api-id: T:Windows.UI.Input.Preview.Text.ConversionModeChangedEventArgs
-api-type: winrt class
---

# Windows.UI.Input.Preview.Text.ConversionModeChangedEventArgs

<!--
public sealed class ConversionModeChangedEventArgs
-->

## -description

> [!IMPORTANT]
> The Windows.UI.Input.Preview.Text APIs are part of a Limited Access Feature (see [LimitedAccessFeatures](/uwp/api/windows.applicationmodel.limitedaccessfeatures) class). Use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409) to request an unlock token.

Provides event data for the [ConversionModeChanged](keyboardinputprocessor_conversionmodechanged.md) event that occurs when the conversion mode changes for the focused textbox.

> [!NOTE]
> To use this API in a Windows app being published to the Windows Store, you must declare the **Text Input Method custom capability** (Microsoft.appCategory.textInputMethod_8wekyb3d8bbwe) and request approval during the app submission process. See [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities) for more info.
>
> The Text Input Method capability enables several advanced features related to text input, including events for input focus (determining when to enter and exit) and the ability to read and write text within the current input focus's edit control.

## -remarks
<!--
This class is used as the event argument for the `ConversionModeChanged` event in both [KeyboardInputProcessor](keyboardinputprocessor.md) and [TextInputProvider](textinputprovider.md) classes. The conversion mode change can occur due to user actions, application changes, or focus movement between textboxes with different input requirements.
-->

This class is used as the event argument for the `ConversionModeChanged` event in the [KeyboardInputProcessor](keyboardinputprocessor.md) class. The conversion mode change can occur due to user actions, application changes, or focus movement between textboxes with different input requirements.

The conversion mode determines how keyboard input is processed and converted by the Input Method Editor (IME). For more information about keyboard IME conversion modes, see [IME Conversion Mode Values](/windows/win32/intl/ime-conversion-mode-values).

## -see-also

[NewConversionMode](conversionmodechangedeventargs_newconversionmode.md), [KeyboardInputProcessor.ConversionModeChanged](keyboardinputprocessor_conversionmodechanged.md)

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


