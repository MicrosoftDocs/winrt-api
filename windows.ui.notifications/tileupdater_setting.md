---
-api-id: P:Windows.UI.Notifications.TileUpdater.Setting
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Notifications.NotificationSetting Setting { get; }
-->

# Windows.UI.Notifications.TileUpdater.Setting

## -description
Gets a value that specifies whether a tile can be updated through notifications.

## -property-value
A value that indicates either that the tile can be updated through notifications, or who disabled them: developer, user, or administrator.

## -remarks
<!-- @WRITER erictill 6/11/2012 : This line is no longer in the sample. -->

<!-- @WRITER erictill 6/11/2012 : 1067 hits on the how-to, but not even part of the sample anymore. Wordy, hard to understand what anyone would do with this information. -->

<!-- @WRITER erictill 12/31/2011 :
                These settings are used to determine if the tile or toast for the application is currently enabled or disabled. Note - this information should not be used to tell your service to send or not send notifications, since the setting can be changed at any time while your application is not running. It's advised that your application continue to send tile notifications via push, periodic, scheduled, or local apis irrespective of these user-controlled settings. 
                You may want to use these settings to change your in-application experience, particularly in the case of toast notifications. Should toast notifications be disabled, you may want to inform your user within the app, particularly if the application's core functionality depends on toasting the user while the user is not directly interacting with your application. 
                The HowTo should show how to call the API call. Pretty simple. We do not have a sample for this. If we drop the how-to, we should at least move this advice/content to one of the checklist documents. -->

<!-- @WRITER erictill 6/9/2012 : <p>In general, an app can use this setting to determine if it should update the tile with local content from the app itself.</p> I don't really understand that, but maybe that's the whole point of calling this thing. Otherwise it seems pretty pointless for tiles. -->

<!-- @WRITER erictill 6/11/2012 : Isn't that more of a toast scenario? -->

<!-- @WRITER erictill 6/11/2012 :            
            <step>
                <title>Optional: Determine whether the user can receive notifications</title>
                
                <example devlang="javascript">
                    <desc>
                        <p>This step shows how to retrieve the user's tile notification setting. The user can disable notifications through the <mark type="ui_item">Turn off live tile</mark> option in the app bar, which supresses notifications for only that app, or an administrator can disable all tile notifications for all apps through group policy.</p>
                        
                        <note>Do not use this information to tell your cloud service to stop sending notifications, since the user might change the setting when your app isn't running. Continue to send notifications normally through all delivery mechanisms (local, scheduled, periodic, or push) whether the user can receive them or not.</note>
                            
                        <p>There are legitimate scenarios where, upon finding that the user has disabled notifications, an app could suggest to the user that they enable them. One example is the receipt of an instant message when the user has disabled notifications in a messaging app. However, make sure that the situation is important enough to warrant the request and do not badger the user to make the change.</p>
                    </desc>
                    
                    <snippet devlang="javascript" type="code">
                        <![CDATA[
var notificationSetting = notifications.TileUpdateManager.createTileUpdaterForApplication().setting;]]>
                    </snippet>
                </example>
			</step> -->

## -examples

## -see-also
[App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Quickstart: Sending a tile update](http://msdn.microsoft.com/library/d4b2cebf-9dec-4c8f-bc6d-23edca7aaf83), [Tile and tile notification overview](http://msdn.microsoft.com/library/10a05b52-42c4-4f85-9310-57663e378b9e), [The tile template catalog](http://msdn.microsoft.com/library/2d3dd627-9a34-493c-bda4-ff7b80817e4f), [Guidelines and checklist for tiles](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to schedule a tile notification](http://msdn.microsoft.com/library/56b0c3e3-be90-4461-a8b1-79e88072b37c), [How to set up periodic notifications for tiles](http://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [Tiles XML schema](XREF:TODO:tile.Schema_Root)