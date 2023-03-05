using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace MvcViewEngineApp.ViewEngine
{
    public class MyView : IView
    {
        public MyView(string path)
        {
            Path = path;
        }

        public string Path { set; get; }

        public async Task RenderAsync(ViewContext context)
        {
            string result = "";
            using(StreamReader reader = new(Path))
            {
                result = await reader.ReadToEndAsync();
            }
            await context.Writer.WriteAsync(result);
        }
    }

    
}
