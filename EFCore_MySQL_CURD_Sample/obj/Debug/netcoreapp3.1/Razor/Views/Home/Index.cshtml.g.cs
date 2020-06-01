#pragma checksum "E:\A-我的Github开源项目\EFCore_MySQL_CURD_Sample\EFCore_MySQL_CURD_Sample\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aae87c197c6152c432efe9b86b2a4cb4a83952cc"
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
#line 1 "E:\A-我的Github开源项目\EFCore_MySQL_CURD_Sample\EFCore_MySQL_CURD_Sample\Views\_ViewImports.cshtml"
using EFCore_MySQL_CURD_Sample;

#line default
#line hidden
#line 2 "E:\A-我的Github开源项目\EFCore_MySQL_CURD_Sample\EFCore_MySQL_CURD_Sample\Views\_ViewImports.cshtml"
using EFCore_MySQL_CURD_Sample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae87c197c6152c432efe9b86b2a4cb4a83952cc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"713a594c141b4ea69b3109b192ccc5778f5ffe1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\A-我的Github开源项目\EFCore_MySQL_CURD_Sample\EFCore_MySQL_CURD_Sample\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "ASP.NET Core MVC+Layui使用EF Core连接MySQL执行简单的CRUD操作";

#line default
#line hidden
            WriteLiteral(@"<div style=""margin-top:4px;""></div>
<script type=""text/html"" id=""test-table-toolbar-barDemo"">
    <button class=""layui-btn layui-btn-xs"" lay-event=""edit""><i class=""layui-icon"">&#xe642;</i>编辑</button>
    <button class=""layui-btn layui-btn-danger layui-btn-xs"" lay-event=""del""><i class=""layui-icon"">&#xe640;</i>删除</button>
</script>
<div class=""layui-fluid"">
    <div class=""layui-row layui-col-space15"">
        <div class=""layui-col-md12"">
            <div class=""layui-card"">
                <div class=""layui-card-header"">
                    <!--// 搜索：用户姓名-->
                    <div class=""layui-inline"">
                        <input class=""layui-input layui-icon-search"" name=""id"" id=""userName"" autocomplete=""off"" placeholder=""请输入用户名"">
                    </div>
                    <button class=""layui-btn layui-btn"" id=""queryData""><i class=""layui-icon"">&#xe615;</i>查询</button>
                    <button class=""layui-btn layui-btn"" onclick=""addData()""> <i class=""layui-icon"">&#xe624;</i> 数据添加</bu");
            WriteLiteral(@"tton>
                    <button class=""layui-btn layui-btn"" id=""btn-refresh""><i class=""layui-icon"">&#xe9aa;</i>刷新</button>
                </div>

                <div class=""layui-card-body"">
                    <table class=""layui-hide"" id=""layUI_Table""  lay-filter=""layUI_Table""> </table>
                </div>
            </div>
        </div>
    </div>
</div>

<script>

        //layui—table表格渲染和数据绑定
        layui.use('table', function () {
            var table = layui.table;

         // 表格渲染
         var tableIns=table.render({
               elem: '#layUI_Table',
               url: '");
#line 40 "E:\A-我的Github开源项目\EFCore_MySQL_CURD_Sample\EFCore_MySQL_CURD_Sample\Views\Home\Index.cshtml"
                Write(Url.Action("GetUserInfo","OperationApi"));

#line default
#line hidden
            WriteLiteral(@"',
               toolbar: '#test-table-toolbar-toolbarDemo',
               loading: true,
               height: 505, //容器高度
               limit: 15,
               limits: [15, 30, 60, 90],
               cols: [
                   [
                       { field: 'id', width: 110, title: '用户编号', sort: true },
                       { field: 'userName', width: 150, title: '用户名' }, { field: 'sex', width: 70, title: '性别' },
                       { field: 'phone', width: 150, title: '手机号' },
                       { field: 'description', width: 300, title: '个人介绍' },
                       { field: 'hobby', title: '爱好', minWidth: 150, width: 280 },
                       {fixed: 'right', title:'操作', toolbar: '#test-table-toolbar-barDemo', width:150}
                   ]
               ],
               page: true
            });

            // 刷新
            $('#btn-refresh').on('click',
                function() {
                    tableIns.reload();
                });

      ");
            WriteLiteral(@"      //数据查询
            $(""#queryData"").on(""click"",
                function() {

                    var userName = $(""#userName"").val();
                    //if (userName == """") {
                    //    layer.msg(""用户名不能为空~"");
                    //    return false;
                    //}

                    table.reload('layUI_Table',
                        {
                            where: { //请求参数（注意：这里面的参数可任意定义，并非下面固定的格式）
                                userName: userName
                                //,order: obj.type //排序方式
                            }
                        });
                });

            //注意这里tool里面是匹配lay-filter ：事件过滤器（公用属性），主要用于事件的精确匹配，跟选择器是比较类似的。
            //监听行工具事件
            table.on('tool(layUI_Table)', function(obj){
                var data = obj.data;

                console.log(data);

                if(obj.event === 'del'){//数据删除
                    layer.confirm('您确定要删除该条记录吗？', function (index) {
                      ");
            WriteLiteral("  $.ajax({\r\n                            async: true,\r\n                            dataType: \'json\',\r\n                            type: \'post\',\r\n                            url: \"");
#line 97 "E:\A-我的Github开源项目\EFCore_MySQL_CURD_Sample\EFCore_MySQL_CURD_Sample\Views\Home\Index.cshtml"
                             Write(Url.Action("DataDelete","OperationApi"));

#line default
#line hidden
            WriteLiteral(@""",
                            data: { id: data.id },
                            success: function (res) {
                                if (res.code == 0) {
                                    obj.del();
                                }
                                layer.msg(res.resultMsg);
                                layer.close(index);
                            }
                            
                        });
       
                    });
                }
                else if (obj.event === 'edit') {
                    //数据更新
                    layer.open({
                        type: 2,
                        title: '数据编辑',
                        shadeClose: true,
                        shade: false,
                        maxmin: true, //开启最大化最小化按钮
                        area: ['700px', '500px'],
                        content: '");
#line 120 "E:\A-我的Github开源项目\EFCore_MySQL_CURD_Sample\EFCore_MySQL_CURD_Sample\Views\Home\Index.cshtml"
                             Write(Url.Action("DataEditDialog"));

#line default
#line hidden
            WriteLiteral(@"?id='+data.id
                    });
                }
            });
        });

        //添加弹窗
        function addData() {
            layer.open({
                type: 2,
                title: '数据添加',
                shadeClose: true,
                shade: false,
                maxmin: true, //开启最大化最小化按钮
                area: ['700px', '500px'],
                content: '");
#line 135 "E:\A-我的Github开源项目\EFCore_MySQL_CURD_Sample\EFCore_MySQL_CURD_Sample\Views\Home\Index.cshtml"
                     Write(Url.Action("AddDialog"));

#line default
#line hidden
            WriteLiteral("\'\r\n            });\r\n        }\r\n\r\n</script>\r\n");
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
