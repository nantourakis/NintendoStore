using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {

        //inherit from tag helper to make this a tag helper

        public string Address { get; set; }

        public string LinkText { get; set; }

        // overrride built in Process to use TagHelper
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Address);
            output.Content.SetContent(LinkText);
        }
    }
}
