using Microsoft.AspNetCore.Components;

namespace WEB_CTY.Pages.KPIS_Pages
{
    public partial class KPI_Pages
    {

        [Parameter]
        public string chisi_kpi { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }


    }
}
