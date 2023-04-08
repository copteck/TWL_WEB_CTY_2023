using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks; 
using WEB_CTY.Data;
using System.Reflection.Metadata;
using Dto_gioithieu;

namespace WEB_CTY.Pages
{
    public partial class Index
    {
       public    Data.Database db { get; set; } = new Data.Database();
        //protected override void OnInitialized()
        //{
        //    base.OnInitialized();
        //    using(var itemsdb = new Data.Database())
        //    {
        //        string sql_string = db.Database.GetDbConnection().ConnectionString;
        //        //db.Database.OpenConnection();
        //        var db_ = db.gioithieu_ht_dm_chucnangs;
        //        var a = db_.ToList();
        //    }


        //}

        List<dto_gioithieu_ht_dm_chucnang> lst_Data = new List<dto_gioithieu_ht_dm_chucnang>();

        protected override  async Task OnInitializedAsync()
        {
           var lst = await db.gioithieu_ht_dm_chucnangs.ToListAsync();

            //var data =  lst.res
            lst_Data = lst.ToList();


        }


      


    }
}
