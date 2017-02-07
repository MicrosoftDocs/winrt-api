// <SnippetMediaCaptureJs>

//// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
//// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
//// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//// PARTICULAR PURPOSE.
////
//// Copyright (c) Microsoft Corporation. All rights reserved

/// <reference path="base-sdk.js" />


var mediaCaptureMgr = null;
var storageFile = null;
var photoFile = "photo.jpg";
var photoStorage = null;
var devicelist = new Array();


function id(elementId) {
    return document.getElementById(elementId); 
}

(function () {
   
    
    function initialize() {
        // Add any initialization code here
        initializeMediaCapture();
        id("scenarios").addEventListener("change", onScenarioChanged, false);
        Windows.UI.WebUI.WebUIApplication.addEventListener("suspending", suspendingHandler, false);
        Windows.UI.WebUI.WebUIApplication.addEventListener("resuming", resumingHandler, false); 
        mediaCaptureMgr.addEventListener("failed", errorhandler, false);
        

    }

    function onScenarioChanged() {
        // Do any necessary clean up on the output, the scenario id
        // can be obtained from sdkSample.scenarioId.

        releaseDeviceandVideoTags();
        
        if (sdkSample.scenarioId == 1) {
            id("btnStartDevice").disabled = false;
            id("btnStartPreview").disabled = true;
            id("btnStartRecord").disabled = true;
            id("btnCapturePhoto").disabled = true;
            id("btnStopRecord").disabled = true;
            initializeMediaCapture();

        }
        else if (sdkSample.scenarioId == 2) {
            enumerateWebcams(); 
            id("btnStartChosenDevice").disabled = false;
            id("btnStartPreviewChosenDevice").disabled = true;
        }
        else if (sdkSample.scenarioId == 3) {
            initializeMediaCapture();
        }
        else if (sdkSample.scenarioId == 4) {
            initializeMediaCapture();
            id("btnStartAudioRecord").disabled = true;
            id("btnStopAudioRecord").disabled = true;
        }
       sdkSample.displayStatus("");
    }

    document.addEventListener("DOMContentLoaded", initialize, false);
})();

function releaseDeviceandVideoTags() {

    id("previewTag").src = null;
    id("previewChosenDeviceTag").src = null;
    id("previewEffectTag").src = null;
    delete mediaCaptureMgr;
}

function initializeMediaCapture() {
    
    mediaCaptureMgr = new Windows.Media.Capture.MediaCapture();
    sdkSample.displayStatus("MediaCapture object Created. ");
    var initSettings = new Windows.Media.Capture.MediaCaptureInitializationSettings();
    if (sdkSample.scenarioId == 2) { 
        var selectedIndex = id("webcamSelect").selectedIndex;
        initSettings.videoDeviceId = devicelist[selectedIndex].id;
    }
    else if (sdkSample.scenarioId == 4) { 
        initSettings.streamingCaptureMode = Windows.Media.Capture.StreamingCaptureMode.audio;
    } 
    try {
        mediaCaptureMgr.initializeAsync(initSettings).
            then(initializeComplete, initializeError);
    
    } catch (ex) {
        sdkSample.displayStatus("An exception occurred trying to initialize device: " + ex.message);
   }
}

function initializeComplete(op) {
    sdkSample.displayStatus("Device initialize complete. ");
    
    if (sdkSample.scenarioId == 1) { 
        id("btnStartDevice").disabled = true;
        id("btnStartPreview").disabled = false;
    }
    else if (sdkSample.scenarioId == 2) {
        id("btnStartChosenDevice").disabled = true;
        id("btnStartPreviewChosenDevice").disabled = false;
    }
    else if (sdkSample.scenarioId == 3) {
        startPreview("previewEffectTag");
    }
    else if (sdkSample.scenarioId == 4) {
        id("btnStartAudioRecord").disabled = false;
    }
    op.operation.close();
}

function initializeError(op) {
    sdkSample.displayStatus("An exception occurred: " + ex.message);
}

function startPreview(videodisplayTag) { 
  
    try {
        var previewVidTag = id(videodisplayTag);
        var previewUrl;
        previewUrl = URL.createObjectURL(mediaCaptureMgr);		
        sdkSample.displayStatus("URL creation succeeded. ");
        previewVidTag.src = previewUrl;

        previewVidTag.play();
        sdkSample.displayStatus("Start Preview Succeeded. ");

        if (sdkSample.scenarioId == 1) { 
            id("btnStartDevice").disabled = true;
            id("btnStartPreview").disabled = true;
            id("btnStartRecord").disabled = false;
            id("btnCapturePhoto").disabled = false;
        } 
        else if (sdkSample.scenarioId == 2) {
            id("btnStartChosenDevice").disabled = true;
            id("btnStartPreviewChosenDevice").disabled = false;
        }
        


    } catch (error) {
        sdkSample.displayStatus("The following error occurred attempting to start Preview: " + error.message);                
    }

                
}
function updateaudioeffect() {

    
    if (document.audioeffectform.audioeffect.checked == true) {
        try {
            mediaCaptureMgr.addEffectAsync(Windows.Media.Capture.MediaStreamType.audio, "Microsoft.Samples.AudioDelayMFT", null).
                    then(addEffectComplete, addEffectError);             
        } catch (error) {
            sdkSample.displayStatus("The following error occurred attempting to add audio effect: " + error.message); 
        }
        /*var playbackTag = id('audioPlaybackTag');
        playbackTag.msInsertAudioEffect("Microsoft.Samples.AudioDelayMFT", true, null);*/
    }
    else{
        try {
            mediaCaptureMgr.clearEffectsAsync(Windows.Media.Capture.MediaStreamType.audio).
                   then(clearEffectComplete, clearEffectError); 
        } catch (error) {
            sdkSample.displayStatus("The following error occurred attempting to clear audio effect: " + error.message); 
        }
    }

}

function startRecord() {

    if (sdkSample.scenarioId == 4) {
        var recordFile = "audio.m4a";
        try {
            return Windows.Storage.KnownFolders.videosLibrary.createFileAsync(recordFile).then(
            function (newFile) {
                try {
                    storageFile = newFile;
                    var encodingprofile = new Windows.Media.Capture.MediaEncodingProfile.createM4a(Windows.Media.Capture.AudioEncodingQuality.medium);

                    mediaCaptureMgr.startRecordToStorageFileAsync(encodingprofile, storageFile).
                    then(startRecordComplete, startRecordError);
                    sdkSample.displayStatus("StartRecord. "); 

                } catch (error) {
                    sdkSample.displayStatus("getVideoStorageFile inner exception " + error.message);
                }
            },
            function (error) {
                sdkSample.displayStatus("getVideoStorageFile async exception " + error.message);
            }
        );
        } catch (error) {
            sdkSample.displayStatus("getVideoStorageFile outer exception " + error.message);
        } 
    }
    else { 
        var recordFile = "video.wmv";
        try {
            return Windows.Storage.KnownFolders.videosLibrary.createFileAsync(recordFile).then(
            function (newFile) {
                try {
                    storageFile = newFile;
                    
                    var encodingprofile = new Windows.Media.Capture.MediaEncodingProfile.createWmv(Windows.Media.Capture.VideoEncodingQuality.qvga);

                    mediaCaptureMgr.startRecordToStorageFileAsync(encodingprofile, storageFile).
                    then(startRecordComplete, startRecordError);
                    sdkSample.displayStatus("StartRecord. "); 

                } catch (error) {
                    sdkSample.displayStatus("getVideoStorageFile inner exception " + error.message);
                }
            },
            function (error) {
                sdkSample.displayStatus("getVideoStorageFile async exception " + error.message);
            }
        );
        } catch (error) {
            sdkSample.displayStatus("getVideoStorageFile outer exception " + error.message);
        } 
    
    
    }
}

function startRecordComplete(op) {
    sdkSample.displayStatus("Recording Started. ");

    if (sdkSample.scenarioId == 1) {
        id("btnStartRecord").disabled = true;
        id("btnStopRecord").disabled = false;
    }
    else if(sdkSample.scenarioId == 4) {
        id("btnStartAudioRecord").disabled = true;
        id("btnStopAudioRecord").disabled = false;
    } 
    op.operation.close();
}

function startRecordError(ex) {
    sdkSample.displayStatus("An exception occurred trying to record: " + ex.message);
}

function stopRecord() { 
    try {
        mediaCaptureMgr.stopRecordAsync().
            then(stopRecordComplete, stopRecordError);
        sdkSample.displayStatus("StopRecord. "); 
        
    } catch (error) {
        sdkSample.displayStatus("An exception occurred trying to stop record: " + ex.message);
        
    }
}

function stopRecordComplete(op) {
    sdkSample.displayStatus("Recording Stopped.  File " + storageFile.path + "  ");
    try {
        var url = URL.createObjectURL(storageFile);

        if (sdkSample.scenarioId == 1) {
            var playbackTag = id('videoPlaybackTag');
            playbackTag.src = url;
            playbackTag.play();
        }
        else if (sdkSample.scenarioId == 4){
            var playbackTag = id('audioPlaybackTag');
            playbackTag.src = url;
            playbackTag.play(); 
        }

    } catch (error) {
        sdkSample.displayStatus("URL creation exception: " + error.message);    
    }

    if (sdkSample.scenarioId == 1) {
        id("btnStartRecord").disabled = false;
        id("btnStopRecord").disabled = true;
    }
    else if (sdkSample.scenarioId == 4) {
        id("btnStartAudioRecord").disabled = false;
        id("btnStopAudioRecord").disabled = true;
    }


    op.operation.close();
}

function stopRecordError(ex) {
    sdkSample.displayStatus("An exception occurred trying to stop record: " + ex.message);
}
function capturePhoto() {
    try {
        return Windows.Storage.KnownFolders.picturesLibrary.createFileAsync(photoFile).then(
            function (newFile) {
            try {
                photoStorage = newFile;
                var photoProperties = new Windows.Media.Capture.ImageEncodingProperties();
                photoProperties.subtype = "JPEG";
                photoProperties.width = 320;
                photoProperties.height = 240;

                mediaCaptureMgr.capturePhotoToStorageFileAsync(photoProperties, photoStorage).
                        then(capturePhotoComplete, capturePhotoError);
                sdkSample.displayStatus("Capture Photo.  "); 

            } catch (error) {
                sdkSample.displayStatus("createFileAsync inner exception " + error.message);
            }
        },
            function (error) {
            sdkSample.displayStatus("capturePhoto async exception " + error.message);
        }
        );
    } catch (error) {
        sdkSample.displayStatus("capturePhoto outer exception " + error.message);
    }
}

function capturePhotoComplete(op) {
    sdkSample.displayStatus("Photo Taken.  File " + photoStorage.path + "  ");
    try {
        var url = URL.createObjectURL(photoStorage);
        id('imageTag').src = url;
    } catch (error) {
        sdkSample.displayStatus("URL creation exception " + error.message);    
    }
    op.operation.close();
}

function capturePhotoError(ex) {
    sdkSample.displayStatus("An exception occurred trying to capturePhoto: " + ex.message);
}

function enumerateWebcams() {                   
          
                  
    var mediaDevice = Windows.Media.Devices.MediaDevice;
    var selector = mediaDevice.getVideoCaptureSelector();
    var propertiesToEnumerate = new Array();
    propertiesToEnumerate.push("{a45c254e-df1c-4efd-8020-67d146a850e0} 14");

    
    try {
        
        //Windows.Devices.Enumeration.DeviceClass.VideoCapture
        var enumop = Windows.Devices.Enumeration.DeviceInformation.findAllAsync(
           selector, propertiesToEnumerate
        ).then(
            function (devices) {
            
            //empty the device list
            var optionlistlength = id("webcamSelect").length;
            for (i = 0; i < optionlistlength; i++) {
                id("webcamSelect").remove(0); 
                devicelist.pop(); 
                }
                       
            //add the devices to devicelist
            for (i = 0; i < devices.length; i++) {
                devicelist.push(devices[i]);
                id("webcamSelect").add(new Option(devicelist[i].name), i);
            }

            if (devicelist.length == 0)
                sdkSample.displayStatus("No webcam device is found ");
            else
                id("webcamSelect").options[0].selected = true;
        },
        function (error) {
            sdkSample.displayStatus("Device enumeration async exception " + error.message);
        });
    } catch (error) {
        sdkSample.displayStatus("enumerateWebcams outer exception" + error.message);    
    }
    

}

function addvideoEffect() {

    var selectedIndex = id("effectSelect").selectedIndex;
    try {
        if (selectedIndex == 0) {
            mediaCaptureMgr.addEffectAsync(Windows.Media.Capture.MediaStreamType.videoPreview, "Microsoft.Samples.GrayscaleEffect", null).
                then(addEffectComplete, addEffectError);  
        }
        else if (selectedIndex == 1) {
            mediaCaptureMgr.addEffectAsync(Windows.Media.Capture.MediaStreamType.videoPreview, "Windows.Media.VideoEffects.VideoStabilization", null).
                then(addEffectComplete, addEffectError);
                
        }
                
    } catch (error) {
        sdkSample.displayStatus("The following error occurred attempting to add effect: " + error.message); 
    }

}

function clearvideoEffects() {

    //clear all previous effects
    try {
          mediaCaptureMgr.clearEffectsAsync(Windows.Media.Capture.MediaStreamType.videoPreview).
               then(clearEffectComplete, clearEffectError); 
                
    } catch (error) {
        sdkSample.displayStatus("The following error occurred attempting to clear effects: " + error.message); 
    }

}

function addEffectComplete(op) {
    //sdkSample.displayStatus("Add effect complete. ");
    document.getElementById('statusMessage').innerHTML += "Add effect complete";
    //id("btnEffect").disabled = true;
    op.operation.close();
}

function addEffectError(op) {
    sdkSample.displayStatus("Add effect error: " + ex.message);
}

function clearEffectComplete(op) {
    sdkSample.displayStatus("Clear effect complete. ");
    op.operation.close();
}

function clearEffectError(op) {
    sdkSample.displayStatus("Clear effect error: " + ex.message);
}

function suspendingHandler(e) {

    sdkSample.displayStatus("Suspending message received: ");
    releaseDeviceandVideoTags();
}

function resumingHandler()
{
    sdkSample.displayStatus("Resume message received: ");
    if (sdkSample.scenarioId == 1) {
        id("btnStartDevice").disabled = false;
        id("btnStartPreview").disabled = true;
        id("btnStartRecord").disabled = true;
        id("btnCapturePhoto").disabled = true;
        id("btnStopRecord").disabled = true;
        initializeMediaCapture();

    }
    else if (sdkSample.scenarioId == 2) {
        enumerateWebcams(); 
        id("btnStartChosenDevice").disabled = false;
        id("btnStartPreviewChosenDevice").disabled = true;
    }
    else if (sdkSample.scenarioId == 3) {
        initializeMediaCapture();
    }

}
function errorhandler(e) {
    sdkSample.displayStatus("error handling message received." + e.message + ", Error Code: "+e.code.toString(16)) ;
}

// </SnippetMediaCaptureJs> 



 






