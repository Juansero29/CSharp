using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; //USE THIS!!!
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Library
{
    public struct Device : IEquatable<Device>
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SeriesNumber { get; set; }

        public Device(string model, string brand, string seriesNumber)
        {
            Brand = brand;
            Model = model;
            SeriesNumber = seriesNumber;
        }

        public override string ToString()
        {
            return $"Brand: {Brand} Model: {Model} Series N°: {SeriesNumber}.";
        }

        public override int GetHashCode()
        {
            return (int) Convert.ToInt64(SeriesNumber) % 31;
        }

        public override bool Equals(object right)
        {
            if (right == null)
            {
                return false;
            }

            if (object.ReferenceEquals(right, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, right))
            {
                return true;
            }

            if (this.GetType() != right.GetType())
            {
                return false;
            }

            return Equals(right as Device?);
        }

        public bool Equals(Device other)
        {
            return (this.Brand == other.Brand && this.SeriesNumber == other.SeriesNumber);
        }
    }

    public class Photo : Catalogue
    {
        public DateTime CaptureTime { get; set; }
        public Device TheDevice { get; set; }
        public float Exposition { get; set; }
        public int Temperature { get; set; }
        public static Random rand = new Random();

        public Photo(Device theDevice, DateTime date)
        {
            float a = (float) rand.NextDouble();
            int b = rand.Next(0, 32001);
            Exposition = a;
            Temperature = b;
            CaptureTime = date;
            TheDevice = theDevice;
        }

        public override string ToString()
        {
            return
                $"Date:  {CaptureTime.ToString("dd/MM/yyyy")}\nDevice: {TheDevice.SeriesNumber}. \n - Exposition: {Exposition.ToString("0.00")} - Temperature: {Temperature}\n";
        }

        public override int GetHashCode()
        {
            return Temperature % 31;
        }

        public override bool Equals(object right)
        {
            if (right == null)
            {
                return false;
            }

            if (object.ReferenceEquals(right, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, right))
            {
                return true;
            }

            if (this.GetType() != right.GetType())
            {
                return false;
            }

            return this.Equals(right as Photo);
        }

        public bool Equals(Photo other)
        {
            return (CaptureTime == other.CaptureTime && this.TheDevice.Equals(other.TheDevice));
        }
    }

    public class Catalogue
    {
        //public Device[] devicesArray = new Device[0];  THIS IS OLD BASTARD ARRAYS! AVOID THEM!

        public ReadOnlyCollection<Photo> PhotosArray => _photosArray.AsReadOnly();
        //A PUBLIC ACCESSOR FOR A READ ONLY COLLECTION. IT IS STILL MODIFIABLE BUT ONLY BECAUSE WE WANT TO!!
        public ReadOnlyCollection<Device> DevicesArray => _devicesArray.AsReadOnly();
        //A PUBLIC ACCESSOR FOR A READ ONLY COLLECTION. IT IS STILL MODIFIABLE BUT ONLY BECAUSE WE WANT TO!!

        private readonly List<Device> _devicesArray = new List<Device>(); // THIS ARE LISTS<T> USE THEM!
        private readonly List<Photo> _photosArray = new List<Photo>(); // THIS ARE LISTS<T> USE THEM!

        public void AddPhotos(params Photo[] photoArray)
        {
            //mSize += photosArray.Length;
            //Photo[] photosBuffer = new Photo[mSize];
            //for (int i = 0; i < photoArray.Length; i++)       THIS IS WHAT WE ARE TRYING TO AVOID.
            //{
            //    photosBuffer[i] = photoArray[i];
            //}
            //photosArray = photosBuffer;
            foreach (Photo p in photoArray)
            {
                this.AddPhoto(p);
            }
        }

        public void AddDevices(params Device[] deviceArray)
        {
            //mSize += photosArray.Length;
            //Device[] deviceBuffer = new Device[mSize];
            //for (int i = 0; i < deviceArray.Length; i++)          THIS IS WHAT WE ARE TRYING TO AVOID.
            //{
            //    deviceBuffer[i] = deviceArray[i];
            //}
            //devicesArray = deviceBuffer;
            foreach (Device d in deviceArray)
            {
                this.AddDevice(d);
            }
        }

        public void AddPhoto(Photo photo)
        {
            //mSize++;
            //Photo[] data = new Photo[mSize];
            //photosArray.CopyTo(data, 0);     ALSO THIS...
            //data[mSize - 1] = photo;
            //photosArray = data;
            if (_photosArray.Contains(photo))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The photo:\n{photo} exists already! ");
                Console.ResetColor();
                return;
            }
            _photosArray.Add(photo);
        }

        public void AddDevice(Device device)
        {
            //mSize++;
            //Device[] data = new Device[mSize];
            //photosArray.CopyTo(data, 0);      ALSO THIS...
            //data[mSize - 1] = device;
            //devicesArray = data;
            if (_devicesArray.Contains(device))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The device: \n{device} exists already!");
                Console.ResetColor();
                return;
            }
            _devicesArray.Add(device);
        }

        public void RemovePhoto(int index)
        {
            _photosArray.RemoveAt(index);
        }

        public void RemoveDevice(int index)
        {
            _devicesArray.RemoveAt(index);
        }

        public void ShowDevices()
        {
            Console.WriteLine(_devicesArray.Aggregate("", (current, d) => current + (d + " \n")));
        }

        public void ShowPhotos()
        {
            Console.WriteLine(_photosArray.Aggregate("", (current, p) => current + (p + "  \n")));
        }

    }

    public class Person
    {
        public string lastName;
        public string firstName;
        public string group;

        public Person(string lastName, string firstName, string group)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.group = group;
        }

        public override int GetHashCode()
        {
            return firstName.GetHashCode() * group.GetHashCode() * lastName.GetHashCode();
        }

        public override bool Equals(object right)
        {
            if (right == null)
            {
                return false;
            }

            if (object.ReferenceEquals(right, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, right))
            {
                return true;
            }

            if (this.GetType() != right.GetType())
            {
                return false;
            }

            return this.Equals(right as Person);
        }

        public bool Equals(Person p)
        {
            return this.firstName == p.firstName && this.group == p.group && this.lastName == p.lastName;
        }
    }

    public class Iut
    {
        private readonly Dictionary<Person, int> _dico = new Dictionary<Person, int>();

        public int this[Person key]
        {
            get
            {
                int val;
                if (_dico.TryGetValue(key, out val))
                {
                    return val;
                }
                else
                {
                    return val = -1;
                }
            }
            set
            {
                if (_dico.ContainsKey(key))
                {
                    _dico[key] = value;
                }
                else
                {
                    _dico.Add(key, value);
                }
            }
        }
    }
}