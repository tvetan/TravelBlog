//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.4.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "666254c15eeb17c4")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.3")]

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
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}

		///<summary>
		/// Introduction
		///</summary>
		[ImplementPropertyType("introduction")]
		public string Introduction
		{
			get { return this.GetPropertyValue<string>("introduction"); }
		}

		///<summary>
		/// Pesho
		///</summary>
		[ImplementPropertyType("pesho")]
		public string Pesho
		{
			get { return this.GetPropertyValue<string>("pesho"); }
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
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
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
		/// Site Logo
		///</summary>
		[ImplementPropertyType("siteLogo")]
		public object SiteLogo
		{
			get { return this.GetPropertyValue("siteLogo"); }
		}

		///<summary>
		/// Site Title
		///</summary>
		[ImplementPropertyType("siteTitle")]
		public string SiteTitle
		{
			get { return this.GetPropertyValue<string>("siteTitle"); }
		}
	}

	/// <summary>Landing Page</summary>
	[PublishedContentModel("LandingPage")]
	public partial class LandingPage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "LandingPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public LandingPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LandingPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
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

	/// <summary>Text Page</summary>
	[PublishedContentModel("TextPage")]
	public partial class TextPage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "TextPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TextPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TextPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}
	}

	/// <summary>Articulate</summary>
	[PublishedContentModel("Articulate")]
	public partial class Articulate : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Articulate";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Articulate(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Articulate, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Blog Banner: Optional blog banner
		///</summary>
		[ImplementPropertyType("blogBanner")]
		public Umbraco.Web.Models.ImageCropDataSet BlogBanner
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("blogBanner"); }
		}

		///<summary>
		/// Blog Description
		///</summary>
		[ImplementPropertyType("blogDescription")]
		public string BlogDescription
		{
			get { return this.GetPropertyValue<string>("blogDescription"); }
		}

		///<summary>
		/// Blog Logo: Optional logo
		///</summary>
		[ImplementPropertyType("blogLogo")]
		public Umbraco.Web.Models.ImageCropDataSet BlogLogo
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("blogLogo"); }
		}

		///<summary>
		/// Blog Title
		///</summary>
		[ImplementPropertyType("blogTitle")]
		public string BlogTitle
		{
			get { return this.GetPropertyValue<string>("blogTitle"); }
		}

		///<summary>
		/// Categories Page Name: The page title for the categories listing
		///</summary>
		[ImplementPropertyType("categoriesPageName")]
		public string CategoriesPageName
		{
			get { return this.GetPropertyValue<string>("categoriesPageName"); }
		}

		///<summary>
		/// Categories Url Name
		///</summary>
		[ImplementPropertyType("categoriesUrlName")]
		public string CategoriesUrlName
		{
			get { return this.GetPropertyValue<string>("categoriesUrlName"); }
		}

		///<summary>
		/// Custom RSS Feed Url: Optional custom rss feed URL (i.e. if you use feedburner, etc...)
		///</summary>
		[ImplementPropertyType("customRssFeedUrl")]
		public string CustomRssFeedUrl
		{
			get { return this.GetPropertyValue<string>("customRssFeedUrl"); }
		}

		///<summary>
		/// Disqus Shortname
		///</summary>
		[ImplementPropertyType("disqusShortname")]
		public string DisqusShortname
		{
			get { return this.GetPropertyValue<string>("disqusShortname"); }
		}

		///<summary>
		/// Extract First Image to Property: When Windows Live Writer (or compatible WebBlog API tool) is used to create blog posts, with this option enabled it will set the first image found in the blog post to the blog's image property if one is found.
		///</summary>
		[ImplementPropertyType("extractFirstImage")]
		public bool ExtractFirstImage
		{
			get { return this.GetPropertyValue<bool>("extractFirstImage"); }
		}

		///<summary>
		/// Google Analytics Id: Your Google Analytics Id (i.e. UA-123456789 )
		///</summary>
		[ImplementPropertyType("googleAnalyticsId")]
		public string GoogleAnalyticsId
		{
			get { return this.GetPropertyValue<string>("googleAnalyticsId"); }
		}

		///<summary>
		/// Google Analytics Name: The site name associated with your Google Analytics (i.e. mysite.com )
		///</summary>
		[ImplementPropertyType("googleAnalyticsName")]
		public string GoogleAnalyticsName
		{
			get { return this.GetPropertyValue<string>("googleAnalyticsName"); }
		}

		///<summary>
		/// PageSize
		///</summary>
		[ImplementPropertyType("pageSize")]
		public int PageSize
		{
			get { return this.GetPropertyValue<int>("pageSize"); }
		}

		///<summary>
		/// Search Page Name: The page title for the search results
		///</summary>
		[ImplementPropertyType("searchPageName")]
		public string SearchPageName
		{
			get { return this.GetPropertyValue<string>("searchPageName"); }
		}

		///<summary>
		/// Search Url Name
		///</summary>
		[ImplementPropertyType("searchUrlName")]
		public string SearchUrlName
		{
			get { return this.GetPropertyValue<string>("searchUrlName"); }
		}

		///<summary>
		/// Tags Page Name: The page title for the tags listing
		///</summary>
		[ImplementPropertyType("tagsPageName")]
		public string TagsPageName
		{
			get { return this.GetPropertyValue<string>("tagsPageName"); }
		}

		///<summary>
		/// Tags Url Name
		///</summary>
		[ImplementPropertyType("tagsUrlName")]
		public string TagsUrlName
		{
			get { return this.GetPropertyValue<string>("tagsUrlName"); }
		}

		///<summary>
		/// Theme
		///</summary>
		[ImplementPropertyType("theme")]
		public object Theme
		{
			get { return this.GetPropertyValue("theme"); }
		}
	}

	/// <summary>Articulate Archive</summary>
	[PublishedContentModel("ArticulateArchive")]
	public partial class ArticulateArchive : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "ArticulateArchive";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ArticulateArchive(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticulateArchive, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Umbraco Url Name: The Umbraco Url Name for this node, this will be the prefix URL for each blog post
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return this.GetPropertyValue<string>("umbracoUrlName"); }
		}
	}

	/// <summary>Articulate Author</summary>
	[PublishedContentModel("ArticulateAuthor")]
	public partial class ArticulateAuthor : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "ArticulateAuthor";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ArticulateAuthor(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticulateAuthor, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Author Bio: Description of the author
		///</summary>
		[ImplementPropertyType("authorBio")]
		public string AuthorBio
		{
			get { return this.GetPropertyValue<string>("authorBio"); }
		}

		///<summary>
		/// Author Image
		///</summary>
		[ImplementPropertyType("authorImage")]
		public Umbraco.Web.Models.ImageCropDataSet AuthorImage
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("authorImage"); }
		}

		///<summary>
		/// Author Url: A url to link to the author's website
		///</summary>
		[ImplementPropertyType("authorUrl")]
		public string AuthorUrl
		{
			get { return this.GetPropertyValue<string>("authorUrl"); }
		}
	}

	/// <summary>Articulate Authors</summary>
	[PublishedContentModel("ArticulateAuthors")]
	public partial class ArticulateAuthors : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "ArticulateAuthors";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ArticulateAuthors(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticulateAuthors, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Articulate Post</summary>
	[PublishedContentModel("ArticulatePost")]
	public partial class ArticulatePost : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "ArticulatePost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ArticulatePost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticulatePost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Author
		///</summary>
		[ImplementPropertyType("author")]
		public string Author
		{
			get { return this.GetPropertyValue<string>("author"); }
		}

		///<summary>
		/// Categories
		///</summary>
		[ImplementPropertyType("categories")]
		public object Categories
		{
			get { return this.GetPropertyValue("categories"); }
		}

		///<summary>
		/// Enable Comments
		///</summary>
		[ImplementPropertyType("enableComments")]
		public bool EnableComments
		{
			get { return this.GetPropertyValue<bool>("enableComments"); }
		}

		///<summary>
		/// Excerpt
		///</summary>
		[ImplementPropertyType("excerpt")]
		public string Excerpt
		{
			get { return this.GetPropertyValue<string>("excerpt"); }
		}

		///<summary>
		/// Import Id: Used during a blogml import process to ensure that re-importing does not create duplicate posts.
		///</summary>
		[ImplementPropertyType("importId")]
		public string ImportId
		{
			get { return this.GetPropertyValue<string>("importId"); }
		}

		///<summary>
		/// Post Image: An optional image for your blog post
		///</summary>
		[ImplementPropertyType("postImage")]
		public Umbraco.Web.Models.ImageCropDataSet PostImage
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("postImage"); }
		}

		///<summary>
		/// Published Date: This is the date that the document will be shown as published on your website
		///</summary>
		[ImplementPropertyType("publishedDate")]
		public DateTime PublishedDate
		{
			get { return this.GetPropertyValue<DateTime>("publishedDate"); }
		}

		///<summary>
		/// Tags
		///</summary>
		[ImplementPropertyType("tags")]
		public object Tags
		{
			get { return this.GetPropertyValue("tags"); }
		}

		///<summary>
		/// umbracoUrlAlias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return this.GetPropertyValue<string>("umbracoUrlAlias"); }
		}

		///<summary>
		/// Slug: If left blank then umbraco will auto-generate the URL name based on the node name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return this.GetPropertyValue<string>("umbracoUrlName"); }
		}
	}

	/// <summary>Articulate Markdown</summary>
	[PublishedContentModel("ArticulateMarkdown")]
	public partial class ArticulateMarkdown : ArticulatePost
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "ArticulateMarkdown";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ArticulateMarkdown(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticulateMarkdown, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Markdown
		///</summary>
		[ImplementPropertyType("markdown")]
		public object Markdown
		{
			get { return this.GetPropertyValue("markdown"); }
		}
	}

	/// <summary>Articulate Rich Text</summary>
	[PublishedContentModel("ArticulateRichText")]
	public partial class ArticulateRichText : ArticulatePost
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "ArticulateRichText";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ArticulateRichText(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticulateRichText, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Rich Text
		///</summary>
		[ImplementPropertyType("richText")]
		public IHtmlString RichText
		{
			get { return this.GetPropertyValue<IHtmlString>("richText"); }
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
