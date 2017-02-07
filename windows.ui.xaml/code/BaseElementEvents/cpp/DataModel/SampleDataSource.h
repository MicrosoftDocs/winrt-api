//
// SampleDataSource.h
// Declaration of the SampleDataSource, SampleDataGroup, SampleDataItem, and SampleDataCommon classes
//

#pragma once

#include <collection.h>
#include "Common\BindableBase.h"

// The data model defined by this file serves as a representative example of a strongly-typed
// model that supports notification when members are added, removed, or modified.  The property
// names chosen coincide with data bindings in the standard item templates.
//
// Applications may use this model as a starting point and build on it, or discard it entirely and
// replace it with something appropriate to their needs.

namespace BaseElementEvents
{
	namespace Data
	{
		ref class SampleDataGroup; // Resolve circular relationship between SampleDataItem and SampleDataGroup

		/// <summary>
		/// Base class for <see cref="SampleDataItem"/> and <see cref="SampleDataGroup"/> that
		/// defines properties common to both.
		/// </summary>
		[Windows::Foundation::Metadata::WebHostHidden]
		[Windows::UI::Xaml::Data::Bindable]
		public ref class SampleDataCommon : BaseElementEvents::Common::BindableBase
		{
		internal:
			SampleDataCommon(Platform::String^ uniqueId, Platform::String^ title, Platform::String^ subtitle, Platform::String^ imagePath,
				Platform::String^ description);

		public:
			void SetImage(Platform::String^ path);

			property Platform::String^ UniqueId { Platform::String^ get(); void set(Platform::String^ value); }
			property Platform::String^ Title { Platform::String^ get(); void set(Platform::String^ value); }
			property Platform::String^ Subtitle { Platform::String^ get(); void set(Platform::String^ value); }
			property Windows::UI::Xaml::Media::ImageSource^ Image { Windows::UI::Xaml::Media::ImageSource^ get(); void set(Windows::UI::Xaml::Media::ImageSource^ value); }
			property Platform::String^ Description { Platform::String^ get(); void set(Platform::String^ value); }

		private:
			Platform::String^ _uniqueId;
			Platform::String^ _title;
			Platform::String^ _subtitle;
			Windows::UI::Xaml::Media::ImageSource^ _image;
			Platform::String^ _imagePath;
			Platform::String^ _description;
		};

		/// <summary>
		/// Generic item data model.
		/// </summary>
		[Windows::UI::Xaml::Data::Bindable]
		public ref class SampleDataItem sealed : SampleDataCommon
		{
		public:
			SampleDataItem(Platform::String^ uniqueId, Platform::String^ title, Platform::String^ subtitle, Platform::String^ imagePath,
				Platform::String^ description, Platform::String^ content, SampleDataGroup^ group);

			property Platform::String^ Content { Platform::String^ get(); void set(Platform::String^ value); }
			property SampleDataGroup^ Group { SampleDataGroup^ get(); void set(SampleDataGroup^ value); }

		private:
			Platform::WeakReference _group; // Weak reference used to break reference counting cycle
			Platform::String^ _content;
		};

		/// <summary>
		/// Generic group data model.
		/// </summary>
		[Windows::UI::Xaml::Data::Bindable]
		public ref class SampleDataGroup sealed : public SampleDataCommon
		{
		public:
			SampleDataGroup(Platform::String^ uniqueId, Platform::String^ title, Platform::String^ subtitle, Platform::String^ imagePath,
				Platform::String^ description);
			property Windows::Foundation::Collections::IObservableVector<SampleDataItem^>^ Items
			{
				Windows::Foundation::Collections::IObservableVector<SampleDataItem^>^ get();
			}
			property Windows::Foundation::Collections::IVector<SampleDataItem^>^ TopItems
			{
				Windows::Foundation::Collections::IVector<SampleDataItem^>^ get();
			}

		private:
			Platform::Collections::Vector<SampleDataItem^>^ _items;
		};

		/// <summary>
		/// Creates a collection of groups and items with hard-coded content.
		/// </summary>
		[Windows::UI::Xaml::Data::Bindable]
		public ref class SampleDataSource sealed
		{
		public:			
			SampleDataSource();
			property Windows::Foundation::Collections::IObservableVector<SampleDataGroup^>^ AllGroups
			{
				Windows::Foundation::Collections::IObservableVector<SampleDataGroup^>^ get();
			}
			static Windows::Foundation::Collections::IIterable<SampleDataGroup^>^ GetGroups(Platform::String^ uniqueId);
			static SampleDataGroup^ GetGroup(Platform::String^ uniqueId);
			static SampleDataItem^ GetItem(Platform::String^ uniqueId);

		private: 
			Platform::Collections::Vector<SampleDataGroup^>^ _allGroups;
		};
	}
}
