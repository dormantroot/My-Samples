using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace MyTestingGroundMVC.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public static class HtmlHelperExtension
    {
        #region ---------------------- PRIVATE PROPERTIES ----------------------

        #endregion ------------------- PRIVATE PROPERTIES ----------------------

        #region ---------------------- PUBLIC PROPERTIES ----------------------

        #endregion ------------------- PUBLIC PROPERTIES ----------------------

        #region ------------------------ CONSTRUCTORS -------------------------       
        #endregion --------------------- CONSTRUCTORS -------------------------

        #region ----------------------- PRIVATE METHODS ------------------------

        #endregion--------------------- PRIVATE METHODS ------------------------

        #region ----------------------- PUBLIC METHODS ------------------------
        public static string PageHeader(this HtmlHelper helper, string title)
        {
            return PageHeader(helper, title, null, null);
        }

        public static string PageHeader(this HtmlHelper helper, string title, string rssUrl, string atomUrl)
        {
            StringBuilder headerHtml = new StringBuilder();

            headerHtml.Append("<div class=\"pageHeader\">");

            headerHtml.Append("<div class=\"pageTitle\">");

            if (!string.IsNullOrEmpty(title))
            {
                headerHtml.Append("<h2>{0}</h2>".FormatWith(helper.Encode(title)));
            }

            headerHtml.Append("</div>");
            //headerHtml.Append(SyndicationIcons(helper, rssUrl, atomUrl));

            headerHtml.Append("</div>");

            return headerHtml.ToString();
        }

        #endregion--------------------- PUBLIC METHODS ------------------------
    }
}