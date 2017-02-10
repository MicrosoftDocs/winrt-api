---
-api-id: T:Windows.UI.StartScreen.VisualElementsRequest
-api-type: winrt class
---

<!-- Class syntax.
public class VisualElementsRequest : Windows.UI.StartScreen.IVisualElementsRequest
-->

# Windows.UI.StartScreen.VisualElementsRequest

## -description
Provides a method to delay the display of the **Pin to Start**  flyout, as well as methods through which you can set the visual elements of the secondary tile to be presented in that flyout as well as alternate versions of the tile that can also be presented as options.

> On Windows Phone 8.1, the secondary tile is created without showing the user a flyout, prompting them for confirmation, or allowing them to choose an alternate version of the tile.
<!-- @WRITER erictill 3/24/2014 : Note that when using the <xref rid="w_ui_start.secondarytile_requestcreateasync" targtype="method_overload_winrt">RequestCreateAsync</xref> method to pin a secondary tile in <tla rid="tailored_app_wps" plural="1"/>, the app is suspended and the user is taken to the <tla rid="start_screen"/>. This same API call on a PC does not suspend the program. Therefore, be aware that any code called after <xref rid="w_ui_start.secondarytile_requestcreateasync" targtype="method_overload_winrt">RequestCreateAsync</xref> is not guaranteed to be run before the app is suspended. To avoid this potential issue you should use the OnSuspended event of your app to run any code, such as updating the pinned tile, that should be run before the app suspends. To see an example of this pattern, download and run the <xref hlink="http://go.microsoft.com/fwlink/p/?LinkId=394144">Tile update on suspend sample</xref>. -->

## -remarks
This object is obtained by calling the [Request](visualelementsrequestedeventargs_request.md) method of the [VisualElementsRequestedEventArgs](visualelementsrequestedeventargs.md) object obtained through the [VisualElementsRequested](secondarytile_visualelementsrequested.md) event.

## -examples

## -see-also
