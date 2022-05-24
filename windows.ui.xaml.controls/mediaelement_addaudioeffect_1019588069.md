---
-api-id: M:Windows.UI.Xaml.Controls.MediaElement.AddAudioEffect(System.String,System.Boolean,Windows.Foundation.Collections.IPropertySet)
-api-type: winrt method
---

<!-- Method syntax
public void AddAudioEffect(System.String effectID, System.Boolean effectOptional, Windows.Foundation.Collections.IPropertySet effectConfiguration)
-->

# Windows.UI.Xaml.Controls.MediaElement.AddAudioEffect

## -description
Applies an audio effect to playback. Takes effect for the next source that is set on this [MediaElement](mediaelement.md).


## -parameters
### -param effectID
The identifier for the desired effect.

### -param effectOptional
**true** if the effect shouldn't block playback when the effect can't be used at run time. **false** if the effect should block playback when the effect can't be used at run time.

### -param effectConfiguration
A property set that transmits property values to specific effects as selected by *effectID*.

## -remarks
The audio effects needs to be added before loading the source. Otherwise, it will be applied for the next source that is set on this [MediaElement](mediaelement.md).

## -examples

## -see-also
