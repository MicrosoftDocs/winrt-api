

// <SnippetMediaCaptureVideo_Complete>

var oMediaCapture;
var profile;
var captureInitSettings;
var deviceList = new Array();
var recordState = false;
var storageFile;



function errorHandler(e) {
    sdkSample.displayStatus(e.message + ", Error Code: " + e.code.toString(16));
}



// Begin initialization.
function initialization() {
    document.getElementById("message").innerHTML = "Initialization started.";
    enumerateCameras();   
}


// Identify available cameras.
function enumerateCameras() {
    var deviceInfo = Windows.Devices.Enumeration.DeviceInformation;
    deviceInfo.findAllAsync(Windows.Devices.Enumeration.DeviceClass.videoCapture).then(function (devices) {
        // Add the devices to deviceList
        if (devices.length > 0) {
           
            for (var i = 0; i < devices.length; i++) {
                deviceList.push(devices[i]);              
            }
     
            initCaptureSettings();
            initMediaCapture();
            document.getElementById("message").innerHTML = "Initialization complete.";

        } else {
            sdkSample.displayError("No camera device is found ");            
        }
    }, errorHandler);
}


// <SnippetMediaCaptureVideo_InitSettings>
// Initialize the MediaCaptureInitialzationSettings.
function initCaptureSettings() {
    captureInitSettings = null;
    captureInitSettings = new Windows.Media.Capture.MediaCaptureInitializationSettings();
    captureInitSettings.audioDeviceId = "";
    captureInitSettings.videoDeviceId = "";
    captureInitSettings.streamingCaptureMode = Windows.Media.Capture.StreamingCaptureMode.audioAndVideo;
    captureInitSettings.photoCaptureSource = Windows.Media.Capture.PhotoCaptureSource.photo;
    if (deviceList.length > 0)
        captureInitSettings.videoDeviceId = deviceList[0].id;
}

// </SnippetMediaCaptureVideo_InitSettings>

// <SnippetMediaCaptureVideo_CreateProfile>
// Create a profile.
function createProfile() {
    profile = Windows.Media.MediaProperties.MediaEncodingProfile.createMp4(
        Windows.Media.MediaProperties.VideoEncodingQuality.hd720p);
}
// </SnippetMediaCaptureVideo_CreateProfile>

// <SnippetMediaCaptureVideo_InitMCobject>
// Create and initialze the MediaCapture object.
function initMediaCapture() {
    oMediaCapture = null;
// <SnippetMediaCaptureVideo_CreateMCobject>
    oMediaCapture = new Windows.Media.Capture.MediaCapture();
// </SnippetMediaCaptureVideo_CreateMCobject>
    oMediaCapture.initializeAsync(captureInitSettings).then (function (result) {
       createProfile();
    }, errorHandler);    
}
// </SnippetMediaCaptureVideo_InitMCobject>


// <SnippetMediaCaptureVideo_StartRecord>
// Start the video capture.
function startMediaCaptureSession() {
   Windows.Storage.KnownFolders.videosLibrary.createFileAsync("cameraCapture.mp4", Windows.Storage.CreationCollisionOption.generateUniqueName).then(function (newFile) {
        storageFile = newFile;
        oMediaCapture.startRecordToStorageFileAsync(profile, storageFile).then(function (result) {           
           
        }, errorHandler);
    }  );   
}
// </SnippetMediaCaptureVideo_StartRecord>

// <SnippetMediaCaptureVideo_StopRecord>
// Stop the video capture.
function stopMediaCaptureSession() {
    oMediaCapture.stopRecordAsync().then(function (result) {
        
    }, errorHandler);         
}
// </SnippetMediaCaptureVideo_StopRecord>
// </SnippetMediaCaptureVideo_Complete>


function devController() {

// <SnippetMediaCaptureVideo_GetDeviceController>
// Create the media capture object.
    var oMediaCapture = new Windows.Media.Capture.MediaCapture();
    oMediaCapture.initializeAsync();
    
// Retrieve a video device controller.
var videoDeviceController = oMediaCapture.videoDeviceController;

// Retrieve an audio device controller.
var audioDeviceController = oMediaCapture.audioDeviceController;
// </SnippetMediaCaptureVideo_GetDeviceController>

// <SnippetMediaCaptureVideo_SetVideoDeviceControllerProperties>
// Retrieve the brightness capabilites of the video camera
var brightnessCapabilities = videoDeviceController.brightness.capabilities; 

//
// Determine if the video camera supports adjustment of the brightness setting.
//
if (brightnessCapabilities.supported)
{
  var brightness;

  //
  // Retrieve the current brightness value.
  //

  if (videoDeviceController.brightness.tryGetValue( brightness ))
  {
    //
    // Get the minimum, maximum and step size for the brightness value. 
    // 
    var min = brightnessCapabilities.min;
    var max = brightnessCapabilities.max;
    var step = brightnessCapabilities.step;
  
    //
    // Increase the brightness value by one step as long as the new value is less than or equal to the maximum.
    //

    if( (brightness + step) <= max )
    {
       if( brightnessCapabilities.trySetValue( brightness + step ) )
       {
         // The brightness was successfully increased by one step.
       }
       else
       {
         // The brightness value couldn't be increased.
       }
    }
    else
    {
       // The brightness value is greater than the maximum.
    }
  }
  else
  {
    // The brightness value couldn't be retrieved.
  }
}
else
{
  // Setting the brightness value is not supported on this camera.
}

// </SnippetMediaCaptureVideo_SetVideoDeviceControllerProperties>
// <SnippetMediaCaptureVideo_SetAudioDeviceControllerProperties>
// Mute the microphone.
audioDeviceController.muted = true;

// Un-mute the microphone.
audioDeviceController.muted = false;

// Get the current volume setting.
var currentVolume = audioDeviceController.volumePercent;

// Increase the volume by 10 percent, if possible.
if (currentVolume <= 90) {
    audioDeviceController.volumePercent = (currentVolume + 10);
}
// </SnippetMediaCaptureVideo_SetAudioDeviceControllerProperties>
}

// <SnippetMediaCaptureVideo_AdjustCameraComplete>
//
// Initialize MediaCapture global object   
//
var oMediaCapture;

function startMediaCaptureSession() {
    oMediaCapture = new Windows.Media.Capture.MediaCapture();
    oMediaCapture.initializeAsync().then (function (result) {
        // Set the audio and video.
        setDevices();
    }, errorHandler);   
}

function setDevices()
{
      
     //
     // Obtain Video and Audio device controllers. 
     //
     var videoDeviceController = oMediaCapture.videoDeviceController;
     var audioDeviceController = oMediaCapture.audioDeviceController;

     //
     // Adjust Video and Audio device settings. 
     //

     //
     // Increase the brightness value by one step as long as the new value is less than or equal to the maximum.
     //
     var brightness;
     var brightnessCapabilities = videoDeviceController.brightness.capabilities;

     brightness = videoDeviceController.brightness.tryGetValue();
               
     if( (brightness.value + brightnessCapabilities.step) <= brightnessCapabilities.max )
     {
         if (videoDeviceController.brightness.trySetValue(brightness + brightnessCapabilities.step))
         {
             // The brightness value was successfully increased by one step.             
         }
         else
         {
             // The brightness value could not be increased.             
         }
     }
     else
     {
         // The new brightness value would be greater than the maximum value.        
     }
           

     //
     // Increase the microphone volume by 10 percent if possible.
     //
     var increase = 10;
     var currentVolume = audioDeviceController.volumePercent;
     if (currentVolume + increase <= 100) {
         audioDeviceController.volumePercent += increase;
     }
}

// </SnippetMediaCaptureVideo_AdjustCameraComplete>





// <SnippetMediaCaptureVideo_RecordVideo>
var oMediaCapture;

function setRotation() {
// <SnippetMediaCaptureVideo_CreateCaptureObject>  
    oMediaCapture = new Windows.Media.Capture.MediaCapture();
    oMediaCapture.initializeAsync().then(function (result) {
// </SnippetMediaCaptureVideo_CreateCaptureObject>
        // Set the video rotation value.
// <SnippetMediaCaptureVideo_SetVideoRotation>
        oMediaCapture.setRecordRotation(Windows.Media.Capture.VideoRotation.clockwise90Degrees);         
// </SnippetMediaCaptureVideo_SetVideoRotation>
    }, errorHandler);

    //Check rotation value;
// <SnippetMediaCaptureVideo_GetRecordRotation>
    var videoRotation = oMediaCapture.getRecordRotation();   
// </SnippetMediaCaptureVideo_GetRecordRotation>
    
    // Ready to start the capture session   
}
// </SnippetMediaCaptureVideo_RecordVideo>






// <SnippetMediaCaptureVideo_MirroringComplete>
var oMediaCapture;
var profile;

function turnMirroringOn()
{
// <SnippetMediaCaptureVideo_PreviewMirroring>
    if( !oMediaCapture.getPreviewMirroring() )
        oMediaCapture.setPreviewMirroring(true);
// </SnippetMediaCaptureVideo_PreviewMirroring>
}

function OnStartPreviewComplete(startPreviewOperation)
{
    // This method does not return a value.
    //
    startPreviewOperation.GetResults();
// <SnippetMediaCaptureVideo_StopPreview>
    // Set the handler for the StopPreviewOperation.    
    var stopPreviewOperation = oMediaCapture.stopPreviewAsync();
// </SnippetMediaCaptureVideo_StopPreview>

    stopPreviewOperation.Completed = OnStopPreviewComplete;
    stopPreviewOperation.Start();

    startPreviewOperation.Close();
}

function OnStopPreviewComplete(stopPreviewOperation)
{
    // This method does not return a value.
    //
    stopPreviewOperation.GetResults();

    stopPreviewOperation.Close();
}

function startPreview()
{

    oMediaCapture = new Windows.Media.Capture.MediaCapture();
    oMediaCapture.initializeAsync().then(function (result) {
        createProfile();
    }, errorHandler);
    // Enable horizontal mirroring.
    //
    turnMirroringOn();

// <SnippetMediaCaptureVideo_StartPreview>
    // Start Previewing
    var startPreviewOperation = oMediaCapture.startPreviewAsync();
// </SnippetMediaCaptureVideo_StartPreview>
    startPreviewOperation.Completed = OnStartPreviewComplete;
    startPreviewOperation.Start();
}
// </SnippetMediaCaptureVideo_MirroringComplete>


function videoStabilization() {

// <SnippetMediaCaptureVideo_VideoStabLive>
    //
    // Create a Media Capture object and add VideoStabilization.
    //

    oMediaCapture = new Windows.Media.Capture.MediaCapture();
    oMediaCapture.initializeAsync().then(function (result) {
        createProfile();
    }, errorHandler);
    // <SnippetMediaCaptureVideo_AddEffect>
    // captureMgr is a MediaCapture object defined elsewhere
    capturMgr.addEffectAsync(
        Windows.Media.Capture.MediaStreamType.videoRecord,
        "Windows.Media.VideoEffects.VideoStabilization",
        null);
// </SnippetMediaCaptureVideo_AddEffect>


    //
    // To clear all the effects from this stream type, use ClearEffectsAsync.
    //
    var clearEffectsOperation = oMediaCapture.clearEffectsAsync(Windows.Media.Capture.MediaStreamType.videoRecord);
// </SnippetMediaCaptureVideo_VideoStabLive>



    // <SnippetMediaCaptureVideo_VideoStabTrans>
    //
    // Create a Transcoder object and add VideoStabilization.
    //

    var oTranscoder = new Windows.Media.Transcoding.MediaTranscoder();

    oTranscoder.addVideoEffect("Windows.Media.VideoEffects.VideoStabilization");


    //
    // To clear all the effects from this stream type, use ClearEffects.
    //
    oTranscoder.clearEffects();
    // </SnippetMediaCaptureVideo_VideoStabTrans>
}

// <SnippetMediaCaptureVideo_CaptureOptions>
var mediaCaptureMgr = null;

function initMediaCapture() {
   
    mediaCaptureMgr = new Windows.Media.Capture.MediaCapture();
    mediaCaptureMgr.initializeAsync().then(function (result) {
        showWebcamSettings();
    }, errorHandler);
    showWebcamSettings();
}

function showWebcamSettings() {
    try {
        if (mediaCaptureMgr) {
            // Display the options
            Windows.Media.Capture.CameraOptionsUI.show(mediaCaptureMgr);
        }
    } catch (err) {
        // Display error.
    }
}
// </SnippetMediaCaptureVideo_CaptureOptions>



// <SnippetMediaCaptureVideo_UIShow>
function showWebcamSettings() {
    var mediaCaptureMgr = new Windows.Media.Capture.MediaCapture();
    Windows.Media.Capture.CameraOptionsUI.show(mediaCaptureMgr);
}
// </SnippetMediaCaptureVideo_UIShow>


// <SnippetMediaCaptureVideo_VideoPreview>
<script type="text/javascript">
   function init(){
      var mediarec = new Windows.Media.MediaRecorder();
      var opInitializeRecorder = mediarec.initializeAsync(null);
      opInitializeRecorder.start();
   }

   function preview(){  
      var myVideo = document.getElementById("videoTag1");
      myVideo.src = URL.createObjectURL(mediarec);
      myVideo.play();
   }
</script>
// </SnippetMediaCaptureVideo_VideoPreview>

// <SnippetMediaCaptureVideo_OnCheckpointCleanupJS>
app.oncheckpoint = function (args) {
    args.setPromise(
        cleanupCaptureResources()
    );
};
// </SnippetMediaCaptureVideo_OnCheckpointCleanupJS>

// <SnippetMediaCaptureVideo_CleanupCaptureResourcesJS>
function cleanupCaptureResources()
{
    var promises = [];

    if (mediaCapture) {
        if (isRecording) {
            promises.push(mediaCapture.stopRecordAsync().then(function () {
                isRecording = false;
            }));
        }

        promises.push(new WinJS.Promise(function (complete) {
            mediaCapture.close();
            mediaCapture = null;
            complete();
        }));
    }

    return WinJS.Promise.join(promises).done(null, errorHandler);
}
// </SnippetMediaCaptureVideo_CleanupCaptureResourcesJS>


