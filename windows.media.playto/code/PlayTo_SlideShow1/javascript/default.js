// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    WinJS.Binding.optimizeBindingReferences = true;

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    // <SnippetInitialize>
    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {

            startSlideShow();

            args.setPromise(WinJS.UI.processAll());
        }
    };

    // Disconnect button event handler.
    function disconnectButtonClick() {
        Windows.Media.PlayTo.PlayToManager.showPlayToUI();
    }

    // Shortcut function.
    function id(tagName) {
        return document.getElementById(tagName);
    }
    // </SnippetInitialize>

    app.oncheckpoint = function (args) {
        // TODO: This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. You might use the
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to complete an
        // asynchronous operation before your application is suspended, call
        // args.setPromise().
    };

    // <SnippetSlideShow>
    var states = Windows.Media.PlayTo.PlayToConnectionState, // alias for PlayToConnectionState
        imageList,               // contains the list of images to show
        streaming = false,       // true when streaming using Play To; otherwise false
        cancel = 0,              // used to cancel a timeout
        timeLapse = 5,           // time between images (5 seconds)
        imageSize = "600px",     // size of current displayed image
        thumbnailSize = "200px", // size of "thumbnail" of next image
        currentImage = 0;        // index of the current image from imageList

    // Get the list of images from the Pictures folder and start the slide show.

    function startSlideShow() {
        Windows.Storage.KnownFolders.picturesLibrary.getFilesAsync().then(
            function (resultsLibrary) {
                imageList = resultsLibrary;
                if (imageList.length > 0) {
                    var image = queueImage(0, true);
                } else {
                    id("messageDiv").innerHTML = "There are no images in the Pictures library.";
                }
            });
    }


    // playNextImage
    // Called when a new image is displayed due to a timeout.
    // Removes the current image object and queues a new next image.
    // Sets the next image index as the new current image, and increases the size 
    // of the new current image. Then sets the timeout to display the next image.

    function playNextImage(num) {
        id("slideshowDiv").removeChild(id("image" + num));
        queueImage(num + 2, false);

        currentImage = num + 1;
        id("image" + currentImage).style.width = imageSize;

        cancel = setTimeout(function () {
            playNextImage(num + 1);
        }, timeLapse * 1000);
    }


    // queueImage
    // Called to create an image object for the displayed images.

    function queueImage(num, isFirstImage) {

        // Create the image element for the specified image index and add to the
        // slide show div.

        var image = document.createElement("img");
        image.style.width = (isFirstImage ? imageSize : thumbnailSize);
        image.id = "image" + num;
        image.src = URL.createObjectURL(imageList[num % imageList.length], { oneTimeOnly: true });
        id("slideshowDiv").appendChild(image);

        // If this is the first image of the slide show, queue the next image. Do
        // not queue if streaming as images are already queued before
        // streaming using Play To.

        if (isFirstImage && !streaming) {

            queueImage(num + 1, false);

            cancel = setTimeout(function () {
                playNextImage(num);
            }, timeLapse * 1000);            
        }

        // Use the transferred event of the Play To connection for the current image object
        // to "move" to the next image in the slide show. The transferred event occurs
        // when the PlayToSource.playNext() method is called, or when the Play To
        // Receiver selects the next image.

        image.msPlayToSource.connection.addEventListener("transferred", function () {

            currentImage = num + 1;
            id("image" + currentImage).style.width = imageSize;

        }, false);


        // Use the statechanged event to determine which action to take or to respond
        // if the Play To Receiver is disconnected.
        image.msPlayToSource.connection.addEventListener("statechanged", function (e) {

            switch (e.currentState) {
                case states.disconnected:

                    // If the state is disconnected and the current image index equals the 
                    // num value passed to queueImage, then the image element is not connected 
                    // to the Play To Receiver any more. Restart the slide show.
                    // Otherwise, the current image has been discarded and the slide show
                    // has moved to the next image. Clear the current image object and
                    // remove it from the slide show div.

                    if (currentImage == num) {
                        id("messageDiv").innerHTML = "Slideshow disconnected";

                        // Cancel any existing timeout
                        if (cancel) {
                            clearTimeout(cancel);
                        }

                        // Clear all image objects from the slide show div
                        while (id("slideshowDiv").firstChild) {
                            id("slideshowDiv").removeChild(id("slideshowDiv").firstChild);
                        }

                        // Reset the slide show objects and values to their beginning state
                        streaming = false;
                        id("disconnectButton").style.display = "none";
                        id("instructionsDiv").style.display = "block";
                        disconnectButton.removeEventListener("click", disconnectButtonClick, false);

                        // Restart the slide show from the current image index
                        queueImage(currentImage, true);
                    } else {
                        image.msPlayToSource.next = null;
                        image.removeAttribute("src");

                        if (streaming) {
                            id("slideshowDiv").removeChild(image);
                        }
                    }

                    break;
                    
                case states.connected:

                    // If the state is connected and the previous state is disconnected, 
                    // then the image element is newly connected. Queue up the next image so 
                    // that it is loaded while the current image is being displayed.
                    // If the previous state is rendering, then the user has paused the slideshow 
                    // on the Play To Receiver. Clear the current timeout until the user restarts
                    // the slide show.

                    if (e.previousState === states.disconnected) {
                        var imageNext = queueImage(num + 1, false);
                        image.msPlayToSource.next = imageNext.msPlayToSource;
                    } else if (e.previousState === states.rendering) {
                        if (cancel) {
                            clearTimeout(cancel);
                            cancel = 0;
                        }
                    }

                    if (currentImage == num) {
                        id("messageDiv").innerHTML = "Slideshow connected";
                    }

                    break;

                case states.rendering:

                    // If the state is rendering and the previous state is
                    // connected, then the Play To Receiver has restarted
                    // the slide show.

                    if (e.previousState === states.connected) {

                        // Clear any existing timeout.
                        if (cancel) {
                            clearTimeout(cancel);
                        }

                        // Restart the slide show.
                        cancel = setTimeout(function () {
                            image.msPlayToSource.playNext();
                        }, timeLapse * 1000);
                    }

                    if (currentImage == num) {
                        id("messageDiv").innerHTML = "Slideshow rendering";
                    }

                    break;
            }

        }, false);

        return image;
    }
    // </SnippetSlideShow>

    // <SnippetPlayToContract>
    // Set up the Play To contract.

    // Used to pass an image to Play To that will not be removed/destroyed
    // by the slide show logic. For example, if the user opens the Devices
    // charm and the sourcerequested event fires, but the image display timeout
    // completes before the user selects a target device, then the image that
    // was being displayed is removed and destroyed. intialImage is never 
    // destroyed so Play To will always have a valid source to stream.
    var initialImage = null;

    var ptm = Windows.Media.PlayTo.PlayToManager.getForCurrentView();

    ptm.addEventListener("sourcerequested", function (e) {
        initialImage = document.createElement("img");

        // Use the statechanged event of the image passed to Play To to determine when
        // the image is finally connected to the Play To Receiver.
        initialImage.msPlayToSource.connection.addEventListener("statechanged", function (e) {

            if (e.currentState === states.connected) {

                // Clear any existing timeout.
                if (cancel) {
                    clearTimeout(cancel);
                    cancel = 0;
                }

                // Clear the slide show div.
                while (id("slideshowDiv").firstChild) {
                    id("slideshowDiv").removeChild(id("slideshowDiv").firstChild);
                }

                // Set the slide show objects and values to show that we are streaming.
                streaming = true;
                id("disconnectButton").style.display = "block";
                id("instructionsDiv").style.display = "none";

                // Queue and display the next image.
                var image = queueImage(currentImage, true);
                initialImage.msPlayToSource.next = image.msPlayToSource;
                initialImage.msPlayToSource.playNext();
            }
        }, false);

        // Provide Play To with the first image to stream.
        e.sourceRequest.setSource(initialImage.msPlayToSource);

    }, false);

    // Update the once the user has selected a device to stream to.
    ptm.addEventListener("sourceselected", function (e) {
        disconnectButton.addEventListener("click", disconnectButtonClick, false);
        id("messageDiv").innerHTML = "Streaming to " + e.friendlyName + "...";
        id("deviceSpan").innerHTML = e.friendlyName + ".<br/>Click here to disconnect.";
        id("iconImage").src = URL.createObjectURL(e.icon, { oneTimeOnly: true });
    }, false);
    // </SnippetPlayToContract>

    app.start();
})();
