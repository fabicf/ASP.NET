#pragma checksum "C:\Users\15144\Documents\john-abbott-2\15-asp.NET\ASP.NET\Bakery\Pages\OrderSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "176e1003236aee224ed1eb48becd876bad550c0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Bakery.Pages.Pages_OrderSuccess), @"mvc.1.0.razor-page", @"/Pages/OrderSuccess.cshtml")]
namespace Bakery.Pages
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
#line 1 "C:\Users\15144\Documents\john-abbott-2\15-asp.NET\ASP.NET\Bakery\Pages\_ViewImports.cshtml"
using Bakery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"176e1003236aee224ed1eb48becd876bad550c0b", @"/Pages/OrderSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27f933f90424543200e11e9b28516183f8d7b469", @"/Pages/_ViewImports.cshtml")]
    public class Pages_OrderSuccess : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<ol id=""orderProcess"">
    <li><span class=""step-number"">1</span>Choose Item</li>
    <li><span class=""step-number"">2</span>Details &amp; Submit</li>
    <li class=""current""><span class=""step-number"">3</span>Receipt</li>
</ol>
<h1>Order Confirmation</h1>
<div class=""message order-success"">
    <h2>Thank you for your order!</h2>
    <p>We are processing your order and have sent a confirmation email. Thank you for your business and enjoy!</p>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bakery.Pages.OrderSuccessModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bakery.Pages.OrderSuccessModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bakery.Pages.OrderSuccessModel>)PageContext?.ViewData;
        public Bakery.Pages.OrderSuccessModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
