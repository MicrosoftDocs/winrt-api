---
-api-id: M:Windows.Networking.Proximity.ProximityDevice.PublishBinaryMessage(System.String,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public long PublishBinaryMessage(System.String messageType, Windows.Storage.Streams.IBuffer message)
-->

# Windows.Networking.Proximity.ProximityDevice.PublishBinaryMessage

## -description
Publishes a message that contains binary data to subscribers of the specified message type.

## -parameters
### -param messageType
The type of message to deliver to subscribers.

### -param message
The binary message data to deliver to subscribers.

## -returns
A unique publication ID for the published message.

## -remarks
You can publish multiple messages of the same message type and each publication will have a unique ID associated with it.

You can stop publishing a message by passing the publication ID returned by the [PublishBinaryMessage](proximitydevice_publishbinarymessage.md) method to the [StopPublishingMessage](proximitydevice_stoppublishingmessage.md) method.

Messages continue to be published until the [StopPublishingMessage](proximitydevice_stoppublishingmessage.md) method is called or the [ProximityDevice](proximitydevice.md) is released.

You can subscribe to published messages using the [SubscribeForMessage](proximitydevice_subscribeformessage.md) method.

You can use the [PublishMessage](proximitydevice_publishmessage.md) method to publish a text message to a proximate computer. You can use the [PublishUriMessage](proximitydevice_publishurimessage.md) method to publish a Uniform Resource Identifier (URI) to a proximate computer.



> [!IMPORTANT]
> The proximity APIs do not provide authentication, encryption, or message integrity. Do not use proximity to exchange user sensitive information such as passwords, financial data, text messages, email, photographs, or government id numbers.

### Message Types

You use the *messageType* parameter to supply an identifier that uniquely identifies the published message, and also defines the meaning of the message and the intended subscriber audience.

Message type values are case-sensitive strings that consist of two parts: the *protocol* and the *subtype*. The *protocol* is first, followed by a dot (.) and then the subtype. The *subtype* is a string of alphanumeric characters and any of the valid URI characters as defined by RFC 3986: **- . _~ : / ? # [ ] @ ! $ &amp; ‘ ( ) * + , ; = %**. The *subtype* cannot exceed a length of 250 characters. The following table shows the supported values for the *protocol* part of the message type.

<termdeflist layout="termdef"><label>Protocol</label><termdef><name>Windows</name>The message contains binary data.</termdef><termdef><name>WindowsUri</name>The message data contains a UTF-16LE encoded string that is a Uniform Resource Identifier (URI).

Windows will always handle "WindowsUri" messages by prompting the user to view a received URI that in the Windows default app that handles a specific URI protocol, for example, **http://** URIs open in the default web browser. Windows will open a URI in the default app even if another app is also subscribed to "WindowsUri".

Instead of calling the [PublishBinaryMessage](proximitydevice_publishbinarymessage.md) method with this protocol, use the [PublishUriMessage](proximitydevice_publishurimessage.md) method.

If you publish a Uri to a computer that is not running Windows, the Uri is automatically formatted based on the proximity technology that your computer supports. For example, if your computer uses NFC hardware for proximity, then the Uri is formatted as an NDEF URI record.

If you are subscribing for a "WindowsUri" message and your Windows computer receives a message formatted for the proximity technology that your computer supports, Windows reads the formatted message and returns only the Uri as the message content.</termdef><termdef><name>WindowsMime</name>The message data is of a specific mime type. For example, if the message data is a jpeg image, the message type is "WindowsMime.image/jpeg".

Windows will always handle "WindowsMime" messages by prompting the user to view the mime content that was received, even if an app is also subscribed for the mime content.

If you publish a "WindowsMime" message to a computer that is not running Windows, the message content is automatically formatted based on the proximity technology that your computer supports. For example, if your computer uses NFC hardware for proximity, then the message content is formatted as an NDEF Mime record.

If you are publishing a "WindowsMime" message, you must always include the mime type. If you are subscribing to a "WindowsMime" message, you can use "WindowsMime" without specifying the mime type to subscribe for all mime types. If you subscribe to a specific mime type and your Windows computer receives a message formatted for the proximity technology that your computer supports, Windows reads the formatted message and returns only the mime content as the message content. If you subscribe for all mime types, the first 256 bytes received is the ASCII mime type string, and the remaining bytes are the mime content.</termdef><termdef><name>Windows:WriteTag</name>This is the same as the **Windows** protocol, except that the content is intended to be written to a static tag. The message is not transmitted to any device except a writable static tag. This protocol is only valid for publications. An example of this protocol is "Windows:WriteTag.SampleSubtype".</termdef><termdef><name>WindowsUri:WriteTag</name>This is the same as the **WindowsUri** protocol, except that the content is intended to be written to a static tag. The message is not transmitted to any device except a writable static tag. This protocol is only valid for publications.</termdef><termdef><name>WindowsMime:WriteTag</name>This is the same as the **WindowsMime** protocol, except that the content is intended to be written to a static tag. The message is not transmitted to any device except a writable static tag. This protocol is only valid for publications. An example of this protocol is "WindowsMime:WriteTag.image/jpeg".</termdef><termdef><name>LaunchApp:WriteTag</name>Write a tag that can be used to launch a specific app with optional launch parameters. If you publish a **LaunchApp:WriteTag** message to a tag the result when that tag is tapped to a computer is the same as calling the [PeerFinder.Start](peerfinder_start.md) method and passing your launch parameters. The message must be a UTF-16LE encoded string where the values are delimited by tab characters or null values in the following form:

```text
<launch arguments>[tab]<app platform 1>[tab]<app name 1>...[tab]<app platform N>[tab]<app name N>
```

The launch arguments are optional. The message can omit them:

```text
<app platform 1>[tab]<app name 1>...[tab]<app platform N>[tab]<app name N>
```

You must specify at least one app platform and app name. The app platform for a Windows 8 computer is **Windows**. The format of the proximity app Id is **&lt;package family name&gt;!&lt;app Id&gt;**. You can get the package family name from the [Windows.ApplicationModel.Package.Current.Id.FamilyName](../windows.applicationmodel/packageid_familyname.md) property. You must copy the app Id value from the **Id** attribute of the **Application** element in the package manifest for your app. An example of this message is "user=default\tWindows\tExample.Proximity.JS_8wekyb3d8bbwe!Proximity.App".

You can also support other app platforms. For more information, see [AlternateIdentities](peerfinder_alternateidentities.md).</termdef><termdef><name>WriteableTag</name>When subscribing for this message protocol, if a writeable tag is brought in to proximity, a proximity message is received that contains an **int32** (little endian) indicating the maximum writeable size of the tag. This protocol is only valid for subscriptions.</termdef><termdef><name>Pairing:Bluetooth</name>Windows subscribes to this message type to complete a Bluetooth pairing using proximity. This protocol is not intended to be uses in apps.</termdef><termdef><name>NDEF</name>The message contents are properly formatted NDEF records. The underlying type of the content for a publication using NDEF as the message type is contained in the NDEF records. A subscription for the NDEF type subscribes to all NDEF formatted messages.</termdef><termdef><name>NDEF:ext</name>The message data is application defined NDEF records (TNF field value of 0x04).

This protocol will launch a properly configured application to handle these events if there is no running application already subscribing to these events. To designate an app to handle a particular protocol using NDEF:ext, you must add a Protocol tag to the app manifest to specify the URI that will launch the app. The appropriate manifest syntax is demonstrated in the following example.

```xml

<Extensions>
  <Extension Category="windows.protocol">
    <Protocol Name="contoso.com+testapp" />
  </Extension>
</Extensions>

```

> [!NOTE]
> The URI format used in the app manifest is slightly different from the URI format used on the NFC tag, in that the manifest URI uses a '**+** ' character rather than a '**:** ' character. The URI on the NFC tag that activates the app with the manifest sample above is contoso.com:testapp.</termdef><termdef><name>NDEF:MIME</name>The message data is a properly formatted NDEF mime message (TNF field value of 0x02). For example, "NDEF:MIME.image/jpeg". This protocol only applies to subscriptions, when publishing NDEF content, use **NDEF**.</termdef><termdef><name>NDEF:URI</name>The message data is a properly formatted NDEF message of a type defined by a URI namespace (TNF field value of 0x03).This protocol only applies to subscriptions, when publishing NDEF content, use **NDEF**. This means that the data format is identified by the specified URI. An example of this protocol is "NDEF:URI.http://contoso.com/sometype".</termdef><termdef><name>NDEF:wkt</name>The message data is a properly formatted NDEF message of a type defined by the NFC forum (TNF field value of 0x01).An example of this type is "NDEF:wkt.U" for the well known type of URI. This protocol only applies to subscriptions, when publishing NDEF content, use **NDEF**.</termdef><termdef><name>NDEF:WriteTag</name>The message data should be written to an NFC forum standard static tag. The message data must be in a proper NDEF format. This protocol is only valid for publications.</termdef><termdef><name>NDEF:Unknown</name>The message data is an untyped NDEF message (TNF field value of 0x05).This protocol only applies to subscriptions, when publishing NDEF content, use **NDEF**.</termdef></termdeflist>

## -examples


[!code-csharp[LaunchAppWriteTag2](../windows.networking.proximity/code/Proximity_PublishBinaryMessage/csharp/MainPage.xaml.cs#SnippetLaunchAppWriteTag2)]

[!code-js[LaunchAppWriteTag2](../windows.networking.proximity/code/Proximity_PublishBinaryMessage/js/default.js#SnippetLaunchAppWriteTag2)]

[!code-vb[LaunchAppWriteTag2](../windows.networking.proximity/code/Proximity_PublishBinaryMessage/vbnet/MainPage.xaml.vb#SnippetLaunchAppWriteTag2)]

[!code-csharp[LaunchAppWriteTag2](../windows.networking.proximity/code/Proximity_PublishBinaryMessage/csharp/MainPage.xaml.cs#SnippetLaunchAppWriteTag2)]

[!code-js[LaunchAppWriteTag2](../windows.networking.proximity/code/Proximity_PublishBinaryMessage/js/default.js#SnippetLaunchAppWriteTag2)]

[!code-vb[LaunchAppWriteTag2](../windows.networking.proximity/code/Proximity_PublishBinaryMessage/vbnet/MainPage.xaml.vb#SnippetLaunchAppWriteTag2)]

## -see-also
[PublishBinaryMessage(String, IBuffer, MessageTransmittedHandler)](proximitydevice_publishbinarymessage_374148007.md), [Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity
ID_CAP_PROXIMITY [Windows Phone], ID_CAP_PROXIMITY [Windows Phone]
