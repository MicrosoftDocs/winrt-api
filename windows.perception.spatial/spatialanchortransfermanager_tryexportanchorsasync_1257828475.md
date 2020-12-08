---
-api-id: M:Windows.Perception.Spatial.SpatialAnchorTransferManager.TryExportAnchorsAsync(Windows.Foundation.Collections.IIterable{Windows.Foundation.Collections.IKeyValuePair{System.String,Windows.Perception.Spatial.SpatialAnchor}},Windows.Storage.Streams.IOutputStream)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TryExportAnchorsAsync(Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, Windows.Perception.Spatial.SpatialAnchor>> anchors, Windows.Storage.Streams.IOutputStream stream)
-->

# Windows.Perception.Spatial.SpatialAnchorTransferManager.TryExportAnchorsAsync

## -description
Exports spatial anchors to a stream, which can later be imported on another device. This allows both devices to reason about the same locations in their users' surroundings.

## -parameters
### -param anchors
The collection of anchors to export, each identified by an app-specified string key.

### -param stream
The stream to export anchors to.

## -returns
Operation that triggers once the export is complete.

## -remarks
It's the app's responsibility to get the data in the stream to the other device through its own network channel.

This method yields a result of **true** if the export succeeded. The export can fail if the spatial understanding system times out during the export.

**Note:** If you're using JavaScript, you can't create the *anchors* parameter directly, because it's of type IIterable&lt;IKeyValuePair&lt;Platform::String^, Windows::Perception::Spatial::SpatialAnchor^&gt;&gt;. Instead, create a native WinRT helper component that has a **CreateMap** function:

```cppwinrt
#include <winrt/Windows.Foundation.Collections.h>
#include <winrt/Windows.Perception.Spatial.h>

using namespace winrt;
using namespace Windows::Foundation::Collections;
using namespace Windows::Perception::Spatial;

IMap<winrt::hstring, SpatialAnchor> CreateMap()
{
    return winrt::single_threaded_map<winrt::hstring, SpatialAnchor>();
}
```

```cppcx
#include "pch.h"
#include "SpatialAnchorHelper.h"
 
using namespace SpatialHelper;
using namespace Platform;
 
Windows::Foundation::Collections::IMap<Platform::String^, Windows::Perception::Spatial::SpatialAnchor^>^ SpatialAnchorHelper::CreateMap()
{
    return ref new Platform::Collections::Map<Platform::String^, Windows::Perception::Spatial::SpatialAnchor^>();
}
```

Now you can populate the anchors collection in JavaScript and pass it to the TryExportAnchorsAsync method. The following code example shows how to use the SpatialAnchorHelper class to populate the anchors collection.

```javascript
waitForPositionalTracking(function () {
	var spatialAnchor = Windows.Perception.Spatial.SpatialAnchor.tryCreateRelativeTo(stationaryRef.coordinateSystem);

	if (isLocatableRelativeToUser(spatialAnchor)) {
		var map = SpatialHelper.SpatialAnchorHelper.createMap();
		map.insert("test", spatialAnchor);

		var stream = Windows.Storage.Streams.InMemoryRandomAccessStream();

		console.log("Exporting spatial anchor");
		var exportWatch = new Stopwatch();
		Windows.Perception.Spatial.SpatialAnchorTransferManager.tryExportAnchorsAsync(map.getView(), stream.getOutputStreamAt(0)).then(
            function (succeeded) {
                if (succeeded) {
                    console.log("Exported " + stream.size + " bytes to stream.  Elapsed time: " + exportWatch.stop() + " seconds");
...
```



## -examples

## -see-also

## -capabilities
spatialPerception
