using Owin;

namespace SignalRExperiments
{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}