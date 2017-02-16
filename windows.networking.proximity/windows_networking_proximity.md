---
-api-id: N:Windows.Networking.Proximity
-api-type: winrt namespace
---

# Windows.Networking.Proximity

## -description
Contains classes that support connections between devices that are within close range.

## -remarks
You can use proximity to connect computers by using a simple tap gesture. If two computers come within 3 centimeters to 4 centimeters of each other, or are tapped together, the operating system of each computer detects the other computer. You can then connect the two computers to share content or publish and subscribe to messages. Proximity also supports discovery of peer devices via Wi-Fi Direct.



> [!IMPORTANT]
> The proximity APIs do not provide authentication, encryption, or message integrity. Do not use proximity to exchange user sensitive information such as passwords, financial data, text messages, email, photographs, or government id numbers.

## -examples
This example shows how you can use the [ProximityDevice](proximitydevice.md) class to determine when a device enters and leaves proximity.



<<<<<<< HEAD
[!code-csharp[ArriveDepart](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetArriveDepart)]

[!code-js[ArriveDepart](../windows.networking.proximity/code/ProximityReferenceSample/js/default.js#SnippetArriveDepart)]

[!code-vb[ArriveDepart](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetArriveDepart)]
=======
[!code-csharp[ArriveDepart](../windows.networking.proximity/code/ProximityReferenceSample/csharp/MainPage.xaml.cs#SnippetArriveDepart)]

[!code-js[ArriveDepart](../windows.networking.proximity/code/ProximityReferenceSample/js/default.js#SnippetArriveDepart)]

[!code-vb[ArriveDepart](../windows.networking.proximity/code/ProximityReferenceSample/vbnet/MainPage.xaml.vb#SnippetArriveDepart)]
>>>>>>> master

## -see-also
[Proximity and Tapping (JavaScript)](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [Proximity and Tapping (C#/VB/C++)](http://msdn.microsoft.com/library/f25bb1df-1cfd-45cd-8c67-04eec73ebfbd), [Proximity sample](http://go.microsoft.com/fwlink/p/?linkid=245082)

## -capabilities
proximity, ID_CAP_PROXIMITY [Windows Phone]
 ID_CAP_PROXIMITY [Windows Phone]
