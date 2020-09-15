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
> This method is available only in [Embedded mode](/windows/iot-core/develop-your-app/EmbeddedMode).

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

Use [Windows.Globalization.ApplicationLanguages.Languages](/uwp/api/windows.globalization.applicationlanguages.Languages) to get the ranked list of current runtime language values preferred by the user.

## -examples

## -see-also

[Embedded mode](/windows/iot-core/develop-your-app/EmbeddedMode), [App capability declarations](/windows/uwp/packaging/app-capability-declarations), [Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)