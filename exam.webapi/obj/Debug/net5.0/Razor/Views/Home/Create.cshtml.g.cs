#pragma checksum "C:\Users\hasan\Documents\asp\examasp\exam-asp\exam.webapi\Views\Home\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf5ae14027b212252cedbab0d57fda36145f414b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Create), @"mvc.1.0.view", @"/Views/Home/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf5ae14027b212252cedbab0d57fda36145f414b", @"/Views/Home/Create.cshtml")]
    public class Views_Home_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://code.jquery.com/jquery-3.6.0.min.js""
        integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4=""
        crossorigin=""anonymous""></script>
<form action=""#"" method=""post"">
    <div class=""form-group"">
        <label for=""examname"">Sınav Adı:</label>
        <input type=""text"" name=""examname"" class=""form-control"" />
    </div>
    <div class=""form-group"">
        <label for=""examname"">Soru açıklaması:</label>
        <input type=""text"" name=""qtext"" class=""form-control""  id=""qtext""/>
    </div>
    <div class=""form-group"">
        <label for=""opt1"">a şıkkı:</label>
        <input type=""text"" name=""opt1"" class=""form-control"" id=""opt1""/>
    </div>
    <div class=""form-group"">
        <label for=""opt2"">b şıkkı:</label>
        <input type=""text"" name=""opt2"" class=""form-control"" id=""opt2"" />
    </div>
    <div class=""form-group"">
        <label for=""opt3"">c şıkkı:</label>
        <input type=""text"" name=""opt3"" class=""form-control"" id=""opt3""/>
    </div>
    ");
            WriteLiteral(@"<div class=""form-group"">
        <label for=""opt4"">d şıkkı:</label>
        <input type=""text"" name=""opt4"" class=""form-control"" id=""opt4""/>
    </div>
    <div class=""form-group"">
        <label for=""opt5"">e şıkkı:</label>
        <input type=""text"" name=""opt5"" class=""form-control"" id=""opt5""/>
    </div>
    <div class=""form-group"">
        <label for=""copt"">Doğru şık:</label>
        <select id=""copt"" class=""form-control"" name=""copt"">
            <option value=""a"" >doğru şıkkı seçiniz</option>
            <option value=""opt1"">a şıkkı</option>
            <option value=""opt2"">b şıkkı</option>
            <option value=""opt3"">c şıkkı</option>
            <option value=""opt4"">d şıkkı</option>
            <option value=""opt5"">e şıkkı</option>
        </select>
    </div>
    <input name=""qtextarray"" id=""opt1array"" type=""hidden"" class=""form-control"" />
    <input name=""opt1array"" id=""opt1array"" type=""hidden"" class=""form-control""/>
    <input name=""opt2array"" id=""opt2array"" type=""hidden"" class");
            WriteLiteral(@"=""form-control""/>
    <input name=""opt3array"" id=""opt3array"" type=""hidden"" class=""form-control""/>
    <input name=""opt4array"" id=""opt4array"" type=""hidden"" class=""form-control""/>
    <input name=""opt5array"" id=""opt5array"" type=""hidden"" class=""form-control""/>
    <input name=""coptarray"" id=""coptarray"" type=""hidden"" class=""form-control""/>
    <button type=""submit"">Sınav oluşturmayı tamamlayın</button>
    <button onclick=""kaydet();"">Soruyu kaydet</button>
</form>
<script type=""text/javascript"">
   
        var qtext = document.getElementById(""qtext"");
        var opt1 = document.getElementById(""opt1"");
        var opt2 = document.getElementById(""opt2"");
        var opt3 = document.getElementById(""opt3"");
        var opt4 = document.getElementById(""opt4"");
        var opt5 = document.getElementById(""opt5"");
        var copt = document.getElementById(""copt"");
        var qtexta = document.getElementById(""qtextarray"");
        var op1a = document.getElementById(""opt1array"");
        var op2a = do");
            WriteLiteral(@"cument.getElementById(""opt2array"");
        var op3a = document.getElementById(""opt3array"");
        var op4a = document.getElementById(""opt4array"");
        var op5a = document.getElementById(""opt5array"");
        var copa = document.getElementById(""coptarray"");
        
    function kaydet() {
        console.log(copt.value);
        if (op1a == null && op2a == null && op3a == null && op4a == null && op5a == null && copa == null) {
            qtexta.value = qtext.value;
            op1a.value = opt1.value;
            op2a.value = opt2.value;
            op3a.value = opt3.value;
            op4a.value = opt4.value;
            op4a.value = opt5.value;
            copa.value = copt.value;
            console.log(""if e girdi"");

        }
        else {
            qtexta.value += "","" + qtext.value;
            op1a.value += "","" + opt1.value;
            op2a.value += "","" + opt2.value;
            op3a.value += "","" + opt3.value;
            op4a.value += "","" + opt4.value;
           ");
            WriteLiteral(" op4a.value += \",\" + opt5.value;\r\n            copa.value += \",\" + copt.value;\r\n        }\r\n\r\n\r\n    }\r\n</script>");
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
