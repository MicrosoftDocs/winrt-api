---
-api-id: T:Windows.Phone.Speech.Recognition.SpeechRecognitionUIStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Phone.Speech.Recognition.SpeechRecognitionUIStatus : int
-->

# SpeechRecognitionUIStatus

## -description
Indicates the status of the speech recognition session. 

## -enum-fields
### -field Succeeded:0
Speech recognition succeeded through the default graphical user interface (GUI).

### -field Busy:1
The speech recognizer GUI could not start because the phone’s speech feature was active, or because the app attempted speech recognition while a phone call was in progress.

### -field Cancelled:2
The user manually cancelled the speech recognizer GUI, such as by using the back button. This value is also returned if the user switches out of the app, or if a phone call is received while the GUI is active.

### -field Preempted:3
The Preempted value is returned in the following scenarios:


+ The speech recognizer GUI was interrupted by a phone call.
+ The speech recognizer GUI was superceded by an invocation of the phone's speech feature.


### -field PrivacyPolicyDeclined:4
The user declined the privacy policy.


## -remarks

## -examples

## -see-also


## -capabilities
ID_CAP_NETWORKING [Windows Phone], ID_CAP_SPEECH_RECOGNITION [Windows Phone], ID_CAP_MICROPHONE [Windows Phone]
