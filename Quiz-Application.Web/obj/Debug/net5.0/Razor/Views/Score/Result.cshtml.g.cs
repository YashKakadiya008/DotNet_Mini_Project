#pragma checksum "C:\Users\ventura\source\repos\Quiz-Application\Quiz-Application.Web\Views\Score\Result.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5d2e08c42231d62922a3618ec5fa7aeaf34688b2cf86521ef27912a2b9d6a017"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Score_Result), @"mvc.1.0.view", @"/Views/Score/Result.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ventura\source\repos\Quiz-Application\Quiz-Application.Web\Views\_ViewImports.cshtml"
using Quiz_Application.Web

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\ventura\source\repos\Quiz-Application\Quiz-Application.Web\Views\_ViewImports.cshtml"
using Quiz_Application.Web.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5d2e08c42231d62922a3618ec5fa7aeaf34688b2cf86521ef27912a2b9d6a017", @"/Views/Score/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8083106680980333bfda92b8d98d100075cc817fc074d109c65a353a3c50351a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Score_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Quiz_Application.Services.Entities.Root>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("hdnCandidateID"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ventura\source\repos\Quiz-Application\Quiz-Application.Web\Views\Score\Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<div class=\"w3-container w3-content\" style=\"max-width:1200px;margin-top:80px\">\r\n    <h2>Quiz Attempt</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d2e08c42231d62922a3618ec5fa7aeaf34688b2cf86521ef27912a2b9d6a0174305", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.
#nullable restore
#line 8 "C:\Users\ventura\source\repos\Quiz-Application\Quiz-Application.Web\Views\Score\Result.cshtml"
                    objCandidate.Candidate_ID

#line default
#line hidden
#nullable disable
            );
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <p>
        <table class=""w3-table-all w3-centered w3-card-4 w3-white w3-round"">
            <tr class=""w3-blue"">
                <th>Sl. No.</th>
                <th style=""display:none;"">SessionID</th>
                <th style=""display:none;"">ExamID</th>
                <th>Quiz</th>
                <th>Score</th>
                <th>Date</th>
                <th style=""display:none;"">Status</th>
                <th>Action</th>
            </tr>
");
#nullable restore
#line 21 "C:\Users\ventura\source\repos\Quiz-Application\Quiz-Application.Web\Views\Score\Result.cshtml"
             if (Model.objAttempt.Count > 0)
            {
                foreach (var item in Model.objAttempt)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <tr>\r\n                        <td>");
            Write(
#nullable restore
#line 26 "C:\Users\ventura\source\repos\Quiz-Application\Quiz-Application.Web\Views\Score\Result.cshtml"
                             item.Sl_No

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td style=\"display:none;\">");
            Write(
#nullable restore
#line 27 "C:\Users\ventura\source\repos\Quiz-Application\Quiz-Application.Web\Views\Score\Result.cshtml"
                                                   item.SessionID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td style=\"display:none;\">");
            Write(
#nullable restore
#line 28 "C:\Users\ventura\source\repos\Quiz-Application\Quiz-Application.Web\Views\Score\Result.cshtml"
                                                   item.ExamID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>");
            Write(
#nullable restore
#line 29 "C:\Users\ventura\source\repos\Quiz-Application\Quiz-Application.Web\Views\Score\Result.cshtml"
                             item.Exam

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>");
            Write(
#nullable restore
#line 30 "C:\Users\ventura\source\repos\Quiz-Application\Quiz-Application.Web\Views\Score\Result.cshtml"
                             item.Score

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>");
            Write(
#nullable restore
#line 31 "C:\Users\ventura\source\repos\Quiz-Application\Quiz-Application.Web\Views\Score\Result.cshtml"
                             item.Date

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td style=\"display:none;\">");
            Write(
#nullable restore
#line 32 "C:\Users\ventura\source\repos\Quiz-Application\Quiz-Application.Web\Views\Score\Result.cshtml"
                                                   item.Status

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td><button class=\"w3-button w3-tiny w3-light-green btnScore\">Get Report</button></td>\r\n                    </tr>\r\n");
#nullable restore
#line 35 "C:\Users\ventura\source\repos\Quiz-Application\Quiz-Application.Web\Views\Score\Result.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <tr><td colspan=\"7\">No Records Found</td></tr>\r\n");
#nullable restore
#line 40 "C:\Users\ventura\source\repos\Quiz-Application\Quiz-Application.Web\Views\Score\Result.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"        </table>
    </p>
    <div id=""eqScore"" class=""w3-card-4 w3-round w3-white"">
        <header class=""w3-container w3-light-grey"">
            <h3>Loading...</h3>
        </header>
        <div class=""w3-container"">
            <p>Loading...</p>
            <hr>
            <img src=""https://icon-library.com/images/win-icon/win-icon-4.jpg"" alt=""Avatar"" class=""w3-left w3-circle w3-margin-right"" style=""width:60px"">
            <h5>Loading...</h5>
            <br />
            <span class=""w3-right w3-opacity""></span><br />
            <hr />
        </div>
        <button id=""btnReport"" class=""w3-button w3-block w3-blue""><i class=""fa fa-download""></i> Download Report</button>
    </div>
</div>
<br />
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Quiz_Application.Services.Entities.Root> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
