---
-api-id: T:Windows.ApplicationModel.VoiceCommands.VoiceCommandContentTileType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.VoiceCommands.VoiceCommandContentTileType : int
-->

# VoiceCommandContentTileType

## -description
The layout template used for content tiles on the **Cortana** canvas.

Specify the template with the [ContentTileType](voicecommandcontenttile_contenttiletype.md) property.

> [!NOTE]
> All content tiles on a **Cortana** feedback screen must use the same template.

## -enum-fields
### -field TitleOnly:0
Only item title.<img src="images/VoiceCommandContentTileType_TitleOnly_small.png" alt="TitleOnly" />

### -field TitleWithText:1
Item title with up to three lines of text. <img src="images/VoiceCommandContentTileType_TitleWithText_small.png" alt="TitleWithText" />

### -field TitleWith68x68Icon:2
Item title with small, square image.

### -field TitleWith68x68IconAndText:3
Item title, up to three lines of text, and small square image. <img src="images/VoiceCommandContentTileType_TitleWith68x68IconAndText_small.png" alt="TitleWith68x68IconAndText" />

### -field TitleWith68x92Icon:4
Item title with tall image.

### -field TitleWith68x92IconAndText:5
Item title, up to three lines of text, and tall image. <img src="images/VoiceCommandContentTileType_TitleWith68x92IconAndText_small.png" alt="TitleWith68x92IconAndText" />

### -field TitleWith280x140Icon:6
Item title with wide image.

### -field TitleWith280x140IconAndText:7
Item title, up to two lines of text, and wide image. <img src="images/VoiceCommandContentTileType_TitleWith280x140IconAndText_small.png" alt="TitleWith280x140IconAndText" />


## -remarks

## -examples

## -see-also
[Windows.ApplicationModel.VoiceCommands](windows_applicationmodel_voicecommands.md), [ContentTileType](voicecommandcontenttile_contenttiletype.md), [ elements and attributes v1.2](/uwp/schemas/voicecommands/voice-command-elements-and-attributes-1-2), [Cortana interactions](/windows/apps/design/input/cortana-interactions), [Cortana design guidelines](/windows/apps/design/input/cortana-design-guidelines), [Cortana voice command sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CortanaVoiceCommand)
