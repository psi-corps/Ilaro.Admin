﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ilaro.Admin.Views.IlaroAdmin
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Ilaro.Admin.Commons.Paging;
    using Ilaro.Admin.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IlaroAdmin/Delete.cshtml")]
    public partial class Delete : System.Web.Mvc.WebViewPage<Ilaro.Admin.ViewModels.DeleteViewModel>
    {
        public Delete()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\IlaroAdmin\Delete.cshtml"
  
    Layout = "~/Views/IlaroAdmin/_Layout.cshtml";
    ViewBag.Title = string.Format(Resources.IlaroAdminResources.Delete_Title, Model.Entity.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("Breadcrumb", () => {

WriteLiteral("\r\n    <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n        <li>");

            
            #line 10 "..\..\Views\IlaroAdmin\Delete.cshtml"
       Write(Html.ActionLink(Resources.IlaroAdminResources.Index_Title, "Index"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 11 "..\..\Views\IlaroAdmin\Delete.cshtml"
       Write(Html.ActionLink(Model.Entity.GroupName, "Group", new { groupName = Model.Entity.GroupName }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 12 "..\..\Views\IlaroAdmin\Delete.cshtml"
       Write(Html.ActionLink(Model.Entity.Plural, "Details", new { entityName = Model.Entity.Name }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">");

            
            #line 13 "..\..\Views\IlaroAdmin\Delete.cshtml"
                      Write(string.Format(Resources.IlaroAdminResources.Delete_Title, Model.Entity.Name));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    </ul>\r\n");

});

WriteLiteral("\r\n<h2>");

            
            #line 17 "..\..\Views\IlaroAdmin\Delete.cshtml"
Write(Model.Entity.Singular);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n\r\n");

            
            #line 19 "..\..\Views\IlaroAdmin\Delete.cshtml"
 using (Html.BeginForm("Delete", "IlaroAdmin", FormMethod.Post, new { @class = "form-horizontal" }))
{
    
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\IlaroAdmin\Delete.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\IlaroAdmin\Delete.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\IlaroAdmin\Delete.cshtml"
Write(Html.ValidationSummary());

            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\IlaroAdmin\Delete.cshtml"
                             
    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\IlaroAdmin\Delete.cshtml"
Write(Html.Hidden("key", Model.Entity.Key.Value));

            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\IlaroAdmin\Delete.cshtml"
                                               


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"control-group\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"controls\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 27 "..\..\Views\IlaroAdmin\Delete.cshtml"
       Write(Resources.IlaroAdminResources.DeleteText);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n    </div>\r\n");

            
            #line 30 "..\..\Views\IlaroAdmin\Delete.cshtml"


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-action\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 32 "..\..\Views\IlaroAdmin\Delete.cshtml"
                                                 Write(Resources.IlaroAdminResources.Delete);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1237), Tuple.Create("\"", 1263)
            
            #line 33 "..\..\Views\IlaroAdmin\Delete.cshtml"
, Tuple.Create(Tuple.Create("", 1244), Tuple.Create<System.Object, System.Int32>(Url.Action("Edit")
            
            #line default
            #line hidden
, 1244), false)
);

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-edit\"");

WriteLiteral("></i> ");

            
            #line 33 "..\..\Views\IlaroAdmin\Delete.cshtml"
                                                                                                  Write(Resources.IlaroAdminResources.Edit);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1381), Tuple.Create("\"", 1410)
            
            #line 34 "..\..\Views\IlaroAdmin\Delete.cshtml"
, Tuple.Create(Tuple.Create("", 1388), Tuple.Create<System.Object, System.Int32>(Url.Action("Details")
            
            #line default
            #line hidden
, 1388), false)
);

WriteLiteral(" class=\"btn btn-link\"");

WriteLiteral(">");

            
            #line 34 "..\..\Views\IlaroAdmin\Delete.cshtml"
                                                         Write(Resources.IlaroAdminResources.Cancel);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </div>\r\n");

            
            #line 36 "..\..\Views\IlaroAdmin\Delete.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
