using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

public class RenderViewComponent : ViewComponent
{
    private List<MenuItem> MenuItems = new List<MenuItem>();

    public RenderViewComponent()
    {
        MenuItems = new List<MenuItem>()
        {
            new MenuItem()
            {
                Id = 1,
                Name = "Branches",
                Link = "/Admin/Branch/List",
            },
            new MenuItem()
            {
                Id = 2,
                Name = "Students",
                Link = "/Admin/Student/List",
            },
        };
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View("RenderLeftMenu", MenuItems);
    }
}
