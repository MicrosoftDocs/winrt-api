// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    // <SnippetInitialize_JS>
    app.onactivated = function (args) {
        if (args.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
            if (args.detail.previousExecutionState !== Windows.ApplicationModel.Activation.ApplicationExecutionState.terminated) {
                startReceiverButton.addEventListener("click", startReceiverButton_Click);
                stopReceiverButton.addEventListener("click", stopReceiverButton_Click);
            } else {
                // TODO: This application has been reactivated from suspension. 
                // Restore application state here.
            }
            args.setPromise(WinJS.UI.processAll());
        }
    };
    // </SnippetInitialize_JS>

    app.oncheckpoint = function (args) {
        // TODO: This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. You might use the 
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to complete an
        // asynchronous operation before your application is suspended, call
        // eventObject.setPromise(). 
    };

    // <SnippetStartAndStop_JS>
    var receiver;
    var display;
    var videoPlayer;

    function startReceiverButton_Click() {
        try {
            if (receiver == null) {
                receiver = new Windows.Media.PlayTo.PlayToReceiver();
            }

            // Add Play To Receiver events and properties
            receiver.addEventListener("currenttimechangerequested", receiver_CurrentTimeChangeRequested);
            receiver.addEventListener("mutechangerequested", receiver_MuteChangeRequested);
            receiver.addEventListener("pauserequested", receiver_PauseRequested);
            receiver.addEventListener("playbackratechangerequested", receiver_PlaybackRateChangeRequested);
            receiver.addEventListener("playrequested", receiver_PlayRequested);
            receiver.addEventListener("sourcechangerequested", receiver_SourceChangeRequested);
            receiver.addEventListener("stoprequested", receiver_StopRequested);
            receiver.addEventListener("timeupdaterequested", receiver_TimeUpdateRequested);
            receiver.addEventListener("volumechangerequested", receiver_VolumeChangeRequested);

	    // <SnippetProperties>
            receiver.friendlyName = "Sample Play To Receiver";
            receiver.supportsAudio = false;
            receiver.supportsVideo = true;
            receiver.supportsImage = false;
	    // </SnippetProperties>

            // Add MediaElement events
            videoPlayer = document.getElementById("videoPlayer");
            videoPlayer.addEventListener("durationchange",videoPlayer_DurationChange); 
            videoPlayer.addEventListener("ended", videoPlayer_Ended); 
            videoPlayer.addEventListener("error", videoPlayer_Error);
            videoPlayer.addEventListener("loadedmetadata", videoPlayer_LoadedMetadata); 
            videoPlayer.addEventListener("pause", videoPlayer_Pause); 
            videoPlayer.addEventListener("playing", videoPlayer_Playing); 
            videoPlayer.addEventListener("ratechange", videoPlayer_RateChange); 
            videoPlayer.addEventListener("seeked", videoPlayer_Seeked); 
            videoPlayer.addEventListener("seeking", videoPlayer_Seeking); 
            videoPlayer.addEventListener("volumechange", videoPlayer_VolumeChange); 

	    // <SnippetStartAsync>
            // Advertise the receiver on the local network and start receiving commands
            receiver.startAsync().done(function () {
                // Prevent the screen from locking
                if (display == null) {
                    display = new Windows.System.Display.DisplayRequest();
                }
                display.requestActive();

                statusDiv.innerHTML = "'" + receiver.friendlyName + "' started.";
            });
	    // </SnippetStartAsync>


        }
        catch(e) {
            receiver = null;
            statusDiv.innerHTML = "Failed to start receiver.";
        }
    }

    function stopReceiverButton_Click(e) {
        try {
	    // <SnippetStopAsync>
            if (receiver != null) {
                receiver.stopAsync().done(function() {
                    if (display != null)
                        display.requestRelease();

                    // Remove Play To Receiver events
                    receiver.removeEventListener("currenttimechangerequested", receiver_CurrentTimeChangeRequested);
                    receiver.removeEventListener("mutechangerequested", receiver_MuteChangeRequested);
                    receiver.removeEventListener("pauserequested", receiver_PauseRequested);
                    receiver.removeEventListener("playbackratechangerequested", receiver_PlaybackRateChangeRequested);
                    receiver.removeEventListener("playrequested", receiver_PlayRequested);
                    receiver.removeEventListener("sourcechangerequested", receiver_SourceChangeRequested);
                    receiver.removeEventListener("stoprequested", receiver_StopRequested);
                    receiver.removeEventListener("timeupdaterequested", receiver_TimeUpdateRequested);
                    receiver.removeEventListener("volumechangerequested", receiver_VolumeChangeRequested);

                    //  Remove MediaElement events
                    videoPlayer = document.getElementById("videoPlayer");
                    if (videoPlayer.readyState != 0) {
                        videoPlayer.pause();
                        videoPlayer.currentTime = 0;
                    }

                    videoPlayer.removeEventListener("durationchange",videoPlayer_DurationChange); 
                    videoPlayer.removeEventListener("ended", videoPlayer_Ended); 
                    videoPlayer.removeEventListener("error", videoPlayer_Error);
                    videoPlayer.removeEventListener("loadedmetadata", videoPlayer_LoadedMetadata); 
                    videoPlayer.removeEventListener("pause", videoPlayer_Pause); 
                    videoPlayer.removeEventListener("playing", videoPlayer_Playing); 
                    videoPlayer.removeEventListener("ratechange", videoPlayer_RateChange); 
                    videoPlayer.removeEventListener("seeked", videoPlayer_Seeked); 
                    videoPlayer.removeEventListener("seeking", videoPlayer_Seeking); 
                    videoPlayer.removeEventListener("volumechange", videoPlayer_VolumeChange); 

                    statusDiv.innerHTML = "Stopped receiver.";
                });
            }
	    // </SnippetStopAsync>
        }
        catch (e) {
            statusDiv.innerHTML = "Failed to stop '" + receiver.FriendlyName + "'.";
        }
    }
    // </SnippetStartAndStop_JS>

    // <SnippetReceiverEvents_JS>
    // <SnippetCurrentTimeChangeRequested>
    function receiver_CurrentTimeChangeRequested(args) {
        if (videoPlayer.currentTime !== 0 || args.time !== 0) {
            videoPlayer.currentTime = args.time / 1000;
        }
    }
    // </SnippetCurrentTimeChangeRequested>

    // <SnippetMuteChangeRequested>
    function receiver_MuteChangeRequested(args) {
        videoPlayer.muted = args.mute;
    }
    // </SnippetMuteChangeRequested>

    // <SnippetPauseRequested>
    function receiver_PauseRequested() {
        videoPlayer.pause();
    }

    // </SnippetPauseRequested>

    // <SnippetPlaybackRateChangeRequested>
    function receiver_PlaybackRateChangeRequested(args) {
        videoPlayer.playbackRate = args.rate;
    }
    // </SnippetPlaybackRateChangeRequested>

    // <SnippetPlayRequested>
    function receiver_PlayRequested() {
        videoPlayer.play();
    }
    // </SnippetPlayRequested>

    // <SnippetSourceChangeRequested>
    function receiver_SourceChangeRequested(args) {
        if (args.stream != null) {
            var mediaStream = MSApp.createBlobFromRandomAccessStream(args.stream.contentType, args.stream);
            videoPlayer.src = URL.createObjectURL(mediaStream, false);
        }
    }
    // </SnippetSourceChangeRequested>

    // <SnippetStopRequested>
    function receiver_StopRequested() {
        if (videoPlayer.readyState != 0) {
            videoPlayer.pause();
            videoPlayer.currentTime = 0;
        }
    }
    // </SnippetStopRequested>

    // <SnippetTimeUpdateRequested>
    function receiver_TimeUpdateRequested() {
        receiver.notifyTimeUpdate(videoPlayer.currentTime * 1000);
    }
    // </SnippetTimeUpdateRequested>

    // <SnippetVolumeChangeRequested>
    function receiver_VolumeChangeRequested(args) {
        videoPlayer.volume = args.volume;
    }
    // </SnippetVolumeChangeRequested>
    // </SnippetReceiverEvents_JS>

// <SnippetPlayerEvents_JS>
    // <SnippetNotifyDurationChange>
    function videoPlayer_DurationChange() {
        if (videoPlayer.duration !== Infinity)
        {
            receiver.notifyDurationChange(videoPlayer.duration * 1000);
        }
    }

    function videoPlayer_LoadedMetadata () { 
        receiver.notifyLoadedMetadata(); 
    }
    // </SnippetNotifyDurationChange>

    // <SnippetNotifyEnded>
    function videoPlayer_Ended () { 
        receiver.notifyEnded(); 
    }
    // </SnippetNotifyEnded>    

    // <SnippetNotifyPlayPauseStopError>
    function videoPlayer_Error() {
        receiver.notifyError();
        receiver.notifyStopped();
    }

    function videoPlayer_Pause () { 
        receiver.notifyPaused(); 
    }

    function videoPlayer_Playing () { 
        receiver.notifyPlaying(); 
    }
    // </SnippetNotifyPlayPauseStopError>
    
    // <SnippetNotifyRateChange>
    function videoPlayer_RateChange () { 
        receiver.notifyRateChange(videoPlayer.playbackRate); 
    }
    // </SnippetNotifyRateChange>

    // <SnippetNotifySeek>
    function videoPlayer_Seeked () { 
        receiver.notifySeeked(); 
    }

    function videoPlayer_Seeking () { 
        receiver.notifySeeking(); 
    }
    // </SnippetNotifySeek>

    // <SnippetNotifyVolumeChanged>
    function videoPlayer_VolumeChange() {
        receiver.notifyVolumeChange(videoPlayer.volume, videoPlayer.muted);
    }
    // </SnippetNotifyVolumeChanged>
    // </SnippetPlayerEvents_JS>

    app.start();
})();
