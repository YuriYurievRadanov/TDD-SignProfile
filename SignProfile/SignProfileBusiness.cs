using System;
using System.Collections.Generic;
using System.Text;

namespace SignProfile
{
    public class SignProfileBusiness
    {
        private protected string profileName;
        private protected string startMonth;
        private protected string startDay;
        private protected string endMonth;
        private protected string endDay;

        public SignProfileBusiness(string profileName, string startMonth, string startDay, string endMonth, string endDay)
        {
            this.profileName = profileName;
            this.startMonth = startMonth;
            this.startDay = startDay;
            this.endMonth = endMonth;
            this.endDay = endDay;
        }
        public String getProfileName()
        {
            return profileName;
        }
    }
}
