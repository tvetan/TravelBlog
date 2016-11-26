using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "3236f92d6008d6b3")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.4.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Blog Post</summary>
	[PublishedContentModel("BlogPost")]
	public partial class BlogPost : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BlogPost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlogPost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogPost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Category
		///</summary>
		[ImplementPropertyType("category")]
		public string Category
		{
			get { return this.GetPropertyValue<string>("category"); }
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public IHtmlString Content
		{
			get { return this.GetPropertyValue<IHtmlString>("content"); }
		}

		///<summary>
		/// Main Image
		///</summary>
		[ImplementPropertyType("mainImage")]
		public string MainImage
		{
			get { return this.GetPropertyValue<string>("mainImage"); }
		}

		///<summary>
		/// Next Post
		///</summary>
		[ImplementPropertyType("nextPost")]
		public object NextPost
		{
			get { return this.GetPropertyValue("nextPost"); }
		}

		///<summary>
		/// Previous Post
		///</summary>
		[ImplementPropertyType("previousPost")]
		public object PreviousPost
		{
			get { return this.GetPropertyValue("previousPost"); }
		}

		///<summary>
		/// Show In Slider
		///</summary>
		[ImplementPropertyType("showInSlider")]
		public bool ShowInSlider
		{
			get { return this.GetPropertyValue<bool>("showInSlider"); }
		}

		///<summary>
		/// Summary
		///</summary>
		[ImplementPropertyType("summary")]
		public string Summary
		{
			get { return this.GetPropertyValue<string>("summary"); }
		}

		///<summary>
		/// Tags
		///</summary>
		[ImplementPropertyType("tags")]
		public object Tags
		{
			get { return this.GetPropertyValue("tags"); }
		}
	}

	/// <summary>Blog Post Repository</summary>
	[PublishedContentModel("BlogPostRepository")]
	public partial class BlogPostRepository : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BlogPostRepository";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlogPostRepository(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogPostRepository, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide in bottom navigation?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("Home")]
	public partial class Home : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// About Me Image
		///</summary>
		[ImplementPropertyType("aboutMeImage")]
		public string AboutMeImage
		{
			get { return this.GetPropertyValue<string>("aboutMeImage"); }
		}

		///<summary>
		/// About Me Text
		///</summary>
		[ImplementPropertyType("aboutMeText")]
		public IHtmlString AboutMeText
		{
			get { return this.GetPropertyValue<IHtmlString>("aboutMeText"); }
		}

		///<summary>
		/// About Me Title
		///</summary>
		[ImplementPropertyType("aboutMeTitle")]
		public string AboutMeTitle
		{
			get { return this.GetPropertyValue<string>("aboutMeTitle"); }
		}

		///<summary>
		/// Facebook Link
		///</summary>
		[ImplementPropertyType("facebookLink")]
		public string FacebookLink
		{
			get { return this.GetPropertyValue<string>("facebookLink"); }
		}

		///<summary>
		/// globalErrorMessage
		///</summary>
		[ImplementPropertyType("globalErrorMessage")]
		public string GlobalErrorMessage
		{
			get { return this.GetPropertyValue<string>("globalErrorMessage"); }
		}

		///<summary>
		/// Instagram Link
		///</summary>
		[ImplementPropertyType("instagramLink")]
		public string InstagramLink
		{
			get { return this.GetPropertyValue<string>("instagramLink"); }
		}

		///<summary>
		/// Pinterest Link
		///</summary>
		[ImplementPropertyType("pinterestLink")]
		public string PinterestLink
		{
			get { return this.GetPropertyValue<string>("pinterestLink"); }
		}

		///<summary>
		/// Site Description
		///</summary>
		[ImplementPropertyType("siteDescription")]
		public string SiteDescription
		{
			get { return this.GetPropertyValue<string>("siteDescription"); }
		}

		///<summary>
		/// Site Keywords
		///</summary>
		[ImplementPropertyType("siteKeywords")]
		public string SiteKeywords
		{
			get { return this.GetPropertyValue<string>("siteKeywords"); }
		}

		///<summary>
		/// Site Logo
		///</summary>
		[ImplementPropertyType("siteLogo")]
		public object SiteLogo
		{
			get { return this.GetPropertyValue("siteLogo"); }
		}

		///<summary>
		/// Site Tagline
		///</summary>
		[ImplementPropertyType("siteTagline")]
		public string SiteTagline
		{
			get { return this.GetPropertyValue<string>("siteTagline"); }
		}

		///<summary>
		/// Site Title
		///</summary>
		[ImplementPropertyType("siteTitle")]
		public string SiteTitle
		{
			get { return this.GetPropertyValue<string>("siteTitle"); }
		}

		///<summary>
		/// Twitter Link
		///</summary>
		[ImplementPropertyType("twitterLink")]
		public string TwitterLink
		{
			get { return this.GetPropertyValue<string>("twitterLink"); }
		}

		///<summary>
		/// Youtube Link
		///</summary>
		[ImplementPropertyType("youtubeLink")]
		public string YoutubeLink
		{
			get { return this.GetPropertyValue<string>("youtubeLink"); }
		}
	}

	/// <summary>Text</summary>
	[PublishedContentModel("Text")]
	public partial class Text : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Text";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Text(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Text, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public IHtmlString Content
		{
			get { return this.GetPropertyValue<IHtmlString>("content"); }
		}

		///<summary>
		/// Show in footer navigation
		///</summary>
		[ImplementPropertyType("showInFooterNavigation")]
		public bool ShowInFooterNavigation
		{
			get { return this.GetPropertyValue<bool>("showInFooterNavigation"); }
		}

		///<summary>
		/// Show in main navigation
		///</summary>
		[ImplementPropertyType("showInMainNavigation")]
		public bool ShowInMainNavigation
		{
			get { return this.GetPropertyValue<bool>("showInMainNavigation"); }
		}
	}

	/// <summary>Contact Requests Repository</summary>
	[PublishedContentModel("contactRequestsRepository")]
	public partial class ContactRequestsRepository : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contactRequestsRepository";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ContactRequestsRepository(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactRequestsRepository, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Contact Request</summary>
	[PublishedContentModel("contactRequest")]
	public partial class ContactRequest : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contactRequest";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ContactRequest(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactRequest, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Email
		///</summary>
		[ImplementPropertyType("email")]
		public object Email
		{
			get { return this.GetPropertyValue("email"); }
		}

		///<summary>
		/// Message
		///</summary>
		[ImplementPropertyType("message")]
		public string Message
		{
			get { return this.GetPropertyValue<string>("message"); }
		}

		///<summary>
		/// Subject
		///</summary>
		[ImplementPropertyType("subject")]
		public string Subject
		{
			get { return this.GetPropertyValue<string>("subject"); }
		}

		///<summary>
		/// User First Name
		///</summary>
		[ImplementPropertyType("UserFirstName")]
		public string UserFirstName
		{
			get { return this.GetPropertyValue<string>("UserFirstName"); }
		}
	}

	/// <summary>Category</summary>
	[PublishedContentModel("category")]
	public partial class Category : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "category";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Category(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Category, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Show In Main Navigation
		///</summary>
		[ImplementPropertyType("showInMainNavigation")]
		public bool ShowInMainNavigation
		{
			get { return this.GetPropertyValue<bool>("showInMainNavigation"); }
		}
	}

	/// <summary>Categories Repository</summary>
	[PublishedContentModel("categoriesRepository")]
	public partial class CategoriesRepository : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "categoriesRepository";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CategoriesRepository(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CategoriesRepository, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Search Result</summary>
	[PublishedContentModel("searchResult")]
	public partial class SearchResult : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "searchResult";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SearchResult(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SearchResult, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Sitemap</summary>
	[PublishedContentModel("sitemap")]
	public partial class Sitemap : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sitemap";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Sitemap(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Sitemap, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// HideInXmlSitemap
		///</summary>
		[ImplementPropertyType("hideInXmlSitemap")]
		public bool HideInXmlSitemap
		{
			get { return this.GetPropertyValue<bool>("hideInXmlSitemap"); }
		}
	}

	/// <summary>Newsletter</summary>
	[PublishedContentModel("newsletter")]
	public partial class Newsletter : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "newsletter";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Newsletter(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Newsletter, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// HideInXmlSitemap
		///</summary>
		[ImplementPropertyType("hideInXmlSitemap")]
		public bool HideInXmlSitemap
		{
			get { return this.GetPropertyValue<bool>("hideInXmlSitemap"); }
		}

		///<summary>
		/// Subscribers
		///</summary>
		[ImplementPropertyType("subscribers")]
		public string Subscribers
		{
			get { return this.GetPropertyValue<string>("subscribers"); }
		}

		///<summary>
		/// Successfull Subscription Message
		///</summary>
		[ImplementPropertyType("successfullSubscriptionMessage")]
		public string SuccessfullSubscriptionMessage
		{
			get { return this.GetPropertyValue<string>("successfullSubscriptionMessage"); }
		}

		///<summary>
		/// The email already exists error message
		///</summary>
		[ImplementPropertyType("theEmailAlreadyExistsErrorMessage")]
		public string TheEmailAlreadyExistsErrorMessage
		{
			get { return this.GetPropertyValue<string>("theEmailAlreadyExistsErrorMessage"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
