---
-api-id: M:Windows.ApplicationModel.AppService.AppServiceConnection.Close
-api-type: winrt method
---

<!-- Method syntax
public void Close()
-->

# Windows.ApplicationModel.AppService.AppServiceConnection.Close

## -description
Closes the connection to the app service.

## -remarks

**C++/WinRT** : You don't *need* to call **Close** from C++/WinRT because the object will be closed and destructed naturally when all references are released. But you might choose to call **Close** if you want to stop the app service regardless of outstanding references to the app service connection. After calling **Close** in a situation like that, we recommend that you consider the object to be invalid, and not to use it further. Specifically, consider that the **AppServiceConnection** object isn't reusable nor re-openable after **Close** is called. Also see [Do I need to call IClosable::Close on runtime classes that I consume?](/windows/uwp/cpp-and-winrt-apis/faq#do-i-need-to-call-iclosableclose-on-runtime-classes-that-i-consume).

**C++/CX** : You can't call [Close](../windows.foundation/iclosable_close_811482585.md) methods through Visual C++ component extensions (C++/CX) on Windows Runtime class instances where the class implements [IClosable](../windows.foundation/iclosable.md). Instead, Visual C++ component extensions (C++/CX) code for runtime classes should call the destructor, or set the last reference to **null**.

## -examples

## -see-also
