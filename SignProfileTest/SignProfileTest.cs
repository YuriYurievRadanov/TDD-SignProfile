using SignProfile;
using System;
using Xunit;

namespace SignProfileTest
{
    public class SignProfileTest
    {
        [Fact]
        public void shouldReturnAsignProfile()
        {
            string startMonth = "03";
            string startDay = "21";

            string endMonth = "03";
            string endDay = "21";

            string profileName = "Aries";

            SignProfileBusiness signProfile = new SignProfileBusiness(profileName, startMonth, startDay, endMonth, endDay);

            Assert.Equal("Aries", signProfile.getProfileName());
        }
    }
}
