// <SnippetTranscoding_SelectSourceFile>
var source;

var openPicker = new Windows.Storage.Pickers.FileOpenPicker();
openPicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.videosLibrary;
openPicker.fileTypeFilter.replaceAll([".wmv", ".mp4"]);
openPicker.pickSingleFileAsync().then(
    function(file){
        source = file;
        ...
// </SnippetTranscoding_SelectSourceFile>


// <SnippetTranscoding_CreateDestFile>
...
var savePicker = new Windows.Storage.Pickers.FileSavePicker();
savePicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.videosLibrary;
savePicker.defaultFileExtension = ".mp4";
savePicker.suggestedFileName = "New Video";
savePicker.fileTypeChoices.insert("MPEG4", [".mp4"]);
return savePicker.pickSaveFileAsync();
}).then(
    function(file){    
        destination = file;
...
// </SnippetTranscoding_CreateDestFile>


// <SnippetTranscoding_CreateProfile>
var profile = Windows.Media.MediaProperties.MediaEncodingProfile.createMp4(
            Windows.Media.MediaProperties.VideoEncodingQuality.hd720p);
// </SnippetTranscoding_CreateProfile>



// <SnippetTranscoding_Transcode>
var transcoder = new Windows.Media.Transcoding.MediaTranscoder();
return transcoder.prepareFileTranscodeAsync(source, destination, profile);
// </SnippetTranscoding_Transcode>


// <SnippetTranscoding_TranscodeStream>
var transcoder = new Windows.Media.Transcoding.MediaTranscoder();
return transcoder.prepareStreamTranscodeAsync(sourceStream, destinationStream, profile);
// </SnippetTranscoding_TranscodeStream>


// <SnippetTranscoding_ProgressHandler>
...
}).then(
    function(){
        // Update the UI for completion.
    },
    function(error){
        // Handle Errors.
    },
    function(percent)
    {
        // Update the UI for progress.
    });

// </SnippetTranscoding_ProgressHandler>


// <SnippetTranscoding_VideoControls>
<video controls id="myvideo"/>
// </SnippetTranscoding_VideoControls>



// <SnippetTranscoding_PlayVideo>
var video = document.getElementById('myvideo');
video.src = URL.createObjectURL(destination);
video.play();
// </SnippetTranscoding_PlayVideo>


// <SnippetTranscoding_InitTranscoder>
...
var profile = Windows.Media.MediaProperties.MediaEncodingProfile.createMp4(
    Windows.Media.MediaProperties.VideoEncodingQuality.hd720p);

var transcoder = new Windows.Media.Transcoding.MediaTranscoder();
transcoder.trimStartTime = 1000;
transcoder.trimStopTime = 9000;
...
// </SnippetTranscoding_InitTranscoder>



// <SnippetTranscoding_TrimFile>
...
    return transcoder.prepareFileTranscodeAsync(source, destination, profile);
}).then(
function(){
    // Update the UI for completion.
},
function(error){
    // Handle Errors.
},
function(percent)
{
    // Update the UI for progress.
});
// </SnippetTranscoding_TrimFile>


// <SnippetTranscoding_Complete>
var source;
var destination;

var openPicker = new Windows.Storage.Pickers.FileOpenPicker();
openPicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.videosLibrary;
openPicker.fileTypeFilter.replaceAll([".wmv", ".mp4"]);
openPicker.pickSingleFileAsync().then(
    function(file){
        source = file;

        var savePicker = new Windows.Storage.Pickers.FileSavePicker();
        savePicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.videosLibrary;
        savePicker.defaultFileExtension = ".mp4";
        savePicker.suggestedFileName = "New Video";
        savePicker.fileTypeChoices.insert("MPEG4", [".mp4"]);
        return savePicker.pickSaveFileAsync();
    }).then(
    function(file){    
        destination = file;

        var profile = Windows.Media.MediaProperties.MediaEncodingProfile.createMp4(
            Windows.Media.MediaProperties.VideoEncodingQuality.hd720p);

        var transcoder = new Windows.Media.Transcoding.MediaTranscoder();
        return transcoder.prepareFileTranscodeAsync(source, destination, profile);
    }).then(
    function(){
        // Update the UI for completion.
    },
    function(error){
        // Handle Errors.
    },
    function(percent)
    {
        // Update the UI for progress.
    });


// </SnippetTranscoding_Complete>



// <SnippetTranscoding_TrimComplete>
var source;
var destination;

var openPicker = new Windows.Storage.Pickers.FileOpenPicker();
openPicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.videosLibrary;
openPicker.fileTypeFilter.replaceAll([".wmv", ".mp4"]);
openPicker.pickSingleFileAsync().then(
    function(file){
        source = file;
                
        var savePicker = new Windows.Storage.Pickers.FileSavePicker();
        savePicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.videosLibrary;
        savePicker.defaultFileExtension = ".mp4";
        savePicker.suggestedFileName = "New Video";
        savePicker.fileTypeChoices.insert("MPEG4", [".mp4"]);
        return savePicker.pickSaveFileAsync();
    }).then(
    function(file){    
        destination = file;
                
        var profile = Windows.Media.MediaProperties.MediaEncodingProfile.createMp4(Windows.Media.MediaProperties.VideoEncodingQuality.hd720p);

        var transcoder = new Windows.Media.Transcoding.MediaTranscoder();
        transcoder.trimStartTime = 1000;
        transcoder.trimStopTime = 9000;
        return transcoder.prepareFileTranscodeAsync(source, destination, profile);
    }).then(
    function(){
        // Update the UI for completion.
    },
    function(error){
       // Handle errors.
    },
    function(percent)
    {
        // Update the UI for progress.
    });
// </SnippetTranscoding_TrimComplete>



// <SnippetTranscoding_DeferTranscodeComplete>
var source;
var destination;

var openPicker = new Windows.Storage.Pickers.FileOpenPicker();
openPicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.videosLibrary;
openPicker.fileTypeFilter.replaceAll([".wmv", ".mp4"]);
openPicker.pickSingleFileAsync().then(
    function(file){
        source = file;
                
        var savePicker = new Windows.Storage.Pickers.FileSavePicker();
        savePicker.suggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.videosLibrary;
        savePicker.defaultFileExtension = ".mp4";
        savePicker.suggestedFileName = "New Video";
        savePicker.fileTypeChoices.insert("MPEG4", [".mp4"]);
        return savePicker.pickSaveFileAsync();
    }).then(
    function(file){    
        destination = file;
                
        var profile = Windows.Media.MediaProperties.MediaEncodingProfile.createMp4(Windows.Media.MediaProperties.VideoEncodingQuality.hd720p);

        var transcoder = new Windows.Media.Transcoding.MediaTranscoder();
        return transcoder.prepareFileTranscodeAsync(source, destination, profile);
    }).then(

    // Begin phase 2.

    function(deferral){
        return prepareTranscodeResult.transcodeAsync();
    }).then(
    function(){
        // Update the UI for completion.
    },
    function(error){
        // Handle errors.
    },
    function(percent)
    {
        // Update the UI for progress.
    });

// </SnippetTranscoding_DeferTranscodeComplete>


// <SnippetTranscoding_DoTranscode>

function doTranscode() {
        // Clear any existing effects.
        transcoder.clearEffects;
        // Add video effect.
        transcoder.addVideoEffect(videoEffect);
        // Add audio effect.
        transcoder.addAudioEffect(audioEffect);
        // Set start and stop times for trimming.
        transcoder.trimStartTime(1000);
        transcoder.trimStopTime(9000);
        // Always reencode the source
        transcoder.alwaysReencode = true;

        return transcoder.prepareFileTranscodeAsync(source, destination, profile);
    }
// </SnippetTranscoding_DoTranscode>


// <SnippetTranscoding_DoTranscode1>
function doTranscode() {
       Windows.Storage.KnownFolders.videosLibrary.createFileAsync(g_outputFileName, Windows.Storage.CreationCollisionOption.generateUniqueName).then (function (file) {
            g_outputFile = file;
            g_transcoder.prepareFileTranscodeAsync(g_inputFile, g_outputFile, g_profile).then (function(result) {
            
            }, errorHandler);
       } );
}
// </SnippetTranscoding_DoTranscode1>



// <SnippetTranscoding_PrepareResult>
function setDeferral() {
        
        transcoder = new Windows.Media.Transcoding.MediaTranscoder();
        var deferral = transcoder.prepareFileTranscodeAsync(inputFile, outputFile, profile);
            deferral.then(completeTranscode, transcodeError);
        };
       
    }

    function completeTranscode {
        if (!result.canTranscode) {
            // Display error
            
        } else {
            result.transcodeAsync();
            
        }
    }
// </SnippetTranscoding_PrepareResult>