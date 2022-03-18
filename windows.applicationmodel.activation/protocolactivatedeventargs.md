---
-api-id: T:Windows.ApplicationModel.Activation.ProtocolActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class ProtocolActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgs, Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser, Windows.ApplicationModel.Activation.IApplicationViewActivatedEventArgs, Windows.ApplicationModel.Activation.IProtocolActivatedEventArgs, Windows.ApplicationModel.Activation.IProtocolActivatedEventArgsWithCallerPackageFamilyNameAndData, Windows.ApplicationModel.Activation.IViewSwitcherProvider
-->

# Windows.ApplicationModel.Activation.ProtocolActivatedEventArgs

## -description

Provides data when an app is activated because it is the app associated with a URI scheme name.

> **JavaScript**
> This type appears as [WebUIProtocolActivatedEventArgs](../windows.ui.webui/webuiprotocolactivatedeventargs.md).

## -remarks

This object is accessed when you implement an event handler to respond to [Activated](../windows.applicationmodel.core/coreapplicationview_activated.md) events when [ActivationKind](activationkind.md) is **Protocol**.

UWP app using C++, C#, or Visual Basic typically implement activation points by overriding methods of the [Application](../windows.ui.xaml/application.md) object. The default template app.xaml code-behind files always include an override for [OnLaunched](../windows.ui.xaml/application_onlaunched_859642554.md), but defining overrides for other activation points such as [OnActivated](../windows.ui.xaml/application_onactivated_603737819.md) is up to your app code. If [ActivationKind](activationkind.md) is **Protocol** then the interface-typed [IActivatedEventArgs](iactivatedeventargs.md) from [OnActivated](../windows.ui.xaml/application_onactivated_603737819.md) can be cast to ProtocolActivatedEventArgs.

All [Application](../windows.ui.xaml/application.md) overrides involved in an activation scenario should call [Window.Activate](../windows.ui.xaml/window_activate_1797342875.md) in their implementations.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | User |

## -examples

The [OnActivated](../windows.ui.xaml/application_onactivated_603737819.md) event handler receives all activation events. The  property indicates the type of activation event. This example is set up to handle **URI** activation events.

```csharp
public partial class App
{
   protected override void OnActivated(IActivatedEventArgs args)
   {
      if (args.Kind == ActivationKind.Protocol)
      {
         ProtocolActivatedEventArgs eventArgs = args as ProtocolActivatedEventArgs;

         // TODO: Handle URI activation
         // The received URI is eventArgs.Uri.AbsoluteUri
      }
   }
}
```

```vb
Private Sub OnFileActivated(ByVal args As Windows.ApplicationModel.Activation.IActivatedEventArgs)
   If args.Kind = ActivationKind.Protocol Then
      ProtocolActivatedEventArgs eventArgs = args As ProtocolActivatedEventArgs

      ' TODO: Handle URI activation
      ' The received URI is eventArgs.Uri.AbsoluteUri
   End If
End Sub
```

```cppwinrt
void App::OnActivated(Windows::ApplicationModel::Activation::IActivatedEventArgs const& args)
{
    if (args.Kind() == Windows::ApplicationModel::Activation::ActivationKind::Protocol)
    {
        auto eventArgs{ args.as<Windows::ApplicationModel::Activation::ProtocolActivatedEventArgs>() };

        // TODO: Handle URI activation.
        // The received URI is eventArgs.Uri().RawUri().
    }
}
```

```cppcx
void App::OnActivated(Windows::ApplicationModel::Activation::IActivatedEventArgs^ args)
{
   if (args->Kind == Windows::ApplicationModel::Activation::ActivationKind::Protocol)
   {
      Windows::ApplicationModel::Activation::ProtocolActivatedEventArgs^ eventArgs = 
          dynamic_cast<Windows::ApplicationModel::Activation::ProtocolActivatedEventArgs^>(args);
      
      // TODO: Handle URI activation  
      // The received URI is eventArgs->Uri->RawUri
   } 
}
```

## -see-also

[Association launching sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Association%20launching%20sample), [Handling Contact Actions sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Handling%20Contact%20Actions), [Handle URI activation](/windows/uwp/launch-resume/handle-uri-activation), [Quickstart: Handling contact actions ](/previous-versions/windows/apps/dn518236(v=win.10)), [Guidelines for file types and URIs](/windows/uwp/files/index), [Windows.UI.Core.CoreApplicationView.Activated](../windows.applicationmodel.core/coreapplicationview_activated.md), [Windows.UI.Xaml.Application.OnActivated](../windows.ui.xaml/application_onactivated_603737819.md), [URI](../windows.foundation/uri.md), [Association launching sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620490)