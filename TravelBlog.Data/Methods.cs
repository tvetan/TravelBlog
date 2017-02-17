using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace TravelBlog.Data
{
    public static class Methods
    {
        public static IPublishedContent GetContentByDocumentAlias(IPublishedContent homePage, string docTypeAlias)
        {
            return homePage.Descendant(docTypeAlias);
        }

        public static UmbracoHelper SiteUmbracoHelper()
        {
            return new UmbracoHelper(UmbracoContext.Current);
        }

        public static string GetImage(int mediaId)
        {
            var media = Methods.SiteUmbracoHelper().TypedMedia(mediaId);
            if (media != null)
            {
                return media.GetPropertyValue<string>("umbracoFile");
            }

            return null;
        }

        public static string GetContent(int contentId)
        {
            var content = SiteUmbracoHelper().Content(contentId);
            if (content != null)
            {
                return content.Url;
            }

            return null;
        }

        public static string TruncateHtml(this string html)
        {
            return TruncateHtml(html, int.MaxValue);
        }

        /// <summary>
        /// Truncates a string containing HTML to a number of text characters, keeping whole words.
        /// The result contains HTML and any tags left open are closed.</summary>
        /// <param name="maxCharacters">Int MaxCharacters</param>
        public static string TruncateHtml(this string html, int maxCharacters)
        {
            if (string.IsNullOrEmpty(html))
            {
                return html;
            }

            // find the spot to truncate
            // count the text characters and ignore tags
            var textCount = 0;
            var charCount = 0;
            var ignore = false;
            foreach (char c in html)
            {
                charCount++;
                if (c == '<')
                {
                    ignore = true;
                }
                else if (!ignore)
                {
                    textCount++;
                }

                ignore &= c != '>';

                // stop once we hit the limit
                if (textCount >= maxCharacters)
                {
                    break;
                }
            }

            // Truncate the html and keep whole words only
            var trunc = new StringBuilder(html.TruncateWords(charCount));

            // keep track of open tags and close any tags left open
            var tags = new Stack<string>();
            var matches = Regex.Matches(trunc.ToString(),
                @"<((?<tag>[^\s/>]+)|/(?<closeTag>[^\s>]+)).*?(?<selfClose>/)?\s*>",
                RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline);

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    var tag = match.Groups["tag"].Value;
                    var closeTag = match.Groups["closeTag"].Value;

                    // push to stack if open tag and ignore it if it is self-closing, i.e. <br />
                    if (!string.IsNullOrEmpty(tag) && string.IsNullOrEmpty(match.Groups["selfClose"].Value))
                    {
                        tags.Push(tag);
                    }

                    // pop from stack if close tag
                    else if (!string.IsNullOrEmpty(closeTag))
                    {
                        // pop the tag to close it.. find the matching opening tag
                        // ignore any unclosed tags
                        while (tags.Pop() != closeTag && tags.Count > 0)
                        { }
                    }
                }
            }

            // pop the rest off the stack to close remainder of tags
            while (tags.Count > 0)
            {
                trunc.Append("</");
                trunc.Append(tags.Pop());
                trunc.Append('>');
            }

            return trunc.ToString();
        }

        /// <summary>
        /// Truncates text to a number of characters
        /// </summary>
        /// <param name="text">Int maxCharacters</param>
        public static string Truncate(this string text, int maxCharacters)
        {
            return Truncate(text, maxCharacters, null);
        }

        /// <summary>
        /// Truncates text to a number of characters
        /// </summary>
        /// <param name="text">Int maxCharacters</param>
        /// <param name="maxCharacters">Max characters</param>
        /// <param name="prefix">String prefix</param>
        public static string Truncate(this string text, int maxCharacters, string prefix)
        {
            if (string.IsNullOrEmpty(text) || maxCharacters <= 0 || text.Length <= maxCharacters)
            {
                return text + prefix;
            }
            else
            {
                return text.Substring(0, maxCharacters) + prefix;
            }
        }

        /// <summary>
        /// Truncates text and discars any partial words left at the end
        /// </summary>
        /// <param name="maxCharacters">Int maxCharacters</param>
        public static string TruncateWords(this string text, int maxCharacters)
        {
            if (string.IsNullOrEmpty(text) || maxCharacters <= 0 || text.Length <= maxCharacters)
            {
                return text;
            }

            // truncate the text, then remove the partial word at the end
            return Regex.Replace(text.Truncate(maxCharacters), @"\s+[^\s]+$", string.Empty, RegexOptions.IgnoreCase | RegexOptions.Compiled);
        }

        public static List<string> ExtractFromHtml(string text)
        {
            var words = new List<string>();

            var firstChar = text.IndexOf('>');
            var secondChar = text.IndexOf('<');

            // we begin from second occurrence of '<'
            secondChar = text.IndexOf('<', secondChar + 1);

            while (secondChar != -1)
            {
                if (firstChar + 1 == secondChar)
                { /* do nothing */}
                else if (firstChar == text.Length - 1)
                {
                    break;
                }
                else
                {
                    var word = text.Substring(firstChar + 1, (secondChar - 1) - (firstChar));

                    if (word != "\n" && word != "\r\n" && !string.IsNullOrEmpty(word))
                    {
                        words.Add(word);
                    }
                }

                firstChar = text.IndexOf('>', firstChar + 1);
                secondChar = text.IndexOf('<', secondChar + 1);
            }

            return words;
        }

        public static string ExtractFromHtmlAsOneText(string text)
        {
            var alltext = new StringBuilder();

            var firstChar = text.IndexOf('>');
            var secondChar = text.IndexOf('<');

            // we begin from second occurrence of '<'
            secondChar = text.IndexOf('<', secondChar + 1);

            while (secondChar != -1)
            {
                if (firstChar + 1 == secondChar)
                { /* do nothing */}
                else if (firstChar == text.Length - 1)
                {
                    break;
                }
                else
                {
                    var word = text.Substring(firstChar + 1, (secondChar - 1) - (firstChar));

                    if (word != "\n" && word != "\r\n" && !string.IsNullOrEmpty(word))
                    {
                        alltext.Append(word);
                    }
                }

                firstChar = text.IndexOf('>', firstChar + 1);
                secondChar = text.IndexOf('<', secondChar + 1);
            }

            return alltext.ToString();
        }
    }
}
