using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WestWindSystem.BLL;

#region Additional Namespaces
using WestWindSystem.Entities;
#endregion
namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BuildVersionServices _buildVersionServices;


        public IndexModel(ILogger<IndexModel> logger, BuildVersionServices bvservices)
        {
            _logger = logger;
            _buildVersionServices = bvservices;
        }

        [BindProperty]
        public BuildVersion buildVersionInfo { get; set; }
        public string MyName { get; set; }
        public void OnGet()
        {
           Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if (value % 2 == 0)
            {
                MyName = $"Rajwinder ({value}) welcome to the wide wild world of razor";
            }
            else
            {
                MyName = null;
            }
            buildVersionInfo = _buildVersionServices.GetBuildVersion();
        }
    }
}