---
-api-id: M:Windows.UI.Notifications.TileUpdater.StartPeriodicUpdateBatch(Windows.Foundation.Collections.IIterable{Windows.Foundation.Uri},Windows.Foundation.DateTime,Windows.UI.Notifications.PeriodicUpdateRecurrence)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void StartPeriodicUpdateBatch(Windows.Foundation.Collections.IIterable<Windows.Foundation.Uri> tileContents, Windows.Foundation.DateTime startTime, Windows.UI.Notifications.PeriodicUpdateRecurrence requestedInterval)
-->

# Windows.UI.Notifications.TileUpdater.StartPeriodicUpdateBatch

## -description
Begins a series of timed updates that cycle on the tile that the updater is bound to. Update content is retrieved from an array of specified Uniform Resource Identifier (URI) with updates beginning at a specified time and subsequent updates occurring at the periodic interval thereafter.

> [!NOTE]
> To use this feature, you must first enable the tile's notification queue by calling [EnableNotificationQueue](tileupdater_enablenotificationqueue_1798421599.md).

## -parameters
### -param tileContents
An array of up to five Uniform Resource Identifier (URI) from which the XML content of the cycling tile updates will be retrieved. If the array contains more than five Uniform Resource Identifier (URI), the method will fail.

### -param startTime
The time at which the initial Uniform Resource Identifier (URI) should first be polled for new content.

### -param requestedInterval
The frequency with which the Uniform Resource Identifier (URI) is polled for new tile content, following the initial update at *startTime*.

## -remarks
### Using the notification queue with periodic updates

To use the notification queue, you must first enable it for your tile with this line of code:

```javascript
Windows.UI.Notifications.TileUpdateManager.createTileUpdaterForApplication().enableNotificationQueue(true);
```

This API only needs to be called once in your app's lifetime, but there is no harm in calling it each time the app launches.

In the case of periodic notifications, a unique URL is provided for each notification. Each URL is polled on a periodic basis by Windows for updated notification content. The content payload returned from each URL should contain versions of the notification XML for all supported tile sizes. Each polled URL also can optionally return its own unique expiration time and tag value.

### Tagging notifications for periodic updates

With the notification queue enabled, your tile can cycle through a maximum of five queued notifications. Generally, the oldest notification is replaced in the queue when a new notification arrives. However, notifications can be given a tag so that a new notification with a specific tag will replace an older notification with the same tag, regardless of its place in the queue.

Tags are optional strings of up to 16 characters that can be set on a notification as an identifier. If a new notification arrives with the same tag as a notification already in the queue, the new notification replaces the old one rather than falling under the default first-in, first-out queue behavior. This prevents the case where two versions of the same notification— one of them out-of-date— are present in the queue at the same time.

In the case of periodic notifications, tags are provided in the X-WNS-Tag header of the notification's HTTP response message, which also includes the notification's content. This message is sent in response to the system's periodic call to the notification's Uniform Resource Identifier (URI). The header name and the tag value are case-insensitive.

An example is shown here:

```html
X-WNS-Tag: stockMSFT
```

### Setting an expiration time for periodic updates

Tiles expire by default after three days. If your notification content has a significantly different useful lifespan— shorter or longer— you should explicitly set an expiration time for each notification. This prevents stale or irrelevant content from remaining in the queue. This is especially important if the user's machine loses Internet connectivity for a long period of time.

For example, during active trading, it would be advisable for a stock app to set the expiration on a stock price notification to twice that of your polling interval, such as a notification that expires one hour after it is sent if you poll for an update every half-hour. In the case of a news app, an expiration of one day for a tile that shows the top daily news would be appropriate.

For periodic notifications, the expiration time is set in the X-WNS-Expires header of the notification's HTTP response message. The expiration time is expressed as an HTTP-date, which uses one of the formats shown in these examples:


+ Sun, 06 Nov 1994 08:49:37 GMT
+ Sunday, 06-Nov-94 08:49:37 GMT
+ Sun Nov 6 08:49:37 1994


For more information on the HTTP-date format, see the World Wide Web Consortium (W3C) [3 Protocol Parameters](https://www.w3.org/Protocols/rfc2616/rfc2616-sec3.html) document.

For an example of a full implementation of periodic notifications used in conjunction with the notification queue, see Scenario 3 in the [Push and periodic notifications sample (archived)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Push%20and%20periodic%20notifications%20client-side%20sample).

## -examples

## -see-also
[StartPeriodicUpdateBatch(IIterable(Uri), PeriodicUpdateRecurrence)](tileupdater_startperiodicupdatebatch_1331011351.md), [StartPeriodicUpdate](tileupdater_startperiodicupdate_1369986471.md), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [Guidelines and checklist for periodic notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-periodic-notification-overview), [Tile and tile notification overview](/previous-versions/windows/apps/hh779724(v=win.10))
