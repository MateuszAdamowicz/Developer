using System;
using System.Web;

namespace Developer.Helpers
{
    public class OwnHelpers
    {
        public static IHtmlString PropertyNotNull(string name, string property)
        {
            string htmlString;
            if (!String.IsNullOrEmpty(property))
            {
                htmlString =
                    String.Format(
                        "<div class='list-group-item-danger' style='margin-bottom: 3px; padding-left: 15px'><div class='row' style='font-size: smaller'><div class='col-md-5'>{0}:</div><div class='col-md-7'>{1}</div></div></div>",
                        name, property);
            }
            else
            {
                htmlString = "";
            }
            
            return new HtmlString(htmlString);
        }
    }
}