---
-api-id: P:Windows.Gaming.Input.UINavigationController.UINavigationControllers
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Gaming.Input.UINavigationController> UINavigationControllers { get; }
-->

# Windows.Gaming.Input.UINavigationController.UINavigationControllers

## -description

The list of all connected UI navigation controllers.

## -property-value

The list of all connected UI navigation controllers.

## -remarks

**UINavigationController** objects are managed by the system, therefore you don't have to create or initialize them. Instead, you can access connected UI navigation controllers through this property. Because you might only be interested in some of the connected UI navigation controllers, we recommend that you maintain your own collection.

This list is initially empty and will not list UI navigation controllers even if they are already connected. After a short period this will return a complete list of UI navigation controllers.

## -examples

## -see-also
