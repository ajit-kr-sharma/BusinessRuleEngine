using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Model
{
    public class UpgradeMembershipModel
    {
        public string MembershipName { get; set; }
        public DateTime UpgradeStartDate { get; set; }
        public DateTime UpgradeEndDate { get; set; }
        public Boolean Status { get; set; }
    }
}
