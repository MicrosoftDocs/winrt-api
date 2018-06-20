---
-api-id: P:Windows.UI.Notifications.TileNotification.Tag
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string Tag { get;  set; }
-->

# Windows.UI.Notifications.TileNotification.Tag

## -description
Gets or sets a string that Windows can use to prevent duplicate notification content from appearing in the queue.

## -property-value
A string of 16 characters or less (plus a terminating null character) that identifies the notification in the stack. While there is no set form to the string content, we recommend that it should relate to the content of the notification.

## -remarks
Use tags to replace notifications in the stack. If a new notification arrives with the same tag as an existing notification, the new notification replaces the old. For instance, if your tile shows stock prices, you want to show the most up-to-date info. An existing stock price update waiting in the queue to be displayed should be replaced by the latest quotes rather than showing them one after the other.

A new notification with a matching tag replaces any existing notification with the same tag, but the new notification does not necessarily inherit the older notification's place in the queue.

The tag should relate to the content of the notification. For example, a notification in a stock quote app could use the stock symbol (such as "msft") while a weather app notification could be tagged with the zip code (such as "98052") of the forecast. Do not simply number your notifications as "notification1", "notification2" and so on.

## -examples

## -see-also
[How to use the notification queue with local notifications](http://msdn.microsoft.com/library/614a784e-f418-46f7-b961-cef128779fea), [App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Quickstart: Sending a tile update](http://msdn.microsoft.com/library/d4b2cebf-9dec-4c8f-bc6d-23edca7aaf83), [Tile and tile notification overview](http://msdn.microsoft.com/library/10a05b52-42c4-4f85-9310-57663e378b9e), [The tile template catalog](http://msdn.microsoft.com/library/2d3dd627-9a34-493c-bda4-ff7b80817e4f), [Guidelines and checklist for tiles](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to schedule a tile notification](http://msdn.microsoft.com/library/56b0c3e3-be90-4461-a8b1-79e88072b37c), [How to set up periodic notifications for tiles](http://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [Tiles XML schema](https://docs.microsoft.com/uwp/schemas/tiles/tilesschema/schema-root)