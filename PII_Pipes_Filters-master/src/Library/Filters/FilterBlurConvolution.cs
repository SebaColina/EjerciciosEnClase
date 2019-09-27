using System;
using System.Drawing;
using CompAndDel;

namespace CompAndDel.Filters
{
         public class FilterBlurConvolution : IFilter
         {
                  // componente de la clase FilterBlurConvolution
                  Convolution convolution = new Convolution();
                  public int[,] matrizParametros
                  {
                           get
                           {
                                    return this.convolution.matrizParametros;
                           }
                           set
                           {
                                    this.convolution.matrizParametros = value;
                           }
                  }
                  public int complemento
                  {
                           get
                           {
                                    return this.convolution.complemento;
                           }
                           set
                           {
                                    this.convolution.complemento = value;
                           }
                  }
                  public int divisor
                  {
                           get
                           {
                                    return this.convolution.divisor;
                           }
                           set
                           {
                                    this.convolution.divisor = value;
                           }
                  }
                  /// <summary>
                  /// Filtro complejo que suaviza los bordes de una imagen.
                  /// </summary>
                  /// <param name="name">Nombre del objeto</param>
                  public FilterBlurConvolution()
                  {
                           this.matrizParametros = new int[3, 3];
                           this.complemento = 0;
                           this.divisor = 9;
                           for (int x = 0; x < 3; x++)
                           {
                                    for (int y = 0; y < 3; y++)
                                    {
                                             matrizParametros[x, y] = 1;
                                    }
                           }
                  }
                  /// <summary>
                  /// Recibe una imagen y la retorna con el filtro aplicado.
                  /// </summary>
                  /// <param name="image">Imagen a la cual se le va a plicar el filtro</param>
                  /// <returns>Imagen con el filtro aplicado</returns>
                  public IPicture Filter(IPicture image)
                  {
                           IPicture imagenFiltrada = image.Clone();
                           Color[,] matrizVecinos;

                           for (int x = 0; x < image.Width; x++)
                           {
                                    for (int y = 0; y < image.Height; y++)
                                    {
                                             matrizVecinos = CrearMatriz(image, x, y);
                                             imagenFiltrada.SetColor(x, y, ObtenerColorFiltrado(matrizVecinos));
                                    }
                           }
                           return imagenFiltrada;
                  }

                  private Color ObtenerColorFiltrado(Color[,] matrizVecinos)
                  {
                           // delego a el componente convolution
                           return this.convolution.ObtenerColorFiltrado(matrizVecinos);
                  }

                  private Color[,] CrearMatriz(IPicture image, int x, int y)
                  {
                           // delego a el componente convolution
                           return this.convolution.CrearMatriz(image, x, y);
                  }
         }
}