﻿using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;
using UmbracoNineDemoSite.Core.Features.Shared.Components.Hero;
using UmbracoNineDemoSite.Core.Features.Shared.Constants;
using UmbracoNineDemoSite.Core.Features.Shared.Content;

namespace UmbracoNineDemoSite.Core.Features.Home
{
	public class HomeViewModel : SitePageBase, IHeadingPage
	{
		public HomeViewModel(IPublishedContent content) : base(content) { }

		public string Heading => this.Content.Value<string>(PropertyAlias.Heading);
		public string Preamble => this.Content.Value<string>(PropertyAlias.Preamble);
		public string BackgroundImage => this.Content.Value<string>(PropertyAlias.BackgroundImage);
		public string CallToActionUrl => this.Content.Value<IPublishedContent>(PropertyAlias.CallToActionUrl)?.Url();
		public string CallToActionLabel => this.Content.Value<string>(PropertyAlias.CallToActionLabel);
		public BlockListModel Blocks => this.Content.Value<BlockListModel>(PropertyAlias.Blocks);
		public HeroViewModel Hero => new()
		{
			Heading = this.Heading,
			Preamble = this.Preamble,
			BackgroundImageUrl = this.BackgroundImage,
			CallToActionUrl = this.CallToActionUrl,
			CallToActionLabel = this.CallToActionLabel
		};
	}
}
