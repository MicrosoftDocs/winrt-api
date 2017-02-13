---
-api-id: M:Windows.Foundation.Uri.ToString
-api-type: winrt method
---

<!-- Method syntax
public string ToString()
-->

# Windows.Foundation.Uri.ToString

## -description
Gets a canonical string representation for the current [Uri](uri.md).

## -returns
The unescaped canonical representation of the current [Uri](uri.md). All characters are unescaped, except #, ?, and %.

## -remarks
 This **ToString** implementation is for the [IStringable](istringable.md) interface as implemented by the [Uri](uri.md) class. [IStringable](istringable.md) is supported starting with Windows 8.1 and is also available in Windows Phone 8.1. The [IStringable](istringable.md) definition of **ToString** implementation is not literally an override of **Platform::Object** and its base API, but it does replace the **ToString** behavior.

  For Windows 8 and Windows Phone 8, [Uri](uri.md) does not implement [IStringable](istringable.md) (it's not available). So the **ToString** method of [Uri](uri.md) remains the one that's implemented by **Platform::Object** or JavaScript "object" support for Windows Runtime. The apparent difference in origin of the **ToString** API is only visible for Visual C++ component extensions (C++/CX) and JavaScript, and you should consider it as an implementation detail that doesn't matter as far as how you use **ToString** in either case.

 

## -examples

## -see-also
