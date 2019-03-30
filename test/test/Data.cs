using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Data
    {

        public int SoonEndingSamples()
        {
            return SampleList.Where(i => i.Date < DateTime.Now.AddDays(-20)).Count();
        }


        public List<Sample> SampleList = new List<Sample>() { new Sample(2019000001, 1, "A1", "Arkingsall Creasent", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000001, 1, "A2", "Arkingsall Creasent", DateTime.Now.AddDays(-30), Result.Outstanding),
                new Sample(2019000002, 1, "A3", "Arkingsall Creasent", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000003, 1, "A2", "Arkingsall Creasent", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000004, 1, "A2", "Arkingsall Creasent", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000005, 1, "A2", "Hampshire Bridge", DateTime.Now.AddDays(-30), Result.Outstanding),
                new Sample(2019000006, 1, "A2", "Hampshire Bridge", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000007, 1, "D7", "Hampshire Bridge", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000008, 1, "E6", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000009, 1, "T1", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000010, 1, "G1", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000011, 1, "G1", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000011, 1, "J1", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000012, 1, "K1", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000013, 1, "U19", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000014, 1, "V22", "Handsworth Orchard", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000015, 1, "D15", "Kates Hill", DateTime.Now.AddDays(29), Result.Outstanding),
                new Sample(2019000016, 1, "C16", "Kates Hill", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000017, 1, "W15", "Kates Hill", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000018, 1, "Q13", "Kates Hill", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000019, 1, "R55", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000020, 1, "H22", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000021, 1, "B18", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000022, 1, "F12", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000023, 1, "D6", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000024, 1, "U4", "Overdale Road", DateTime.Now.AddDays(-80), Result.Outstanding),
                new Sample(2019000025, 1, "P2", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000026, 1, "I5", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000027, 1, "U9", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000028, 1, "T4", "Overdale Road", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000029, 1, "L1", "Lincoln Way", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000030, 1, "J16", "Lincoln Way", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000031, 1, "A13", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000032, 1, "A16", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000033, 1, "A7", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000034, 1, "A2", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000035, 1, "A1", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000036, 1, "A3", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000037, 1, "T1", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000038, 1, "R2", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000039, 1, "E4", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
                new Sample(2019000040, 1, "W3", "Canncock Chase", DateTime.Now.AddDays(-1), Result.Outstanding),
            };

        


}
}
