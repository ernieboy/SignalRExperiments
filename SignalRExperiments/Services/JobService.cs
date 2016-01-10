using Microsoft.AspNet.SignalR;
using SignalRExperiments.Hubs;
using System.Threading.Tasks;

namespace SignalRExperiments.Services
{
    public class JobService
    {

        public async Task doJob()
        {
            var jobsHub = GlobalHost.ConnectionManager.GetHubContext<JobsHub>();
            string jobName = "Counter";
            string jobStatus;
            int maxCount = 10;
            for (int i = 1; i <= maxCount; i++)
            {
                double percentDone = ((i / (double)maxCount) * 100);
                jobStatus = string.Format("{0} out of {1} done. That is {2}%.", i, maxCount, percentDone);
                jobsHub.Clients.All.newJobStatus(jobName, jobStatus);
                await Task.Delay(2000);
            }
        }
    }
}