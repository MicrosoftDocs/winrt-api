// <SnippetInkComplete>
//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

// <SnippetJS> 
// Windows Store app that demonstrates the use of the Windows.UI.Input.Inking APIs.

// Ink functionality is documented at http://go.microsoft.com/fwlink/?LinkID=260649.
// User interaction functionality is documented at http://go.microsoft.com/fwlink/?LinkID=260650.
// Ink APIs are documented at http://go.microsoft.com/fwlink/?LinkID=260652.
// Pointer APIs are documented at http://go.microsoft.com/fwlink/?LinkID=260653.

(function ()
{
    "use strict";

    //
    // Global variables
    //

        // UI object references.
        var inkCanvas;
        var inkContext;
        var modeMessage;
        var deviceMessage
        var statusMessage;

// <SnippetInkManager>
        // Create an ink manager.
        // InkManager is documented at http://go.microsoft.com/fwlink/?LinkID=260648.
        var inkManager = new Windows.UI.Input.Inking.InkManager();
// </SnippetInkManager>

        // Initial pointer values.
        var pointerId = -1;
        var pointerDeviceType = null;

// <SnippetInitialStrokeValues>
        // Initial stroke property values.
        var strokeColor;
        var strokeWidth;
// </SnippetInitialStrokeValues>

    //
    // End global variables
    //

    // <SnippetGetElementById>
    // Obtain reference to the specified element.
    function get(elementId)
    {
        return document.getElementById(elementId);
    }
    // </SnippetGetElementById>

    function initialize()
    {
        // Set up the UI.
        //<SnippetConnectCanvas>
        inkCanvas = get("inkCanvas");
        inkContext = inkCanvas.getContext("2d");
        //</SnippetConnectCanvas>

        inkContext.lineCap = "round";
        inkContext.lineKJoin = "round";

        inkCanvas.width = window.innerWidth - 10;
        inkCanvas.height = window.innerHeight * 0.5;

        deviceMessage = get("deviceMessage");
        deviceMessage.innerText = "Undefined";
        modeMessage = get("modeMessage");
        modeMessage.innerText = inkManager.mode;
        statusMessage = get("statusMessage");
        statusMessage.innerText = "No pointer input detected."

        // Set initial ink mode.
        drawStrokes();

        // <SnippetSetDefaultRecognizer>
        // Set default recognition language.
        if (!setRecognizerByName("Microsoft English (US) Handwriting Recognizer")) {
            statusMessage.innerText += "\nRecognition: Failed to find English (US) recognizer.";
        }
        else {
            statusMessage.innerText += "\nRecognition: English (US) recognizer.";
        }
        // </SnippetSetDefaultRecognizer>

        // <SnippetPointerHandlers>
        // Set up the handlers for input processing.
        inkCanvas.addEventListener("pointerdown", onPointerDown, false);
        inkCanvas.addEventListener("pointermove", onPointerMove, false);
        inkCanvas.addEventListener("pointerup", onPointerUp, false);
        // </SnippetPointerHandlers>

        get("save").addEventListener("click", saveStrokes, false);
        get("load").addEventListener("click", loadStrokes, false);
        get("draw").addEventListener("click", drawStrokes, false);
        // <SnippetAddSelectListener>
        get("select").addEventListener("click", selectStrokes, false);
        // </SnippetAddSelectListener>
        // <SnippetAddSelectAllListener>
        get("selectall").addEventListener("click", selectAllStrokes, false);
        // </SnippetAddSelectAllListener>
        // <SnippetAddEraseListener>
        get("erase").addEventListener("click", eraseStrokes, false);
        // </SnippetAddEraseListener>
        // <SnippetAddEraseAllListener>
        get("eraseAll").addEventListener("click", eraseAllStrokes, false);
        // </SnippetAddEraseAllListener>
        // <SnippetRecognizeSelectedListener>
        get("recognize").addEventListener("click", recognizeStrokes, false);
        // </SnippetRecognizeSelectedListener>
    }
    document.addEventListener("DOMContentLoaded", initialize, false);

// <SnippetPointerDeviceType>
    function getPointerDeviceType(pId)
    {
        var pointerDeviceType;
        var pointerPoint = Windows.UI.Input.PointerPoint.getCurrentPoint(pId);
        switch (pointerPoint.pointerDevice.pointerDeviceType)
        {
            case Windows.Devices.Input.PointerDeviceType.touch:
                pointerDeviceType = "Touch";
                break;

            case Windows.Devices.Input.PointerDeviceType.pen:
                pointerDeviceType = "Pen";
                break;

            case Windows.Devices.Input.PointerDeviceType.mouse:
                pointerDeviceType = "Mouse";
                break;
            default:
                pointerDeviceType = "Undefined";
        }
        deviceMessage.innerText = pointerDeviceType;
        return pointerDeviceType;
    }
    // </SnippetPointerDeviceType>

// <SnippetPointerDown>
    // Occurs when the pointer (touch, pen, mouse) is detected by the canvas.
    // Each stroke begins with onPointerDown.
    function onPointerDown(evt)
    {
        // Get the device type for the pointer input.
        pointerDeviceType = getPointerDeviceType(evt.pointerId);

        // Process pen and mouse (with left button) only. Reserve touch for manipulations.
        if ((pointerDeviceType === "Pen") || ((pointerDeviceType === "Mouse") && (evt.button === 0)))
        {
            statusMessage.innerText = pointerDeviceType + " pointer down: Start stroke. "

            // Process one pointer at a time.
            if (pointerId === -1)
            {
                var current = evt.currentPoint;

                // Start drawing the stroke.
                inkContext.beginPath();
                inkContext.lineWidth = strokeWidth;
                inkContext.strokeStyle = strokeColor;

                inkContext.moveTo(current.position.x, current.position.y);

                // Add current pointer to the ink manager (begin stroke).
                inkManager.processPointerDown(current);

                // The pointer id is used to restrict input processing to the current stroke.
                pointerId = evt.pointerId;
            }
        }
        else
        {
            // Process touch input.
        }
    }
    // </SnippetPointerDown>

// <SnippetPointerMove>
    // Mouse: Occurs when the pointer moves.
    // Pen/Touch: Occurs at a steady rate (approx. 100 messages/second) whether the pointer moves or not.
    function onPointerMove(evt)
    {
        // Process pen and mouse (with left button) only. Reserve touch for manipulations.
        if ((pointerDeviceType === "Pen") || ((pointerDeviceType === "Mouse") && (evt.button === -1)))
        {
            statusMessage.innerText = pointerDeviceType + " pointer move: Draw stroke as lines. "
            // The pointer Id is used to restrict input processing to the current stroke.
            // pointerId is updated in onPointerDown().
            if (evt.pointerId === pointerId)
            {
                var current = evt.currentPoint;

                // Draw stroke in real time.
                inkContext.lineTo(current.rawPosition.x, current.rawPosition.y);
                inkContext.stroke();

                // Add current pointer to the ink manager (update stroke).
                inkManager.processPointerUpdate(current);
            }
        }
        else
        {
            // Process touch input.
        }
    }
    // </SnippetPointerMove>

    // <SnippetPointerUp>
    // Occurs when the pointer (touch, pen, mouse) is lifted from the canvas.
    // Each stroke ends with onPointerUp.
    function onPointerUp(evt)
    {
        // Process pen and mouse (with left button) only. Reserve touch for manipulations.
        if ((pointerDeviceType === "Pen") || ((pointerDeviceType === "Mouse") && (evt.button === 0)))
        {
            statusMessage.innerText = pointerDeviceType + " pointer up: Finish stroke. "
            if (evt.pointerId === pointerId) {
                // Add current pointer to the ink manager (end stroke).
                inkManager.processPointerUp(evt.currentPoint);

                // End live drawing.
                inkContext.closePath();

                // Render strokes using bezier curves.
                renderAllStrokes();

                // Reset pointer Id.
                pointerId = -1;
            }
        }
        else
        {
            // Process touch input.
        }
    }
    // </SnippetPointerUp>

    // <SnippetRenderAllStrokes>
    // Render all strokes using bezier curves instead of line segments.
    function renderAllStrokes()
    {
        statusMessage.innerText += "Render strokes as bezier curves."

        // Clear the drawing surface of existing strokes.
        inkContext.clearRect(0, 0, inkCanvas.width, inkCanvas.height);

// <SnippetRenderStrokes>
        // Iterate through each stroke.
        inkManager.getStrokes().forEach(
            function (stroke)
            {
                inkContext.beginPath();
                if (stroke.selected) {
                    inkContext.lineWidth = stroke.drawingAttributes.size.width * 2;
                    inkContext.strokeStyle = "green";
                } else {
                    inkContext.lineWidth = stroke.drawingAttributes.size.width;
                    inkContext.strokeStyle = "black";
                }

                // Enumerate through each line segment of the stroke.
                var first = true;

                stroke.getRenderingSegments().forEach(
                    function (segment)
                    {
                        // Move to the starting screen location of the stroke.
                        if (first)
                        {
                            inkContext.moveTo(segment.position.x, segment.position.y);
                            first = false;
                        }
                        // Calculate the bezier curve for the segment.
                        else
                        {
                            inkContext.bezierCurveTo(segment.bezierControlPoint1.x,
                                                     segment.bezierControlPoint1.y,
                                                     segment.bezierControlPoint2.x,
                                                     segment.bezierControlPoint2.y,
                                                     segment.position.x, segment.position.y);
                        }
                    }
                );
                
                // Draw the stroke.
                inkContext.stroke();
                inkContext.closePath();
            }
// </SnippetRenderStrokes>
        );
    }
    // </SnippetRenderAllStrokes>

// <SnippetModeSettingHandlers>
    // Set up draw mode.
    function drawStrokes() {
        inkManager.mode = Windows.UI.Input.Inking.InkManipulationMode.inking;
        strokeColor = "black";
        strokeWidth = 2;
        modeMessage.innerText = inkManager.mode;
    }

    // Set up selection mode.
    function selectStrokes() {
        inkManager.mode = Windows.UI.Input.Inking.InkManipulationMode.selecting;
        strokeColor = "red";
        strokeWidth = 1;
        modeMessage.innerText = inkManager.mode;
    }

    // Set up erase mode.
    function eraseStrokes() {
        inkManager.mode = Windows.UI.Input.Inking.InkManipulationMode.erasing;
        strokeColor = "gold";
        strokeWidth = 1;
        modeMessage.innerText = inkManager.mode;
    }
// </SnippetModeSettingHandlers>

    // <SnippetSelectAllStrokes>
    // Select all strokes handler.
    function selectAllStrokes() {
        inkManager.mode = Windows.UI.Input.Inking.InkManipulationMode.selecting;
        strokeColor = "red";
        strokeWidth = 1;
        modeMessage.innerText = "Select all strokes.";
        // Iterate through each stroke.
        inkManager.getStrokes().forEach(
            function (stroke) {
                stroke.selected = 1;
            }
            );
        renderAllStrokes();
    }
    // </SnippetSelectAllStrokes>

    // <SnippetEraseAllStrokes>
    // Select all strokes handler.
    function eraseAllStrokes() {
        inkManager.mode = Windows.UI.Input.Inking.InkManipulationMode.inking;
        strokeColor = "black";
        strokeWidth = 2;
        modeMessage.innerText = "Erase all strokes.";
        // Iterate through each stroke.
        inkManager.getStrokes().forEach(
            function (stroke) {
                stroke.selected = 1;
            }
            );
        inkManager.deleteSelected();
        renderAllStrokes();
    }
    // </SnippetEraseAllStrokes>

    // <SnippetSaveStrokes>
    // Save all strokes owned by inkManager.
    function saveStrokes()
    {
        // Ensure that strokes exist before calling saveAsync.
        if (inkManager.getStrokes().size > 0)
        {
            // Set up the file save screen.
            var savePicker = Windows.Storage.Pickers.FileSavePicker();
            savePicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.picturesLibrary;
            savePicker.fileTypeChoices.insert("GIF with embedded ISF", [".gif"]);
            savePicker.defaultFileExtension = ".gif";

            // Set up the stream.
            var saveStream = null;

            // Asynchronously save the ink data to the stream.
            savePicker.pickSaveFileAsync().done(
            function (file)
            {
                if (null !== file)
                {
                    file.openAsync(Windows.Storage.FileAccessMode.readWrite).then(
                        function (stream)
                        {
                            saveStream = stream;
                            return inkManager.saveAsync(saveStream);
                        }
                    ).then(
                        function ()
                        {
                            return saveStream.flushAsync(); 
                        },
                        function (e) {
                            // Override the standard saveAsync error with our own.
                            throw new Error("saveAsync");
                        }
                    ).done(
                        function ()
                        {
                            statusMessage.innerText = "Strokes saved as GIF with embedded ISF (.gif).";
                            saveStream.close();
                        },
                        function (e) {
                            statusMessage.innerText = "Save: " + e.toString();
                            // Close the stream if open.
                            if (saveStream) {
                                saveStream.close();
                            }
                        }
                    );
                }
            }
        );
        }
        else
        {
            statusMessage.innerText = "No strokes to save.";
        }
    }
    // </SnippetSaveStrokes>

    // <SnippetLoadStrokes>
    // Load strokes into an inkManager.
    function loadStrokes()
    {
        // Set up the file open screen.
        var openPicker = Windows.Storage.Pickers.FileOpenPicker();
        openPicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.picturesLibrary;
        openPicker.fileTypeFilter.replaceAll([".gif"]);

        // Set up the stream.
        var loadStream = null;

        // Asynchronously load the ink data from the stream.
        openPicker.pickSingleFileAsync().done(
            function (file)
            {
                if (null != file)
                {
                    file.openAsync(Windows.Storage.FileAccessMode.read).then(
                        function (stream) {
                            loadStream = stream;
                            return inkManager.loadAsync(loadStream);
                        }).done(
                            function()
                            {
                                var strokes = inkManager.getStrokes().length;
                                if (strokes === 0)
                                {
                                    statusMessage.innerText = "No strokes in file.";
                                }
                                else
                                {
                                    statusMessage.innerText = strokes + " strokes loaded.";
                                }
                                renderAllStrokes();
                                loadStream.close();
                            },
                            function (e)
                            {
                                statusMessage.innerText = "Load failed.";
                                if (loadStream)
                                {
                                    // Close the stream if open.
                                    loadStream.close();
                                }
                            });
                }
            });
    }
    // </SnippetLoadStrokes>

    // <SnippetSetRecognizerByName>
    /// <summary>
    /// Finds a specific recognizer, and sets the inkManager's default to that recognizer.
    /// Returns true if successful.
    /// </summary>
    /// <param name="recognizerName">The name of the handwriting recognizer.</param>
    function setRecognizerByName(recognizerName) {
        try {
            // recognizers is a normal JavaScript array
            var recognizers = inkManager.getRecognizers();
            for (var i = 0, len = recognizers.length; i < len; i++) {
                if (recognizerName === recognizers[i].name) {
                    inkManager.setDefaultRecognizer(recognizers[i]);
                    return true;
                }
            }
        }
        catch (e) {
            displayError("setRecognizerByName: " + e.toString());
        }
        return false;
    }
    // </SnippetSetRecognizerByName>

    // <SnippetRecognizeStrokes>
    /// <summary>
    /// Invoked when the "Handwriting recognition" button is pressed.
    /// The ink manager processes all strokes through recognizeAsync, which returns 
    /// the number of words detected and a set of recognition results for each word. 
    /// </summary>
    /// <param name="evt">The event object.</param>
    function recognizeStrokes(evt) {

        // Ensure ink strokes exist before calling recognizeAsync.
        if (inkManager.getStrokes().length > 0) {
            // recognizeAsync fails if other recognition tasks are in progress.
            try {
                // The ink manager is used to store the recognition results.
                // recognizeAsync has 3 modes: all | selected | recent.
                // For this example, we process all strokes.
                // recognizeAsync is documented at http://go.microsoft.com/fwlink/?LinkID=265172.
                inkManager.recognizeAsync(Windows.UI.Input.Inking.InkRecognitionTarget.all).done
                (
                    // The recognitionResult object returned by recognizeAsync exposes the 
                    // bounding rect, strokes, and text candidates for each word. 
                    // In this example, we simply display the word count and recognition results.
                    function (results) {
                        // recognizeAsync does not automatically update existing recognition results in the ink manager.
                        // updateRecognitionResults is documented at http://go.microsoft.com/fwlink/?LinkID=265175.
                        inkManager.updateRecognitionResults(results);

                        var x = inkManager.getRecognizers();

                        // Display the number of words returned in results.
                        statusMessage.innerText = "Words recognized: " + results.length.toString();

                        // Iterate through each word and display the ranked list of possible matches.
                        for (var i = 0; i < results.length; i++) {
                            statusMessage.innerText += "\nWord" + (i+1).toString() + ":";
                            var alts = results[i].getTextCandidates();
                            for (var j = 0; j < alts.length; j++) {
                                statusMessage.innerText += " " + alts[j].toString();
                            }
                        }
                    },
                    function (e) {
                        displayError("InkManager::recognizeAsync: " + e.toString());
                    }
                );
            }
            catch (e) {
                displayError("recognize: " + e.toString());
            }
        }
        else {
            statusMessage.innerText = "No strokes to recognize.";
        }
    }
    // </SnippetRecognizeStrokes>

    // Returns true if any strokes inside the ink manager are selected; false otherwise.
    function anySelected() {
        var strokes = inkManager.getStrokes();
        var len = strokes.length;
        for (var i = 0; i < len; i++) {
            if (strokes[i].selected) {
                return true;
            }
        }
        return false;
    }



})();
// </SnippetInkComplete>
