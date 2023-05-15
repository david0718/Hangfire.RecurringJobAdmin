using Hangfire.RecurringJobAdmin;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Hangfire.Tdms.Library
{
    public class TdmsCafPartsInventory
    {
        [RecurringJob("*/1 * * * *", "default", RecurringJobId = "TDMS-UpdateInventoryQuantity")]
        [DisableConcurrentlyJobExecution(nameof(UpdateCafpartsInventoryQuantity))]
        [AutomaticRetry(Attempts = 3, OnAttemptsExceeded = AttemptsExceededAction.Fail)]
        public async Task UpdateCafpartsInventoryQuantity()
        {
            await Task.Run(() => Console.WriteLine("Here we will check part inbound and outbound information, then calculate the inventory count."));
        }
    }
}
