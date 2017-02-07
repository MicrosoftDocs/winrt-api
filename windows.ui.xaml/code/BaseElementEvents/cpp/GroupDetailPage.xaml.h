//
// GroupDetailPage.xaml.h
// Declaration of the GroupDetailPage class
//

#pragma once

#include "Common\LayoutAwarePage.h" // Required by generated header
#include "GroupDetailPage.g.h"

namespace BaseElementEvents
{
	/// <summary>
	/// A page that displays an overview of a single group, including a preview of the items
	/// within the group.
	/// </summary>
	public ref class GroupDetailPage sealed
	{
	public:
		GroupDetailPage();

	protected:
		virtual void LoadState(Platform::Object^ navigationParameter,
			Windows::Foundation::Collections::IMap<Platform::String^, Platform::Object^>^ pageState) override;

	private:
		void ItemView_ItemClick(Platform::Object^ sender, Windows::UI::Xaml::Controls::ItemClickEventArgs^ e);
	};
}
