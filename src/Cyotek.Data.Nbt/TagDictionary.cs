using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Cyotek.Data.Nbt
{
  public partial class TagDictionary : KeyedCollection<string, Tag>
  {
    #region Fields

    private Tag _owner;

    #endregion

    #region Properties

    public Tag Owner
    {
      get { return _owner; }
      set
      {
        _owner = value;

        foreach (Tag child in this)
        {
          child.Parent = value;
        }
      }
    }

    #endregion

    #region Methods

    public TagByte Add(string name, bool value)
    {
      return this.Add(name, (byte)(value ? 1 : 0));
    }

    public TagString Add(string name, DateTime value)
    {
      return this.Add(name, value.ToString("u"));
    }

    public TagByteArray Add(string name, Guid value)
    {
      return this.Add(name, value.ToByteArray());
    }

    public Tag Add(string name, TagType tagType)
    {
      return this.Add(name, tagType, TagType.None);
    }

    public Tag Add(string name, TagType tagType, TagType limitToType)
    {
      Tag tag;

      tag = TagFactory.CreateTag(name, tagType, limitToType);

      this.Add(tag);

      return tag;
    }

    public Tag Add(string name, object value)
    {
      Tag result;

      if (value is byte)
      {
        result = this.Add(name, (byte)value);
      }
      else if (value is byte[])
      {
        result = this.Add(name, (byte[])value);
      }
      else if (value is int)
      {
        result = this.Add(name, (int)value);
      }
      else if (value is int[])
      {
        result = this.Add(name, (int[])value);
      }
      else if (value is float)
      {
        result = this.Add(name, (float)value);
      }
      else if (value is double)
      {
        result = this.Add(name, (double)value);
      }
      else if (value is long)
      {
        result = this.Add(name, (long)value);
      }
      else if (value is short)
      {
        result = this.Add(name, (short)value);
      }
      else if (value is string)
      {
        result = this.Add(name, (string)value);
      }
      else if (value is DateTime)
      {
        result = this.Add(name, (DateTime)value);
      }
      else if (value is Guid)
      {
        result = this.Add(name, (Guid)value);
      }
      else if (value is bool)
      {
        result = this.Add(name, (bool)value);
      }
      else if (value is TagDictionary)
      {
        result = this.Add(name, (TagDictionary)value);
      }
      else if (value is TagCollection)
      {
        result = this.Add(name, (TagCollection)value);
      }
      else
      {
        throw new ArgumentException("Invalid value type.", nameof(value));
      }

      return result;
    }

    /// <summary>
    /// Adds a range of existing <see cref="T:KeyValuePair{string,object}"/> objects to the <see cref="TagDictionary"/>.
    /// </summary>
    /// <param name="values">An IEnumerable&lt;Tag&gt; of items to append to the <see cref="TagDictionary"/>.</param>
    public void AddRange(IEnumerable<KeyValuePair<string, object>> values)
    {
      foreach (KeyValuePair<string, object> value in values)
      {
        this.Add(value.Key, value.Value);
      }
    }

    /// <summary>
    /// Adds the contents of an existing <see cref="T:IDictionary{string,object}"/> objects to the <see cref="TagDictionary"/>.
    /// </summary>
    /// <param name="values">An IEnumerable&lt;Tag&gt; of items to append to the <see cref="TagDictionary"/>.</param>
    public void AddRange(IDictionary<string, object> values)
    {
      foreach (KeyValuePair<string, object> value in values)
      {
        this.Add(value.Key, value.Value);
      }
    }

    /// <summary>
    /// Adds a range of existing <see cref="Tag"/> objects to the <see cref="TagDictionary"/>.
    /// </summary>
    /// <param name="values">An IEnumerable&lt;Tag&gt; of items to append to the <see cref="TagDictionary"/>.</param>
    public void AddRange(IEnumerable<Tag> values)
    {
      foreach (Tag value in values)
      {
        this.Add(value);
      }
    }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>
    /// A string that represents the current object.
    /// </returns>
    public override string ToString()
    {
      StringBuilder sb;

      sb = new StringBuilder();

      sb.Append('[');

      foreach (Tag tag in this)
      {
        if (sb.Length > 1)
        {
          sb.Append(',').Append(' ');
        }

        sb.Append(tag.ToValueString());
      }

      sb.Append(']');

      return sb.ToString();
    }

    public bool TryGetValue(string key, out Tag value)
    {
      bool result;

      if (this.Dictionary != null)
      {
        result = this.Dictionary.TryGetValue(key, out value);
      }
      else
      {
        result = false;
        value = null;
      }

      return result;
    }

    protected override void ClearItems()
    {
      foreach (Tag item in this)
      {
        item.Parent = null;
      }

      base.ClearItems();
    }

    protected override string GetKeyForItem(Tag item)
    {
      return item.Name;
    }

    protected override void InsertItem(int index, Tag item)
    {
      item.Parent = this.Owner;

      base.InsertItem(index, item);
    }

    protected override void RemoveItem(int index)
    {
      Tag item;

      item = this[index];
      item.Parent = null;

      base.RemoveItem(index);
    }

    internal void ChangeKey(Tag item, string newKey)
    {
      this.ChangeItemKey(item, newKey);
    }

    #endregion
  }
}
