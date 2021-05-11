// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Resturent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\internship\Resturent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\internship\Resturent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\internship\Resturent\_Imports.razor"
using Resturent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\internship\Resturent\_Imports.razor"
using Resturent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\internship\Resturent\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\internship\Resturent\Pages\Tables.razor"
using Resturent.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/table")]
    public partial class Tables : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "D:\internship\Resturent\Pages\Tables.razor"
       



    private bool dense = false;
    private bool hover = true;
    private bool striped = false;
    private bool bordered = false;
    private string searchString = "";




    List<Table> objTable;
    
    Table obj = new Table();

    private HashSet<Table> selectedItems = new HashSet<Table>();
    private HashSet<Table> table = new HashSet<Table>();



    //display
    private HashSet<Table> GetTable()
    {

        objTable = objTableService.GetTable(); //after delete display
        return table;
    }

    protected override async Task OnInitializedAsync()
    {
        objTable = await Task.Run(() => objTableService.GetTable());

    }


    //search
    private bool FilterFunc(Table element)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "D:\internship\Resturent\Pages\Tables.razor"
                          
    if ($"{element.TableName} {element.TableDesc}".Contains(searchString))
        return true;

    return false;
}

//delete
protected void Delete(long TableId)
{
    objTableService.Delete(TableId);
    GetTable();

}
//multiDelete
protected void DeleteMulti(long[] num)
{
    foreach (long x in num)
    {
        objTableService.Delete(x);
    }
    GetTable();
}



//----------------------------------------Excel export----------------------------------//


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TableService objTableService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsruntime { get; set; }
    }
}
#pragma warning restore 1591
