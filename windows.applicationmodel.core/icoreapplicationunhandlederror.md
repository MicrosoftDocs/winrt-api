---
-api-id: T:Windows.ApplicationModel.Core.ICoreApplicationUnhandledError
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ICoreApplicationUnhandledError : 
-->

# Windows.ApplicationModel.Core.ICoreApplicationUnhandledError

## -description
Adds an error handling event for global error handling from the system that app models can use.

## -remarks
The ICoreApplicationUnhandledError mechanism for error handling is primarily for C++ developers who are using Microsoft DirectX. For UWP app using C++, C#, or Visual Basic you should handle [UnhandledException](../windows.ui.xaml/application_unhandledexception.md), which is exposed by the [Application](../windows.ui.xaml/application.md) object in that app model.

Most scenarios won't use this interface for either implementation or casting. Instead, most app scenarios will use [CoreApplication.UnhandledErrorDetected](coreapplication_unhandlederrordetected.md) or similar events provided by the app models for UI frameworks.

## -examples

## -see-also
