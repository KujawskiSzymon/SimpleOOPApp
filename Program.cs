using System;
using System.Collections.Generic;

namespace SimpleOOP_app
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Promoter> promoters = new List<Promoter>(){new XSClubPromoter("Szymon","Zszymonowic",123456789), new XSClubPromoter("Kamil","Jankes",987654321), new OmniaClubPromoter("Justyna","Just",666100100) };

                foreach(var promoter in promoters){
                    promoter.Promote();
                }
            
            List<Writer> writers   = new List<Writer>(){new BookWriter("Szymon","Zszymonowic"), new BookWriter("Kamil","Jankes"), new BlogWriter ("Patrycja","Rzesza") };
            foreach(var writer in writers){
                   writer.Vlog();
                }
            
            List<IBodyBuilder> bodybuilders = new List<IBodyBuilder>(){new XSClubPromoter("Szymon","Zszymonowic",123456789), new XSClubPromoter("Kamil","Jankes",987654321), new XSClubPromoter("Justyna","Just",666100100) };
            foreach(var bodyBuilder in bodybuilders){
                  bodyBuilder.Workout();
                }
            
            List<IVlogger> vloggers   = new List<IVlogger>(){ new XSClubPromoter("Kamil","Jankes",311219980), new BlogWriter ("Patrycja","Rzesza") };
            foreach(var vlogger in vloggers){
                   vlogger.Vlog();
                }
        }
    }
}
