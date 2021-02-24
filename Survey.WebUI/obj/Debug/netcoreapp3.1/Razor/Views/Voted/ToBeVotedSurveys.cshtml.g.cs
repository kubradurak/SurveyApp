#pragma checksum "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4295a809d7dd5004f899703e340bf9cfe4c3bc09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Voted_ToBeVotedSurveys), @"mvc.1.0.view", @"/Views/Voted/ToBeVotedSurveys.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4295a809d7dd5004f899703e340bf9cfe4c3bc09", @"/Views/Voted/ToBeVotedSurveys.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd7a8927f2c2cecfd481717bf41a1442974e2c0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Voted_ToBeVotedSurveys : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Survey.Entities.Poll>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "YesNoAnswers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
  
    ViewData["Title"] = "ToBeVotedSurveys";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ToBeVotedSurveys</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
           Write(Html.DisplayNameFor(model => model.CheckinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Kalan gün sayısı\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
           Write(Html.DisplayNameFor(model => model.RequiredVote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
         foreach (var item in Model)
        {
            var days = (int)item.HowManyDays();

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
             if (item.CheckinDate.CompareTo(DateTime.Today) >= 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
           Write(Html.DisplayFor(modelItem => item.CheckinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 49 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
                 if (days <= 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"text-danger\"> ");
#nullable restore
#line 51 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
                                       Write(Math.Abs(days));

#line default
#line hidden
#nullable disable
            WriteLiteral(" gün önce süresi dolmuş.</p>\r\n");
#nullable restore
#line 52 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
                }
                else if (days == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"text-danger\"> Son gün</p>\r\n");
#nullable restore
#line 56 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"

                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
               Write(days);

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
                         

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
           Write(Html.DisplayFor(modelItem => item.RequiredVote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 68 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
                 if (days <= 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"text-danger\">Süresi dolduğu için oy veremezsiniz!</p>\r\n");
#nullable restore
#line 71 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4295a809d7dd5004f899703e340bf9cfe4c3bc099411", async() => {
                WriteLiteral("Oy Ver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
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
            WriteLiteral("\r\n");
#nullable restore
#line 75 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 80 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "D:\Kubra\Final2\Survey\Survey.WebUI\Views\Voted\ToBeVotedSurveys.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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