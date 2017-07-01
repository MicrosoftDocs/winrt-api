---
-api-id: T:Windows.Foundation.Uri
-api-type: winrt class
---

<!-- Class syntax.
public class Uri : Windows.Foundation.IStringable, Windows.Foundation.IUriRuntimeClass, Windows.Foundation.IUriRuntimeClassWithAbsoluteCanonicalUri
-->

# Windows.Foundation.Uri

## -description
Defines an object that represents a Uniform Resource Identifier (URI) value and parses it into components. The [Uri](uri.md) object is used by many other Windows Runtime APIs that are not necessarily confined to web browser scenarios.



> **.NET**
> When programming with .NET, this type is hidden and developers should use [System.Uri](https://msdn.microsoft.com/library/system.uri.aspx). See Remarks.

## -remarks
> [!IMPORTANT]
> When programming with .NET, this class is hidden and developers should use the [System.Uri](https://msdn.microsoft.com/library/system.uri.aspx) class, which uses RFC 3987 rules to encode and decode Uniform Resource Identifier (URI). The [Windows.Foundation.Uri](uri.md) class doesn't percent-encode non-ASCII characters in Uniform Resource Identifier (URI) where the scheme refers to a Windows file path (like ms-appx:). [Windows.Foundation.Uri](uri.md) also interprets percent-encoding using the user's current codepage.

The available members of [System.Uri](https://msdn.microsoft.com/library/system.uri.aspx) are similar but different than the members of [Windows.Foundation.Uri](uri.md), and some of the basic behaviors described in this topic are different. For more info on the encoding differences and what members are available, see [System.Uri](https://msdn.microsoft.com/library/system.uri.aspx) (particularly the Remarks).

Here is a breakdown of the parts of an example Uniform Resource Identifier (URI):

<cmd_line>*scheme*://*username*:*password* @*host*:*port*/*path*.*extension* ?*query* #*fragment*</cmd_line>

For example:

<cmd_line>http://msdn.microsoft.com/en-us/library/windows/apps/windows.foundation.uri.aspx?cs-save-lang=1&amp;cs-lang=cpp#code-snippet-1</cmd_line>

In this example:


+ *scheme* is <cmd_line>http</cmd_line>
+ *host* is <cmd_line>msdn.microsoft.com</cmd_line>
+ *domain* is <cmd_line>microsoft.com</cmd_line> (a subset of *host*)
+ *extension* is <cmd_line>aspx</cmd_line>
+ *query* is <cmd_line>cs-save-lang=1&amp;cs-lang=cpp</cmd_line>
+ *fragment* is <cmd_line>code-snippet-1</cmd_line>
> [!NOTE]
>  *username*:*password***@** preceding the *host* are mainly relevant for File Transfer Protocol (FTP)  Uniform Resource Identifier (URI). File Transfer Protocol (FTP) URIs have limited support in Windows Runtime; see "Transferring data in the background" ([HTML](http://msdn.microsoft.com/library/9e2ed5b4-af57-456a-884f-1e1d2136a8e8) or [XAML](http://msdn.microsoft.com/library/dfc4d2a2-8825-4c12-87db-9743ba3bd167)).



> [!IMPORTANT]
> Not all possible schemes are usable by a Windows Runtime app. Notably, the file: scheme is blocked. It's possible to create a [Uri](uri.md) object that uses schemes that a Windows Runtime app won't support, and you're blocked when you try to apply that [Uri](uri.md) as an input value for an API call, not when creating the object.

### URI schemes that are specific to a Windows Runtime app

Windows Runtime has several schemes that are unique to a Windows Runtime app, and these refer to assets that are part of the app. Generally, these schemes are what you can use instead of the file: scheme, to refer to packaged files and other assets that you've included as part of your app package, or assets that are otherwise associated with an installed app:+ ms-appx: references the app’s locally-packaged files.
+ ms-appx-web: also references the app’s locally-packaged files but loads them in a web context. This is often necessary if you are accessing assets for use by [WebView](../windows.ui.xaml.controls/webview.md), or writing HTML/JavaScript apps and requesting from an HTML page. For more info see [URI schemes](http://msdn.microsoft.com/library/f3b3ae74-aaea-4f00-8f0a-4c231b8745af) or [How to reference content (HTML)](http://msdn.microsoft.com/library/b1ad2d76-d18f-4e9e-b810-06af0cfd4628).
+ ms-appdata: refers to app files that come from the app's local, roaming, and temporary data folders. For more info see [URI schemes](http://msdn.microsoft.com/library/f3b3ae74-aaea-4f00-8f0a-4c231b8745af) or [Store and retrieve settings and other app data](http://msdn.microsoft.com/library/41676a02-325a-455e-8565-c9ec0bc3a8fe).
+ ms-resource: refers to app resources in the [Resource Management System](http://msdn.microsoft.com/library/a090a59f-a8fa-489f-a600-9e7bfb67e5ad). For more info, see "How to load string resources" ([HTML](http://msdn.microsoft.com/library/849f5bbf-6d85-4760-8832-75d3eff9bd96) or [XAML](http://msdn.microsoft.com/library/c0e5b59a-d0d0-454e-aca3-dcaba57ae3e3)).
Each of these schemes ignores many of the component parts of a Uniform Resource Identifier (URI) that are intended for other schemes (for example, [Query](uri_query.md) and [Fragment](uri_fragment.md)). Also, certain components are explicitly disallowed and cause the [Uri](uri.md) value using these schemes to be treated as an invalid input (for example [UserName](uri_username.md) and [Password](uri_password.md) values in an ms-appx:  [Uri](uri.md) scheme will invalidate a [Uri](uri.md)). For more info, see [URI schemes](http://msdn.microsoft.com/library/f3b3ae74-aaea-4f00-8f0a-4c231b8745af).

In most cases, you use these schemes with three slashes (example: ms-appx:///page.html), which references the root of the current app, using the current app as authority. Usages with two slashes are possible, but might require specifying the authority name explicitly. Usages with two slashes can refer to a package dependency as the authority, or can refer to relative locations within the app. For more info, see [URI schemes](http://msdn.microsoft.com/library/f3b3ae74-aaea-4f00-8f0a-4c231b8745af).

### Absolute and relative URIs

At a code level, the Windows Runtime does not support relative Uniform Resource Identifier (URI). All [Uri](uri.md) objects you create must represent an absolute Uniform Resource Identifier (URI). The schemes listed in the previous section are actually absolute Uniform Resource Identifier (URI), because the host and authority are implicit for each scheme and the remainder of the path is evaluated under that authority.

### Launching an app by URI scheme

The Uniform Resource Identifier (URI) scheme of a [Uri](uri.md) value can be used to launch other apps that are associated with that particular scheme. For more info, see "How to launch the default app for a URI" ([HTML](http://msdn.microsoft.com/library/0f9fa8db-3e51-4cf8-879d-2b79a8ddbb7d) or [XAML](http://msdn.microsoft.com/library/7b0d0af5-d89e-4db0-9b79-90201d79974f)).

<!--Leaving activation by URI alone, not sure of the emphasis/model-->

## -examples
This example creates a [Uri](uri.md) object that represents a Uniform Resource Identifier (URI) that's using the **http** protocol to access a website.

```javascript
// The URI string
var uriToLaunch = "http://www.bing.com";

// Create a Uri object from the URI string
var uri = new Windows.Foundation.Uri(uriToLaunch);
```

```cpp
// The URI string
var uriToLaunch = L"http://www.bing.com";

// Create a Uri object from the URI string
auto uri = ref new Windows::Foundation::Uri(uriToLaunch);
```

This example creates a [Uri](uri.md) that uses the **ms-appx** protocol to access an image file in the app package.

```javascript
// The URI string
var uriImage = "ms-appx:///images/SecondaryTileDefault-sdk.png";

// Create a Uri object from the URI string
var uri = new Windows.Foundation.Uri(uriImage);
```

```cpp
// The URI string
var uriImage = "ms-appx:///images/SecondaryTileDefault-sdk.png";

// Create a Uri object from the URI string
auto uri = ref new Windows::Foundation::Uri(uriImage);
```

This example creates a [Uri](uri.md) that uses the **ms-appdata** protocol to access a file in local app data store for your app.

```javascript
// The URI string
var uriFile = "ms-appdata:///local/file.ext";

// Create a Uri object from the URI string
var uri = new Windows.Foundation.Uri(uriFile);
```

```cpp
// The URI string
var uriFile = "ms-appdata:///local/file.ext";

// Create a Uri object from the URI string
auto uri = ref new Windows::Foundation::Uri(uriFile);
```



## -see-also
[System.Uri](https://msdn.microsoft.com/library/system.uri.aspx), [How to reference content (HTML)](http://msdn.microsoft.com/library/b1ad2d76-d18f-4e9e-b810-06af0cfd4628), [How to load file resources (XAML)](http://msdn.microsoft.com/library/a1bfa080-757c-49f7-8b7e-dcf64234edac), [Connecting to networks and web services](https://docs.microsoft.com/en-us/windows/uwp/networking/index), [WwwFormUrlDecoder](wwwformurldecoder.md), [createObjectURL (for HTML/JavaScript)](https://msdn.microsoft.com/library/windows/apps/hh453196), [RFC 3986](http://go.microsoft.com/fwlink/p/?LinkId=263444), [RFC 3987](http://tools.ietf.org/html/rfc3987), [RSS reader end-to-end (JavaScript) sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620542)
