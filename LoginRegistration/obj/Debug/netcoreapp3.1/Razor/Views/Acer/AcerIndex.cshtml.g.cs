#pragma checksum "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "205797f6dd803328e2bad38f8f09b024f20e688a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Acer_AcerIndex), @"mvc.1.0.view", @"/Views/Acer/AcerIndex.cshtml")]
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
#line 1 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\_ViewImports.cshtml"
using LoginRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\_ViewImports.cshtml"
using LoginRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"205797f6dd803328e2bad38f8f09b024f20e688a", @"/Views/Acer/AcerIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58b8b69ac1923d039b18bb6580c27c9405e8eb6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Acer_AcerIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "acerbuy1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 4 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
  
    ViewData["Title"] = "Acer";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "205797f6dd803328e2bad38f8f09b024f20e688a4292", async() => {
                WriteLiteral("\r\n    <div>\r\n\r\n        <section class=\"middle pt-5\">\r\n            <div class=\"container-fluid pl-5\">\r\n\r\n                <!--  <div class=\"weeding weeding10\">\r\n                  <h2 style>Acer</h2>\r\n                </div> -->\r\n\r\n                <a");
                BeginWriteAttribute("href", " href=\'", 373, "\'", 411, 1);
#nullable restore
#line 20 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
WriteAttributeValue("", 380, Url.Action("swiftdes", "Acer"), 380, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <div class=\"weeding weeding10\">\r\n                        <h2>\r\n                            Swift\r\n                        </h2>\r\n                    </div>\r\n                </a>\r\n\r\n\r\n\r\n                <div class=\"row\">\r\n\r\n");
#nullable restore
#line 32 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                     foreach (var acer in ViewBag.acers)
                    {

                        if (count <= 8)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-md-3 col-sm-3 col-3\">\r\n                                <div class=\"product-top\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "205797f6dd803328e2bad38f8f09b024f20e688a6072", async() => {
                    WriteLiteral("<img");
                    BeginWriteAttribute("src", " src=\"", 1047, "\"", 1064, 1);
#nullable restore
#line 40 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
WriteAttributeValue("", 1053, acer.Photo, 1053, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                                                                                     WriteLiteral(acer.Id);

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
                WriteLiteral(@"

                                </div>

                                <div class=""product-bottom text-center"">
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star-half-o""> </i>
                                    <h3>");
#nullable restore
#line 50 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                                   Write(acer.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                    <h6>");
#nullable restore
#line 51 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                                   Write(acer.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h6>\r\n\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 56 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"


                        }
                        count++;



                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n\r\n\r\n\r\n\r\n        </section>\r\n\r\n\r\n");
#nullable restore
#line 72 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
         if (count != 1)
        {
            count = 1;
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <section class=\"middle pt-5\">\r\n            <div class=\"container-fluid pl-5\">\r\n\r\n                <a");
                BeginWriteAttribute("href", " href=\'", 2049, "\'", 2086, 1);
#nullable restore
#line 80 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
WriteAttributeValue("", 2056, Url.Action("spindes", "Acer"), 2056, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""weeding weeding17"">
                        <h2>
                            Spin
                        </h2>
                    </div>
                </a>
                <br>
                <div class=""row"">

");
#nullable restore
#line 90 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                     foreach (var acer in ViewBag.acers)
                    {


                        if (/*@acer.Id=="11"|| @acer.Id== "12" || @acer.Id == "13" || @acer.Id == "14"*/ count >= 11 && count <= 14)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-md-3 col-sm-3 col-3\">\r\n                                <div class=\"product-top\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "205797f6dd803328e2bad38f8f09b024f20e688a12420", async() => {
                    WriteLiteral("<img");
                    BeginWriteAttribute("src", " src=\"", 2832, "\"", 2849, 1);
#nullable restore
#line 99 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
WriteAttributeValue("", 2838, acer.Photo, 2838, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                                                                                     WriteLiteral(acer.Id);

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
                WriteLiteral(@"

                                </div>

                                <div class=""product-bottom text-center"">
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star-half-o""> </i>
                                    <h3>");
#nullable restore
#line 109 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                                   Write(acer.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                    <h6>");
#nullable restore
#line 110 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                                   Write(acer.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h6>\r\n\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 115 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"

                            //count++;

                        }

                        count++;

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n        </section>\r\n");
#nullable restore
#line 125 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
         if (count != 1)
        {
            count = 1;
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n        <section class=\"middle pt-5\">\r\n            <div class=\"container-fluid pl-5\">\r\n\r\n                <a");
                BeginWriteAttribute("href", " href=\'", 3864, "\'", 3903, 1);
#nullable restore
#line 135 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
WriteAttributeValue("", 3871, Url.Action("aspiredes", "Acer"), 3871, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <div class=\"weeding weeding11\">\r\n                        <h2>\r\n                            Aspire\r\n                        </h2>\r\n                    </div>\r\n                </a>\r\n\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 144 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                     foreach (var acer in ViewBag.acers)
                    {


                        if (/*@acer.Id == "15" || @acer.Id == "16" || @acer.Id == "17" || @acer.Id == "18"*/count >= 15 && count <= 18)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-md-3 col-sm-3 col-3\">\r\n                                <div class=\"product-top\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "205797f6dd803328e2bad38f8f09b024f20e688a18799", async() => {
                    WriteLiteral("<img");
                    BeginWriteAttribute("src", " src=\"", 4632, "\"", 4649, 1);
#nullable restore
#line 153 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
WriteAttributeValue("", 4638, acer.Photo, 4638, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 153 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                                                                                     WriteLiteral(acer.Id);

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
                WriteLiteral(@"

                                </div>

                                <div class=""product-bottom text-center"">
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star-half-o""> </i>
                                    <h3>");
#nullable restore
#line 163 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                                   Write(acer.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                    <h6>");
#nullable restore
#line 164 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                                   Write(acer.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h6>\r\n\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 169 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"

                            //count++;
                        }

                        count++;

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n        </section>\r\n\r\n\r\n");
#nullable restore
#line 180 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
         if (count != 1)
        {
            count = 1;
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <section class=\"middle pt-5\">\r\n            <div class=\"container-fluid pl-5\">\r\n\r\n                <a");
                BeginWriteAttribute("href", " href=\'", 5660, "\'", 5698, 1);
#nullable restore
#line 187 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
WriteAttributeValue("", 5667, Url.Action("nitrodes", "Acer"), 5667, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <div class=\"weeding weeding12\">\r\n                        <h2>\r\n                            Nitro\r\n                        </h2>\r\n                    </div>\r\n                </a>\r\n\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 196 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                     foreach (var acer in ViewBag.acers)
                    {


                        if (/*@acer.Id == "19" || @acer.Id == "20" || @acer.Id == "21" || @acer.Id == "22"*/count >= 19 && count <= 22)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-md-3 col-sm-3 col-3\">\r\n                                <div class=\"product-top\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "205797f6dd803328e2bad38f8f09b024f20e688a25172", async() => {
                    WriteLiteral("<img");
                    BeginWriteAttribute("src", " src=\"", 6426, "\"", 6443, 1);
#nullable restore
#line 205 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
WriteAttributeValue("", 6432, acer.Photo, 6432, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 205 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                                                                                     WriteLiteral(acer.Id);

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
                WriteLiteral(@"

                                </div>

                                <div class=""product-bottom text-center"">
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star-half-o""> </i>
                                    <h3>");
#nullable restore
#line 215 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                                   Write(acer.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                    <h6>");
#nullable restore
#line 216 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                                   Write(acer.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h6>\r\n\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 221 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"

                            //count++;
                        }

                        count++;

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n        </section>\r\n\r\n");
#nullable restore
#line 231 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
         if (count != 1)
        {
            count = 1;
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <section class=\"middle pt-5\">\r\n            <div class=\"container-fluid pl-5\">\r\n\r\n                <a");
                BeginWriteAttribute("href", " href=\'", 7452, "\'", 7495, 1);
#nullable restore
#line 238 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
WriteAttributeValue("", 7459, Url.Action("chromebookdes", "Acer"), 7459, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <div class=\"weeding weeding13\">\r\n                        <h2>\r\n                            Chromebook\r\n                        </h2>\r\n                    </div>\r\n                </a>\r\n\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 247 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                     foreach (var acer in ViewBag.acers)
                    {


                        if (/*@acer.Id == "23" || @acer.Id == "24" || @acer.Id == "25" || @acer.Id == "26" || @acer.Id == "27" || @acer.Id == "28" || @acer.Id == "29" || @acer.Id == "30"*/count >= 23 && count <= 57)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-md-3 col-sm-3 col-3\">\r\n                                <div class=\"product-top\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "205797f6dd803328e2bad38f8f09b024f20e688a31631", async() => {
                    WriteLiteral("<img");
                    BeginWriteAttribute("src", " src=\"", 8308, "\"", 8325, 1);
#nullable restore
#line 256 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
WriteAttributeValue("", 8314, acer.Photo, 8314, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 256 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                                                                                     WriteLiteral(acer.Id);

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
                WriteLiteral(@"

                                </div>

                                <div class=""product-bottom text-center"">
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star""> </i>
                                    <i class=""fa fa-star-half-o""> </i>
                                    <h3>");
#nullable restore
#line 266 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                                   Write(acer.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                    <h6>");
#nullable restore
#line 267 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"
                                   Write(acer.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h6>\r\n\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 272 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Acer\AcerIndex.cshtml"

                            //count++;
                        }

                        count++;

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n        </section>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
