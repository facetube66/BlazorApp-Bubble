#pragma checksum "F:\Blood\second\Project\BlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daaca4ac15a86924e979809d3721be663e1bb933"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Blood\second\Project\BlazorApp\_Imports.razor"
using jQWidgets.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Bubble Dragging</h3>\r\n\r\n");
#nullable restore
#line 8 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
 foreach (var task in employees)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BlazorApp.Pages.DropTarget<Employee>>(2);
            __builder.AddAttribute(3, "Drop", new System.Action<BlazorApp.Data.Employee>(
#nullable restore
#line 10 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
                                    OnDrop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "zone", 
#nullable restore
#line 10 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
                                                   task.Score

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "drop-target");
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenComponent<BlazorApp.Pages.Draggable<Employee>>(10);
                __builder2.AddAttribute(11, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp.Data.Employee>(
#nullable restore
#line 12 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
                              task

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Drag", new System.Action<BlazorApp.Data.Employee>(
#nullable restore
#line 12 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
                                                        OnDragStart

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "\r\n                ");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "draggable");
                    __builder3.AddMarkupContent(17, "\r\n                    ");
                    __builder3.OpenElement(18, "svg");
                    __builder3.AddAttribute(19, "height", 
#nullable restore
#line 14 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
                                   task.Score*2

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(20, "width", 
#nullable restore
#line 14 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
                                                           task.Score*2

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(21, "\r\n                        ");
                    __builder3.OpenElement(22, "circle");
                    __builder3.AddAttribute(23, "cx", 
#nullable restore
#line 15 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
                                     task.Score

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(24, "cy", 
#nullable restore
#line 15 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
                                                      task.Score

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(25, "r", 
#nullable restore
#line 15 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
                                                                       task.Score*0.8

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(26, "stroke", "black");
                    __builder3.AddAttribute(27, "stroke-width", 
#nullable restore
#line 15 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
                                                                                                                       task.Score *0.05

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(28, "fill", "#a0a");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(29, "\r\n                        ");
                    __builder3.OpenElement(30, "text");
                    __builder3.AddAttribute(31, "x", "50%");
                    __builder3.AddAttribute(32, "y", "50%");
                    __builder3.AddAttribute(33, "text-anchor", "middle");
                    __builder3.AddAttribute(34, "alignment-baseline", "central");
                    __builder3.AddAttribute(35, "fill", "#fff");
                    __builder3.AddAttribute(36, "font-size", (
#nullable restore
#line 16 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
                                                                                                                         task.Score*0.2

#line default
#line hidden
#nullable disable
                    ) + "px");
                    __builder3.AddContent(37, 
#nullable restore
#line 16 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
                                                                                                                                             task.Title

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(38, " (");
                    __builder3.AddContent(39, 
#nullable restore
#line 16 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
                                                                                                                                                          task.Score

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(40, ")");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 22 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 24 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
 if (dragScore == 2) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "    ");
            __builder.OpenElement(49, "h1");
            __builder.AddContent(50, 
#nullable restore
#line 25 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
         dropSuccess

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 26 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "F:\Blood\second\Project\BlazorApp\Pages\Index.razor"
       
    private List<Employee> employees;

    protected override void OnInitialized()
    {
        employees = EmployeeService.GetEmployeeData();
    }

    int dropScore = 0;
    int dragScore = 0;
    string dropSuccess = "Circle was dragged.";
    string dropError = "Drop is not available";
    void OnDrop(Employee data)
    {
        // Important: Invoke StateHasChanged() to update the page
        dragScore = 2;
        dropScore = 1;
        StateHasChanged();
    }

    void OnDragStart(Employee data)
    {
        // Important: Invoke StateHasChanged() to update the page
        dragScore = 1;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DragAndDropService DragAndDropService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService EmployeeService { get; set; }
    }
}
#pragma warning restore 1591
