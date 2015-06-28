﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
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
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Ilaro.Admin;
    using Ilaro.Admin.Core;
    using Ilaro.Admin.Extensions;
    using Ilaro.Admin.Models;
    using Resources;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/IlaroAdmin/Views/Entity/Create.cshtml")]
    public partial class _Areas_IlaroAdmin_Views_Entity_Create_cshtml : System.Web.Mvc.WebViewPage<EntityCreateModel>
    {
        public _Areas_IlaroAdmin_Views_Entity_Create_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
  
    if (ViewBag.IsAjaxRequest)
    {
        Layout = null;
    }
    else
    {
        Layout = "~/Areas/IlaroAdmin/Views/Shared/_Layout.cshtml";
    }
    ViewBag.Title = string.Format(IlaroAdminResources.Create_Title, Model.Entity.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Breadcrumb", () => {

WriteLiteral("\r\n    <ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n        <li>");

            
            #line 17 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
       Write(Html.ActionLink(IlaroAdminResources.Index_Title, "Index", "Group", new { area = "IlaroAdmin" }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 18 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
       Write(Html.ActionLink(Model.Entity.Verbose.Group, "Details", "Group", new { area = "IlaroAdmin", groupName = Model.Entity.Verbose.Group }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li>");

            
            #line 19 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
       Write(Html.ActionLink(Model.Entity.Verbose.Plural, "Index", "Entities", new { area = "IlaroAdmin", entityName = Model.Entity.Name }, null));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n        <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">");

            
            #line 20 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                      Write(string.Format(IlaroAdminResources.Create_Title, Model.Entity.Name));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n    </ul>\r\n");

});

WriteLiteral("\r\n<h2>");

            
            #line 24 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
Write(Model.Entity.Verbose.Singular);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n\r\n");

            
            #line 26 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
 using (Html.BeginForm("Create", "Entity", new { area = "IlaroAdmin" }, FormMethod.Post, new { enctype = "multipart/form-data", @class = "form-horizontal", role = "form" }))
{
    
            
            #line default
            #line hidden
            
            #line 28 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 28 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                            
    
            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 29 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                                 

    if (Model.PropertiesGroups.Count > 1)
    {
        foreach (var group in Model.PropertiesGroups)
        {

            
            #line default
            #line hidden
WriteLiteral("            <fieldset>\r\n                <legend>");

            
            #line 36 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                   Write(group.GroupName);

            
            #line default
            #line hidden
WriteLiteral(" <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn pull-right\"");

WriteLiteral("><i");

WriteAttribute("class", Tuple.Create(" class=\"", 1403), Tuple.Create("\"", 1514)
            
            #line 36 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                , Tuple.Create(Tuple.Create("", 1411), Tuple.Create<System.Object, System.Int32>(Html.Condition(group.IsCollapsed, () => "glyphicon glyphicon-plus", () => "glyphicon glyphicon-minus")
            
            #line default
            #line hidden
, 1411), false)
);

WriteLiteral("></i></button></legend>\r\n                <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1560), Tuple.Create("\"", 1623)
, Tuple.Create(Tuple.Create("", 1568), Tuple.Create("fields", 1568), true)
            
            #line 37 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
, Tuple.Create(Tuple.Create(" ", 1574), Tuple.Create<System.Object, System.Int32>(Html.Condition(group.IsCollapsed, () => "hide")
            
            #line default
            #line hidden
, 1575), false)
);

WriteLiteral(">\r\n");

            
            #line 38 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 38 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                     foreach (var property in group.Properties)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 41 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                       Write(Html.EditorFor(m => property, property.Template.Editor));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 42 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 42 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                             if (property.IsForeignKey)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1973), Tuple.Create("\"", 2051)
            
            #line 44 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
, Tuple.Create(Tuple.Create("", 1980), Tuple.Create<System.Object, System.Int32>(Url.Action("Create", new { entityName = property.ForeignEntity.Name })
            
            #line default
            #line hidden
, 1980), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"btn btn-primary create-foreign\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-plus\"");

WriteLiteral("></span></a>\r\n");

            
            #line 45 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </div>\r\n");

            
            #line 47 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </fieldset>\r\n");

            
            #line 50 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
        }
    }
    else if (Model.PropertiesGroups.Count == 1)
    {
        foreach (var property in Model.PropertiesGroups[0].Properties)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 57 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
           Write(Html.EditorFor(m => property, property.Template.Editor));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 58 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                
            
            #line default
            #line hidden
            
            #line 58 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                 if (property.IsForeignKey)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2650), Tuple.Create("\"", 2728)
            
            #line 60 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
, Tuple.Create(Tuple.Create("", 2657), Tuple.Create<System.Object, System.Int32>(Url.Action("Create", new { entityName = property.ForeignEntity.Name })
            
            #line default
            #line hidden
, 2657), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" class=\"btn btn-primary create-foreign\"");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-plus\"");

WriteLiteral("></span></a>\r\n");

            
            #line 61 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");

            
            #line 63 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
        }
    }

    
            
            #line default
            #line hidden
            
            #line 66 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
Write(Html.Hidden("EntityName", Model.Entity.Name));

            
            #line default
            #line hidden
            
            #line 66 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                                                 


            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-action\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-offset-2\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 70 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                                                     Write(IlaroAdminResources.Save);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" name=\"ContinueEdit\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-edit\"");

WriteLiteral("></i> ");

            
            #line 71 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                                                                                                                  Write(IlaroAdminResources.SaveAndContinueEdit);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" name=\"AddNext\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-plus\"");

WriteLiteral("></i> ");

            
            #line 72 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                                                                                                             Write(IlaroAdminResources.SaveAndAddNext);

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3457), Tuple.Create("\"", 3563)
            
            #line 73 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
, Tuple.Create(Tuple.Create("", 3464), Tuple.Create<System.Object, System.Int32>(Url.Action("Index", "Entities", new { area = "IlaroAdmin", entityName = Model.Entity.Name }, null)
            
            #line default
            #line hidden
, 3464), false)
);

WriteLiteral(" class=\"btn btn-link\"");

WriteLiteral(">");

            
            #line 73 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
                                                                                                                                          Write(IlaroAdminResources.Cancel);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n    </div>\r\n");

            
            #line 76 "..\..\Areas\IlaroAdmin\Views\Entity\Create.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"modal fade\"");

WriteLiteral(" id=\"foreign-modal\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-labelledby=\"Create foreign entity\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"modal-dialog\"");

WriteLiteral(" style=\"width:90%\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"modal-content\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"modal-header\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" data-dismiss=\"modal\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</button>\r\n                <h4");

WriteLiteral(" class=\"modal-title\"");

WriteLiteral(" id=\"myModalLabel\"");

WriteLiteral(">Create foreign entity</h4>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"modal-body\"");

WriteLiteral(">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
