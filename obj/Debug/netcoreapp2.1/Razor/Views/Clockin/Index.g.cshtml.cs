#pragma checksum "/Users/ryandines/Projects/SeniorDevOps/Views/Clockin/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10b09aee2f151722acb4bbcb0b4bccc9d5d2f090"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clockin_Index), @"mvc.1.0.view", @"/Views/Clockin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clockin/Index.cshtml", typeof(AspNetCore.Views_Clockin_Index))]
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
#line 1 "/Users/ryandines/Projects/SeniorDevOps/Views/_ViewImports.cshtml"
using SeniorDevops;

#line default
#line hidden
#line 2 "/Users/ryandines/Projects/SeniorDevOps/Views/_ViewImports.cshtml"
using SeniorDevops.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10b09aee2f151722acb4bbcb0b4bccc9d5d2f090", @"/Views/Clockin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07467aa1d209cecae6ebf48592186f27b36b31ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Clockin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/ryandines/Projects/SeniorDevOps/Views/Clockin/Index.cshtml"
  ViewData["Title"] = "Clock-In Page";

#line default
#line hidden
            BeginContext(41, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(66, 583, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80efad7d0e1a40719bb69ddcfbef3ccc", async() => {
                BeginContext(72, 570, true);
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>Stored Procedures</title>
    <link rel=""stylesheet""
          href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css""
          integrity=""sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u""
          crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://cdn.datatables.net/1.10.13/css/jquery.dataTables.min.css"" />
    <style>
        span.field-validation-error {
            color: red;
        }
    </style>
");
                EndContext();
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
            EndContext();
            BeginContext(649, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(651, 707, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ff6addf6a0b483ea019b535661c79f3", async() => {
                BeginContext(657, 10, true);
                WriteLiteral("\r\n    <h3>");
                EndContext();
                BeginContext(668, 19, false);
#line 19 "/Users/ryandines/Projects/SeniorDevOps/Views/Clockin/Index.cshtml"
   Write(ViewData["Message"]);

#line default
#line hidden
                EndContext();
                BeginContext(687, 664, true);
                WriteLiteral(@"</h3>

    <p>Populate the user data here.</p>
    <div style=""width:90%; margin:0 auto"" class=""tablecontainer"">
        <a class=""popup btn btn-primary"" href=""/Home/Save/0/"" style=""margin-bottom:20px; margin-top:20px;"">Add New Employee</a>
        <table id=""myDatatable"">
            <thead>
                <tr>
                    <th>Full Name</th>
                    <th>Gender</th>
                    <th>Department</th>
                    <th>Position</th>
                    <th>Salary</th>
                    <th>Edit</th>
                    <th>Delete</th>
                </tr>
            </thead>
        </table>
    </div>
");
                EndContext();
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
            EndContext();
            BeginContext(1358, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1388, 3148, true);
                WriteLiteral(@"
<script src=""https://cdn.datatables.net/1.10.13/js/jquery.dataTables.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.17.0/jquery.validate.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.10/jquery.validate.unobtrusive.min.js"" integrity=""sha256-zkVFxDCBA0K+Fl6QZDRpD0G+GQ+TfuGv7xXkIAM69h8="" crossorigin=""anonymous""></script>
<script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.min.js"" integrity=""sha256-VazP97ZCwtekAsvgPBSUwPFKdrwD3unUfSGVYrahUqU="" crossorigin=""anonymous""></script>
<script>$('#myDatatable').DataTable({
        ""ajax"": {
            ""url"": '/api/Employee',
            ""type"": ""get"",
            ""datatype"": ""json"",
            ""dataSrc"": '',
            ""crossDomain"": ""true""
        },
        ""columns"": [
            { data: 'full_name' },
            { data: 'gender' },
            { data: 'department' },
            { data: 'position' },
            { data: 'salary' },
         ");
                WriteLiteral(@"   {
                ""data"": ""employee_id"", ""width"": ""50px"", ""render"": function(data) {
                    return '<a class=""popup"" href=""/Home/Save/' + data + '"">Edit</a>';
                }
            },
            {
                ""data"": ""EmployeeID"", ""width"": ""50px"", ""render"": function(data) {
                    return '<a class=""popup"" href=""/Home/Delete/' + data + '"">Delete</a>';
                }
            }]
});
$(document).ready(function() {
        $('.tablecontainer').on('click', 'a.popup', function(e) {
            e.preventDefault();
            var $pageContent = $('<div/>');

            $pageContent.load($(this).attr('href'), function() {
                $('#popupForm', $pageContent).removeData('validator');
                $('#popupForm', $pageContent).removeData('unobtrusiveValidation');
            });

            $dialog = $('<div class=""popupWindow"" style=""overflow:auto; background-color:#5185FF""></div>')
                .html($pageContent)
                ");
                WriteLiteral(@".dialog({
                    draggable: false,
                    autoOpen: false,
                    resizable: false,
                    model: true,
                    title: 'Popup Dialog',
                    height: 550,
                    width: 600,
                    close: function() {
                        $dialog.dialog('destroy').remove();
                    }
                })

            $('.popupWindow').on('submit', '#popupForm', function(e) {
                var url = $('#popupForm')[0].action;
                $.ajax({
                    type: ""POST"",
                    url: url,
                    data: $('#popupForm').serialize(),
                    success: function(data) {
                        if (data.status) {
                            $dialog.dialog('close');
                            $('#myDatatable').DataTable.ajax.reload();
                        }
                    }
                })

                e.preventDefault();
     ");
                WriteLiteral("       })\r\n            $dialog.dialog(\'open\');\r\n\r\n        })\r\n});</script>\r\n");
                EndContext();
            }
            );
            BeginContext(4539, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
