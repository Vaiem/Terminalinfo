#pragma checksum "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d24579500b84a940320ea316c4bf42e48a80fe5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Terminal), @"mvc.1.0.view", @"/Views/Home/Terminal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Terminal.cshtml", typeof(AspNetCore.Views_Home_Terminal))]
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
#line 1 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\_ViewImports.cshtml"
using TerminalInfo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d24579500b84a940320ea316c4bf42e48a80fe5", @"/Views/Home/Terminal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa7b69589dd448d0b21971ab038824ee5a3d2aeb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Terminal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewUserTerminal>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Terminal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
  
    ViewData["Title"] = "Terminal";

#line default
#line hidden
            BeginContext(69, 634, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class="".col-xs-13 .col-md-9"" style=""background-color:#222; border-radius: 25px;"">
            <div >
                <a href=""#"">About</a>
                <a href=""#"">Services</a>
                <a href=""#"">Clients</a>
                <a href=""#"">Contact</a>
            </div>
        </div>
            <div class=""col-md-2""  style=""margin-top:5px;"">
                <div class=""dropdown"">
                    <button onclick=""myFunction()"" class=""dropbtn"">???????????????? ??????????????</button>
                    <div id=""myDropdown"" class=""dropdown-content"">
");
            EndContext();
#line 20 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                         foreach (var item in Model.ViewCommands)
                        {


#line default
#line hidden
            BeginContext(799, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(827, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b116dd128564c1fa9870cfa8650cdc0", async() => {
                BeginContext(877, 9, false);
#line 23 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                                                                        Write(item.name);

#line default
#line hidden
                EndContext();
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
#line 23 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                                                       WriteLiteral(item.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(890, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 24 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"

                        }

#line default
#line hidden
            BeginContext(921, 149, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-2\" style=\"margin-left:10px;margin-top:5px;\">\r\n");
            EndContext();
#line 30 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                 if (Model.InfoParams != null)
                {

#line default
#line hidden
            BeginContext(1137, 42, true);
            WriteLiteral("                    <p>???? ?????????????? ?????????????? ");
            EndContext();
            BeginContext(1180, 21, false);
#line 32 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                                     Write(Model.InfoParams.name);

#line default
#line hidden
            EndContext();
            BeginContext(1201, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 33 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                }

#line default
#line hidden
            BeginContext(1226, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1242, 1738, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ba27ebab6ad47abb6f5e78a402ce2c4", async() => {
                BeginContext(1279, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1301, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dffb80ea4944a72ae26fc79afb255d4", async() => {
                    BeginContext(1329, 11, true);
                    WriteLiteral("ID??????????????????");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 35 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdTerminal);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1348, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1370, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "241f548cf89948f68cc5545a0b038d40", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 36 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdTerminal);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1409, 36, true);
                WriteLiteral("<br />\r\n                    <br />\r\n");
                EndContext();
#line 38 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                     if (Model.InfoParams != null)
                    {


                        

#line default
#line hidden
#line 42 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                         if (Model.InfoParams.parameter_name1 != null)
                        {


#line default
#line hidden
                BeginContext(1625, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1653, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c25790429e08499cb5f43811d479769a", async() => {
                    BeginContext(1690, 32, false);
#line 45 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                                                           Write(Model.InfoParams.parameter_name1);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 45 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.command.parameter1);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1730, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1760, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "87f5e58234574e0389ab0db73df54249", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 46 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.command.parameter1);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1798, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 47 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                        }

#line default
#line hidden
#line 48 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                         if (Model.InfoParams.parameter_name2 != null)
                        {


#line default
#line hidden
                BeginContext(1928, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1956, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39ad4692b8214d00b2f0149bd7222ec3", async() => {
                    BeginContext(1993, 32, false);
#line 51 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                                                           Write(Model.InfoParams.parameter_name2);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 51 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.command.parameter2);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2033, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2063, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "38842815f5814709813092d43fec80da", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 52 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.command.parameter2);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2101, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 53 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                        }

#line default
#line hidden
#line 54 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                         if (Model.InfoParams.parameter_name3 != null)
                        {


#line default
#line hidden
                BeginContext(2231, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(2259, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19bfb71fedfd4f1ca28a99da1c364399", async() => {
                    BeginContext(2296, 32, false);
#line 57 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                                                           Write(Model.InfoParams.parameter_name3);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 57 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.command.parameter3);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2336, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2366, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67513e2fd2b64e16bc103fd1767b4e06", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 58 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.command.parameter3);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2404, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 59 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                        }

#line default
#line hidden
#line 60 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                         if (Model.InfoParams.parameter_name4 != null)
                        {


#line default
#line hidden
                BeginContext(2534, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(2562, 77, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d36a6ea4f4e34a788c5c6fbac0263a75", async() => {
                    BeginContext(2599, 32, false);
#line 63 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                                                           Write(Model.InfoParams.parameter_name4);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 63 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.command.parameter4);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2639, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2669, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c9bee13867434efdb075d4c10f98accd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 64 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.command.parameter4);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2707, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 65 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                        }

#line default
#line hidden
                BeginContext(2736, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(2760, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ac3b58a40bf485c8523d821b90fd73b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 66 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.command.command_id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 66 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                                                                     WriteLiteral(Model.InfoParams.id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2841, 91, true);
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-danger\">??????????????????</button>\r\n");
                EndContext();
#line 68 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                    }

#line default
#line hidden
                BeginContext(2955, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2980, 497, true);
            WriteLiteral(@"
            </div>

        </div>
    </div>

<div>

    

   


        <table class=""table"">
            <thead>
                <tr>

                    <th>???</th>
                    <th>???????? ?? ??????????</th>
                    <th>??????????????</th>
                    <th>???????????????? 1</th>
                    <th>???????????????? 2</th>
                    <th>???????????????? 3</th>
                    <th>????????????</th>
                </tr>
            </thead>
            <tbody>

");
            EndContext();
#line 98 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                 if (Model.HistoryCommand.Count() != 0)
                {


                    

#line default
#line hidden
#line 102 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                     foreach (var items in Model.HistoryCommand)
                    {


#line default
#line hidden
            BeginContext(3648, 64, true);
            WriteLiteral("                        <tr>\r\n\r\n                            <td>");
            EndContext();
            BeginContext(3713, 9, false);
#line 107 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                           Write(items.Key);

#line default
#line hidden
            EndContext();
            BeginContext(3722, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3762, 29, false);
#line 108 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                           Write(items.Value.item.time_created);

#line default
#line hidden
            EndContext();
            BeginContext(3791, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3831, 49, false);
#line 109 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                           Write(Model.GetNameCommand(items.Value.item.command_id));

#line default
#line hidden
            EndContext();
            BeginContext(3880, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3920, 27, false);
#line 110 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                           Write(items.Value.item.parameter1);

#line default
#line hidden
            EndContext();
            BeginContext(3947, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3987, 27, false);
#line 111 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                           Write(items.Value.item.parameter2);

#line default
#line hidden
            EndContext();
            BeginContext(4014, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4054, 27, false);
#line 112 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                           Write(items.Value.item.parameter3);

#line default
#line hidden
            EndContext();
            BeginContext(4081, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4121, 27, false);
#line 113 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                           Write(items.Value.item.state_name);

#line default
#line hidden
            EndContext();
            BeginContext(4148, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 115 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"

                    }

#line default
#line hidden
#line 116 "C:\Users\User\source\repos\TerminalInfo\TerminalInfo\Views\Home\Terminal.cshtml"
                     

                }

#line default
#line hidden
            BeginContext(4232, 87, true);
            WriteLiteral("                </tbody>\r\n        </table>\r\n    \r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n<h2>Terminal</h2>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewUserTerminal> Html { get; private set; }
    }
}
#pragma warning restore 1591
