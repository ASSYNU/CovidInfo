using System;
using System.Collections.Generic;
using System.Globalization;

namespace CovidInfo.Core
{
    public class countries
    {
        public static List<string> All()
        {
            List<string> cultureList = new List<string>();
            CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (var getCulture in getCultureInfo)
            {
                RegionInfo getRegionInfo = new RegionInfo(getCulture.LCID);
                if (!(cultureList.Contains(getRegionInfo.EnglishName)))
                {
                    cultureList.Add(getRegionInfo.EnglishName);
                }
            }
            cultureList.Sort();
            return cultureList;
        }
    }
}