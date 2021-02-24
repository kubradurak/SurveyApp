#pragma checksum "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f789f1a0e0dbab927fd794cf1a6ab29c922fe81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Poll_ApprovedPolls), @"mvc.1.0.view", @"/Views/Poll/ApprovedPolls.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\_ViewImports.cshtml"
using Survey.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\_ViewImports.cshtml"
using Survey.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f789f1a0e0dbab927fd794cf1a6ab29c922fe81", @"/Views/Poll/ApprovedPolls.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd7a8927f2c2cecfd481717bf41a1442974e2c0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Poll_ApprovedPolls : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Survey.Entities.Poll>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
  
    ViewData["Title"] = "ApprovedPolls";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Onaylanan Anketler</h4>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
           Write(Html.DisplayNameFor(model => model.CheckinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Kalan gün sayısı\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
           Write(Html.DisplayNameFor(model => model.RequiredVote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
         foreach (var item in Model)
        {
            var days = (int)item.HowManyDays();

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
             if (item.CheckinDate.CompareTo(DateTime.Today) < 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CheckinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 47 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
                         if (days <= 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"text-danger\"> ");
#nullable restore
#line 49 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
                                               Write(Math.Abs(days));

#line default
#line hidden
#nullable disable
            WriteLiteral(" gün önce süresi dolmuş.</p>\r\n");
#nullable restore
#line 50 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
                        }
                        else if (days == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"text-danger\"> Son gün</p>\r\n");
#nullable restore
#line 54 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"

                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
                       Write(days);

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
                                 

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 63 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RequiredVote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f789f1a0e0dbab927fd794cf1a6ab29c922fe818718", async() => {
                WriteLiteral("Tekrar Set Et");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 70 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Poll\ApprovedPolls.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Survey.Entities.Poll>> Html { get; private set; }
    }
}
#pragma warning restore 1591
