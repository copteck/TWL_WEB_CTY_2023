 
using Microsoft.EntityFrameworkCore;
using TWLS.Data;
using TWLS.Databases;

namespace TWLS.Components.Hethong
{
    public  partial class Menu
    {


        public List<dto_demo> lst_menu = new List<dto_demo>();
         public Databases.DB_Context db_context { get; set; } = new DB_Context();        





        protected override async Task OnInitializedAsync()
        {


            var lst =  await db_context.ht_dm_chucnangs.ToListAsync();
            lst_menu = lst.ToList();

        }
         




    }
}
