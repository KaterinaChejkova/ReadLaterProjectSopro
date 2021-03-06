#pragma checksum "C:\data\ReadLater5\ReadLater5\ReadLater5\ReadLater5\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20a19ff90666ba0711e14b2d07262bc607e718ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\data\ReadLater5\ReadLater5\ReadLater5\ReadLater5\Views\_ViewImports.cshtml"
using ReadLater5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\data\ReadLater5\ReadLater5\ReadLater5\ReadLater5\Views\_ViewImports.cshtml"
using ReadLater5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a19ff90666ba0711e14b2d07262bc607e718ac", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08faceac1ab979c2b859ec9d950e1ab3b3da99e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""featured"">
    <div class=""content-wrapper"">
        <hgroup class=""title"">
            <h1>Read Later</h1>
            <h2>A revolution in the world of social bookmarking</h2>
        </hgroup>
        <p>
            Read Later is a fictional service designed to test a range of skills using the .net core 5 MVC architecture.
            For full details about this project, the libraries used, and a quickstart guide to getting it up and running,
            please visit the ");
#nullable restore
#line 10 "C:\data\ReadLater5\ReadLater5\ReadLater5\ReadLater5\Views\Home\Index.cshtml"
                        Write(Html.ActionLink("About", "About", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" page
        </p>
    </div>
</section>

<h3>Tasks</h3>
<p>Please complete 3 of the below exercises.  You will need to complete the first 2, and then choose 1 from the remaining 3 however feel free to complete more than 3, or to elaborate on the ways you achieve the solution.</p>
<p>
    This test is designed to measure your coding knowledge and skill however as time is limited you are not expected to produce 100% production ready code in all cases.  Most important is that the code works, and has the correct logical process
    and structure to solve the problem.  Coding standards e.g. error logging and reporting, correct variable naming, conde commenting, unit testing are not required - you won't lose marks for forgetting to check a null reference here and there!
</p>
<h4>Complete these 2 first:</h4>
<ol class=""round"">
    <li class=""one"">
        <h5>Bookmark management</h5>
        Implement full CRUD management for Bookmarks.  Users should be able to create a new category whilst creating a");
            WriteLiteral(@" bookmark without requiring any page refresh
    </li>

    <li class=""two"">
        <h5>User accounts</h5>
        The package has the default AspNetCore Identity installed however not implemented fully.  Complete this implementation and change the entities to work on a per user basis.  For additional credit,
        implement multiple membership providers allowing users to log in with OpenID services
    </li>
</ol>
<h4>Now choose one of these:</h4>
<ol class=""round"">
    <li class=""one"">
        <h5>API access</h5>
        Expose an API allowing external systems to manage bookmarks.  You will need to consider authentication / access tokens
    </li>
    <li class=""two"">
        <h5>Tracking and reporting</h5>
        Track each time a user clicks out on one of their saved bookmarks and provide a simple dashboard which can show a summary of stats by user, and as an overview (e.g. for tracking the most popular links).
        Users should also be able to share a short url with their friends");
            WriteLiteral(@" which when clicked would also log usage statictics and be reported on
    </li>
    <li class=""three"">
        <h5>Website widget</h5>
        Provide 1 or more widgets that can be used in an external website, regardless of the server side technology.  These can provide any functionality you choose - for example showing the most recent 5 bookmarks for a particular user, or the 3 most popular bookmarks today
    </li>
</ol>");
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
