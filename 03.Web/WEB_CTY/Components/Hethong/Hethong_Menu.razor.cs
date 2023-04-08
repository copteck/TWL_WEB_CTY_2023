using Dto_gioithieu;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_CTY.Components.Hethong
{
    public partial class Hethong_Menu
    {

        List<dto_gioithieu_ht_dm_chucnang> lst_Data = new List<dto_gioithieu_ht_dm_chucnang>();

        protected override async Task OnInitializedAsync()
        {
            using (var dbcontext =  new Data.Database())
            {
                var lst = await dbcontext.gioithieu_ht_dm_chucnangs.
                    OrderBy(p=>p.sott).
                    Where(p=>p.daxoa==0).ToListAsync();

                lst_Data = lst.ToList();
            }
           
        }
    }
}
