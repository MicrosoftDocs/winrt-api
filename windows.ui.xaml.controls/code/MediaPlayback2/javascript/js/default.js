// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    var media;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
                // TODO: This application has been newly launched. Initialize
                // your application here.
            } else {
                // TODO: This application has been reactivated from suspension.
                // Restore application state here.
            }
            args.setPromise(WinJS.UI.processAll());
        }
    };

    app.oncheckpoint = function (args) {
        // TODO: This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. You might use the
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to complete an
        // asynchronous operation before your application is suspended, call
        // args.setPromise().
    };

    app.start();
})();

function startVideo() {

    media = document.getElementById("mediaVideo");

    media.src = "http://go.microsoft.com/fwlink/p/?LinkID=272585";
}


// <SnippetSystemMediaTransportControlsSetupJS>
var systemMediaControls;

systemMediaControls = Windows.Media.SystemMediaTransportControls.getForCurrentView();

systemMediaControls.addEventListener("buttonpressed", systemMediaControlsButtonPressed, false);

systemMediaControls.isPlayEnabled = true;
systemMediaControls.isPauseEnabled = true;
systemMediaControls.isStopEnabled = true;

systemMediaControls.playbackStatus = Windows.Media.MediaPlaybackStatus.closed;
// </SnippetSystemMediaTransportControlsSetupJS>

// <SnippetSystemMediaTransportControlsButtonPressedJS>
// Event handler for SystemMediaTransportControls' buttonpressed event
function systemMediaControlsButtonPressed(eventIn) {

    var mediaButton = Windows.Media.SystemMediaTransportControlsButton;

    switch (eventIn.button) {
        case mediaButton.play:
            playMedia();
            break;

        case mediaButton.pause:
            pauseMedia();
            break;

        case mediaButton.stop:
            stopMedia();
            break;

        // Insert additional case statements for other buttons you want to handle
    }
}

// Plays the media.
function playMedia() {
    var media = document.getElementById("mediaVideo");
    media.play();
}

// Pauses the media.
function pauseMedia() {
    var media = document.getElementById("mediaVideo");
    media.pause();
}

// Stops the media.
function stopMedia() {
    var media = document.getElementById("mediaVideo");
    media.pause();
    media.currentTime = 0;
}
// </SnippetSystemMediaTransportControlsButtonPressedJS>

// <SnippetMediaElementEventHandlersJS>
// The media Play event handler.
function mediaPlaying() {
    // Update the SystemMediaTransportControl state.
    systemMediaControls.playbackStatus = Windows.Media.MediaPlaybackStatus.playing;
}

// The media Pause event handler.
function mediaPaused() {
    // Update the SystemMediaTransportControl state.
    systemMediaControls.playbackStatus = Windows.Media.MediaPlaybackStatus.paused;
}

// The media Ended event handler.
function mediaEnded() {
    // Update the SystemMediaTransportControl state.
    systemMediaControls.playbackStatus = Windows.Media.MediaPlaybackStatus.stopped;
}
// </SnippetMediaElementEventHandlersJS>