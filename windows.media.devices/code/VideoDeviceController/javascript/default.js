
function setSliders() {
    createVideoDevice();
    setBrtSlider();
    getBacklightComp();
    setCrtSlider();
    setExposureSlider();
    setFocusSlider();
    setHueSlider();
    setPanSlider();
    setRollSlider();
    setTiltSlider();
    setWhiteBalanceSlider();
    setZoomSlider();
}

// <SnippetVideoDeviceController_CreateVideoController>
function createVideoDevice() {
    var videoDev = null;
    var mediaDev = null;
    mediaDev = new Windows.Media.Capture.MediaCapture();
    videoDev = mediaDev.videoDeviceController;
}
// </SnippetVideoDeviceController_CreateVideoController>


// <SnippetVideoDeviceController_Brightness>
// Get the step size, minimum value, and maximum value of the brightness property to set
// values on a slider control.

function setBrtSlider() {
    var videoDev = null;
    var bValue = null;

    var mediaDevice = new Windows.Media.Capture.MediaCapture();
    videoDev = mediaDevice.videoDeviceController;
   
    if (videoDev.brightness.capabilities.step !== 0)
    {
        bValue = videoDev.brightness.tryGetValue();
        document.getElementById("slBrt").value = bValue.value;
        document.getElementById("slBrt").min = videoDev.brightness.capabilities.min;
        document.getElementById("slBrt").max = videoDev.brightness.capabilities.max;
        document.getElementById("slBrt").step = videoDev.brightness.capabilities.step;
    }
} 
//</SnippetVideoDeviceController_Brightness>


// <SnippetVideoDeviceController_BacklightCompensation>
// Determine if backlight compensation is enabled.
function getBacklightComp () {
    var mediaDevice = new Windows.Media.Capture.MediaCapture();
    var videoDev = mediaDevice.videoDeviceController;

    if (videoDev.backlightCompensation)
    {
        // Notify the user that backlight compensation is enabled.
    }
}
// </SnippetVideoDeviceController_BacklightCompensation>



// <SnippetVideoDeviceController_Contrast>
// Get the step size, minimum value, and maximum value of the contrast property to set
// values on a slider control.

function setCrtSlider() {
    var videoDev = null;
    var bValue = null;

    var mediaDevice = new Windows.Media.Capture.MediaCapture();
    videoDev = mediaDevice.videoDeviceController;
  
    if (videoDev.contrast.capabilities.step !== 0)
    {
        bValue = videoDev.contrast.tryGetValue();
        document.getElementById("slCrt").value = bValue.value;
        document.getElementById("slCrt").min = videoDev.contrast.capabilities.min;
        document.getElementById("slCrt").max = videoDev.contrast.capabilities.max;
        document.getElementById("slCrt").step = videoDev.contrast.capabilities.step;
    } 
}
// </SnippetVideoDeviceController_Contrast>


// <SnippetVideoDeviceController_Exposure>
// Get the step size, minimum value, and maximum value of the exposure property to set
// values on a slider control.

function setExposureSlider() {
    var videoDev = null;
    var bValue = null;

    var mediaDevice = new Windows.Media.Capture.MediaCapture();
    videoDev = mediaDevice.videoDeviceController;
  
    if (videoDev.exposure.capabilities.step !== 0)
    {
        bValue = videoDev.exposure.tryGetValue();
        document.getElementById("slExp").value = bValue.value;
        document.getElementById("slExp").min = videoDev.exposure.capabilities.min;
        document.getElementById("slExp").max = videoDev.exposure.capabilities.max;
        document.getElementById("slExp").step = videoDev.exposure.capabilities.step;
    } 
}
// </SnippetVideoDeviceController_Exposure>



// <SnippetVideoDeviceController_Focus>
// Get the step size, minimum value, and maximum value of the focus property to set
// values on a slider control.

function setFocusSlider() {
    var videoDev = null;
    var bValue = null;

    var mediaDevice = new Windows.Media.Capture.MediaCapture();
    videoDev = mediaDevice.videoDeviceController;

    if (videoDev.focus.capabilities.step !== 0)
    {
        bValue = videoDev.focus.tryGetValue();
        document.getElementById("slFocus").value = bValue.value;
        document.getElementById("slFocus").min = videoDev.focus.capabilities.min;
        document.getElementById("slFocus").max = videoDev.focus.capabilities.max;
        document.getElementById("slFocus").step = videoDev.focus.capabilities.step;
    } 
}
// </SnippetVideoDeviceController_Focus>


// <SnippetVideoDeviceController_Hue>
// Get the step size, minimum value, and maximum value of the hue property to set
// valUes on a slider control.

function setHueSlider() {

    var videoDev = null;
    var bValue = null;

    var mediaDevice = new Windows.Media.Capture.MediaCapture();
    videoDev = mediaDevice.videoDeviceController;

    if (videoDev.hue.capabilities.step !== 0)
    {
        bValue = videoDev.hue.tryGetValue();
        document.getElementById("slHue").value = bValue.value;
        document.getElementById("slHue").min = videoDev.hue.capabilities.min;
        document.getElementById("slHue").max = videoDev.hue.capabilities.max;
        document.getElementById("slHue").step = videoDev.hue.capabilities.step;
    }
} 
// </SnippetVideoDeviceController_Hue>



// <SnippetVideoDeviceController_Pan>
// Get the step size, minimum value, and maximum value of the pan property to set
// values on a slider control.

function setPanSlider () {

    var videoDev = null;
    var bValue = null;

    var mediaDevice = new Windows.Media.Capture.MediaCapture();
    videoDev = mediaDevice.videoDeviceController;

    if (videoDev.pan.capabilities.step !== 0)
    {
        bValue = videoDev.pan.tryGetValue();
        document.getElementById("slPan").value = bValue.value;
        document.getElementById("slPan").min = videoDev.pan.capabilities.min;
        document.getElementById("slPan").max = videoDev.pan.capabilities.max;
        document.getElementById("slPan").step = videoDev.pan.capabilities.step;
    } 
}
// </SnippetVideoDeviceController_Pan>



// <SnippetVideoDeviceController_Roll>
// Get the step size, minimum value, and maximum value of the roll property to set
// values on a slider control.

function setRollSlider() {

    var videoDev = null;
    var bValue = null;

    var mediaDevice = new Windows.Media.Capture.MediaCapture();
    videoDev = mediaDevice.videoDeviceController;

    if (videoDev.roll.capabilities.step !== 0)
    {
        bValue = videoDev.roll.tryGetValue();
        document.getElementById("slRoll").value = bValue.value;
        document.getElementById("slRoll").min = videoDev.roll.capabilities.min;
        document.getElementById("slRoll").max = videoDev.roll.capabilities.max;
        document.getElementById("slRoll").step = videoDev.roll.capabilities.step;
    }
} 
// </SnippetVideoDeviceController_Roll>



// <SnippetVideoDeviceController_Tilt>
// Get the step size, minimum value, and maximum value of the tilt property to set
// values on a slider control.

function setTiltSlider() {

    var videoDev = null;
    var bValue = null;

    var mediaDevice = new Windows.Media.Capture.MediaCapture();
    videoDev = mediaDevice.videoDeviceController;

    if (videoDev.tilt.capabilities.step !== 0)
    {
        bValue = videoDev.tilt.tryGetValue();
        document.getElementById("slTilt").value = bValue.value;
        document.getElementById("slTilt").min = videoDev.tilt.capabilities.min;
        document.getElementById("slTilt").max = videoDev.tilt.capabilities.max;
        document.getElementById("slTilt").step = videoDev.tilt.capabilities.step;
    } 
}
// </SnippetVideoDeviceController_Tilt>



// <SnippetVideoDeviceController_WhiteBalance>
// Get the step size, minimum value, and maximum value of the white balance property to 
// set values on a slider control.

function setWhiteBalanceSlider() {

    var videoDev = null;
    var bValue = null;

    var mediaDevice = new Windows.Media.Capture.MediaCapture();
    videoDev = mediaDevice.videoDeviceController;

    if (videoDev.whiteBalance.capabilities.step !== 0)
    {
        bValue = videoDev.whiteBalance.tryGetValue();
        document.getElementById("slWBal").value = bValue.value;
        document.getElementById("slWBal").min = videoDev.whiteBalance.capabilities.min;
        document.getElementById("slWBal").max = videoDev.whiteBalance.capabilities.max;
        document.getElementById("slWBal").step = videoDev.whiteBalance.capabilities.step;
    } 
}
// </SnippetVideoDeviceController_WhiteBalance>




// <SnippetVideoDeviceController_Zoom>
// Get the step size, minimum value, and maximum value of the zoom property to set 
// values on a slider control.

function setZoomSlider() {

    var videoDev = null;
    var bValue = null;

    var mediaDevice = new Windows.Media.Capture.MediaCapture();
    videoDev = mediaDevice.videoDeviceController;

    if (videoDev.zoom.capabilities.step !== 0)
    {
        bValue = videoDev.brightness.tryGetValue();
        document.getElementById("slZoom").value = bValue.value;
        document.getElementById("slZoom").min = videoDev.zoom.capabilities.min;
        document.getElementById("slZoom").max = videoDev.zoom.capabilities.max;
        document.getElementById("slZoom").step = videoDev.zoom.capabilities.step;
    } 
}
// </SnippetVideoDeviceController_Zoom>

 