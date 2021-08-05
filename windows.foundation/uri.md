---
-api-id: T:Windows.Foundation.Uri
-api-type: winrt class
---

<!-- Class syntax.
public class Uri : Windows.Foundation.IStringable, Windows.Foundation.IUriRuntimeClass, Windows.Foundation.IUriRuntimeClassWithAbsoluteCanonicalUri
-->

# Windows.Foundation.Uri

## -description
Defines an object that represents a Uniform Resource Identifier (URI) value and parses it into components. The Uri object is used by many other Windows Runtime APIs that are not necessarily confined to web browser scenarios.

> **.NET**
> When programming with .NET, this type is hidden and developers should use [System.Uri](/dotnet/api/system.uri?view=dotnet-uwp-10.0&preserve-view=true). See Remarks.

## -remarks
> [!IMPORTANT]
> When programming with .NET, this class is hidden and developers should use the [System.Uri](/dotnet/api/system.uri?view=dotnet-uwp-10.0&preserve-view=true) class, which uses RFC 3987 rules to encode and decode Uniform Resource Identifier (URI). The Windows.Foundation.Uri class doesn't percent-encode non-ASCII characters in Uniform Resource Identifier (URI) where the scheme refers to a Windows file path (like ms-appx:). Windows.Foundation.Uri also interprets percent-encoding using the user's current codepage.

The available members of [System.Uri](/dotnet/api/system.uri?view=dotnet-uwp-10.0&preserve-view=true) are similar but different than the members of Windows.Foundation.Uri, and some of the basic behaviors described in this topic are different. For more info on the encoding differences and what members are available, see [System.Uri](/dotnet/api/system.uri?view=dotnet-uwp-10.0&preserve-view=true) (particularly the Remarks).

Here is a breakdown of the parts of an example Uniform Resource Identifier (URI):

*scheme*://*username*:*password*@*host*:*port*/*path*.*extension*?*query*#*fragment*

For example:

`http://msdn.microsoft.com/library/windows/apps/windows.foundation.uri.aspx?cs-save-lang=1&amp;cs-lang=cpp#code-snippet-1`

In this example:

+ *scheme* is `http`
+ *host* is `msdn.microsoft.com`
+ *domain* is `microsoft.com` (a subset of *host*)
+ *extension* is `aspx`
+ *query* is `cs-save-lang=1&amp;cs-lang=cpp`
+ *fragment* is `code-snippet-1`
> [!NOTE]
>  *username*:*password*@ preceding the *host* are mainly relevant for File Transfer Protocol (FTP)  Uniform Resource Identifier (URI). File Transfer Protocol (FTP) URIs have limited support in Windows Runtime; see "Transferring data in the background" ([HTML](/previous-versions/windows/apps/hh452979(v=win.10)) or [XAML](/previous-versions/windows/apps/hh452975(v=win.10))).

> [!IMPORTANT]
> Not all possible schemes are usable by a Windows Runtime app. Notably, the file: scheme is blocked. It's possible to create a Uri object that uses schemes that a Windows Runtime app won't support, and you're blocked when you try to apply that Uri as an input value for an API call, not when creating the object.

### URI schemes that are specific to a Windows Runtime app
Windows Runtime has several schemes that are unique to a Windows Runtime app, and these refer to assets that are part of the app. Generally, these schemes are what you can use instead of the file: scheme, to refer to packaged files and other assets that you've included as part of your app package, or assets that are otherwise associated with an installed app:

+ ms-appx: references the app's locally-packaged files.
+ ms-appx-web: also references the app's locally-packaged files but loads them in a web context. This is often necessary if you are accessing assets for use by [WebView](../windows.ui.xaml.controls/webview.md), or writing HTML/JavaScript apps and requesting from an HTML page. For more info see [URI schemes](/previous-versions/windows/apps/jj655406(v=win.10)) or [How to reference content (HTML)](/previous-versions/windows/apps/hh781215(v=win.10)).
+ ms-appdata: refers to app files that come from the app's local, roaming, and temporary data folders. For more info see [URI schemes](/previous-versions/windows/apps/jj655406(v=win.10)) or [Store and retrieve settings and other app data](/windows/uwp/app-settings/store-and-retrieve-app-data).
+ ms-resource: refers to app resources in the [Resource Management System](/windows/uwp/app-resources/resource-management-system). For more info, see [Localize strings in your UI and app package manifest](/windows/uwp/app-resources/localize-strings-ui-manifest).

Each of these schemes ignores many of the component parts of a Uniform Resource Identifier (URI) that are intended for other schemes (for example, [Query](uri_query.md) and [Fragment](uri_fragment.md)). Also, certain components are explicitly disallowed and cause the Uri value using these schemes to be treated as an invalid input (for example [UserName](uri_username.md) and [Password](uri_password.md) values in an ms-appx:  Uri scheme will invalidate a Uri). For more info, see [URI schemes](/previous-versions/windows/apps/jj655406(v=win.10)).

In most cases, you use these schemes with three slashes (example: ms-appx:///page.html), which references the root of the current app, using the current app as authority. Usages with two slashes are possible, but might require specifying the authority name explicitly. Usages with two slashes can refer to a package dependency as the authority, or can refer to relative locations within the app. For more info, see [URI schemes](/previous-versions/windows/apps/jj655406(v=win.10)).

### Absolute and relative URIs
At a code level, the Windows Runtime does not support relative Uniform Resource Identifier (URI). All Uri objects you create must represent an absolute Uniform Resource Identifier (URI). The schemes listed in the previous section are actually absolute Uniform Resource Identifier (URI), because the host and authority are implicit for each scheme and the remainder of the path is evaluated under that authority.

### Launching an app by URI scheme
The Uniform Resource Identifier (URI) scheme of a Uri value can be used to launch other apps that are associated with that particular scheme. For more info, see [Launch the default app for a URI](/windows/uwp/launch-resume/launch-default-app)).

<!--Leaving activation by URI alone, not sure of the emphasis/model-->

## -examples
This example creates a Uri object that represents a Uniform Resource Identifier (URI) that's using the **http** protocol to access a website.

```javascript
// The URI string
var uriToLaunch = "http://www.bing.com";

// Create a Uri object from the URI string
var uri = new Windows.Foundation.Uri(uriToLaunch);
```

```cppwinrt
// The URI string.
std::wstring uriToLaunch{ L"http://www.bing.com" };

// Create a Uri object from the URI string.
Windows::Foundation::Uri uri{ uriToLaunch };
```

```cppcx
// The URI string
var uriToLaunch = L"http://www.bing.com";

// Create a Uri object from the URI string
auto uri = ref new Windows::Foundation::Uri(uriToLaunch);
```

This example creates a Uri that uses the **ms-appx** protocol to access an image file in the app package.

```javascript
// The URI string
var uriImage = "ms-appx:///images/SecondaryTileDefault-sdk.png";

// Create a Uri object from the URI string
var uri = new Windows.Foundation.Uri(uriImage);
```

```cppwinrt
// The URI string.
std::wstring uriImage{ L"ms-appx:///images/SecondaryTileDefault-sdk.png" };

// Create a Uri object from the URI string.
Windows::Foundation::Uri uri{ uriImage };
```

```cppcx
// The URI string
var uriImage = ;

// Create a Uri object from the URI string
auto uri = ref new Windows::Foundation::Uri(uriImage);
```

This example creates a Uri that uses the **ms-appdata** protocol to access a file in local app data store for your app.

```javascript
// The URI string
var uriFile = "ms-appdata:///local/file.ext";

// Create a Uri object from the URI string
var uri = new Windows.Foundation.Uri(uriFile);
```

```cppwinrt
// The URI string.
std::wstring uriFile{ L"ms-appdata:///local/file.ext" };

// Create a Uri object from the URI string.
Windows::Foundation::Uri uri{ uriFile };
```

```cppcx
// The URI string
var uriFile = "ms-appdata:///local/file.ext";

// Create a Uri object from the URI string
auto uri = ref new Windows::Foundation::Uri(uriFile);
```

## -see-also
[System.Uri](/dotnet/api/system.uri?view=dotnet-uwp-10.0&preserve-view=true), [How to reference content (HTML)](/previous-versions/windows/apps/hh781215(v=win.10)), [How to load file resources (XAML)](/previous-versions/windows/apps/hh965322(v=win.10)), [Connecting to networks and web services](/windows/uwp/networking/index), [WwwFormUrlDecoder](wwwformurldecoder.md), [createObjectURL (for HTML/JavaScript)](https://developer.mozilla.org/en-US/docs/Web/API/URL/createObjectURL), [RFC 3986](https://www.ietf.org/rfc/rfc3986.txt), [RFC 3987](https://tools.ietf.org/html/rfc3987), [RssReader sample](/samples/microsoft/windows-appsample-rssreader/rssreader-sample/)
