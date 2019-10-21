---
-api-id: M:Windows.Media.SpeechSynthesis.SpeechSynthesizer.TrySetDefaultVoiceAsync(Windows.Media.SpeechSynthesis.VoiceInformation)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> SpeechSynthesizer.TrySetDefaultVoiceAsync(VoiceInformation voice)
-->

# Windows.Media.SpeechSynthesis.SpeechSynthesizer.TrySetDefaultVoiceAsync

## -description

Asynchronously attempts to set the voice used for speech synthesis on an [IoT](https://developer.microsoft.com/windows/iot) device.

> [!NOTE]
> This method is available only in [Embedded mode](https://developer.microsoft.com/windows/iot/docs/embeddedmode).

## -parameters

### -param voice

One of the installed speech synthesis engines (voices).

## -returns

An asynchronous operation that returns true if the set operation was a success. Otherwise, returns false.

## -remarks

 Your app must declare the **systemManagement** capability, which lets apps access basic system administration privileges including locale, timezone, shut down, and reboot.

The systemManagement capability must include the iot namespace when you declare it in your app's package manifest.

```xml
<Capabilities><iot:Capability Name="systemManagement"/></Capabilities>
```

Use [Windows.Globalization.ApplicationLanguages.Languages](https://docs.microsoft.com/uwp/api/windows.globalization.applicationlanguages.Languages) to get the ranked list of current runtime language values preferred by the user.

## -examples

## -see-also

[Embedded mode](https://developer.microsoft.com/windows/iot/docs/embeddedmode)
[App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations), [Speech interactions](https://docs.microsoft.com/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://go.microsoft.com/fwlink/p/?LinkID=619897)
