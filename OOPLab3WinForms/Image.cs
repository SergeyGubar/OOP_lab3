using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace OOPLab3
{
    public class Image : Figure
    {
        public List<Figure> list = new List<Figure>();

        public void AddImage(Image img)
        {
            foreach (var item in img.list)
            {
                list.Add(item);
            }
        }

        public static Image LoadFromFile(string path)
        {
            return JsonConvert.DeserializeObject<Image>(File.ReadAllText(path));
        }
        public static void SaveToFile(Image image, string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(image));
        }

        public override double Square {
            get {
                double result = 0;
                foreach (var figure in list)
                {
                    result += figure.Square;
                }
                return result;
            }
        }
        public override double Perim {
            get {
                double result = 0;
                foreach (var figure in list)
                {
                    result += figure.Perim;
                }
                return result;
            }
        }
        
        public override double Volume {
            get {
                double result = 0;
                foreach (var figure in list)
                {
                    result += figure.Volume;
                }
                return result;
            }
        }

        public override void Move(double x = 0, double y = 0, double z = 0)
        {
            base.Move(x, y, z);
            MoveChildren(x, y, z);
        }


        public void MoveChildren(double x = 0, double y = 0, double z = 0)
        {
            foreach (var figure in list)
            {
                figure.Move(x, y, z);
            }
        }

        public override void Scale(double factor)
        {
            foreach (var figure in list)
            {
                figure.Scale(factor);
            }

        }

        public override string GetInfo()
        {
            string temp = "";
            foreach (var figure in list)
            {
                temp += figure.GetInfo2();
            }
            return temp;
        }

        public override void Draw()
        {
            foreach (var figure in list)
            {
                figure.Draw();
            }
        }
    }
}