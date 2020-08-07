using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Factory.Models
{
  public static class CustomHelper
  {
    public static IHtmlHelper YesNo(this IHtmlHelper htmlHelper, bool yesNo)
    {
      var text = yesNo ? "Yes" : "No";
      return new MvcHtmlString(text);
    }
  }
}