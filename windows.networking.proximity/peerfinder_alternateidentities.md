---
-api-id: P:Windows.Networking.Proximity.PeerFinder.AlternateIdentities
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Collections.IMap<string, string> AlternateIdentities { get; }
-->

# Windows.Networking.Proximity.PeerFinder.AlternateIdentities

## -description
Gets a list of alternate appId values to match with peer applications on other platforms.

## -property-value
A list of alternate appId values to match with peer applications on other platforms.

## -remarks
The AlternateIdentities property is used to add alternate proximity app Ids that match the proximity app Ids of peer apps running on other platforms. The [PeerFinder](peerfinder.md) class uses the alternate app Ids to match a peer app running on a Windows 8 computer with a peer app running on another platform. For example, if you create an app for Windows 8 and also create the same app for Windows Phone, the apps will not have the same unique app Id on both platforms. You can use the [PeerFinder](peerfinder.md) class to match the peer apps by adding the app Id from the Windows Phone to the AlternateIdentities property of your Windows app, and by adding the app Id for your Windows app to the alternate identities of the Windows Phone.

The other platform must also support adding alternate identities so that the proximity app Id can be specified on that platform. You must include the proximity app Id on the other platform for the [PeerFinder](peerfinder.md) class to connect your apps when tapping with a Windows device. The format of the alternate identity string for a specific platform is determined by the implementation of the other platform. For example, to get the correct alternate identity string for Windows Phone, refer to the Windows Phone proximity API documentation.

The format of the proximity app Id is **&lt;package family name&gt;!&lt;app Id&gt;**. You can get the package family name from the [Windows.ApplicationModel.Package.Current.Id.FamilyName](../windows.applicationmodel/packageid_familyname.md) property. You must copy the app Id value from the **Id** attribute of the **Application** element in the package manifest for your app. For Example, `PeerFinder.Add("WindowsPhone", "{1c6379c1-9d5e-4254-8f4c-be7ea24057d1}")` adds a Windows Phone 8 app id as an alternate identity in your Windows 8 app. `PeerFinder.Add("Windows", "b3c3e7ef-371a-464f-a75e-95ddbdcaf974_7fed2v891h66p!App")` adds a Windows 8 app id as an alternate identity in a Windows Phone 8 app.

### Browsing within wireless range (FindAllPeersAsync)

When you connect peer apps by browsing for devices within wireless range using the [FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md) method, you can only match one app Id at a time. By default peer matching when browsing uses the Windows 8 proximity app Id . You can browse to connect peer apps running on different platforms by adding a unique "browse" app Id to the AlternateIdentities property. You can then add that same "browse" app Id to your peer app on the other platforms. If the "browse" alternate identity strings match, then the [PeerFinder](peerfinder.md) class can find the peer apps when you call the [FindAllPeersAsync](peerfinder_findallpeersasync_830195586.md) method.

## -examples

## -see-also
[Proximity and Tapping (C#/VB/C++)](/previous-versions/windows/apps/hh465221(v=win.10)), [Proximity sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Proximity%20sample)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_NETWORKING [Windows Phone]
