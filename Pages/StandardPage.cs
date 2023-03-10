using System.ComponentModel.DataAnnotations;

namespace EpiCms.Pages
{
    [ContentType(
        DisplayName = "Standard page",
        GUID = "934E7266-FB8C-4DEA-B033-3B4E6AE6CBCF",
        Description = "The standard page",
        AvailableInEditMode = true)]
    [ImageUrl("~/styles/images/page_type.png")]
    public class StandardPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title for the page",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string? Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main Body",
            Description = "Main body",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual XhtmlString? MainBody { get; set; }
    }
}
