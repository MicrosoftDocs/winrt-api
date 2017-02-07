
// <SnippetMediaProperties_GetAudioEncodingProperties>
function getProperties() {
    var encodingProperties = new Windows.Media.MediaProperties.AudioEncodingProperties();
    var bit_rate = encodingProperties.bitrate;
    var sampleBits = encodingProperties.bitsPerSample;
    var count = encodingProperties.channelCount;
    var s_rate = encodingProperties.sampleRate;
    var audioSubType = encodingProperties.subtype;
    var audioType = encodingProperties.type;
    if (audioType === "Audio" && audioSubType === "MP3") {
        // The format is an MP3 audio stream.
    }
}
// </SnippetMediaProperties_GetAudioEncodingProperties>

// <SnippetMediaProperties_GetPropertySet>

function getPropertySet() { 
    // <SnippetMediaProperties_GetPropertySetInstance> 
    var encodingProperties = new Windows.Media.MediaProperties.AudioEncodingProperties();
    var props = encodingProperties.properties;
    // </SnippetMediaProperties_GetPropertySetInstance> 
    // Remove all items from the property set.
    props.clear();
    // Get an iterator for this property set. 
    var itertator = props.first();
    // Get the immutable view of the property set.
    var view = props.getView();   
    // Determine if the set has an item with the specified key.   
    if (props.hasKey(key)) {
        // Use the item.
    }
    // Add an item with the specified key and value to the property set.    
    if (props.insert(key, value)) {
        // Value was replaced.
    }
    else {
        // New key and value.
    }
    // Get the value for the specified key.
    var value = props.lookup(key);
    // Remove the item with the specified key from the property set.
    props.remove(key);
    // Get the number of items in the property set.
    var number = props.size;
}
// </SnippetMediaProperties_GetPropertySet>

// <SnippetMediaProperties_GetFormat>
function getFormat() {
    var encodingProperties = new Windows.Media.MediaProperties.AudioEncodingProperties();
    var audioSubType = encodingProperties.subtype;
    var audioType = encodingProperties.type;
    if (audioType === "Audio" && audioSubType === "MP3") {
        // The format is an MP3 audio stream.
    }
}
// </SnippetMediaProperties_GetFormat>


// <SnippetMediaProperties_GetContainerFormat>
function getContainerFormat() {
    var containerProperties = new Windows.Media.MediaProperties.ContainerEncodingProperties();
    var containerType = containerProperties.type;
    var containerSubType = containerProperties.subtype;
    if (containerType === "Container" && containerSubType === "MPEG4") {
        // The format is an MPEG4 file container.
    }
}
// </SnippetMediaProperties_GetContainerFormat>

// <SnippetMediaProperties_GetContainerEncodingProperties>
function getContainerProperties() {
    var containerProperties = new Windows.Media.MediaProperties.ContainerEncodingProperties();
    var props = containerProperties.properties;
    // Remove all items from the property set;
    props.clear();

    var containerType = containerProperties.type;
    var containerSubType = containerProperties.subtype;
    if (containerType === "Container" && containerSubType === "MPEG4") {
        // The format is an MPEG4 file container.

    }
}
// </SnippetMediaProperties_GetContainerEncodingProperties>


function createProperties()
{
    createJpegProperties();
    createJpegXRProperties();
    createPngProperties();
    getImageProperties();
}
// <SnippetMediaProperties_ImageCreateJpeg>
function createJpegProperties() {
    var jpegProperties = new Windows.Media.MediaProperties.ImageEncodingProperties();
    jpegProperties = Windows.Media.MediaProperties.ImageEncodingProperties.createJpeg();
}
// </SnippetMediaProperties_ImageCreateJpeg>


// <SnippetMediaProperties_ImageCreateJpegXR>
function createJpegXRProperties() {
    var jpegXRProperties = new Windows.Media.MediaProperties.ImageEncodingProperties();
    jpegXRProperties = Windows.Media.MediaProperties.ImageEncodingProperties.createJpegXR();
}
// </SnippetMediaProperties_ImageCreateJpegXR>



// <SnippetMediaProperties_ImageCreatePng>
function createPngProperties() {
    var pngProperties = new Windows.Media.MediaProperties.ImageEncodingProperties();
    pngProperties = Windows.Media.MediaProperties.ImageEncodingProperties.createPng();
}
// </SnippetMediaProperties_ImageCreatePng>

// <SnippetMediaProperties_GetImageEncodingProperties>
function getImageProperties() {
    var imageProperties = new Windows.Media.MediaProperties.ImageEncodingProperties();
    // Get the format properties.
    var props = imageProperties.properties;
    // Get the number of items in the format properties.
    var count = props.size;

    // Get the height and width of the image.
    var size_Height = imageProperties.height;
    var size_Width = imageProperties.Width;

    // Get the type and subtype of the image format.
    var imageType = imageProperties.type;
    var imageSubType = imageProperties.subtype;
    if (imageType === "Image" && imageSubType === "GIF") {
        // The format is a GIF image file.
    }
}
// </SnippetMediaProperties_GetImageEncodingProperties>

function createProfiles() {
    M4aProfile();
    Mp3Profile();
    Mp4Profile();
    WmaProfile();
    WmvProfile();
}

// <SnippetMediaProperties_EncodingProfileM4a>
function M4aProfile() {
    // Create M4a profile with high audio encoding quality.
    var mediaProfile = Windows.Media.MediaProperties.MediaEncodingProfile.createM4a(Windows.Media.MediaProperties.AudioEncodingQuality.high);
}
// </SnippetMediaProperties_EncodingProfileM4a>


// <SnippetMediaProperties_EncodingProfileMp3>
function Mp3Profile() {
    // Create Mp3 profile with medium audio encoding quality.
    var mediaProfile = Windows.Media.MediaProperties.MediaEncodingProfile.createMp3(Windows.Media.MediaProperties.AudioEncodingQuality.medium);
}
// </SnippetMediaProperties_EncodingProfileMp3>


// <SnippetMediaProperties_EncodingProfileMp4>
function Mp4Profile() {
    // Create Mp4 profile with Vga format.
    var mediaProfile = Windows.Media.MediaProperties.MediaEncodingProfile.createMp4(Windows.Media.MediaProperties.VideoEncodingQuality.vga);
}
// </SnippetMediaProperties_EncodingProfileMp4>


// <SnippetMediaProperties_EncodingProfileWma>
function WmaProfile() {
    // Create Wma profile with low audio encoding quality.
    var mediaProfile = Windows.Media.MediaProperties.MediaEncodingProfile.createWma(Windows.Media.MediaProperties.AudioEncodingQuality.low);
}
// </SnippetMediaProperties_EncodingProfileWma>


// <SnippetMediaProperties_EncodingProfileWmv>
function WmvProfile() {
    // Create Wmv profile with Wvga format.
    var mediaProfile = Windows.Media.MediaProperties.MediaEncodingProfile.createWmv(Windows.Media.MediaProperties.VideoEncodingQuality.wvga);
}
// </SnippetMediaProperties_EncodingProfileWmv>

function getAudioVideoProperties() {
    getAudioProperties();
    getVideoProperties();
    getFrameRate();
}
var count = 9;
// <SnippetMediaProperties_MediaEncodingProfile>
function getAudioProperties() {
    var mediaProfile = new Windows.Media.MediaProperties.MediaEncodingProfile();

    // Get the encoding properties for the audio stream.
    var audioProps = mediaProfile.audio;
    // Set the channel count.
    audioProps.channelCount = count;

    // Get the encoding properties for the media container.
    var containerProps = mediaProfile.container;
    // Set the container subtype.
    containerProps.subtype = "MP3";

    // Get the encoding properties for the video stream.
    var videoProps = mediaProfile.video;
    // Get the frame rate.
    var d_value = videoProps.frameRate.denominator;
    var n_value = videoProps.frameRate.numerator;

}
// </SnippetMediaProperties_MediaEncodingProfile>
var value = 128000;
var h_Value = 12;
var w_Value = 10;
// <SnippetMediaProperties_GetVideoEncodingProperties>
function getVideoProperties() {
    var videoProperties = new Windows.Media.MediaProperties.VideoEncodingProperties();
    var props = videoProperties.properties;
    // Remove all values from the property set.
    props.clear();

    var videoType = videoProperties.type;
    var videoSubType = videoProperties.subtype;
    if (videoType === "Video" && videoSubType === "H264") {
        // The format is an H.264 video.
    }
    // Set the bitrate. 
    videoProperties.bitrate = value;

    // Get the frame rate ratio.
    var d_value = videoProperties.frameRate.denominator;
    var n_value = videoProperties.frameRate.numerator;

    // Get the pixel aspect ratio.
    d_value = videoProperties.pixelAspectRatio.denominator;
    n_value = videoProperties.pixelAspectRatio.numerator;

    // Set new height and width.
    videoProperties.height = h_Value;
    videoProperties.width = w_Value;
}
// </SnippetMediaProperties_GetVideoEncodingProperties>

// <SnippetMediaProperties_GetRatio>
function getFrameRate() {
    var videoProperties = new Windows.Media.MediaProperties.VideoEncodingProperties();
    // Get the MediaRatio object.
    var ratio = videoProperties.frameRate;
    // Get the numerator and denominator of the frame rate ratio.
    var d_value = ratio.denominator;
    var n_value = ratio.numerator;
}
// </SnippetMediaProperties_GetRatio>