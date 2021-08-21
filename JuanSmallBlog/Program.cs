using System.Threading.Tasks;
using Statiq.App;
using Statiq.Web;
using Statiq.Common;

namespace JuanSmallBlog
{
  public class Program
  {
    public static async Task<int> Main(string[] args) =>
      await Bootstrapper
        .Factory
        .CreateWeb(args)
        .DeployToGitHubPages(
                  "juanjuanzero",
                  "JuanSmallBlog",
                  Config.FromSetting<string>("GITHUB_TOKEN"))
        .RunAsync();
  }
}
