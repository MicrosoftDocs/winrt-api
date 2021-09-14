---
-api-id: P:Windows.UI.Xaml.Controls.MediaElement.RealTimePlayback
-api-type: winrt property
---

<!-- Property syntax
public bool RealTimePlayback { get;  set; }
-->

# Windows.UI.Xaml.Controls.MediaElement.RealTimePlayback

## -description
Gets or sets a value that configures the [MediaElement](mediaelement.md) for real-time communications scenarios.


## -xaml-syntax
```xaml
<MediaElement RealTimePlayback="bool" />
```


## -property-value
**true** to configure for real-time communications. **false** to not configure the [MediaElement](mediaelement.md) for real-time communications.

## -remarks
Configuring for real-time playback changes the internal update logic to place higher emphasis on video refresh from available samples, and also restricts playback to natural 1x speed. Setting the property requires an internal reconstruction of the backing media engine. 
<!--which might justify recommendation to set sparsely.-->

## -examples

## -see-also
[Real-time communication sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleCommunication)
