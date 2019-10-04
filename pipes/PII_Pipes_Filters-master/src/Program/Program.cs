using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
         class Program
         {
                  static void Main(string[] args)
                  {
                           // creamos un objeto PictureProvider y obtenemos una imagen
                           PictureProvider p = new PictureProvider();
                           IPicture pic = p.GetPicture("C:/Users/FIT/programacion2/ejercicio_en_clase/ComposicionYDelegacion/PII_Pipes_Filters-master/gato.png");

                           // creamos un pipeNull
                           IPipe pipenull = new PipeNull();

                           // creamos instancias de todos los filtros que nos interecen
                           FilterSave filtersave = new FilterSave("../../gato2.png");
                           FilterTwitter filtertwitter = new FilterTwitter(filtersave.path);
                           FilterNegative filternegative = new FilterNegative();
                           FilterGreyscale filtergreyscale = new FilterGreyscale();
                           ConditionalFilter conditionalfilter = new ConditionalFilter(filtersave.path);
                           FilterBlurConvolution filterblurconvolution = new FilterBlurConvolution();

                           // creamos instancias de todos los pipeSerial que vayamos a utilizar
                           IPipe pipeserial7 = new PipeSerial(filtertwitter,pipenull);
                           IPipe pipeserial6 = new PipeSerial(filtersave,pipeserial7); // en este caso se sobrescribe la imagen guardada ya que estoy usando el mismo filtersave con el mismo path
                           IPipe pipeserial5 = new PipeSerial(filterblurconvolution,pipeserial6);
                           IPipe pipeserial4 = new PipeSerial(filtertwitter,pipenull);
                           IPipe pipefork = new PipeFork(conditionalfilter,pipeserial4,pipeserial5);
                           IPipe pipeserial3 = new PipeSerial(filtersave,pipefork);
                           IPipe pipeserial2 = new PipeSerial(filternegative,pipeserial3);
                           IPipe pipeserial = new PipeSerial(filtergreyscale,pipeserial2);

                           // enviamos la imagen al primer pipeSerial
                           pipeserial.Send(pic);

                  }
         }
}
