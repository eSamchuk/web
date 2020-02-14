using GymTrainingDiary.Model;
using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace GymTrainingDiary.HtmlHelpers
{
    public static class HtmlHelperExtensions
    {

        public static IHtmlString ImageUpload(this HtmlHelper<User> htmlHelper, User viewModel)
        {
            var outerDiv = new TagBuilder("div");
            outerDiv.AddCssClass("pull-left upload-img-wrapper");
            var label = new TagBuilder("label");
            label.AddCssClass("upload-img");
            label.MergeAttribute("data-content", "Change photo");

            var image = new TagBuilder("img");
            image.AddCssClass("img-responsive");

            image.MergeAttribute("src", "../Images/no-user-image.png");
            image.MergeAttribute("width", "250");
            image.MergeAttribute("height", "250");

            var textbox = InputExtensions.TextBoxFor(htmlHelper, m => ImageName, new { type = "file", style = "display:none" });

            StringBuilder htmlBuilder = new StringBuilder();
            htmlBuilder.Append(label.ToString(TagRenderMode.StartTag));
            htmlBuilder.Append(image.ToString(TagRenderMode.Normal));
            htmlBuilder.Append(label.ToString(TagRenderMode.EndTag));
           // htmlBuilder.Append(textbox.ToHtmlString());
            outerDiv.InnerHtml = htmlBuilder.ToString();
            var html = outerDiv.ToString(TagRenderMode.Normal);

            return MvcHtmlString.Create(html);
        }


    }
}