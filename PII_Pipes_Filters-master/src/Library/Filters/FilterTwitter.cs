using System.Diagnostics;
using TwitterUCU;
using System;

namespace CompAndDel.Filters
{
         public class FilterTwitter : IFilter
         {
                  TwitterImage twitter = new TwitterImage("g7rkPB5uI2xOqELAhlNrorSU4", "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc", "1396065818-9Q6o38qm99WQywFeqrJFTfs7DFAhI4LvjoJvFRk", "eAut3eKlWwBB0o1BfTRLaRBfOgXF6WriMKwpkevgf7C2t");
                  private string path;
                  public FilterTwitter(string path)
                  {
                           this.path = path;
                  }
                  public IPicture Filter(IPicture image)
                  {
                           Console.WriteLine(this.twitter.PublishToTwitter("Arte ",path));
                           return image;
                  }
         }
}
