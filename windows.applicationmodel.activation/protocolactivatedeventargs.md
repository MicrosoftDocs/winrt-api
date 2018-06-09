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

UWP app using C++, C#, or Visual Basic typically implement activation points by overriding methods of the [Application](../windows.ui.xaml/application.md) object. The default template app.xaml code-behind files always include an override for [OnLaunched](../windows.ui.xaml/application_onlaunched.md), but defining overrides for other activation points such as [OnActivated](../windows.ui.xaml/application_onactivated.md) is up to your app code. If [ActivationKind](activationkind.md) is **Protocol** then the interface-typed [IActivatedEventArgs](iactivatedeventargs.md) from [OnActivated](../windows.ui.xaml/application_onactivated.md) can be cast to [ProtocolActivatedEventArgs](protocolactivatedeventargs.md).

All [Application](../windows.ui.xaml/application.md) overrides involved in an activation scenario should call [Window.Activate](../windows.ui.xaml/window_activate.md) in their implementations.

## -examples

The [OnActivated](../windows.ui.xaml/application_onactivated.md) event handler receives all activation events. The  property indicates the type of activation event. This example is set up to handle **URI** activation events.

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

```vbnet
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

```cpp
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

[Association launching sample](http://go.microsoft.com/fwlink/p/?linkid=231484), [Handling Contact Actions sample](http://go.microsoft.com/fwlink/p/?LinkID=320151), [Handle URI activation](http://msdn.microsoft.com/library/92d06f3e-c8f3-42e0-a476-7e94fd14b2be), [Quickstart: Handling contact actions ](http://msdn.microsoft.com/library/397d8b2a-6255-4f37-8556-449a3be2ef3f), [Quickstart: Handling contact actions ](http://msdn.microsoft.com/library/61bacc8a-24c9-4b3d-b77b-e0822467700c), [Guidelines for file types and URIs](http://msdn.microsoft.com/library/a6653b8f-763f-4d67-9d12-6af73a673bc5), [Windows.UI.Core.CoreApplicationView.Activated](../windows.applicationmodel.core/coreapplicationview_activated.md), [Windows.UI.Xaml.Application.OnActivated](../windows.ui.xaml/application_onactivated.md), [URI](../windows.foundation/uri.md), [Association launching sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620490)