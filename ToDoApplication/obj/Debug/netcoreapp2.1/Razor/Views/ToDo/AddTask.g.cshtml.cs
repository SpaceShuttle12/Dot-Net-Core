#pragma checksum "F:\antariksha\MVCStudyProject\.NetCore2.0\ToDoApplication\ToDoApplication\Views\ToDo\AddTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "669e78272ac104e0534478c08e0977893312574d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDo_AddTask), @"mvc.1.0.view", @"/Views/ToDo/AddTask.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ToDo/AddTask.cshtml", typeof(AspNetCore.Views_ToDo_AddTask))]
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
#line 1 "F:\antariksha\MVCStudyProject\.NetCore2.0\ToDoApplication\ToDoApplication\Views\_ViewImports.cshtml"
using ToDoApplication;

#line default
#line hidden
#line 2 "F:\antariksha\MVCStudyProject\.NetCore2.0\ToDoApplication\ToDoApplication\Views\_ViewImports.cshtml"
using ToDoApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"669e78272ac104e0534478c08e0977893312574d", @"/Views/ToDo/AddTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84495fb1153e51b3285af311dada3734de6f00ad", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDo_AddTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoApplication.Models.ToDoModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/scripts/ToDo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\antariksha\MVCStudyProject\.NetCore2.0\ToDoApplication\ToDoApplication\Views\ToDo\AddTask.cshtml"
  
    ViewData["Title"] = "Add Task";

#line default
#line hidden
            BeginContext(85, 272, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""row"">
        <div  style=""text-align:center"">
            <h3 class=""h2"">Add task</h3>
            <hr style=""border:1px solid #90C3D4;"" />
        </div>
    </div>
    <div class=""row"">&nbsp;</div>
    <div class=""row"">
");
            EndContext();
#line 15 "F:\antariksha\MVCStudyProject\.NetCore2.0\ToDoApplication\ToDoApplication\Views\ToDo\AddTask.cshtml"
        using (Html.BeginForm("AddTask", "ToDo", FormMethod.Post, new { @class = "addForm" }))
        {

#line default
#line hidden
            BeginContext(464, 17, true);
            WriteLiteral("            <div>");
            EndContext();
            BeginContext(482, 23, false);
#line 17 "F:\antariksha\MVCStudyProject\.NetCore2.0\ToDoApplication\ToDoApplication\Views\ToDo\AddTask.cshtml"
            Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(505, 109, true);
            WriteLiteral("</div>\r\n            <div class=\"col-md-1\">&nbsp;</div>\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(615, 32, false);
#line 20 "F:\antariksha\MVCStudyProject\.NetCore2.0\ToDoApplication\ToDoApplication\Views\ToDo\AddTask.cshtml"
           Write(Html.Partial("_TaskForm", Model));

#line default
#line hidden
            EndContext();
            BeginContext(647, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 22 "F:\antariksha\MVCStudyProject\.NetCore2.0\ToDoApplication\ToDoApplication\Views\ToDo\AddTask.cshtml"
            
            
        }

#line default
#line hidden
            BeginContext(708, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(728, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c11f26aaa56548999e20fae9c3094d09", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(769, 86, true);
            WriteLiteral("\r\n<script>\r\n    var resources = [];\r\n    resources.push({\r\n        ValidateTaskName :\'");
            EndContext();
            BeginContext(856, 50, false);
#line 31 "F:\antariksha\MVCStudyProject\.NetCore2.0\ToDoApplication\ToDoApplication\Views\ToDo\AddTask.cshtml"
                      Write(ToDoApplication.Resources.Common.Validate_TaskName);

#line default
#line hidden
            EndContext();
            BeginContext(906, 32, true);
            WriteLiteral("\',\r\n       ValidateTaskName1 : \'");
            EndContext();
            BeginContext(939, 51, false);
#line 32 "F:\antariksha\MVCStudyProject\.NetCore2.0\ToDoApplication\ToDoApplication\Views\ToDo\AddTask.cshtml"
                       Write(ToDoApplication.Resources.Common.Validate_TaskName1);

#line default
#line hidden
            EndContext();
            BeginContext(990, 37, true);
            WriteLiteral("\',\r\n       ValidateTaskDescription :\'");
            EndContext();
            BeginContext(1028, 57, false);
#line 33 "F:\antariksha\MVCStudyProject\.NetCore2.0\ToDoApplication\ToDoApplication\Views\ToDo\AddTask.cshtml"
                            Write(ToDoApplication.Resources.Common.Validate_TaskDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1085, 37, true);
            WriteLiteral("\',\r\n       ValidateTaskDescription1:\'");
            EndContext();
            BeginContext(1123, 58, false);
#line 34 "F:\antariksha\MVCStudyProject\.NetCore2.0\ToDoApplication\ToDoApplication\Views\ToDo\AddTask.cshtml"
                            Write(ToDoApplication.Resources.Common.Validate_TaskDescription1);

#line default
#line hidden
            EndContext();
            BeginContext(1181, 31, true);
            WriteLiteral("\',\r\n       ValidateTaskStatus:\'");
            EndContext();
            BeginContext(1213, 52, false);
#line 35 "F:\antariksha\MVCStudyProject\.NetCore2.0\ToDoApplication\ToDoApplication\Views\ToDo\AddTask.cshtml"
                      Write(ToDoApplication.Resources.Common.Validate_TaskStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1265, 57, true);
            WriteLiteral("\'\r\n    });\r\n    ToDo.init(resources,siteRoot);\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoApplication.Models.ToDoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591