---
-api-id: P:Windows.UI.Input.Preview.Text.ConversionModeChangedEventArgs.NewConversionMode
-api-type: winrt property
prerelease: true
---

# Windows.UI.Input.Preview.Text.ConversionModeChangedEventArgs.NewConversionMode

<!--
public Windows.UI.Input.Preview.Text.TextConversionMode NewConversionMode { get; }
-->

## -description

> [!IMPORTANT]
> The Windows.UI.Input.Preview.Text APIs are part of a Limited Access Feature (see [LimitedAccessFeatures](/uwp/api/windows.applicationmodel.limitedaccessfeatures) class). Use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409) to request an unlock token.

Gets the new conversion mode for the focused textbox after the conversion mode change event.

> [!NOTE]
> To use this API in a Windows app being published to the Windows Store, you must declare the **Text Input Method custom capability** (Microsoft.appCategory.textInputMethod_8wekyb3d8bbwe) and request approval during the app submission process. See [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities) for more info.
>
> The Text Input Method capability enables several advanced features related to text input, including events for input focus (determining when to enter and exit) and the ability to read and write text within the current input focus's edit control.

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
