// PointerInput 
// Purpose: Snippet host app
// Description:
//   Track pointer input on a target object.
//   UI feedback through color and text updates.
// 
// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkID=392286

// <SnippetCompleteExample>
(function () {
    "use strict";
    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;


    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
                // TODO: This application has been newly launched. Initialize
                // your application here.
                initialize();
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

    // <SnippetInitialize>
    // For this example, we track simultaneous contacts in case the 
    // number of contacts has reached the maximum supported by the device.
    // Depending on the device, additional contacts might be ignored 
    // (PointerPressed not fired). 
    var numActiveContacts = 0;

    // The input target.
    var target;

    // Target background colors corresponding to various pointer states.
    var pointerColor = {
        hover: "rgb(255, 255, 102)",
        down: "rgb(0, 255, 0)",
        up: "rgb(255, 0, 0)",
        cancel: "rgb(0,0,0)",
        out: "rgb(127,127,127)",
        over: "rgb(0,0,255)"
    };

    // The event log (updated on each event).
    var eventLog;

    function initialize() {
        /// <summary>Set up the app.</summary>
        eventLog = document.getElementById("eventLog");
        target = document.getElementById("target");
        setTarget();
    }
    // </SnippetInitialize>

    // <SnippetSetTarget>
    function setTarget() {
        /// <summary>Set up the target and interaction event handlers.</summary>

        // Initial color of target.
        target.style.backgroundColor = pointerColor.out;

        // Expando dictionary property to track active contacts. 
        // An entry is added during pointer down/hover/over events 
        // and removed during pointer up/cancel/out/lostpointercapture events.
        target.pointers = [];

        // Declare pointer event handlers.
        target.addEventListener("pointerdown", onPointerDown, true);
        target.addEventListener("pointerover", onPointerOver, true);
        target.addEventListener("pointerup", onPointerUp, true);
        target.addEventListener("pointerout", onPointerOut, true);
        target.addEventListener("pointercancel", onPointerCancel, true);
        target.addEventListener("lostpointercapture", onLostPointerCapture, true);
        target.addEventListener("pointermove", onPointerMove, true);
        target.addEventListener("wheel", onMouseWheel, false);
    }
    // </SnippetSetTarget>

    // Handles pointers that are in contact and moved within the boundary of the target. 
    // See the pointermove event for handling the hover state of a pointer that is not in contact 
    // but is within the boundary of the target (typically a pen/stylus device). 
    // <SnippetPointerOver>
    function onPointerOver(e) {
        /// <summary>
        /// Occurs when a pointer is detected within the hit test boundaries 
        /// of an element.
        /// Also occurs prior to a pointerdown event for devices that do not 
        /// support hover.  
        /// This event type is similar to pointerenter, but bubbles. 
        /// See the pointermove event for handling the hover state of a pointer 
        /// that is not in contact but is within the boundary of the target 
        /// (typically a pen/stylus device). 
        /// </summary>
        /// <param name="e" type="Event">The event argument.</param>

        // Prevent the next handler in the hierarchy from receiving the event.
        e.cancelBubble = true;

        // Update event details and target UI.
        eventLog.innerText += "\nOver: " + e.pointerId;

        if (target.pointers.length === 0) {
            // Change background color of target when pointer contact detected.
            if (e.getCurrentPoint(e.currentTarget).isInContact) {
                // Pointer down occured outside target.
                target.style.backgroundColor = pointerColor.down;
            } else {
                // Pointer down occured inside target.
                target.style.backgroundColor = pointerColor.over;
            }
        }

        // Check if pointer already exists.
        for (var i in target.pointers) {
            if (target.pointers[i].id = e.pointerId) {
                return;
            }
        }

        // Push new pointer Id onto expando target pointers array.
        target.pointers.push({ id: e.pointerId, type: e.pointerType });

        // Ensure that the element continues to receive PointerEvents 
        // even if the contact moves off the element. 
        // Capturing the current pointer can improve usability by reducing 
        // the touch precision required when interacting with an element.
        // Note: Only the assigned pointer is affected. 
        target.setPointerCapture(e.pointerId);

        // Display pointer details.
        createInfoPop(e);
    }
    // </SnippetPointerOver>

    // <SnippetPointerDown>
    function onPointerDown(e) {
        /// <summary>
        /// Occurs for mouse when at least one mouse button is pressed or 
        /// for touch and pen when there is physical contact with the digitizer.
        /// For input devices that do not support hover, the pointerover event is 
        /// fired immediately before the pointerdown event.  
        /// Here, we  filter pointer input based on the first pointer type detected. 
        /// </summary>
        /// <param name="e" type="Event">The event argument.</param>

        // pointerdown and pointerup events do not always occur in pairs. 
        // Listen for and handle any event that might conclude a pointer down action 
        // (such as pointerup, pointerout, pointercancel, and lostpointercapture).
        //
        // For this example, we track the number of contacts in case the 
        // number of contacts has reached the maximum supported by the device.
        // Depending on the device, additional contacts might be ignored 
        // (PointerPressed not fired). 

        // Prevent the next handler in the hierarchy from receiving the event.
        e.cancelBubble = true;

        // Check if the number of supported contacts is exceeded.
        var touchCapabilities = new Windows.Devices.Input.TouchCapabilities();
        if ((touchCapabilities.touchPresent != 0) & (numActiveContacts > touchCapabilities.contacts)) {
            return;
        }

        // Update event details and target UI.
        eventLog.innerText += "\nDown: " + e.pointerId;
        target.style.backgroundColor = pointerColor.down;

        // Check if pointer already exists (if hover/over occurred prior to down).
        for (var i in target.pointers) {
            if (target.pointers[i].id = e.pointerId) {
                return;
            }
        }

        // Push new pointer Id onto expando target pointers array.
        target.pointers.push({ id: e.pointerId, type: e.pointerType });

        // Ensure that the element continues to receive PointerEvents 
        // even if the contact moves off the element. 
        // Capturing the current pointer can improve usability by reducing 
        // the touch precision required when interacting with an element.
        // Note: Only the assigned pointer is affected. 
        target.setPointerCapture(e.pointerId);

        // Display pointer details.
        createInfoPop(e);
    }
    // </SnippetPointerDown>

    // <SnippetPointerUp>
    function onPointerUp(e) {
        /// <summary>
        /// Occurs for mouse at transition from at least one button pressed 
        /// to no buttons pressed.
        /// Occurs for touch and pen when contact is removed from the digitizer. 
        /// For input devices that do not support hover, the pointerout event 
        /// is fired immediately after the pointerup event.  
        /// </summary>
        /// <param name="e" type="Event">The event argument.</param>

        // Prevent the next handler in the hierarchy from receiving the event.
        e.cancelBubble = true;

        // Update event details.
        eventLog.innerText += "\nUp: " + e.pointerId;

        // If event source is mouse pointer and the pointer is still 
        // over the target, retain pointer and pointer details.
        // Return without removing pointer from pointers dictionary.
        // For this example, we assume a maximum of one mouse pointer.
        if ((e.pointerType === "mouse") &
            (document.elementFromPoint(e.x, e.y) === target)) {
            target.style.backgroundColor = pointerColor.up;
            return;
        }

        // Ensure capture is released on a pointer up event.
        target.releasePointerCapture(e.pointerId);

        // Remove pointer from pointers dictionary.
        var targetPointers = target.pointers;
        for (var i in targetPointers) {
            if (target.pointers[i].id === e.pointerId) {
                target.pointers.splice(i, 1);
                var pointerInfoPop = document.getElementById("infoPop" + e.pointerId);
                if (pointerInfoPop === null)
                    return;
                pointerInfoPop.removeNode(true);
            }
        }

        // Update target UI.
        if (target.pointers.length === 0) {
            target.style.backgroundColor = pointerColor.up;
        }
    }
    // </SnippetPointerUp>

    // <SnippetPointerMove>
    function onPointerMove(e) {
        /// <summary>
        /// Occurs when a pointer moves within the hit test boundaries 
        /// of an element.
        /// </summary>
        /// <param name="e" type="Event">The event argument.</param>

        // NOTE: Multiple, simultaneous mouse button inputs are processed here.
        // Mouse input is associated with a single pointer assigned when 
        // mouse input is first detected. 
        // Clicking additional mouse buttons (left, wheel, or right) during 
        // the interaction creates secondary associations between those buttons 
        // and the pointer through the pointer pressed event. 
        // The pointer released event is fired only when the last mouse button 
        // associated with the interaction (not necessarily the initial button) 
        // is released. 
        // Because of this exclusive association, other mouse button clicks are 
        // routed through the pointer move event.  

        // Prevent the next handler in the hierarchy from receiving the event.
        e.cancelBubble = true;

        if (e.pointerType == "mouse") {
            // Mouse button states are extended PointerPoint properties.
            var pt = e.getCurrentPoint(e.currentTarget);
            var ptProperties = pt.properties;
            if (ptProperties.isLeftButtonPressed) {
                eventLog.innerText += "\nLeft button: " + e.pointerId;
            }
            if (ptProperties.isMiddleButtonPressed) {
                eventLog.innerText += "\nWheel button: " + e.pointerId;
            }
            if (ptProperties.isRightButtonPressed) {
                eventLog.innerText += "\nRight button: " + e.pointerId;
            }
        }
        // Handle hover state of a pointer that is not in contact but is within 
        // the boundary of the target (typically a pen/stylus device). 
        if (e.pointerType == "pen") {
            var pt = e.getCurrentPoint(e.currentTarget);
            if (pt.isInContact == false) {
                // Update event details and target UI.
                target.style.backgroundColor = pointerColor.hover;
                eventLog.innerText = "\nHover: " + e.pointerId;

                // Check if pointer already exists.
                for (var i in target.pointers) {
                    if (target.pointers[i].id = e.pointerId) {
                        updateInfoPop(e);
                        return;
                    }
                }

                target.pointers.push({ id: e.pointerId, type: e.pointerType });

                // Ensure that the element continues to receive PointerEvents 
                // even if the contact moves off the element. 
                // Capturing the current pointer can improve usability by reducing 
                // the touch precision required when interacting with an element.
                // Note: Only the assigned pointer is affected. 
                target.setPointerCapture(e.pointerId);
            }
        }

        // Display pointer details.
        updateInfoPop(e);
    }
    // </SnippetPointerMove>

    // <SnippetPointerOut>
    function onPointerOut(e) {
        /// <summary>
        /// Occurs when a pointer (in contact or not) moves out of the 
        /// target hit test boundary, after a pointerup event for a device 
        /// that does not support hover, and after a pointercancel event. 
        /// This event type is similar to pointerleave, but bubbles.  
        /// Note: Pointer capture is maintained until pointer up event.
        /// </summary>
        /// <param name="e" type="Event">The event argument.</param>

        // Prevent the next handler in the hierarchy from receiving the event.
        e.cancelBubble = true;

        // Update event details.
        eventLog.innerText += "\nPointer out: " + e.pointerId;

        // Remove pointer from pointers dictionary.
        var targetPointers = target.pointers;
        for (var i in targetPointers) {
            if (target.pointers[i].id === e.pointerId) {
                target.pointers.splice(i, 1);
                var pointerInfoPop = document.getElementById("infoPop" + e.pointerId);
                if (pointerInfoPop === null)
                    return;
                pointerInfoPop.removeNode(true);

                // Update target UI.
                if (target.pointers.length === 0) {
                    target.style.backgroundColor = pointerColor.out;
                }
            }
        }
    }
    // </SnippetPointerOut>

    // <SnippetMouseWheel>
    function onMouseWheel(e) {
        /// <summary>  
        /// Occurs when the mouse wheel is rotated. 
        /// </summary> 
        /// <param name="e" type="Event">The event argument.</param>
        // Check if a mouse pointer already exists.
        for (var i in target.pointers) {
            // Ensure existing pointer type registered with pointerover is mouse. 
            if (target.pointers[i].type === "mouse") {
                e.pointerId = target.pointers[i].id;
                break;
            }
        }
        eventLog.innerText += "\nMouse wheel: " + e.pointerId;
        // For this example, we fire a corresponding pointer down event.
        onPointerDown(e);
    }
    // </SnippetMouseWheel>

    // <SnippetPointerCancel>
    function onPointerCancel(e) {
        /// <summary>
        /// Occurs when a pointer is removed.
        /// The app will not receive subsequent events for that pointer, including pointerup.  
        /// </summary>
        /// <param name="e" type="Event">The event argument.</param>

        // A pointer can be canceled as a result of one of the following:
        //    - A touch contact is canceled when a pen is detected.
        //    - More than 100ms has passed since the device reported
        //      an active contact.
        //    - The desktop is locked or the user logged off. 
        //    - The number of simultaneous contacts exceeds the number 
        //      supported by the device.
        //    - The system has determined that a pointer is unlikely to 
        //      continue to produce events (for example, due to a hardware event).
        //    - After a pointerdown event, the pointer is subsequently used to 
        //      manipulate the page viewport (for example, panning or zooming).  

        // Prevent the next handler in the hierarchy from receiving the event.
        e.cancelBubble = true;

        // Update event details.
        eventLog.innerText += "\nPointer canceled: " + e.pointerId;

        // Ensure capture is released on a pointer cancel event.
        target.releasePointerCapture(e.pointerId);

        // Update target UI.
        if (target.pointers.length === 0) {
            target.style.backgroundColor = pointerColor.cancel;
        }

        // Remove pointer from pointers dictionary.
        var targetPointers = target.pointers;
        for (var i in targetPointers) {
            if (target.pointers[i].id === e.pointerId) {
                target.pointers.splice(i, 1);
                var pointerInfoPop = document.getElementById("infoPop" + e.pointerId);
                if (pointerInfoPop === null)
                    return;
                pointerInfoPop.removeNode(true);

                // Update target UI.
                if (target.pointers.length === 0) {
                    target.style.backgroundColor = pointerColor.out;
                }
            }
        }
    }
    // </SnippetPointerCancel>

    // <SnippetLostPointerCapture>
    function onLostPointerCapture(e) {
        /// <summary>
        /// Occurs after pointer capture is released for the pointer.  
        /// </summary>
        /// <param name="e" type="Event">The event argument.</param>

        // lostpointercapture can fire instead of pointerup. 

        // Pointer capture can be lost as a result of one of the following:
        //    - User interactions
        //    - Programmatic caputre of another pointer
        //    - Captured pointer was deliberately released

        // Prevent the next handler in the hierarchy from receiving the event.
        e.cancelBubble = true;

        // Update event details.
        eventLog.innerText += "\nLost pointer capture: " + e.pointerId;

        // We need the device type to handle lost pointer capture from mouse input.
        // Use the getCurrentPoint method over currentPoint property to ensure
        // the coordinate space is in relation to the target element.
        // Note: getCurrentPoint and currentPoint are only available in the 
        // local compartment, they are not available in the web compartment.
        var ptTarget = e.getCurrentPoint(e.currentTarget);
        var ptContainer = e.getCurrentPoint(document.getElementsByTagName("body")[0]);

        // If event source is mouse pointer and the pointer is still over 
        // the target, retain pointer and pointer details.
        // For this example, we assume only one mouse pointer.
        if ((ptTarget.pointerDevice.pointerDeviceType === Windows.Devices.Input.PointerDeviceType.mouse) &
            (document.elementFromPoint(ptContainer.position.x, ptContainer.position.y) === target)) {
            target.setPointerCapture(e.pointerId);
            return;
        }

        // Remove pointer from pointers dictionary.
        var targetPointers = target.pointers;
        for (var i in targetPointers) {
            if (target.pointers[i].id === e.pointerId) {
                target.pointers.splice(i, 1);
                var pointerInfoPop = document.getElementById("infoPop" + e.pointerId);
                if (pointerInfoPop === null)
                    return;
                pointerInfoPop.removeNode(true);
            }
        }

        // Update target UI.
        if (target.pointers.length === 0) {
            target.style.backgroundColor = pointerColor.cancel;
        }
    }
    // </SnippetLostPointerCapture>

    // <SnippetSetOutput>
    function createInfoPop(e) {
        /// <summary>
        /// Create and insert DIV into the DOM for displaying pointer details.
        /// </summary>
        /// <param name="e" type="Event">The event argument.</param>
        var infoPop = document.createElement("div");
        infoPop.setAttribute("id", "infoPop" + e.pointerId);

        // Set screen position of DIV.
        var transform = (new MSCSSMatrix()).translate(e.offsetX + 20, e.offsetY + 20);
        infoPop.style.msTransform = transform;
        target.appendChild(infoPop);

        infoPop.innerText = queryPointer(e);
    }

    function updateInfoPop(e) {
        /// <summary>
        /// Update pointer details in UI.
        /// </summary>
        /// <param name="e" type="Event">The event argument.</param>
        var infoPop = document.getElementById("infoPop" + e.pointerId);
        if (infoPop === null)
            return;

        // Set screen position of DIV.
        var transform = (new MSCSSMatrix()).translate(e.offsetX + 20, e.offsetY + 20);
        infoPop.style.msTransform = transform;
        infoPop.innerText = queryPointer(e);
    }
    // </SnippetSetOutput>


    //<SnippetQueryPointer>
    function queryPointer(e) {
        /// <summary>
        /// Get extended pointer data.
        /// </summary>
        /// <param name="e" type="Event">The event argument.</param>

        // We get the extended pointer info through the getCurrentPoint method
        // of the event argument. (We recommend using getCurrentPoint 
        // to ensure the coordinate space is in relation to the target.)
        // Note: getCurrentPoint and currentPoint are only available in the 
        // local compartment, they are not available in the web compartment.

        var pt = e.getCurrentPoint(e.currentTarget);
        var ptTargetProperties = pt.properties;

        var details = "Pointer Id: " + e.pointerId;
        switch (e.pointerType) {
            case "mouse":
                details += "\nPointer type: mouse";
                details += "\nLeft button: " + ptTargetProperties.isLeftButtonPressed;
                details += "\nRight button: " + ptTargetProperties.isRightButtonPressed;
                details += "\nWheel button: " + ptTargetProperties.isMiddleButtonPressed;
                details += "\nX1 button: " + ptTargetProperties.isXButton1Pressed;
                details += "\nX2 button: " + ptTargetProperties.isXButton2Pressed;
                break;
            case "pen":
                details += "\nPointer type: pen";
                if (pt.isInContact) {
                    details += "\nPressure: " + ptTargetProperties.pressure;
                    details += "\nrotation: " + ptTargetProperties.rotation;
                    details += "\nTilt X: " + ptTargetProperties.xtilt;
                    details += "\nTilt Y: " + ptTargetProperties.ytilt;
                    details += "\nBarrel button pressed: " + ptTargetProperties.isBarrelButtonPressed;
                }
                break;
            case "touch":
                details += "\nPointer type: touch";
                details += "\nPressure: " + ptTargetProperties.pressure;
                details += "\nrotation: " + ptTargetProperties.rotation;
                details += "\nTilt X: " + ptTargetProperties.xtilt;
                details += "\nTilt Y: " + ptTargetProperties.ytilt;
                break;
            default:
                details += "\nPointer type: " + "n/a";
                break;
        }
        details += "\nPointer location (target): " + e.offsetX + ", " + e.offsetY;
        details += "\nPointer location (screen): " + e.screenX + ", " + e.screenY;

        return details;
    }
    //</SnippetQueryPointer>

})();
// </SnippetCompleteExample>
