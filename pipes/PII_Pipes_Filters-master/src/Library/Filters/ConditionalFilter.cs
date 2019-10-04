using System.Diagnostics;
using System;
using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
         public class ConditionalFilter : IConditionalFilter
         {
                  CognitiveFace cog = new CognitiveFace("a36648d3c5134ab692acd35605d491f7", false);
                  protected bool FaceOrNot;
                  private string path;
                  public ConditionalFilter(string path)
                  {
                           this.path = path;
                  }
                  /// <summary>
                  /// filtra la imagen devolviendo un valor bool indicando si pasa el filtro o no
                  /// </summary>
                  /// <param name="image"> imagen para filtrar </param>
                  /// <returns> devuelve si la imagen pasa el filtro o no </returns>
                  public bool Filter(IPicture image)
                  {
                           cog.Recognize(path);
                           if (cog.FaceFound)
                           {
                                    this.FaceOrNot = true;
                                    return true;
                           }
                           else
                           {
                                    this.FaceOrNot = false;
                                    return false;
                           }
                           
                  }
         }
}
