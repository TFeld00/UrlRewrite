using Hi.UrlRewrite.Templates.Action.Base;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;

namespace Hi.UrlRewrite.Templates.Inbound
{
	public partial class SimpleRedirectItem : CustomItem
    {

        public static readonly string TemplateId = "{E30B15B9-34CD-419C-8671-60FEAAAD5A46}";
		
        #region Inherited Base Templates

        private readonly BaseUrlRewriteItem _BaseUrlRewriteItem;
        public BaseUrlRewriteItem BaseUrlRewriteItem { get { return _BaseUrlRewriteItem; } }

        private readonly BaseEnabledItem _BaseEnabledItem;
        public BaseEnabledItem BaseEnabledItem { get { return _BaseEnabledItem; } }

        private readonly BaseRedirectTypeItem _BaseRedirectTypeItem;
        public BaseRedirectTypeItem BaseRedirectTypeItem { get { return _BaseRedirectTypeItem; } }

        #endregion

        #region Boilerplate CustomItem Code

        public SimpleRedirectItem(Item innerItem)
            : base(innerItem)
        {
            _BaseUrlRewriteItem = new BaseUrlRewriteItem(innerItem);
            _BaseEnabledItem = new BaseEnabledItem(innerItem);
            _BaseRedirectTypeItem = new BaseRedirectTypeItem(innerItem);
        }

        public static implicit operator SimpleRedirectItem(Item innerItem)
        {
            return innerItem != null ? new SimpleRedirectItem(innerItem) : null;
        }

        public static implicit operator Item(SimpleRedirectItem customItem)
        {
            return customItem != null ? customItem.InnerItem : null;
        }

        #endregion //Boilerplate CustomItem Code


        #region Field Instance Methods


        public TextField Path
        {
            get
            {
                return new TextField(InnerItem.Fields["Path"]);
            }
        }


        public LinkField Target
        {
            get
            {
                return new LinkField(InnerItem.Fields["Target"]);
            }
        }

        public int SortOrder
        {
            get
            {
                return this.InnerItem.Appearance.Sortorder;
            }
        }

        #endregion //Field Instance Methods
    }
}