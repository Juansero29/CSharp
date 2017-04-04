using System;

namespace TP3_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue cat = new Catalogue();
            var d = new Device("EOS 1100D", "Canon", "SN1234");
            cat.AddDevice(d);
            cat.AddDevice(d);
            //Yeay! cat.DevicesArray.Add(d); //We don't want to be able and do this
            cat.AddDevices(new Device("EOS 1100D", "Canon", "SN1234"),
                new Device("EOS 650D", "Canon", "SN2345"),
                new Device("EOS 650D", "Canon", "SN3456"),
                new Device("EOS 60D", "Canon", "SN4567"),               // we want to keep doing this.
                new Device("EOS 7D", "Canon", "SN5678"),
                new Device("EOS 7D", "Canon", "SN6789"),
                new Device("EOS 5D Mark II", "Canon", "SN7890"),
                new Device("EOS 5D	Mark III", "Canon", "SN8901"),
                new Device("EOS 1D X", "Canon", "SN9012")
                );

            cat.AddPhotos(
            new Photo(cat.DevicesArray[2], new DateTime(2012, 01, 01)),
            new Photo(cat.DevicesArray[2], new DateTime(2012, 02, 01)),
            new Photo(cat.DevicesArray[1], new DateTime(2012, 03, 01)),
            new Photo(cat.DevicesArray[1], new DateTime(2012, 04, 01)),
            new Photo(cat.DevicesArray[2], new DateTime(2012, 05, 01)), // we want to keep doing this.
            new Photo(cat.DevicesArray[5], new DateTime(2012, 06, 01)),
            new Photo(cat.DevicesArray[5], new DateTime(2012, 07, 01)),
            new Photo(cat.DevicesArray[5], new DateTime(2012, 07, 01)),
            new Photo(cat.DevicesArray[5], new DateTime(2012, 07, 01)),
            new Photo(cat.DevicesArray[5], new DateTime(2012, 08, 01)),
            new Photo(cat.DevicesArray[2], new DateTime(2012, 09, 01)),
            new Photo(cat.DevicesArray[5], new DateTime(2012, 09, 10)),
            new Photo(cat.DevicesArray[1], new DateTime(2012, 09, 20))
            );
            //Yeay!!! cat.DevicesArray.Clear();     //we need to make impossible for this to compile...
            //Yeay!!! cat.PhotosArray.Clear();  //we need to make impossible for this to compile...
            cat.ShowDevices();
            cat.ShowPhotos();
            //var iut = new Iut();
            //iut[new Person("Dwight", "Schrute", "GI2")] = 17;
            //iut[new Person("Dwight", "Schrute", "GI2")] += 18;
            //Console.WriteLine(iut[new Person("Dwight", "Schrute", "GI2")]);
            Console.ReadKey();
        }
    }
}
