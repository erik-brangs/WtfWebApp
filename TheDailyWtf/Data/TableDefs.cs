//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System;
using global::System.ComponentModel;
using global::System.Data;
using global::System.Data.SqlClient;
using global::System.Collections.Generic;
using global::System.Linq;
using global::System.Xml.Linq;
using global::Inedo.Data;

#pragma warning disable 1591
namespace TheDailyWtf.Data
{
	public static class TableDefs
	{
		[Obsolete("Articles is obsolete. Use Articles_Extended instead.", true)]
		public static class Articles
		{
			public const string Article_Id = "Article_Id";
			public const string Article_Slug = "Article_Slug";
			public const string Published_Date = "Published_Date";
			public const string PublishedStatus_Name = "PublishedStatus_Name";
			public const string Author_Slug = "Author_Slug";
			public const string Title_Text = "Title_Text";
			public const string Series_Slug = "Series_Slug";
			public const string Body_Html = "Body_Html";
			public const string Discourse_Topic_Id = "Discourse_Topic_Id";
			public const string Discourse_Topic_Opened = "Discourse_Topic_Opened";
		}
		public static class Articles_Extended
		{
			public const string Article_Id = "Article_Id";
			public const string Article_Slug = "Article_Slug";
			public const string Published_Date = "Published_Date";
			public const string PublishedStatus_Name = "PublishedStatus_Name";
			public const string Author_Slug = "Author_Slug";
			public const string Title_Text = "Title_Text";
			public const string Series_Slug = "Series_Slug";
			public const string Body_Html = "Body_Html";
			public const string Discourse_Topic_Id = "Discourse_Topic_Id";
			public const string Discourse_Topic_Opened = "Discourse_Topic_Opened";
			public const string Author_Display_Name = "Author_Display_Name";
			public const string Author_Admin_Indicator = "Author_Admin_Indicator";
			public const string Author_Bio_Html = "Author_Bio_Html";
			public const string Author_ShortBio_Text = "Author_ShortBio_Text";
			public const string Author_Image_Url = "Author_Image_Url";
			public const string Series_Title_Text = "Series_Title_Text";
			public const string Series_Description_Text = "Series_Description_Text";
		}
		public static class Authors
		{
			public const string Author_Slug = "Author_Slug";
			public const string Display_Name = "Display_Name";
			public const string Password_Bytes = "Password_Bytes";
			public const string Salt_Bytes = "Salt_Bytes";
			public const string Admin_Indicator = "Admin_Indicator";
			public const string Bio_Html = "Bio_Html";
			public const string ShortBio_Text = "ShortBio_Text";
			public const string Image_Url = "Image_Url";
		}
		public static class FeaturedComments
		{
			public const string Article_Id = "Article_Id";
			public const string Discourse_Post_Id = "Discourse_Post_Id";
		}
		public static class Series
		{
			public const string Series_Slug = "Series_Slug";
			public const string Title_Text = "Title_Text";
			public const string Description_Text = "Description_Text";
		}
	}
}
#pragma warning restore 1591
