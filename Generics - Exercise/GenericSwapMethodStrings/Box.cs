using System.Text;

namespace GenericSwapMethodStrings
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> list;

        public Box()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T swap = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = swap;
        }

        public List<T> GetGreaterItems(T value)
        {
            List<T> greaterItems = new List<T>();
            foreach (T item in list)
            {
                if (item.CompareTo(value) > 0)
                {
                    greaterItems.Add(item);
                }
            }
            return greaterItems;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in list)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
