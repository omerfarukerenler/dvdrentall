#pragma checksum "C:\Users\Administrator\source\repos\stajproje\stajproje\Views\Home\Customer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42280c97e2485e167e4dd6979d4816e68eb3dec0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Customer), @"mvc.1.0.view", @"/Views/Home/Customer.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\stajproje\stajproje\Views\_ViewImports.cshtml"
using stajproje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\stajproje\stajproje\Views\_ViewImports.cshtml"
using stajproje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42280c97e2485e167e4dd6979d4816e68eb3dec0", @"/Views/Home/Customer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54f7c6bf65e17a2dba05c3a2539f0402f0e84b41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Customer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\source\repos\stajproje\stajproje\Views\Home\Customer.cshtml"
  
    ViewData["Title"] = "Customer Page";
    Layout = "~/Views/Shared/AdminLTE/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div style=""overflow-x:auto;"">
    <table class=""table-warning"" id=""myTable6"">
        <thead>
            <tr class=""tablo"">
                <th scope=""row"">customer_id</th>
                <th scope=""row"">store_id</th>
                <th scope=""row"">first_name</th>
                <th scope=""row"">last_name</th>
                <th scope=""row"">email</th>
                <th scope=""row"">address_id</th>
                <th scope=""row"">activebool</th>
                <th scope=""row"">create_date</th>
                <th scope=""row"">last_update</th>
                <th scope=""row"">active</th>

            </tr>
        </thead>
    </table>

</div>
");
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
