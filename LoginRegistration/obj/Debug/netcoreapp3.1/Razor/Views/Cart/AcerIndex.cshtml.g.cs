#pragma checksum "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Cart\AcerIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e75855e5ebfe4fce123f904f1e57d51b0761593"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_AcerIndex), @"mvc.1.0.view", @"/Views/Cart/AcerIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e75855e5ebfe4fce123f904f1e57d51b0761593", @"/Views/Cart/AcerIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58b8b69ac1923d039b18bb6580c27c9405e8eb6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_AcerIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "acerremove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "acerindex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e75855e5ebfe4fce123f904f1e57d51b07615936012", async() => {
                WriteLiteral(@"

    <style>
        h1 {
            font-size: 24px;
            font-family: 'Baloo Chettan', cursive;
        }
        body {
            color: #000;
            overflow-x: hidden;
            height: 100%;
            background-color: #fff;
            background-repeat: no-repeat
        }

        .plus-minus {
            position: relative
        }

        .plus {
            position: absolute;
            top: -4px;
            left: 2px;
            cursor: pointer
        }

        .minus {
            position: absolute;
            top: 8px;
            left: 5px;
            cursor: pointer
        }

        .vsm-text:hover {
            color: #FF5252
        }

        .book,
        .book-img {
            width: 180px;
            height: 180px;
            border-radius: 5px
        }

        .book {
            margin: 20px 15px 5px 15px
        }

        .border-top {
            border-top: 1px solid #EEEEEE !important;
     ");
                WriteLiteral(@"       margin-top: 20px;
            padding-top: 15px
        }

        .card {
            margin: 40px 0px;
            padding: 40px 50px;
            border-radius: 20px;
            border: none;
            box-shadow: 1px 5px 10px 1px rgba(0, 0, 0, 0.2)
        }

        input,
        textarea {
            background-color: #F3E5F5;
            padding: 8px 15px 8px 15px;
            width: 100%;
            border-radius: 5px !important;
            box-sizing: border-box;
            border: 1px solid #F3E5F5;
            font-size: 15px !important;
            color: #000 !important;
            font-weight: 300
        }

            input:focus,
            textarea:focus {
                -moz-box-shadow: none !important;
                -webkit-box-shadow: none !important;
                box-shadow: none !important;
                border: 1px solid #9FA8DA;
                outline-width: 0;
                font-weight: 400
            }

        button:f");
                WriteLiteral(@"ocus {
            -moz-box-shadow: none !important;
            -webkit-box-shadow: none !important;
            box-shadow: none !important;
            outline-width: 0
        }

        .pay {
            width: 80px;
            height: 40px;
            border-radius: 5px;
            border: 1px solid #673AB7;
            margin: 10px 20px 10px 0px;
            cursor: pointer;
            box-shadow: 1px 5px 10px 1px rgba(0, 0, 0, 0.2)
        }

        .gray {
            -webkit-filter: grayscale(100%);
            -moz-filter: grayscale(100%);
            -o-filter: grayscale(100%);
            -ms-filter: grayscale(100%);
            filter: grayscale(100%);
            color: #E0E0E0
        }

            .gray .pay {
                box-shadow: none
            }

        #tax {
            border-top: 1px lightgray solid;
            margin-top: 10px;
            padding-top: 10px
        }

        .btn-blue {
            border: none;
            borde");
                WriteLiteral(@"r-radius: 10px;
            background-color: #673AB7;
            color: #fff;
            padding: 8px 15px;
            margin: 20px 0px;
            cursor: pointer
        }

            .btn-blue:hover {
                background-color: #311B92;
                color: #fff
            }

        #checkout {
            float: left
        }

        #check-amt {
            float: right
        }
    </style>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e75855e5ebfe4fce123f904f1e57d51b076159310699", async() => {
                WriteLiteral(@"


    <div class=""container px-4 py-5 mx-auto"">
        <div class=""row d-flex justify-content-center"">
            <div class=""col-5"">
                <h1>Shopping Bag</h1>
            </div>
            <div class=""col-7"">
                <div class=""row text-right"">
                    <div class=""col-4"">
                        <h6 class=""mt-2"">Action</h6>
                    </div>
                  
                    <div class=""col-4"">
                        <h6 class=""mt-2"">Quantity</h6>
                    </div>
                    <div class=""col-4"">
                        <h6 class=""mt-2"">Price</h6>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 174 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Cart\AcerIndex.cshtml"
         foreach (var item in ViewBag.cart)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row d-flex justify-content-center border-top\">\r\n                <div class=\"col-5\">\r\n                    <div class=\"row d-flex\">\r\n                        <div class=\"book\"> <img");
                BeginWriteAttribute("src", " src=\"", 4626, "\"", 4648, 1);
#nullable restore
#line 179 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Cart\AcerIndex.cshtml"
WriteAttributeValue("", 4632, item.Acer.Photo, 4632, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"book-img\"> </div>\r\n                        <div class=\"my-auto flex-column d-flex pad-left\">\r\n                            <h6 class=\"mob-text\">");
#nullable restore
#line 181 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Cart\AcerIndex.cshtml"
                                            Write(item.Acer.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                            <p class=\"mob-text\">");
#nullable restore
#line 182 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Cart\AcerIndex.cshtml"
                                           Write(item.Acer.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" Infotek Bso</p>
                        </div>
                      
                    </div>
                </div>
                <div class=""my-auto col-7"">
                    <div class=""row text-right"">
                        <div class=""col-4"">
                            <div class=""close"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e75855e5ebfe4fce123f904f1e57d51b076159313770", async() => {
                    WriteLiteral("&times;");
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
#line 190 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Cart\AcerIndex.cshtml"
                                                                                                  WriteLiteral(item.Acer.Id);

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
                WriteLiteral(@"</div>
                            
                        </div>
                        <div class=""col-4"">
                            <div class=""row d-flex justify-content-end px-3"">
                                <p class=""mb-0"" id=""cnt1"">

                                    ");
#nullable restore
#line 197 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Cart\AcerIndex.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </p>
                                <div class=""d-flex flex-column plus-minus""> <span class=""vsm-text plus"">+</span> <span class=""vsm-text minus"">-</span> </div>
                            </div>
                        </div>
                        <div class=""col-4"">
                            <script>
                    var a = ");
#nullable restore
#line 204 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Cart\AcerIndex.cshtml"
                        Write(item.Acer.Price * item.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n                    document.write(b);\r\n                            </script>\r\n\r\n\r\n                            <h6 class=\"mob-text\">Rs.");
#nullable restore
#line 209 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Cart\AcerIndex.cshtml"
                                               Write(item.Acer.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>");
#nullable restore
#line 213 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Cart\AcerIndex.cshtml"
                  }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <div class=""row justify-content-center"">
            <div class=""col-lg-12"">
                <div class=""card"">
                    <div class=""row"">
                        <div class=""col-lg-3 radio-group"">
                            <div class=""row d-flex px-3 radio"">
                                <img class=""pay"" src=""https://i.imgur.com/WIAP9Ku.jpg"">
                                <p class=""my-auto"">Credit Card</p>
                            </div>
                            <div class=""row d-flex px-3 radio gray"">
                                <img class=""pay"" src=""https://i.imgur.com/OdxcctP.jpg"">
                                <p class=""my-auto"">Debit Card</p>
                            </div>
                            <div class=""row d-flex px-3 radio gray mb-3"">
                                <img class=""pay"" src=""https://i.imgur.com/cMk1MtK.jpg"">
                                <p class=""my-auto"">PayPal</p>
                            </div>
                 ");
                WriteLiteral(@"       </div>
                        <div class=""col-lg-5"">
                            <div class=""row px-2"">
                                <div class=""form-group col-md-6""> <label class=""form-control-label"">Name on Card</label> <input type=""text"" id=""cname"" name=""cname"" placeholder=""Johnny Doe""> </div>
                                <div class=""form-group col-md-6""> <label class=""form-control-label"">Card Number</label> <input type=""text"" id=""cnum"" name=""cnum"" placeholder=""1111 2222 3333 4444""> </div>
                            </div>
                            <div class=""row px-2"">
                                <div class=""form-group col-md-6""> <label class=""form-control-label"">Expiration Date</label> <input type=""text"" id=""exp"" name=""exp"" placeholder=""MM/YYYY""> </div>
                                <div class=""form-group col-md-6""> <label class=""form-control-label"">CVV</label> <input type=""text"" id=""cvv"" name=""cvv"" placeholder=""***""> </div>
                            </div>
           ");
                WriteLiteral(@"             </div>
                        <div class=""col-lg-4 mt-2"">
                            <div class=""row d-flex justify-content-between px-4"">
                                <p class=""mb-1 text-left"">Subtotal</p>
                                <h6 class=""mb-1 text-right"">
                                    Rs.");
#nullable restore
#line 247 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Cart\AcerIndex.cshtml"
                                  Write(ViewBag.total);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </h6>
                            </div>
                            <div class=""row d-flex justify-content-between px-4"">
                                <p class=""mb-1 text-left"">Shipping</p>
                                <h6 class=""mb-1 text-right"">Rs200</h6>
                            </div>
                            <div class=""row d-flex justify-content-between px-4"" id=""tax"">
                                <p class=""mb-1 text-left"">Total (tax included)</p>
                                <h6 class=""mb-1 text-right"">
                                    Rs.
                                    <script>
    document.write(eval(""");
#nullable restore
#line 259 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Cart\AcerIndex.cshtml"
                    Write(ViewBag.total);

#line default
#line hidden
#nullable disable
                WriteLiteral("+200\"));\r\n                                    </script>\r\n\r\n                                </h6>\r\n                            </div> \r\n                                <span>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e75855e5ebfe4fce123f904f1e57d51b076159322430", async() => {
                    WriteLiteral(" <span id=\"checkout\">Checkout");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</span> <span id=\"check-amt\">\r\n                                    Rs.\r\n                                    <script>\r\n                                    document.write(eval(\"");
#nullable restore
#line 267 "C:\Users\admin\Downloads\Ecommerce app V5\Ecommerce App\Ecommerce App\LoginRegistration\Views\Cart\AcerIndex.cshtml"
                                                    Write(ViewBag.total);

#line default
#line hidden
#nullable disable
                WriteLiteral("+200\"));\r\n                                    </script>\r\n                                </span> </span>\r\n                           \r\n                        </div>\r\n\r\n                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e75855e5ebfe4fce123f904f1e57d51b076159324668", async() => {
                    WriteLiteral(" Continue Shopping");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
    </div>
    <script>
        $(document).ready(function () {
            $(""#checkout"").click(function () {
                alert(""Thank you!!!Your order will been delievered within 24 hrs"");
            });

            $('.radio-group .radio').click(function () {
                $('.radio').addClass('gray');
                $(this).removeClass('gray');
            });

            $('.plus-minus .plus').click(function () {
                var count = $(this).parent().prev().text();
                $(this).parent().prev().html(Number(count) + 1);
               var b=eval(""count*a"");
            });

            $('.plus-minus .minus').click(function () {
                var count = $(this).parent().prev().text();
                $(this).parent().prev().html(Number(count) - 1);
            });

        });
    </script>
");
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
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
