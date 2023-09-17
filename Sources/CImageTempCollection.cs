namespace StephanusDai.SDImageResizer
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;



    public class CImageTempCollection : IList
    {
        private List<ImageTempBrowsed> imageTemps;

        public CImageTempCollection()
        {
            imageTemps = new List<ImageTempBrowsed>();
        }

        public virtual object this[int index]
        {
            get
            {
                return imageTemps[index];
            }
            set
            {
                if (value is ImageTempBrowsed)
                {
                    Insert(index, (ImageTempBrowsed)value);
                }
            }
        }

        public virtual object this[string key]
        {
            get
            {
                // We do not support null and empty string as valid keys.
                if (string.IsNullOrEmpty(key))
                {
                    return null;
                }

                // Search for the key in our collection
                int index = IndexOfKey(key);
                if (IsValidIndex(index))
                {
                    return this[index];
                }
                else
                {
                    return null;
                }

            }
        }

        public void Insert(int index, object item)
        {
            if (item is ImageTempBrowsed)
            {
                Insert(index, (ImageTempBrowsed)item);
            }
            else
            {
                throw new ArgumentNullException("value");
            }
        }

        public virtual bool ContainsKey(string key)
        {
            return IsValidIndex(IndexOfKey(key));
        }

        private bool IsValidIndex(int index)
        {
            return ((index >= 0) && (index < this.Count));
        }

        public void Add(object item)
        {
            if (item is ImageTempBrowsed)
            {
                imageTemps.Add((ImageTempBrowsed)item);
            }
            else
            {
                throw new ArgumentNullException("value");
            }
        }

        public virtual int IndexOfKey(String key)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (imageTemps[i].Name == key)
                    return i;
            }
            return -1;
        }

        public void Remove(object item)
        {
            if (item is ImageTempBrowsed)
            {
                imageTemps.Remove((ImageTempBrowsed)item);
            }
            else
            {
                throw new ArgumentNullException("value");
            }
        }

        public void RemoveAt(int index)
        {
            imageTemps.RemoveAt(index);
        }

        public virtual void RemoveByKey(string key)
        {
            int index = IndexOfKey(key);
            if (IsValidIndex(index))
            {
                RemoveAt(index);
            }
        }

        [Browsable(false)]
        public int Count
        {
            get
            {
                return imageTemps.Count;
            }
        }

        int IList.Add(object value)
        {
            if (value is ImageTempBrowsed)
            {
                imageTemps.Add((ImageTempBrowsed)value);
            }
            return imageTemps.Count;
        }

        void IList.Clear()
        {
            imageTemps.Clear();
        }

        bool IList.Contains(object value)
        {
            if (value is ImageTempBrowsed)
            {
                return imageTemps.Contains((ImageTempBrowsed)value);
            }
            return false;
        }

        int IList.IndexOf(object value)
        {
            if (value is ImageTempBrowsed)
            {
                return imageTemps.IndexOf((ImageTempBrowsed)value);
            }
            return imageTemps.Count;
        }

        void IList.Insert(int index, object value)
        {
            if (value is ImageTempBrowsed)
            {
                imageTemps.Insert(index, (ImageTempBrowsed)value);
            }
            else
            {
                throw new ArgumentNullException("value");
            }
        }

        bool IList.IsFixedSize
        {
            get { return false; }
        }

        bool IList.IsReadOnly
        {
            get { return false; }
        }

        void IList.Remove(object value)
        {
            if (value is ImageTempBrowsed)
            {
                imageTemps.Remove((ImageTempBrowsed)value);
            }
            else
            {
                throw new ArgumentNullException("value");
            }
        }

        void IList.RemoveAt(int index)
        {
            imageTemps.RemoveAt(index);
        }

        object IList.this[int index]
        {
            get
            {
                return imageTemps[index];
            }
            set
            {
                if (value is ImageTempBrowsed)
                {
                    this[index] = (ImageTempBrowsed)value;
                }
                else
                {
                    throw new ArgumentNullException("value");
                }
            }
        }

        ImageTempBrowsed[] GetImageFiles()
        {
            ImageTempBrowsed[] result = new ImageTempBrowsed[Count * 2];
            foreach (ImageTempBrowsed imageTemp in imageTemps)
            {
                result[0] = imageTemp;
            }
            return result;
        }

        void ICollection.CopyTo(Array array, int index)
        {
            if (Count > 0)
            {
                Array.Copy(GetImageFiles(), 0, array, index, Count);
            }
        }

        int ICollection.Count
        {
            get { return this.imageTemps.Count; }
        }

        bool ICollection.IsSynchronized
        {
            get { return false; }
        }

        object ICollection.SyncRoot
        {
            get { return this; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return imageTemps.GetEnumerator();
        }
    }
}
