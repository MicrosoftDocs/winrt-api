---
-api-id: T:Windows.UI.Xaml.Application
-api-type: winrt class
---

<!-- Class syntax.
public class Application : Windows.UI.Xaml.IApplication, Windows.UI.Xaml.IApplication2, Windows.UI.Xaml.IApplicationOverrides, Windows.UI.Xaml.IApplicationOverrides2
-->

# Windows.UI.Xaml.Application

## -description
Encapsulates the app and its available services.

## -xaml-syntax
```xaml
<Application />
 
```


## -remarks
The [Application](application.md) class encapsulates an app and provides the following services: 
+ app entry point, particularly for various activation contracts
+ app lifetime management
+ app-scoped resources
+ unhandled exception detection


The [Application](application.md) object is typically provided in the initial XAML for App.xaml. The default project templates in Visual Studio generate an `App` class that derives from [Application](application.md) and provides an entry point where you can add initialization code.

The `App` class associates itself with the corresponding XAML by calling the generated `InitializeComponent` method in its constructor. You can add additional initialization code to the `App` constructor, but you will typically only add code to associate handlers to [Application](application.md) events. For other initialization code, you should override one or more initialization methods such as [OnLaunched](application_onlaunched_859642554.md).

The system handles app lifetime by suspending your app whenever the user switches to another app or to the desktop, and resuming your app whenever the user switches back to it. However, the system can also terminate your app while it is suspended in order to free up resources. You should handle the [Suspending](application_suspending.md) event to save your app state in case of termination, and override the [OnLaunched](application_onlaunched_859642554.md) method to restore your app state. You should handle the [Resuming](application_resuming.md) event only if you need to refresh any displayed content that might have changed while the app is suspended. You do not need to restore other app state when the app resumes.

Because of its position in the application model, codegen, and activation sequence, [Application](application.md) has some restrictions on its XAML usage:


+ Other than the xmlns declarations and **x:Class**, no other attribute can appear on the `Application` root tag.
+ Don't attempt to change **x:Class** values that come from the project template App.xaml pages, there are additional dependencies on using that naming scheme that exist in the build actions.
+ Don't wire the [Application](application.md) event handlers in XAML. All event wiring should be done in code (usually in the constructor). Also, you generally use method overrides rather than event syntax for an event (for example, you override [OnActivated](application_onactivated_603737819.md) to respond to that phase of the application life cycle.)
+ The only expected properties on an [Application](application.md) instance in XAML is the set of elements to populate the [Application.Resources](application_resources.md) property, using a XAML property element usage. For more info, see [Resources](application_resources.md).
To provide general error handling for any exceptions that your app code doesn't catch, handle the [UnhandledException](application_unhandledexception.md) event.

> [!NOTE]
> The [Application](application.md) main file must be named `App.xaml`.

## -examples

## -see-also
[Handle app activation](http://msdn.microsoft.com/library/da9a6a43-f09d-4512-a2ab-9b6132431007), [Handle app suspend](http://msdn.microsoft.com/library/f84f1512-24b9-45ec-bf23-a09e0ac985b0), [Handle app resume](http://msdn.microsoft.com/library/daccc556-b814-4600-a10a-90b82664ea15), [Window](window.md)