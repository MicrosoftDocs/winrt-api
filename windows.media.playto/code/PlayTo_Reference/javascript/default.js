// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

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


    function id(tagName) {
        return document.getElementById(tagName);
    }

    function init() {
        id("videoButton").addEventListener("click", videoButtonClick, false);
        id("audioButton").addEventListener("click", audioButtonClick, false);
        id("imageButton").addEventListener("click", imageButtonClick, false);
        id("playtoButton").addEventListener("click", playtoButtonClick, false);
        id("stopButton").addEventListener("click", stopButtonClick, false);
        id("closeButton").addEventListener("click", closeButtonClick, false);

        videoButtonClick();
    }

    // Save a reference to the current media element for PlayTo.
    var mediaElement;

    function showDiv(divName) {
        id("audioDiv").style.display = "none";
        id("aplayer").src = null;
        id("imageDiv").style.display = "none";
        id("videoDiv").style.display = "none";
        id("vplayer").src = null;
        id("playToStatusDiv").style.display = "none";

        id(divName).style.display = "block";

        switch (divName) {
            case "audioDiv":
                mediaElement = id("aplayer");
                break;
            case "videoDiv":
                mediaElement = id("vplayer");
                break;
            case "imageDiv":
                mediaElement = id("iplayer");
                break;
        }
    }

    function videoButtonClick() {
        showDiv("videoDiv");
        getVideoFile(0);
    }

    function audioButtonClick() {
        showDiv("audioDiv");
        getAudioFile(0);
    }

    function imageButtonClick() {
        showDiv("imageDiv");
        getImageFile(0);
    }

    function stopButtonClick() {
        clearConnections();
    }

    function playtoButtonClick() {
        showPlayTo();
    }

    function closeButtonClick() {
        WinJS.Application.stop;
        window.close();
    }

    function getVideoFile(fileIndex) {
        try {
            var videosLibrary = Windows.Storage.KnownFolders.videosLibrary;
            videosLibrary.getFilesAsync().then(function (resultLibrary) {
                if (resultLibrary.length > 0) {
                    id("messageDiv").innerHTML +=
        "Play video: " + resultLibrary[fileIndex].fileName + "<br/>";
                    id("vplayer").src = URL.createObjectURL(resultLibrary[fileIndex]);
                    id("vplayer").play();
                }
            });
        } catch (ex) {
            id("messageDiv").innerHTML +=
                "Exception encountered: " + ex.message + "<br/>";
        }
    }

    function getAudioFile(fileIndex) {
        try {
            var musicLibrary = Windows.Storage.KnownFolders.musicLibrary;
            musicLibrary.getFilesAsync().then(function (resultLibrary) {
                if (resultLibrary.length > 0) {
                    id("messageDiv").innerHTML +=
                        "Play audio: " + resultLibrary[fileIndex].fileName + "<br/>";
                    id("aplayer").src = URL.createObjectURL(resultLibrary[fileIndex]);
                    id("aplayer").play();
                }
            });
        } catch (ex) {
            id("messageDiv").innerHTML +=
                "Exception encountered: " + ex.message + "<br/>";
        }
    }

    function getImageFile(fileIndex) {
        try {
            var picturesLibrary = Windows.Storage.KnownFolders.picturesLibrary;
            picturesLibrary.getFilesAsync().then(function (resultLibrary) {
                if (resultLibrary.length > 0) {
                    id("messageDiv").innerHTML +=
                        "Show image: " + resultLibrary[fileIndex].fileName + "<br/>";
                    id("iplayer").src = URL.createObjectURL(resultLibrary[fileIndex]);
                }
            });
        } catch (ex) {
            id("messageDiv").innerHTML +=
                "Exception encountered: " + ex.message + "<br/>";
        }
    }


    // <SnippetSourceRequested>
    // Play To Contract

    var ptm = Windows.Media.PlayTo.PlayToManager.getForCurrentView();
    ptm.addEventListener("sourcerequested", sourceRequestHandler, false);

    function sourceRequestHandler(e) {
        try {
            e.sourceRequest.setSource(mediaElement.msPlayToSource);

        } catch (ex) {
            id("messageDiv").innerHTML += "Exception encountered: " + ex.message + "<br/>";
        }
    }
    // </SnippetSourceRequested>

    // exclude from the running application

    function exclude1() {
        // <SnippetPlayToEvents>
        var ptm = Windows.Media.PlayTo.PlayToManager.getForCurrentView();
        ptm.addEventListener("sourcerequested", sourceRequestHandlerWithEvents, false);
        ptm.addEventListener("sourceselected", sourceSelectedHandler, false);

        function sourceRequestHandlerWithEvents(e) {
            try {
                var controller = mediaElement.msPlayToSource;

                controller.connection.addEventListener("error", playToConnectionError, false);
                controller.connection.addEventListener("stateChanged", playToConnectionStageChanged, false);
                controller.connection.addEventListener("transferred", playToConnectionTransferred, false);

                e.sourceRequest.setSource(controller);

            } catch (ex) {
                id("messageDiv").innerHTML += "Exception encountered: " + ex.message + "<br/>";
            }
        }

        // Called when the user selects a Play To device to stream to.

        function sourceSelectedHandler(e) {
            if (mediaElement.id == "iplayer") {
                if (!e.supportsImage) {
                    id("messageDiv").innerHTML += e.friendlyName + " does not support streaming images. " +
                                                  "Please select a different device.";
                    return;
                }
            }

            if (mediaElement.id == "vplayer") {
                if (!e.supportsVideo) {
                    id("messageDiv").innerHTML += e.friendlyName + " does not support streaming video. " +
                                                  "Please select a different device.";
                    return;
                }
            }

            if (mediaElement.id == "aplayer") {
                if (!e.supportsAudio) {
                    id("messageDiv").innerHTML += e.friendlyName + " does not support streaming audio. " +
                                                  "Please select a different device.";
                    return;
                }
            }


            var iconBlob = window.msWWA.createBlobFromRandomAccessStream(e.icon.contentType, e.icon);
            id("playToDeviceIconImage").src = window.URL.createObjectURL(iconBlob, false);

            id("playToDeviceFriendlyName").innerHTML = e.friendlyName;

            id("playToStatusDiv").style.display = "block";
        }

        function playToConnectionError(e) {
            if (e.code == Windows.Media.PlayTo.PlayToConnectionError.deviceError |
                e.code == Windows.Media.PlayTo.PlayToConnectionError.deviceNotResponding) {

                id("messageDiv").innerHTML += "Error occurred. Disconnecting.<br/>";
            }

            id("messageDiv").innerHTML += "Error: Message = " + e.message.toString() + "<br/>";
        }

        function playToConnectionStageChanged(e) {
            id("messageDiv").innerHTML += "StateChanged: PreviousState = " + stateToString(e.previousState) + "<br/>";
            id("messageDiv").innerHTML += "StateChanged: CurrentState = " + stateToString(e.currentState) + "<br/>";
        }

        function stateToString(state) {
            switch (state) {
                case Windows.Media.PlayTo.PlayToConnectionState.connected:
                    return "Connected";
                case Windows.Media.PlayTo.PlayToConnectionState.disconnected:
                    return "Disconnected";
                case Windows.Media.PlayTo.PlayToConnectionState.rendering:
                    return "Rendering";
            }
        }

        function playToConnectionTransferred(e) {
            id("messageDiv").innerHTML += "Transferred: PreviousSource = " + e.previousSource.toString() + "<br/>";
            id("messageDiv").innerHTML += "Transferred: CurrentSource = " + e.currentSource.toString() + "<br/>";
        }

        // </SnippetPlayToEvents>
    }

    // exclude from the running application
    function exclude2() {
        // <SnippetDeferral>
        var ptm = Windows.Media.PlayTo.PlayToManager.getForCurrentView();
        ptm.addEventListener("sourcerequested", sourceRequestHandlerDeferred, false);

        function sourceRequestHandlerDeferred(e) {
            var deferral = e.sourceRequest.getDeferral();

            // Async call to get source media
            getMediaElementAsync().then(function (element) {
                e.sourceRequest.setSource(element.msPlayToSource);

                deferral.complete();
            });
        }
        // </SnippetDeferral>

        function getMediaElementAsync() {
            return mediaElement;
        }
    }

    // <SnippetShowPlayToUI>
    function showPlayTo() {
        Windows.Media.PlayTo.PlayToManager.showPlayToUI();
    }
    // </SnippetShowPlayToUI>

    app.start();
})();
