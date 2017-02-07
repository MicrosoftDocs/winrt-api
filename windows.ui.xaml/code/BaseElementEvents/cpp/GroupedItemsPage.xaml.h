//
// GroupedItemsPage.xaml.h
// Declaration of the GroupedItemsPage class
//

#pragma once

#include "Common\LayoutAwarePage.h" // Required by generated header
#include "GroupedItemsPage.g.h"

namespace BaseElementEvents
{
	/// <summary>
	/// A page that displays a grouped collection of items.
	/// </summary>
	public ref class GroupedItemsPage sealed
	{
	public:
		GroupedItemsPage();

	protected:
		virtual void LoadState(Platform::Object^ navigationParameter,
			Windows::Foundation::Collections::IMap<Platform::String^, Platform::Object^>^ pageState) override;

	private:
		void Header_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
		void ItemView_ItemClick(Platform::Object^ sender, Windows::UI::Xaml::Controls::ItemClickEventArgs^ e);
	};
}
