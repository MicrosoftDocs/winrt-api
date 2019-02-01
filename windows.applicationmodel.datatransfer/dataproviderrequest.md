---
-api-id: T:Windows.ApplicationModel.DataTransfer.DataProviderRequest
-api-type: winrt class
---

<!-- Class syntax.
public class DataProviderRequest : Windows.ApplicationModel.DataTransfer.IDataProviderRequest
-->

# Windows.ApplicationModel.DataTransfer.DataProviderRequest

## -description
An object of this type is passed to the [DataProviderHandler](dataproviderhandler.md) delegate.

## -remarks
Use this object when you need to delay, or defer, a share for a few milliseconds. To learn more, check out [How to delay sharing](https://msdn.microsoft.com/library/34c8bda2-807c-4142-a0fc-d80e62d9b6b2).

## -examples


[!code-csharp[ShareFileFunction_CS](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareEssentials1.xaml.cs#SnippetShareFileFunction_CS)]

[!code-js[ShareFileFunction](../windows.applicationmodel.datatransfer/code/ShareMainBeta/javascript/js/ShareFiles.js#SnippetShareFileFunction)]

## -see-also
