#pragma checksum "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0b8a81e6b955bef8cec9e95d3aaf2e14e47cbe2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicles_Index), @"mvc.1.0.view", @"/Views/Vehicles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehicles/Index.cshtml", typeof(AspNetCore.Views_Vehicles_Index))]
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
#line 1 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\_ViewImports.cshtml"
using mobile.mk;

#line default
#line hidden
#line 2 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\_ViewImports.cshtml"
using mobile.mk.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0b8a81e6b955bef8cec9e95d3aaf2e14e47cbe2", @"/Views/Vehicles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62481d1cd29f2d062415c40e6ed7dbd2a48329fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<mobile.WebModels.VehicleViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Vehicles"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
   
    if (ViewBag.RenderActions == null)
    {
        ViewBag.RenderActions = false;
    }

    bool test = User.IsInRole("customer");
    bool test2 = User.Identity.IsAuthenticated;

#line default
#line hidden
            BeginContext(254, 235, true);
            WriteLiteral("\r\n<br />\r\n    <div class=\"container jumbotron\">\r\n        <div class=\"row p-2\">\r\n            <div class=\"col-4\">\r\n                <h1>Shop new & used cars, sell your car & more at mobile.mk</h1>\r\n                <br />\r\n                ");
            EndContext();
            BeginContext(489, 843, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b8a81e6b955bef8cec9e95d3aaf2e14e47cbe25695", async() => {
                BeginContext(527, 798, true);
                WriteLiteral(@"

                    <br />
                    <div class=""form-check-inline"">
                        <h4>Make</h4>   <input class=""form-control-sm p-1"" id=""searchBy"" name=""searchBy"" type=""radio"" value=""Make"" checked=""checked"">
                    </div>
                    <div class=""form-check-inline"">
                        <h4>Model</h4>   <input class=""form-control-sm p-1"" id=""searchBy"" name=""searchBy"" type=""radio"" value=""Model"">
                    </div>
                    
                    <input class=""form-control"" id=""search"" name=""search"" type=""text"" value="""" placeholder=""Please Insert Car Make or Model"">
                    <br />
                    <button type=""submit"" value=""Search"" class=""btn btn-warning""><h5>Search</h5></button>

                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1332, 340, true);
            WriteLiteral(@"
            </div>
            <div class=""col-5"">
                <img src=""https://image.cnbcfm.com/api/v1/image/105451982-1536942698662gettyimages-503375934.jpeg?v=1563289233&w=678&h=381"" alt=""cars"" />
            </div>
        </div>
    </div>

    <br />

    <div class=""container jumbotron"">
        <div class=""row"">
");
            EndContext();
#line 45 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
             foreach (var item in Model)
            {
                var images = item.Images.ToList();
                string firstImage;
                if (images.FirstOrDefault() == null)
                {
                    firstImage = "";
                }
                else
                {
                    firstImage = images.FirstOrDefault().Image;
                }
                string imgSrc = $"data:image/jpeg;base64, {firstImage}";


#line default
#line hidden
            BeginContext(2148, 180, true);
            WriteLiteral("                <table class=\"table table-hover p-2\">\r\n                    <tbody>\r\n                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2328, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b8a81e6b955bef8cec9e95d3aaf2e14e47cbe29498", async() => {
                BeginContext(2376, 4, true);
                WriteLiteral("<img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2380, "\"", 2393, 1);
#line 63 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
WriteAttributeValue("", 2386, imgSrc, 2386, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2394, 28, true);
                WriteLiteral(" width=\"250\" height=\"200\" />");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                                          WriteLiteral(item.Id);

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
            BeginContext(2426, 109, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                    ");
            EndContext();
            BeginContext(2535, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b8a81e6b955bef8cec9e95d3aaf2e14e47cbe212382", async() => {
                BeginContext(2583, 4, true);
                WriteLiteral("<h5>");
                EndContext();
                BeginContext(2588, 9, false);
#line 67 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                                                                   Write(item.Make);

#line default
#line hidden
                EndContext();
                BeginContext(2597, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2599, 10, false);
#line 67 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                                                                              Write(item.Model);

#line default
#line hidden
                EndContext();
                BeginContext(2609, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2611, 18, false);
#line 67 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                                                                                          Write(item.CubicCapacity);

#line default
#line hidden
                EndContext();
                BeginContext(2629, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2631, 13, false);
#line 67 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                                                                                                              Write(item.Fueltype);

#line default
#line hidden
                EndContext();
                BeginContext(2644, 5, true);
                WriteLiteral("</h5>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                                              WriteLiteral(item.Id);

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
            BeginContext(2653, 41, true);
            WriteLiteral("\r\n                                    <b>");
            EndContext();
            BeginContext(2695, 9, false);
#line 68 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                  Write(item.Year);

#line default
#line hidden
            EndContext();
            BeginContext(2704, 4, true);
            WriteLiteral("  / ");
            EndContext();
            BeginContext(2709, 10, false);
#line 68 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                                Write(item.Power);

#line default
#line hidden
            EndContext();
            BeginContext(2719, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(2723, 12, false);
#line 68 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                                              Write(item.Mileage);

#line default
#line hidden
            EndContext();
            BeginContext(2735, 105, true);
            WriteLiteral(" km</b>\r\n                                    <br />\r\n                                    <b>Location: <i>");
            EndContext();
            BeginContext(2841, 13, false);
#line 70 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                               Write(item.Location);

#line default
#line hidden
            EndContext();
            BeginContext(2854, 128, true);
            WriteLiteral("</i></b> \r\n                                    <br /><br />\r\n                                    <i><b>Description: </b></i> <i>");
            EndContext();
            BeginContext(2983, 23, false);
#line 72 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                                              Write(item.VehicleDescription);

#line default
#line hidden
            EndContext();
            BeginContext(3006, 121, true);
            WriteLiteral("</i>\r\n                            </td>\r\n\r\n                                <td>\r\n                                    <h5>");
            EndContext();
            BeginContext(3128, 10, false);
#line 76 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3138, 87, true);
            WriteLiteral("&euro;</h5>\r\n                                    <br /><br /><br /><br /><br /><br />\r\n");
            EndContext();
#line 78 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                     if (ViewBag.RenderActions && User.Identity.IsAuthenticated && User.IsInRole("customer"))
                                    {

#line default
#line hidden
            BeginContext(3391, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(3431, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b8a81e6b955bef8cec9e95d3aaf2e14e47cbe219531", async() => {
                BeginContext(3476, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                                               WriteLiteral(item.Id);

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
            BeginContext(3484, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(3526, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b8a81e6b955bef8cec9e95d3aaf2e14e47cbe221915", async() => {
                BeginContext(3573, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                                                 WriteLiteral(item.Id);

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
            BeginContext(3583, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 82 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3624, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(3660, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b8a81e6b955bef8cec9e95d3aaf2e14e47cbe224553", async() => {
                BeginContext(3708, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
                                                              WriteLiteral(item.Id);

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
            BeginContext(3719, 128, true);
            WriteLiteral("\r\n                                </td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n");
            EndContext();
#line 88 "C:\Users\Petar\Desktop\mobile 4.1\mobile.mk\Views\Vehicles\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3862, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<mobile.WebModels.VehicleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591