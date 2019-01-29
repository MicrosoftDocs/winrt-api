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
> This method is available only in [Embedded mode](https://developer.microsoft.com/windows/iot/docs/embeddedmode). 

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

Use [Windows.Globalization.Language.IsWellFormed](https://docs.microsoft.com/uwp/api/windows.globalization.language#Windows_Globalization_Language_IsWellFormed_System_String_) to validate *speechLanguage*.

## -see-also
- [SystemSpeechLanguage](speechrecognizer_systemspeechlanguage.md)
- [Windows.Globalization.Language.IsWellFormed](https://docs.microsoft.com/uwp/api/windows.globalization.language#Windows_Globalization_Language_IsWellFormed_System_String_)

### How-to's
- [Embedded mode](https://developer.microsoft.com/windows/iot/docs/embeddedmode)
- [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations)
- [Set speech recognition timeouts](http://msdn.microsoft.com/library/58f446ac-4a56-454d-8125-62a2c4dbfcc8)
- [Speech interactions](http://msdn.microsoft.com/library/646db3ce-fa81-4727-8c21-936c81079439)
- [Speech design guidelines](http://msdn.microsoft.com/library/4a63a8c4-4182-4e36-ba12-4c343a56fca9)


### Samples
- [Speech recognition and speech synthesis sample](http://go.microsoft.com/fwlink/p/?LinkID=619897)

## -examples

