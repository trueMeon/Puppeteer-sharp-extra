using System.Threading.Tasks;
using PuppeteerSharp;

namespace PuppeteerExtraSharp.Plugins.ExtraStealth.Evasions
{
    public class ViewPortDisplayResolution : PuppeteerExtraPlugin
    {
        public ViewPortDisplayResolution() : base("viewPort-display-resolution")
        {
        }

        public override async Task OnPageCreated(Page page)
        {
            var script = Utils.GetScript("ViewPortDisplayResolution.js");
            await Utils.EvaluateOnNewPage(page, script);
        }
    }
}