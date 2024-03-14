using Microsoft.EntityFrameworkCore;

namespace MSSQLDB
{
    public class ATC_CompanyDBContext : DbContext
    {
        Global.Global.Config_XML config_xml;

        public DbSet<Class_Atc_Cihaz_Tipi> Atc_Cihaz_Tipi { get; set; }

        #region OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                config_xml = Global.Global.Config_XML.Create();
                optionsBuilder.UseSqlServer(config_xml.ConStrCompany);
            }
            catch { }
        }
        #endregion

    }
}
