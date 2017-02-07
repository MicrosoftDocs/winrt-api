---
-api-id: T:Windows.Media.MediaControl
-api-type: winrt class
---

<!-- Class syntax.
public class MediaControl 
-->

# Windows.Media.MediaControl

## -description
> [!NOTE]
> [MediaControl](mediacontrol.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [SystemMediaTransportControls](systemmediatransportcontrols.md).

Describes the object that applications register with, to receive media focus and transport control notifications.

## -remarks
The **MediaControl** class provides access to button press events. These events can be monitored, and can modify the response and behavior of an audio-aware app. Here is a JavaScript code snippet that shows how to add event listeners to a **MediaControl** object. It then shows how to write code to handle those events.





```javascript
// Assign the Windows.Media.MediaControl button object to 
// the user-defined mediaControls variable
mediaControls = Windows.Media.MediaControl;

// Add event listeners for the buttons
mediaControls.addEventListener(“PlayPressed”, play, false);
mediaControls.addEventListener(“PausePressed”, pause, false);
mediaControls.addEventListener(“PlayPauseTogglePressed”, playpausetoggle, false);
mediaControls.addEventListener(“NextTrackPressed”, nexttrack, false);
mediaControls.addEventListener(“PreviousTrackPressed”, previoustrack, false);
mediaControls.addEventListener(“SoundLevelChanged”, soundlevelchanged, false);

// Add code for event handlers for the events
   function play() {
      document.getElementById(“audiotag”).play();
   }

   function pause() {
      document.getElementById(“audiotag”).pause();
   }

   function playpausetoggle() {
      //<code goes here to handle the PlayPauseToggle event> 
   }
   
   ...
   // Additional code to handle the other events

```

To see the complete listing for this example, see [How to configure keys for media controls](http://go.microsoft.com/fwlink/p/?linkid=241436).

## -examples

## -see-also
[How to configure keys for media controls](http://go.microsoft.com/fwlink/p/?linkid=241436)