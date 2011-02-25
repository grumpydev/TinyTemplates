namespace TinyTemplates.ViewEngine
{
    public interface IViewEngine
    {
        /// <summary>
        /// Renders a template
        /// </summary>
        /// <param name="template">
        /// The template to render.
        /// </param>
        /// <param name="model">
        /// The model to user for rendering.
        /// </param>
        /// <returns>
        /// A string containing the expanded template.
        /// </returns>
        string Render(string template, dynamic model);
    }
}