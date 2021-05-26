// Thanks to Owen Conti for inspiration @ https://owenconti.com/posts/replacing-laravel-mix-with-vite/

using System;
using System.Net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Html;

namespace inertia_aspnetcore_vue_example.Models
{
    public class ViteService
    {
        private IWebHostEnvironment _env;

        public ViteService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IHtmlContent ViteAssets()
        {
            var devServerIsRunning = false;

            // Check if the Vite server is running
            if (_env.EnvironmentName == "Development") {
                HttpWebRequest request = (HttpWebRequest) WebRequest.Create("http://localhost:3000/index.html");
                request.Timeout = 15000;
                request.Method = "HEAD";

                try {
                    using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
                    {
                        if (response.StatusCode == HttpStatusCode.OK) {
                            devServerIsRunning = true;
                        }
                    }
                }
                catch (System.Exception) {
                    Console.WriteLine("Vite dev server is NOT running");
                    return new HtmlString($"<script type=\"module\" src=\"\"></script>");
                }

                if (devServerIsRunning) {
                    return new HtmlString($@"<script type=""module"" src=""http://localhost:3000/@vite/client""></script>
                    <script type=""module"" src=""http://localhost:3000/App/app.js""></script>");
                }
            }

            return new HtmlString("The Vite logic is broken...");
        }
    }
}