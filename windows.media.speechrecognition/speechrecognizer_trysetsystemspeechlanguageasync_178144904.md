---
-api-id: M:Windows.Media.SpeechRecognition.SpeechRecognizer.TrySetSystemSpeechLanguageAsync(Windows.Globalization.Language)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> SpeechRecognizer.TrySetSystemSpeechLanguageAsync(Language speechLanguage)
-->

# Windows.Media.SpeechRecognition.SpeechRecognizer.TrySetSystemSpeechLanguageAsync

## -description
Asynchronously attempts to set the system language used for speech recognition on an [IoT](https://developer.microsoft.com/en-us/windows/iot) device.

> [!NOTE]
> This method is available only in [Embedded mode](/windows/iot-core/develop-your-app/EmbeddedMode). 

## -parameters
### -param speechLanguage
The  [BCP-47](https://aka.ms/bcp47)-based system language used for speech recognition. 

## -returns
An asynchronous operation that returns true if the set operation was a success. Otherwise, returns false.

## -remarks
 Your app must declare the **systemManagement** capability, which lets apps access basic system administration privileges including locale, timezone, shut down, and reboot.

The systemManagement capability must include the iot namespace when you declare it in your app's package manifest.

```xml
<Capabilities><iot:Capability Name="systemManagement"/></Capabilities>
```

Use [SystemSpeechLanguage](speechrecognizer_systemspeechlanguage.md) to get the current system speech recognition language.

Use [Windows.Globalization.Language.IsWellFormed](/uwp/api/windows.globalization.language#Windows_Globalization_Language_IsWellFormed_System_String_) to validate *speechLanguage*.

## -see-also

[SystemSpeechLanguage](speechrecognizer_systemspeechlanguage.md), [Windows.Globalization.Language.IsWellFormed](/uwp/api/windows.globalization.language.iswellformed), [Embedded mode](/windows/iot-core/develop-your-app/EmbeddedMode), [App capability declarations](/windows/uwp/packaging/app-capability-declarations), [Set speech recognition timeouts](/windows/uwp/input-and-devices/set-speech-recognition-timeouts), [Speech interactions](/windows/uwp/input-and-devices/speech-interactions), [Speech design guidelines](/windows/uwp/input-and-devices/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)

## -examples