#pragma checksum "C:\Users\Toan\Desktop\StudentManagement\StudentManagement\Views\Home\Line.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68e0216008e21bb07cb3eb790e230e7c7d8e0af1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Line), @"mvc.1.0.view", @"/Views/Home/Line.cshtml")]
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
#line 1 "C:\Users\Toan\Desktop\StudentManagement\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Toan\Desktop\StudentManagement\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68e0216008e21bb07cb3eb790e230e7c7d8e0af1", @"/Views/Home/Line.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bb6102ef74a0920854243dc02f5efb2e491047", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Line : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StudentMarkDetails>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Toan\Desktop\StudentManagement\StudentManagement\Views\Home\Line.cshtml"
  
    ViewData["Title"] = "Trang ch???";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h4 class=\"display-4\">Bi???u ????? ???????ng th??? hi???n ??i???m s??? c??c m??n h???c</h4>\r\n    <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68e0216008e21bb07cb3eb790e230e7c7d8e0af13843", async() => {
                WriteLiteral("Quay l???i");
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
            WriteLiteral(@"</h3>
    <div class=""card"">
        <div class=""card-header"">
            <div class=""chart1"">
                <canvas id=""myChart2""></canvas>
            </div>
        </div>
    </div>
</div>

<script src=""https://code.jquery.com/jquery-3.6.0.min.js""
        integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4=""
        crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.bundle.min.js""></script>
<script>

    var Physics = [];
    var Chemistry = [];
    var Biology = [];
    var Mathematics = [];
    var English = [];

");
#nullable restore
#line 30 "C:\Users\Toan\Desktop\StudentManagement\StudentManagement\Views\Home\Line.cshtml"
     if(Model.Count>0)
    {
        foreach(var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("Physics.push(");
#nullable restore
#line 34 "C:\Users\Toan\Desktop\StudentManagement\StudentManagement\Views\Home\Line.cshtml"
                      Write(item.Physics);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n            ");
            WriteLiteral("Chemistry.push(");
#nullable restore
#line 35 "C:\Users\Toan\Desktop\StudentManagement\StudentManagement\Views\Home\Line.cshtml"
                        Write(item.Chemistry);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n            ");
            WriteLiteral("Biology.push(");
#nullable restore
#line 36 "C:\Users\Toan\Desktop\StudentManagement\StudentManagement\Views\Home\Line.cshtml"
                      Write(item.Biology);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n            ");
            WriteLiteral("Mathematics.push(");
#nullable restore
#line 37 "C:\Users\Toan\Desktop\StudentManagement\StudentManagement\Views\Home\Line.cshtml"
                          Write(item.Mathematics);

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n");
#nullable restore
#line 38 "C:\Users\Toan\Desktop\StudentManagement\StudentManagement\Views\Home\Line.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    var Chart2 = document.getElementById('myChart2').getContext('2d');
    var chart = new Chart(Chart2, {
        type: 'line',
        data: {
            labels: [""Vinh"", ""H??o"", ""Trung"", ""Hi???u"", ""L??nh"", ""Trang""],
            datasets: [{
                label: ""V???t l??"",
                backgroundColor: 'transparent',
                borderColor: ""#ff0000"",
                borderWidth: 2,
                pointBorderColor: false,
                startAngle: 0,
                data: Physics,
                fill: false,
                lineTension: .4,
                showLine: true,
            }, {
                label: ""H??a h???c"",
                fill: false,
                lineTension: .4,
                startAngle: 0,
                data: Chemistry,
                backgroundColor: ""transparent"",
                pointBorderColor: ""#660066"",
                borderColor: '#660066',
                borderWidth: 2,
                showLine: true,
            }, {
            ");
            WriteLiteral(@"    label: ""Sinh h???c"",
                fill: false,
                lineTension: .4,
                startAngle: 0,
                data: Biology,
                backgroundColor: ""transparent"",
                pointBorderColor: ""#00b300"",
                borderColor: '#00b300',
                borderWidth: 2,
                showLine: true,
            },
            {
                label: ""To??n"",
                fill: false,
                lineTension: .4,
                startAngle: 0,
                data: Mathematics,
                backgroundColor: ""transparent"",
                pointBorderColor: ""#3333cc"",
                borderColor: '#3333cc',
                borderWidth: 2,
                showLine: true,
            }]
        },

    });

</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StudentMarkDetails>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
