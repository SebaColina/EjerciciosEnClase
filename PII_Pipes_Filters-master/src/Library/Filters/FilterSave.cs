using System.Diagnostics;

namespace CompAndDel.Filters
{
         public class FilterSave : IFilter
         {
                  // componente de FilterSave
                  PictureProvider pictureprovider = new PictureProvider();
                  public string path;
                  public FilterSave(string path)
                  {
                           this.path = path;
                  }
                  public IPicture Filter(IPicture image)
                  {
                           IPicture imagenFiltrada = image.Clone();
                           // delega la tarea a el componente 
                           this.pictureprovider.SavePicture(imagenFiltrada,path);
                           return imagenFiltrada;
                  }
         }
}
