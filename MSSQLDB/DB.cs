using Microsoft.EntityFrameworkCore;

namespace MSSQLDB
{
    public class MSSQLHelper
    {
        #region Cihaz_Tipi_Add
        public static int Cihaz_Tipi_Add(Class_Atc_Cihaz_Tipi _Atc_Cihaz_Tipi)
        {
            int sonuc = 0;
            try
            {
                using (var context = new ATC_CompanyDBContext())
                {
                    var yenitip = _Atc_Cihaz_Tipi;

                    context.Atc_Cihaz_Tipi.Add(yenitip);
                    sonuc = context.SaveChanges();

                    List<Class_Atc_Cihaz_Tipi> s = context.Atc_Cihaz_Tipi.AsNoTracking().ToList();
                }
            }
            catch (Exception ex) { }
            return sonuc;
        }
        #endregion

    }
}
